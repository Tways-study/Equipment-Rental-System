# 2C Rentals — Equipment Rental System

**2C Rentals** is a Windows desktop application built for a small equipment rental business. It provides a touch-friendly self-service kiosk where customers can browse available gear, build a cart, and complete a rental booking — all without staff involvement. A separate, password-protected admin portal lets staff manage the equipment catalog, monitor active and overdue rentals, and process returns or cancellations with automatic stock restoration.

> **Repository:** https://github.com/Tways-study/Equipment-Rental-System

---

## Tech Stack

| Category      | Technology                                                  |
| ------------- | ----------------------------------------------------------- |
| **Framework** | .NET 10 (`net10.0-windows`)                                 |
| **Language**  | VB.NET                                                      |
| **UI**        | Windows Forms (WinForms)                                    |
| **Database**  | MySQL 8+ — schema: `twoc_rentals_db`                        |
| **DB Driver** | `MySql.Data` v9.6.0                                         |
| **Config**    | `System.Configuration.ConfigurationManager` v9.0.4          |
| **Security**  | SHA-256 password hashing via `System.Security.Cryptography` |

---

## Architecture & System Relationships

The project is structured in three distinct layers — UI forms, business/service classes, and a database abstraction — keeping SQL entirely out of form code.

```
┌─────────────────────────────── Customer Flow ───────────────────────────────┐
│  FrmKiosk  ──►  FrmCheckout  ──►  FrmConfirmation                           │
└─────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────── Admin Flow ─────────────────────────────────┐
│  FrmAdminLogin  ──►  FrmAdminDashboard  ──►  FrmManageEquipment             │
└─────────────────────────────────────────────────────────────────────────────┘

             Both flows call into the Business / Data Layer:

             RentalManager.vb          AdminManager.vb
                        │                    │
                        └────────┬───────────┘
                                 ▼
                          DBConnection.vb
                          (reads App.config)
                                 │
                                 ▼
                     MySQL: twoc_rentals_db
            ┌──────────┬───────────┬─────────┬────────────────┬────────┐
            │customers │ equipment │ rentals │ rental_details │ admins │
            └──────────┴───────────┴─────────┴────────────────┴────────┘
```

### How the pieces communicate

| Interaction           | Detail                                                                                                                                                                                                                                                                                                                                                                                                                            |
| --------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Kiosk → DB**        | `FrmKiosk.OnLoad` calls `RentalManager.LoadEquipment(category?)`. The optional category parameter maps to a server-side `WHERE category = @cat` clause so only one round trip is made per filter change.                                                                                                                                                                                                                          |
| **Cart**              | Items are kept as an in-memory `List(Of CartItem)`. Each `CartItem` holds an `EquipmentItem` reference and a quantity. `LineTotal(days)` returns `DailyRate × Quantity × days`. Grand total = subtotal + fixed ₱500 security deposit.                                                                                                                                                                                             |
| **Atomic booking**    | `RentalManager.CreateBooking()` opens a single MySQL transaction and executes four steps: ① insert `customers` row → ② insert `rentals` header with generated booking code → ③ insert one `rental_details` row per cart item → ④ decrement `avail_stock` with `WHERE avail_stock >= @qty`. If that last `UPDATE` affects 0 rows, an `InvalidOperationException` is raised and the transaction rolls back, preventing overselling. |
| **Booking codes**     | `GenerateBookingCode()` builds a `BK-YYYYMMDD-NNNN` string. It counts same-day bookings already in the database to assign a sequential four-digit suffix (e.g., `BK-20260416-0003`).                                                                                                                                                                                                                                              |
| **Admin auth**        | `AdminManager.ValidateLogin()` hashes the submitted password with `HashHelper.ComputeSHA256()` and executes `SELECT full_name FROM admins WHERE username = @u AND password_hash = @h`. No plaintext passwords are ever stored or compared.                                                                                                                                                                                        |
| **Overdue detection** | On every open of `FrmAdminDashboard`, `AdminManager.UpdateOverdueRentals()` runs `UPDATE rentals SET status = 'Overdue' WHERE rental_end < CURDATE() AND status = 'Active'`, keeping the status column accurate without a scheduled job.                                                                                                                                                                                          |
| **Return / Cancel**   | Both operations in `AdminManager` open a transaction: first restore `avail_stock` via a joined `UPDATE equipment … JOIN rental_details`, then set the rental `status`. Rollback fires on any exception.                                                                                                                                                                                                                           |
| **Soft delete**       | `AdminManager.DeleteEquipment()` sets `is_active = 0` rather than removing the row, preserving `rental_details` FK references for historical bookings. The kiosk query includes `WHERE is_active = 1` to hide deactivated items.                                                                                                                                                                                                  |
| **Configuration**     | `DBConnection.GetConnection()` reads the `TwoCRentals` key from `App.config` and returns a `MySqlConnection`. This is the single place where the connection string is consumed — changing a server hostname or credentials requires editing only one XML file.                                                                                                                                                                    |

---

## Database Schema

```
customers
  customer_id (PK) | full_name | contact_no | created_at

equipment
  equipment_id (PK) | name | category | daily_rate
  total_stock | avail_stock | icon_tag | is_active

rentals
  rental_id (PK) | booking_code (UNIQUE) | customer_id (FK)
  rental_start | rental_end | security_dep | subtotal
  total_amount | status | created_at

rental_details
  detail_id (PK) | rental_id (FK) | equipment_id (FK)
  quantity | daily_rate | days_rented | line_total

admins
  admin_id (PK) | username (UNIQUE) | password_hash | full_name
```

Rental `status` values: `Active` → `Overdue` (auto) → `Returned` or `Cancelled`.

---

## File Structure

