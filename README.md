# 2C Rentals — Equipment Rental System (project README)

Repository: https://github.com/Tways-study/Equipment-Rental-System

This repository contains a small desktop equipment rental system written in Visual Basic .NET (WinForms) using MySQL as the data store. The README below explains the file layout, key code responsibilities, and step-by-step setup and run instructions.

---

## Quick setup and run

1. Clone the repository
```powershell
git clone https://github.com/Tways-study/Equipment-Rental-System.git
cd Equipment-Rental-System
```

2. Create the database and seed data
```powershell
mysql -u root -p < ERS/setup_database.sql
```
This creates the `twoc_rentals_db` schema, tables, seed equipment rows, and a default admin account.

3. Configure connection string
- Open `ERS/App.config` and set the MySQL password: `Pwd=YOUR_PASSWORD`.
- Connection string key: `TwoCRentals`.
- Ensure `CharSet=utf8mb4` is present for emoji/Unicode support.

4. Open the project in Visual Studio (Community 2026 or later)
- Open `ERS/ERS.vbproj` or the solution folder in Visual Studio.
- Restore NuGet packages (automatic on build): `MySql.Data` and `System.Configuration.ConfigurationManager`.
- Build: `Build → Build Solution` (Ctrl+Shift+B).

5. Run
- Start debugging (F5). The kiosk (`FrmKiosk`) opens by default.
- Press `F12` in the kiosk to open Admin login.

---

## Default admin
- Username: `admin`
- Access: Press `F12` on the kiosk screen and use the admin login dialog.

To add another admin (SQL):
```sql
INSERT INTO admins (username, password_hash, full_name)
VALUES ('newuser', SHA2('yourpassword', 256), 'Full Name');
```

---

## Project layout (important files)
- `README.md` — this file.
- `ERS/` — Visual Studio project folder.
  - `ERS.vbproj` — SDK-style project file, NuGet packages and file entries.
  - `App.config` — connection string with key `TwoCRentals`.
  - `setup_database.sql` — full DB schema + seed data.
  - `DBConnection.vb` — returns a `MySqlConnection` built from the config.
  - `HashHelper.vb` — SHA-256 helper to compute password hashes.
  - `EquipmentItem.vb` — equipment model (POCO) with `IsAvailable` property.
  - `CartItem.vb` — cart line model with quantity and line-total helper.
  - `RentalManager.vb` — customer-facing DB logic (load catalog, create booking transaction).
  - `AdminManager.vb` — admin DB logic (login, stats, rentals listing, return/cancel, equipment CRUD).
  - `FrmKiosk.vb` & `FrmKiosk.Designer.vb` — kiosk UI (designer holds static controls; code-behind builds dynamic UI at runtime).
  - `FrmCheckout.vb`, `FrmConfirmation.vb` — checkout flow and confirmation UI. `FrmCheckout(cart, days)` accepts the rental days from the kiosk and pre-populates `dtpEnd` as `today + days`.
  - `FrmAdminLogin.vb`, `FrmAdminDashboard.vb`, `FrmManageEquipment.vb` — admin UI screens.

---

## Key code responsibilities and explanations (summary)

- `DBConnection.GetConnection()`
  - Single factory method used across the codebase to create and open `MySqlConnection` objects using the `TwoCRentals` connection string from `App.config`.

- `HashHelper.ComputeSHA256(plaintext)`
  - Returns a lowercase hex SHA-256 hash string. Used to validate admin passwords and to seed admin passwords safely.

- `EquipmentItem` (model)
  - Properties: `EquipmentId`, `Name`, `Category`, `DailyRate`, `TotalStock`, `AvailStock`, `IconTag`, `IsActive`.
  - `IsAvailable` property returns `True` when `AvailStock > 0` and `IsActive = True`.

- `CartItem` (model)
  - Holds a reference to `EquipmentItem` and `Quantity`. `LineTotal(days)` returns `DailyRate * Quantity * days`.

- `RentalManager` (customer operations)
  - `LoadEquipment(category?)` — loads equipment rows, used by the kiosk to populate cards.
  - `CreateBooking(customer, dates, cart)` — runs a transaction: insert customer → insert rental → insert rental_details → update `avail_stock`. The transaction rolls back if any stock constraint fails.
  - `GenerateBookingCode()` — produces `BK-YYYYMMDD-NNNN` sequential identifiers.

- `AdminManager` (admin operations)
  - `ValidateLogin(username, password)` — hashes provided password, compares to stored `password_hash`.
  - `UpdateOverdueRentals()` — marks overdue rentals (`rental_end < CURDATE()`) as `Overdue`.
  - `LoadRentals(status?)` — returns a `DataTable` for the rentals grid.
  - `ReturnRental(rentalId)` / `CancelRental(rentalId)` — both use transactions to restore `avail_stock` and update rental `status`.
  - Equipment CRUD: `LoadAllEquipment()`, `AddEquipment()`, `UpdateEquipment()`, `DeleteEquipment()` (soft delete via `is_active = 0`).

- `FrmKiosk` (UI)
  - `FrmKiosk.Designer.vb` contains static controls: header, splitter, cart panel, **Rental Days stepper** (`btnDaysDown`, `lblDaysValue`, `btnDaysUp`), checkout button, and clear cart button.
  - `FrmKiosk.vb` (code-behind) contains runtime UI builders and state:
    - `_rentalDays` — integer state (default 1, min 1, max 365) tracking the selected rental duration.
    - `AddFilterPills()` — creates category pill `Button` controls and adds them to `pnlFilterBar` at runtime.
    - `RenderGrid()` — reads `_allEquipment` and creates a card `Panel` for each `EquipmentItem` at runtime (icon, name, rate, stock, Add button).
    - `RefreshCartUI()` — rebuilds cart rows dynamically with `+` and `−` quantity controls; calls `RecalcTotals()`.
    - `RecalcTotals()` — recomputes subtotal as `daily_rate × quantity × _rentalDays` and updates all total labels live.
    - `BtnDaysDown_Click` / `BtnDaysUp_Click` — decrement/increment `_rentalDays` and trigger `RecalcTotals()` immediately.
    - `BtnClearCart_Click` — prompts confirmation then clears all cart items.
    - `ShowToast()` — shows a temporary green notification label, auto-dismisses after 2 seconds.
  - Note: dynamic controls are not visible in the Visual Studio designer. The designer only shows static controls placed in `InitializeComponent()`.

---

## How the UI is constructed (designer vs runtime)
- Controls declared in `FrmKiosk.Designer.vb` are visible in the Visual Studio designer and exist before the program runs.
- Controls created in code (`New Button`, `New Panel`, `AddHandler ...`) are built at runtime when methods like `AddFilterPills()` or `RenderGrid()` execute (usually in `OnLoad` or in response to data changes).
- If you need a control editable in the designer, declare it in the designer file or add it using the Visual Studio Designer.

---

## Run-time notes and troubleshooting
- If build fails with file-lock errors (MSBuild MSB3027/MSB3021), ensure the program executable is not running and no external process is holding the file (e.g., security software). Close running instances and try rebuilding.
- If the catalog shows emoji as `?`, ensure `CharSet=utf8mb4` is present in `App.config` connection string and your database/tables use `utf8mb4`.
<<<<<<< HEAD

---
=======
>>>>>>> f6d50c7d0c3c5398561f6b95f06d9e8793e49c95
