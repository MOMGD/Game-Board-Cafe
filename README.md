# BoardGameCafeApp (WinForms + EF Core)

## Overview
BoardGameCafeApp is a Windows Forms desktop application for managing a board game café.  
It supports managing the game catalog, renting games to customers, booking café tables, and viewing history with filters.

This project uses:
- **C# WinForms (.NET 10)** for the GUI (event-driven programming)
- **Entity Framework Core** for database access
- **SQL Server LocalDB** for the database
- A simple **Service Layer** (`Services/`) to separate business logic from UI

---

## Login (Hardcoded)
Use the following credentials to log in:

- **Username:** `admin`  
- **Password:** `1234`

---

## Main Features

### 1) Game Catalog (CRUD + Filtering)
- View all games in a grid
- Filter by **Title** and **Genre**
- Add new games
- Edit existing games
- Delete games (delete is prevented if the game has rental history)

### 2) Rent a Game
- Select a game and enter a customer name
- Prevents renting when **no copies are available**
- Tracks active rentals (ReturnDate = null)
- “Return Selected” in History marks rental as returned

### 3) Table Booking
- Select a table, customer name, start/end time, optional notes
- Validates:
  - required fields
  - EndTime > StartTime
- Prevents **overlapping bookings** on the same table

### 4) History (Two Tabs)
- **Rentals tab**
  - filter by customer
  - optional date range filter
  - status filter: All / Active / Returned
  - return selected rental
- **Bookings tab**
  - filter by customer
  - optional date range filter
  - filter by table

---

## Project Structure (High Level)

- `Forms/`  
  WinForms UI screens (Login, Dashboard, GameCatalog, Add/Edit, Rent, Booking, History)

- `Models/`  
  Entity classes: `Game`, `Rental`, `CafeTable`, `Booking`

- `Data/`  
  EF Core database layer:
  - `CafeDbContext.cs`
  - `CafeDbContextFactory.cs` (design-time factory for migrations)
  - `DbInitializer.cs` (runtime seeding)

- `Services/`  
  Business logic layer:
  - `GameService`
  - `RentalService`
  - `BookingService`

---

## Database / EF Core

### Connection String
Stored in: `appsettings.json`

Example (LocalDB):
```json
{
  "ConnectionStrings": {
    "CafeDb": "Server=(localdb)\\MSSQLLocalDB;Database=BoardGameCafeDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

Make sure `appsettings.json` is set to:
- **Copy to Output Directory** → `Copy if newer`

### Migrations
From Visual Studio **Package Manager Console**:

```powershell
Add-Migration InitialCreate
Update-Database
```

### Seeding
On application startup, the app runs `DbInitializer.Initialize(db)` which:
- applies migrations (`db.Database.Migrate()`)
- seeds default **CafeTables** and some sample **Games** if tables are empty

---

## How to Run
1. Open the solution in Visual Studio
2. Ensure NuGet packages are restored
3. Run the project (F5)
4. Log in using the hardcoded credentials above

---

## Notes / Validation & Error Handling
- Forms use input validation (required fields, numeric ranges, date logic)
- Business rules throw `InvalidOperationException` which is shown to the user in friendly message boxes
- Additional exceptions are caught and displayed as error dialogs