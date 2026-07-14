# Production Giveaway Tracker

A Windows Forms desktop application built with C# and .NET for recording, managing and reviewing production giveaway data.

The project was inspired by a real manufacturing process and was created to practise applying C# to a practical workplace problem.

## Features

- Add production giveaway records
- Edit existing records
- Delete records
- Validate user input
- Record:
  - Date
  - Shift
  - Production line
  - Product
  - Giveaway weight
- Display records in a `DataGridView`
- Automatically calculate total giveaway
- Save records to a JSON file
- Load previously saved records when the application starts

## Technologies Used

- C#
- .NET
- Windows Forms
- System.Text.Json
- Git
- GitHub
- Visual Studio

## Project Structure


ProductionGiveawayTracker/
├── Form1.cs
├── Form1.Designer.cs
├── GiveawayRecord.cs
├── Program.cs
└── ProductionGiveawayTracker.csproj