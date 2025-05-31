# MonitorApp

A simple Windows Forms application for monitoring system resource usage.

The program reads CPU and RAM usage using system performance counters and logs warnings to the Windows Event Log if usage exceeds predefined thresholds.

## Features

- Monitors CPU and RAM usage every few seconds
- Displays current usage in the GUI
- Logs warnings to Windows Event Log if:
  - CPU usage > 80%
  - RAM usage > 70%
- Customizable timer interval and log thresholds (in future extensions)

## Requirements

- Visual Studio 2022 or newer
- .NET 6.0 or later
- Windows OS with administrative privileges (for EventLog writing)

## How to Run

1. Open `MonitorApp.sln` in Visual Studio
2. Press `F5` to run the application
3. Click "Start monitoring"
4. CPU and RAM usage will update every 3 seconds

## Troubleshooting

If the application does not start or crashes immediately:

- Ensure `EventLog.CreateEventSource()` is wrapped in a try-catch block
- Run Visual Studio as administrator if you want Event Log access
- Replace `ApplicationConfiguration.Initialize()` with classic startup code:

```csharp
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
Application.Run(new Form1());
```

## Windows Event Log

To inspect log entries:

1. Press `Win + R`, type `eventvwr`, press Enter
2. Open `Windows Logs -> Application`
3. Look for entries with source: `MonitorApp`

## File Structure

```
MonitorApp/
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── MonitorApp.csproj
MonitorApp.sln
.gitignore
README.md
```


