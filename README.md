# ERS — Equipment Rental System (2C Rentals)

A Windows desktop application that provides a self-service kiosk for customers to browse and book rental equipment, paired with a secure admin portal for managing inventory, tracking rental statuses, and processing returns.

> **Repository:** https://github.com/Tways-study/Equipment-Rental-System

---

## Tech Stack

| Category          | Technology                                                |
| ----------------- | --------------------------------------------------------- |
| **Framework**     | .NET 10 (`net10.0-windows`)                               |
| **Language**      | VB.NET                                                    |
| **UI**            | Windows Forms (WinForms)                                  |
| **Database**      | MySQL (`twoc_rentals_db`)                                 |
| **DB Driver**     | MySql.Data v9.6.0                                         |
| **Configuration** | System.Configuration.ConfigurationManager v9.0.4          |
| **Security**      | SHA-256 password hashing (`System.Security.Cryptography`) |

---

## Architecture & System Relationships

The application follows a **layered Windows Forms architecture**, separating UI concerns from data access logic:

```
[Customer Flow]
FrmKiosk  →  FrmCheckout  →  FrmConfirmation

[Admin Flow]
FrmAdminLogin  →  FrmAdminDashboard  →  FrmManageEquipment

        ↓ both flows call ↓

[Business / Data Layer]
RentalManager.vb          AdminManager.vb

        ↓ both call ↓

[Database Abstraction]
DBConnection.vb  ←  App.config (connection string)

        ↓

[MySQL: twoc_rentals_db]
customers | equipment | rentals | rental_details | admins
```

**Data flow walkthrough:**

1. **Equipment browsing** — `FrmKiosk` calls `RentalManager.LoadEquipment()` on load, rendering available items as card tiles. Category filter pills narrow results with a server-side `WHERE category = @cat` clause.
2. **Cart & Checkout** — selected items are held in memory as a `List(Of CartItem)`. On checkout, `FrmCheckout` collects the customer's name, contact number, and rental dates.
3. **Atomic booking** — `RentalManager.CreateBooking()` wraps four operations inside a single MySQL **transaction**: insert `customers` → insert `rentals` header → insert `rental_details` line items → decrement `avail_stock`. If any step fails the transaction rolls back, preserving data integrity.
4. **Admin authentication** — `FrmAdminLogin` passes credentials to `AdminManager.ValidateLogin()`, which hashes the password with `HashHelper.ComputeSHA256()` and compares against the stored hash using a parameterized query. No plaintext passwords are stored or transmitted.
5. **Admin dashboard** — `FrmAdminDashboard` calls `AdminManager.UpdateOverdueRentals()` on load to auto-flag past-due rentals, then displays live stats via `AdminManager.GetStats()`.
6. **Configuration** — The connection string is stored in `App.config` under the key `TwoCRentals`. `DBConnection.GetConnection()` reads it at runtime, keeping database configuration separate from business logic.

All SQL commands use **parameterized queries** (`cmd.Parameters.AddWithValue`) throughout, preventing SQL injection.

---

## File Structure

```
ERS/
├── ERS.slnx                      # Solution file
└── ERS/
    ├── App.config                 # MySQL connection string
    ├── ERS.vbproj                 # SDK-style project (targets, NuGet refs)
    ├── setup_database.sql         # Schema creation + seed data
    │
    ├── ── Models ──
    ├── EquipmentItem.vb           # Equipment record POCO (includes IsAvailable)
    ├── CartItem.vb                # Cart line item (Quantity + LineTotal helper)
    │
    ├── ── Data / Business Layer ──
    ├── DBConnection.vb            # MySqlConnection factory from App.config
    ├── RentalManager.vb           # Catalog queries & atomic booking transaction
    ├── AdminManager.vb            # Auth, dashboard stats, rental & equipment CRUD
    ├── HashHelper.vb              # SHA-256 password hash utility
    │
    ├── ── Customer Forms ──
    ├── FrmKiosk.vb                # Self-service equipment browser & cart
    ├── FrmKiosk.Designer.vb       # Static WinForms designer controls
    ├── FrmCheckout.vb             # Customer info & rental date entry
    ├── FrmConfirmation.vb         # Booking confirmation screen
    │
    ├── ── Admin Forms ──
    ├── FrmAdminLogin.vb           # Admin credential entry
    ├── FrmAdminDashboard.vb       # Rental overview with return/cancel actions
    ├── FrmManageEquipment.vb      # Equipment CRUD panel
    │
    └── My Project/
        └── Application.myapp      # WinForms application entry-point config
```