```
ERS/
├── ERS.slnx                       # Visual Studio solution file
└── ERS/
    ├── App.config                  # Connection string (key: TwoCRentals)
    ├── ERS.vbproj                  # SDK-style project — framework, NuGet refs
    ├── setup_database.sql          # Full schema creation + seed data
    │
    ├── ── Data Models ──
    ├── EquipmentItem.vb            # POCO: equipment fields + IsAvailable property
    ├── CartItem.vb                 # POCO: holds EquipmentItem ref, qty, LineTotal()
    │
    ├── ── Business / Service Layer ──
    ├── DBConnection.vb             # Factory: returns MySqlConnection from App.config
    ├── HashHelper.vb               # Utility: SHA-256 hex-string computation
    ├── RentalManager.vb            # Customer ops: load catalog, CreateBooking()
    ├── AdminManager.vb             # Admin ops: auth, stats, rental CRUD, equipment CRUD
    │
    ├── ── Customer Forms ──
    ├── FrmKiosk.vb                 # Equipment browser, cart, rental-days stepper
    ├── FrmKiosk.Designer.vb        # Designer-managed controls (static layout)
    ├── FrmCheckout.vb              # Customer name/contact + date pickers
    ├── FrmConfirmation.vb          # Booking confirmed screen (shows booking code)
    │
    ├── ── Admin Forms ──
    ├── FrmAdminLogin.vb            # Username + password entry
    ├── FrmAdminDashboard.vb        # Stats cards + rentals grid + return/cancel
    ├── FrmManageEquipment.vb       # Equipment CRUD (name, category, rate, stock, icon)
    │
    └── My Project/
        └── Application.myapp       # WinForms startup configuration
```

### Designer vs. runtime controls in `FrmKiosk`

`FrmKiosk.Designer.vb` contains the static skeleton: the header bar, left content panel, right cart sidebar, rental-days stepper (`btnDaysDown` / `lblDaysValue` / `btnDaysUp`), and action buttons. Everything data-driven is built at runtime in `FrmKiosk.vb`:

- `AddFilterPills()` — creates pill-shaped `Button` controls for each category at startup.
- `RenderGrid()` — builds a rounded card `Panel` per equipment item, complete with icon label, name, rate, stock badge, and an **Add** button.
- `RefreshCartUI()` — rebuilds cart rows with inline `+` / `−` quantity controls and calls `RecalcTotals()`.
- `RecalcTotals()` — recomputes every line and the grand total live whenever quantity or rental days change.

These runtime-generated controls are **not visible in the Visual Studio Forms Designer** — this is expected behavior.

---

## Installation & Local Setup

### Prerequisites

| Requirement                                            | Version                                            |
| ------------------------------------------------------ | -------------------------------------------------- |
| [.NET SDK](https://dotnet.microsoft.com/download)      | 10.0 or later                                      |
| [MySQL Server](https://dev.mysql.com/downloads/mysql/) | 8.0 or later                                       |
| Windows OS                                             | Required — WinForms only runs on `net10.0-windows` |

### Step 1 — Clone

```bash
git clone https://github.com/Tways-study/Equipment-Rental-System.git
cd Equipment-Rental-System
```

### Step 2 — Create the database

The script creates the `twoc_rentals_db` database, all five tables, six sample equipment items, and the default admin account:

```bash
mysql -u YOUR_MYSQL_USER -p < ERS/setup_database.sql
```

### Step 3 — Configure the connection string

Open `ERS/App.config` and set your MySQL credentials:

```xml
<connectionStrings>
  <add name="TwoCRentals"
       connectionString="Server=localhost;Database=twoc_rentals_db;Uid=YOUR_USER;Pwd=YOUR_PASSWORD;CharSet=utf8mb4;"
       providerName="MySql.Data.MySqlClient" />
</connectionStrings>
```

> `CharSet=utf8mb4` is required — equipment icon tags are stored as emoji in the database.

### Step 4 — Restore NuGet packages

```bash
dotnet restore
```

This fetches `MySql.Data` (v9.6.0) and `System.Configuration.ConfigurationManager` (v9.0.4).

---

## Running the Project

### Development

```bash
dotnet run --project ERS/ERS.vbproj
```

`FrmKiosk` opens as the startup form. Press **F12** anywhere on the kiosk to open the admin login dialog.

### Production — self-contained publish

Produces a folder that can be copied to any Windows machine without a .NET runtime pre-installed:

```bash
dotnet publish ERS/ERS.vbproj -c Release -r win-x64 --self-contained true
```

Output: `ERS/bin/Release/net10.0-windows/win-x64/publish/ERS.exe`

---

## Default Admin Credentials

| Field    | Value                                                        |
| -------- | ------------------------------------------------------------ |
| Username | `admin`                                                      |
| Password | _(see `setup_database.sql` — change this after first login)_ |

> Change the default password after first login. To provision additional admin accounts:
>
> ```sql
> INSERT INTO admins (username, password_hash, full_name)
> VALUES ('newuser', SHA2('your_chosen_password', 256), 'Full Name');
> ```

---

## Troubleshooting

| Symptom                                         | Fix                                                                                                      |
| ----------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| Build error `MSB3027` / `MSB3021` (file locked) | Close any running instance of `ERS.exe` before rebuilding.                                               |
| Equipment icons show as `?` boxes               | Ensure `CharSet=utf8mb4` is in the connection string and your MySQL instance uses a `utf8mb4` collation. |
| `MySqlException: Access denied` on launch       | Verify `Uid` and `Pwd` in `App.config` against your MySQL user.                                          |
| `Unknown database 'twoc_rentals_db'`            | Re-run `setup_database.sql` against the correct MySQL server instance.                                   |
| Dynamic cards/pills missing at runtime          | These controls are built in code, not the designer — this is expected. Run the project to see them.      |
