# 2C Rentals — Equipment Rental System

A dual-interface desktop equipment rental system built with **Visual Basic .NET (WinForms)** and **MySQL**. Designed for physical kiosk use with a separate password-protected admin panel.

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Folder Structure](#folder-structure)
- [Codebase Reference](#codebase-reference)
- [Database Schema](#database-schema)
- [Implementation Guide](#implementation-guide)
- [Default Credentials](#default-credentials)
- [Business Rules](#business-rules)

---

## Overview

| Mode | Access | Purpose |
|---|---|---|
| **Kiosk Mode** | Default on launch | Customers browse equipment, build a cart, and check out |
| **Admin Mode** | Press `F12` → login | Manage rentals, cancel/return orders, manage equipment inventory |

---

## Features

### Kiosk Mode
- Equipment catalog with category filter pills (All Gear, Seating, Audio/Visual, Tables)
- 3-column responsive equipment card grid with icon, name, price per day
- Out-of-stock items grayed out and blocked from cart
- Cart panel with `+` / `−` quantity controls per item
- Live subtotal + ₱500 security deposit + total calculation
- Checkout form — collects Name, Contact No., Start Date, End Date
- Booking confirmation screen showing `BK-YYYYMMDD-NNNN` ID
- Green toast notification on cart add

### Admin Mode
- SHA-256 login (`F12` to access)
- Dashboard with stat cards: Active Rentals, Overdue, Today's Bookings
- Rentals table with status filter (All / Active / Overdue / Returned / Cancelled)
- **Mark as Returned** — restores equipment stock
- **Cancel Rental** — cancels booking and restores equipment stock
- Auto-overdue detection on dashboard load
- Full equipment CRUD — Add, Edit, Delete (soft delete) with name, category, rate, stock, icon

---

## Tech Stack

| Component | Technology |
|---|---|
| Language | Visual Basic .NET |
| UI Framework | Windows Forms (.NET 10) |
| Database | MySQL 8.0 |
| MySQL Driver | MySql.Data 9.6.0 |
| Config | System.Configuration.ConfigurationManager 9.0.4 |
| Password Hashing | SHA-256 (System.Security.Cryptography) |
| Target Framework | net10.0-windows |

---

## Folder Structure

```
2C-Rentals/
│
├── README.md
│
└── ERS/                                  ← Visual Studio project root
    │
    ├── ERS.vbproj                        ← SDK-style project file
    ├── App.config                        ← MySQL connection string
    ├── setup_database.sql                ← Run this first in MySQL
    ├── ApplicationEvents.vb              ← VB Application framework events
    │
    ├── ── Infrastructure ──
    ├── DBConnection.vb                   ← Returns MySqlConnection from App.config
    ├── HashHelper.vb                     ← SHA-256 utility
    │
    ├── ── Models ──
    ├── EquipmentItem.vb                  ← Equipment POCO + IsAvailable property
    ├── CartItem.vb                       ← Cart POCO + LineTotal() method
    │
    ├── ── Business Logic (DB Layer) ──
    ├── RentalManager.vb                  ← LoadEquipment, CreateBooking (transaction)
    ├── AdminManager.vb                   ← Login, stats, rentals, Return/Cancel, equipment CRUD
    │
    ├── ── Kiosk UI ──
    ├── FrmKiosk.vb                       ← Kiosk code-behind (logic + event handlers)
    ├── FrmKiosk.Designer.vb              ← Kiosk designer file (InitializeComponent)
    ├── FrmCheckout.vb                    ← Checkout form (Name, Contact, Dates)
    ├── FrmConfirmation.vb                ← Booking confirmed screen + Booking ID
    │
    ├── ── Admin UI ──
    ├── FrmAdminLogin.vb                  ← SHA-256 credential check
    ├── FrmAdminDashboard.vb              ← Stats, rentals grid, Return + Cancel actions
    ├── FrmManageEquipment.vb             ← Equipment Add / Edit / Delete
    │
    └── My Project/
        └── Application.Designer.vb       ← Sets FrmKiosk as the startup form
```

---

## Codebase Reference

### `DBConnection.vb`
Single static method. Reads the `TwoCRentals` connection string from `App.config` and returns a new `MySqlConnection`. All managers call this — never hardcode connection strings elsewhere.

```vb
DBConnection.GetConnection()  ' → MySqlConnection
```

### `HashHelper.vb`
Wraps `SHA256.Create()`. Used by `AdminManager.ValidateLogin` and can be used to generate hashes for new admin accounts.

```vb
HashHelper.ComputeSHA256("plaintext")  ' → lowercase hex string (64 chars)
```

### `EquipmentItem.vb`
Plain data class. The `IsAvailable` read-only property returns `True` only when `AvailStock > 0 AND IsActive = True`. The kiosk uses this to decide whether to show the Add button or the Out of Stock label.

### `CartItem.vb`
Holds a reference to an `EquipmentItem` and a `Quantity`. `LineTotal(days)` computes `DailyRate × Quantity × days`.

### `RentalManager.vb`

| Method | Description |
|---|---|
| `LoadEquipment(category?)` | Returns `List(Of EquipmentItem)`, optionally filtered by category |
| `CreateBooking(...)` | Full booking transaction — inserts customer → rental → details → deducts stock. Rolls back if any item goes out of stock. Returns booking code. |

### `AdminManager.vb`

| Method | Description |
|---|---|
| `ValidateLogin(user, pass)` | Returns `full_name` on success, `Nothing` on failure |
| `UpdateOverdueRentals()` | Sets `status = 'Overdue'` where `rental_end < CURDATE()` |
| `GetStats()` | Returns `(Active, Overdue, TodayBookings)` tuple |
| `LoadRentals(status?)` | Returns `DataTable` joined with customer name/contact |
| `ReturnRental(id)` | Restores stock + sets `status = 'Returned'` in one transaction |
| `CancelRental(id)` | Restores stock + sets `status = 'Cancelled'` in one transaction |
| `LoadAllEquipment()` | Returns `DataTable` of all equipment rows |
| `AddEquipment(...)` | Inserts new equipment row |
| `UpdateEquipment(...)` | Updates row; adjusts `avail_stock` by stock delta |
| `DeleteEquipment(id)` | Soft delete — sets `is_active = 0` |

### `FrmKiosk.vb` + `FrmKiosk.Designer.vb`
The designer file owns all static controls (`InitializeComponent`). The code-behind owns:
- Color constants
- `AddFilterPills()` — builds the 4 category pill buttons at runtime
- `RenderGrid()` — builds equipment cards dynamically from DB data
- `RefreshCartUI()` — rebuilds cart rows with `+`/`−` controls
- `ShowToast()` — green floating notification, auto-dismisses after 2 seconds
- `OnKeyDown` — `F12` triggers admin login flow

---

## Database Schema

```sql
customers      (customer_id PK, full_name, contact_no, created_at)
equipment      (equipment_id PK, name, category, daily_rate,
                total_stock, avail_stock, icon_tag, is_active)
rentals        (rental_id PK, booking_code UNIQUE, customer_id FK,
                rental_start, rental_end, security_dep, subtotal,
                total_amount, status, created_at)
rental_details (detail_id PK, rental_id FK, equipment_id FK,
                quantity, daily_rate, days_rented, line_total)
admins         (admin_id PK, username UNIQUE, password_hash, full_name)
```

**Status values for `rentals.status`:** `Active` · `Returned` · `Overdue` · `Cancelled`

---

## Implementation Guide

### Prerequisites

| Requirement | Version |
|---|---|
| Visual Studio | 2022 or later |
| .NET SDK | 10.0 |
| MySQL Server | 8.0 |

### Step 1 — Clone the repository

```sh
git clone https://github.com/your-username/2C-Rentals.git
cd 2C-Rentals
```

### Step 2 — Set up the database

Open **MySQL Workbench** (or any MySQL client) and run the setup script:

```sh
mysql -u root -p < ERS/setup_database.sql
```

Or open `ERS/setup_database.sql` in MySQL Workbench and execute it. This will:
- Create the `twoc_rentals_db` database
- Create all 5 tables
- Seed 6 equipment items
- Create the default admin account

### Step 3 — Configure the connection string

Open `ERS/App.config` and update the connection string to match your MySQL credentials:

```xml
<add name="TwoCRentals"
     connectionString="Server=localhost;Database=twoc_rentals_db;Uid=root;Pwd=YOUR_PASSWORD;CharSet=utf8mb4;"
     providerName="MySql.Data.MySqlClient" />
```

| Parameter | Default | Description |
|---|---|---|
| `Server` | `localhost` | MySQL host |
| `Database` | `twoc_rentals_db` | Must match the SQL script |
| `Uid` | `root` | MySQL username |
| `Pwd` | `root` | MySQL password |
| `CharSet` | `utf8mb4` | Required for emoji icon support |

### Step 4 — Restore NuGet packages and build

Open `ERS/ERS.vbproj` in Visual Studio, then:

```
Build → Build Solution   (Ctrl + Shift + B)
```

NuGet packages are restored automatically. Required packages:
- `MySql.Data` 9.6.0
- `System.Configuration.ConfigurationManager` 9.0.4

### Step 5 — Run

Press **F5** to launch. The kiosk opens immediately.

---

## Default Credentials

| Field | Value |
|---|---|
| Username | `admin` |
| Password | `admin123` |
| Access | Press `F12` on the kiosk screen |

> Passwords are stored as SHA-256 hashes. To add a new admin run:
> ```sql
> INSERT INTO admins (username, password_hash, full_name)
> VALUES ('newuser', SHA2('yourpassword', 256), 'Full Name');
> ```

---

## Business Rules

| Rule | Detail |
|---|---|
| **Booking transaction** | `INSERT customer → rental → details → UPDATE avail_stock` wrapped in one `TRANSACTION`. Rolls back entirely if any item has insufficient stock. |
| **Line total formula** | `daily_rate × quantity × DATEDIFF(rental_end, rental_start)` |
| **Grand total formula** | `subtotal + ₱500 security deposit` |
| **Booking ID format** | `BK-YYYYMMDD-NNNN` (sequential per day) |
| **Overdue detection** | Runs automatically on every Admin Dashboard load |
| **Return / Cancel stock restore** | `avail_stock += quantity` per line item, wrapped in one `TRANSACTION` |
| **Restock via Edit** | Change `Stock` field in Manage Equipment → Update adjusts `avail_stock` by the delta, preserving currently rented-out units |
| **Out-of-stock display** | Cards are grayed out with an "Out of Stock" badge; Add to Cart is blocked |
| **Soft delete** | Deleting equipment sets `is_active = 0`; existing rental history is preserved |

---

## Color Palette

| Token | Hex | Used For |
|---|---|---|
| Background | `#F0F2F5` | Page / panel backgrounds |
| Navy | `#1E3A5F` | Header, labels, primary buttons |
| Orange | `#F47C20` | CTA buttons (Checkout, Manage Equipment) |
| Green | `#1A5C2A` | Toast notification, Mark as Returned button |
| White | `#FFFFFF` | Cards, cart panel |