**Key design notes:**

- `RentalManager` and `AdminManager` are `NotInheritable` classes with private constructors, acting as static service classes. All SQL lives here, keeping form code free of data access logic.
- `FrmKiosk.Designer.vb` holds static layout controls (panels, header, cart sidebar, stepper buttons). The code-behind `FrmKiosk.vb` builds dynamic content (equipment cards, filter pills, cart rows) at runtime — these are **not visible** in the Visual Studio designer.
- Equipment deletion is a **soft delete** (`is_active = 0`), preserving referential integrity with historical rentals.

---

## Installation & Local Setup

### Prerequisites

| Requirement                                                 | Notes                                   |
| ----------------------------------------------------------- | --------------------------------------- |
| [.NET SDK 10.0+](https://dotnet.microsoft.com/download)     | Required to build and run               |
| [MySQL Server 8.0+](https://dev.mysql.com/downloads/mysql/) | Must be running locally                 |
| **Windows OS**                                              | WinForms targets `net10.0-windows` only |

### 1. Clone the Repository

```bash
git clone https://github.com/Tways-study/Equipment-Rental-System.git
cd Equipment-Rental-System
```

### 2. Create the Database

Run the provided script against your MySQL server. This creates the `twoc_rentals_db` database, all required tables, sample equipment rows, and the default admin account:

```bash
mysql -u YOUR_USER -p < ERS/setup_database.sql
```

### 3. Configure the Connection String

Open `ERS/App.config` and update the credentials to match your MySQL installation:

```xml
<connectionStrings>
  <add name="TwoCRentals"
       connectionString="Server=localhost;Database=twoc_rentals_db;Uid=YOUR_USER;Pwd=YOUR_PASSWORD;CharSet=utf8mb4;"
       providerName="MySql.Data.MySqlClient" />
</connectionStrings>
```

> **Note:** `CharSet=utf8mb4` is required to correctly display emoji icon tags stored in the `equipment` table.

### 4. Restore NuGet Packages

Restore all dependencies declared in `ERS.vbproj`:

```bash
dotnet restore
```

This downloads `MySql.Data` (v9.6.0) and `System.Configuration.ConfigurationManager` (v9.0.4).

---

## Running the Project

### Development

Build and launch the application:

```bash
dotnet run --project ERS/ERS.vbproj
```

The kiosk form (`FrmKiosk`) opens by default. Press **F12** on the kiosk screen to access the admin login dialog.

**Default admin credentials:**

| Field    | Value      |
| -------- | ---------- |
| Username | `admin`    |
| Password | `admin123` |

> Change the admin password after first login. To add additional admin accounts via SQL:
>
> ```sql
> INSERT INTO admins (username, password_hash, full_name)
> VALUES ('newuser', SHA2('yourpassword', 256), 'Full Name');
> ```

### Production Build

Compile a self-contained Windows binary that does not require a separate .NET installation on the target machine:

```bash
dotnet publish ERS/ERS.vbproj -c Release -r win-x64 --self-contained true
```

Output is placed in `ERS/bin/Release/net10.0-windows/win-x64/publish/`. Copy this folder to the deployment machine and run `ERS.exe`.

---

## Troubleshooting

| Issue                                                 | Resolution                                                                                         |
| ----------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| Build fails with `MSB3027`/`MSB3021` file-lock errors | Ensure no running instance of `ERS.exe` is open. Close it and rebuild.                             |
| Equipment icons display as `?`                        | Verify `CharSet=utf8mb4` is set in `App.config` and the MySQL server collation supports `utf8mb4`. |
| `MySqlException: Access denied` on startup            | Check `Uid` and `Pwd` in `App.config` match your MySQL user credentials.                           |
| Database not found                                    | Confirm `setup_database.sql` was executed successfully against the correct MySQL server.           |
