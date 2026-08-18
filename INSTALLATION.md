# Installation

This document explains how to set up and run the BoardGameCafeApp (WinForms + EF Core) locally on a Windows development machine.

Prerequisites
- Windows 10 or later
- .NET 10 SDK (matching the project's TargetFramework: net10.0-windows)
- Visual Studio 2022/2023 (recommended) with the .NET desktop development workload OR the dotnet CLI
- SQL Server LocalDB (usually installed with Visual Studio)
- (Optional) EF Core tools for CLI: `dotnet tool install --global dotnet-ef` or use Package Manager Console in Visual Studio

Steps
1. Clone the repository

```bash
git clone https://github.com/MOMGD/Game-Board-Cafe.git
cd Game-Board-Cafe
```

2. Open the solution
- Open the .sln in Visual Studio, or use `dotnet` commands from the repo root.

3. Restore NuGet packages
- In Visual Studio: restore via the UI or build the solution.
- CLI: `dotnet restore`

4. Configure connection string
- The app reads `appsettings.json` (already present). By default it points to LocalDB:

```json
{
  "ConnectionStrings": {
    "CafeDb": "Server=(localdb)\\MSSQLLocalDB;Database=BoardGameCafeDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

- If you want to use a different SQL Server instance or file-based .mdf, update `appsettings.json` accordingly.
- Ensure `appsettings.json` is set to be copied to the output (the project already sets this to PreserveNewest).

5. Apply EF Core migrations / create database
Option A — Visual Studio (Package Manager Console)
```powershell
# Open Package Manager Console targeting the project containing the DbContext
Add-Migration InitialCreate
Update-Database
```

Option B — dotnet CLI (requires dotnet-ef tool)
```bash
dotnet ef migrations add InitialCreate --project BoardGameCafeApp --startup-project BoardGameCafeApp
dotnet ef database update --project BoardGameCafeApp --startup-project BoardGameCafeApp
```

Note: The project contains a design-time DbContext factory so EF tools can find the connection string in `appsettings.json`.

6. (Optional) Pre-seeded data
- On first run the application calls `DbInitializer.Initialize(db)` which will apply migrations and seed default cafe tables and some sample games if they do not exist.

7. Run the application
- In Visual Studio: press F5 or choose Start Debugging.
- Or with CLI (Windows-only GUI): `dotnet run --project BoardGameCafeApp`

8. Login
- Use the hardcoded credentials:
  - Username: `admin`
  - Password: `1234`

Troubleshooting
- If LocalDB is not installed, install it via Visual Studio installer or SQL Server Express LocalDB.
- If migration commands fail because EF tools are not installed, install `dotnet-ef` or use Visual Studio's Package Manager Console.
- If the connection string points to a non-existent server, update `appsettings.json` with a reachable SQL Server instance.

Files of interest
- `appsettings.json` — connection strings
- `Data/CafeDbContext.cs` — EF Core DbContext
- `Data/DbInitializer.cs` — runtime seeding
- `Data/CafeDbContextFactory.cs.cs` — design-time factory for migrations
- `BoardGameCafeApp.csproj` — .NET target, packages, and copy-to-output settings

If you'd like, I can also: update README.md to link to this INSTALLATION.md and include a short "Getting started" section, or open a pull request adding the file for you.
