# Hospital Doctor Management System

A Windows Forms desktop application built with C# (.NET Framework 4.7.2) and MySQL for managing hospital doctor records.

## Features

- **Login** – Secure doctor login with username and password
- **Registration** – Add new doctors with full profile info (name, surname, age, gender, specialty, etc.)
- **Doctor Management** – View, update, and delete doctor records in a data grid

## Tech Stack

- C# / .NET Framework 4.7.2
- Windows Forms
- MySQL (`MySql.Data`)

## Requirements

- Visual Studio 2019 or later
- MySQL Server running on `localhost`
- Default credentials: `root` / `1234` (change in `Form1.cs` before running)

## Getting Started

1. Clone the repository
   ```bash
   git clone https://github.com/yourusername/FinalProject.git
   ```
2. Open `FinalProject.sln` in Visual Studio
3. Restore NuGet packages (right-click solution → *Restore NuGet Packages*)
4. Make sure MySQL Server is running
5. Update the connection string in `Form1.cs` if needed:
   ```csharp
   con = new MySqlConnection("server=localhost;username=root;password=YOUR_PASSWORD;");
   ```
6. Run the project (`F5`)

> The application will automatically create the `Hospital` database and `Doctors` table on first launch.

## Project Structure

```
FinalProject/
├── FinalProject.sln
└── FinalProject/
    ├── Program.cs
    ├── Form1.cs          # Login screen
    ├── Form2.cs          # Doctor registration
    ├── Form3.cs          # Doctor management panel
    ├── App.config
    ├── packages.config
    └── Properties/
```
