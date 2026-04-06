# 2C Rentals — Equipment Rental System (simple)

Repository: https://github.com/Tways-study/Equipment-Rental-System

Short, focused README with the steps to get running and a minimal file map.

## Quick start
1. Clone
```powershell
git clone https://github.com/Tways-study/Equipment-Rental-System.git
cd Equipment-Rental-System
```
2. Create database
```powershell
mysql -u root -p < ERS/setup_database.sql
```
3. Update connection string
- Edit `ERS/App.config` and set `Pwd=YOUR_PASSWORD` for your MySQL user.

4. Open solution in Visual Studio (workload: .NET desktop) and build (Ctrl+Shift+B).
5. Run (F5). Kiosk opens by default. Press F12 to open Admin login.

## Minimal folder map
```
Equipment-Rental-System/
└─ ERS/  (Visual Studio project)
   ├─ ERS.vbproj
   ├─ App.config
   ├─ setup_database.sql
   ├─ DBConnection.vb, HashHelper.vb
   ├─ EquipmentItem.vb, CartItem.vb
   ├─ RentalManager.vb, AdminManager.vb
   └─ FrmKiosk.vb (+ Designer), FrmCheckout.vb, FrmAdmin*.vb
```

## Default admin
- Username: `admin`
- Access: Press `F12` on the kiosk screen to login

Passwords are stored as SHA-256 hashes. To add an admin:
```sql
INSERT INTO admins (username, password_hash, full_name)
VALUES ('newuser', SHA2('yourpassword', 256), 'Full Name');
```

## Notes
- Many UI elements (filter pills, equipment cards, cart rows) are created at runtime in code — they do not appear in the Visual Studio designer. Static controls (buttons placed in the Designer) do appear in the designer.
- If you see controls only at runtime, they were created dynamically by `FrmKiosk.vb` methods like `AddFilterPills()`, `RenderGrid()`, or `RefreshCartUI()`.

If you want this simplified README committed with a specific commit message, tell me and I will run the git commands for you (PowerShell).
