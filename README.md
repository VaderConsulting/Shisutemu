# Shisutemu

Shisutemu is a C# judo tournament suite with mat scoreboards, kiosk, Haidenban switchboard, and entrant utilities. It covers championship and club events: ippon / waza-ari / shido and osaekomi timers on the scoreboard, networked updates via Comms/ClientServer, category and player models in Classes (Kurasu), and WillissConverter for mapping entrant CSV columns. Sample category XML and tournament prefs live under Data; NuGet packages are not committed.

**Source last updated:** 2018-11-16 · **Language:** C# · **Target:** .NET Framework 4.7.1 · **Output:** WinForms / WPF WinExe, class libraries, Windows service

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `Judo Scoreboard` | C# | WinForms WinExe | Mat scoreboard UI (timers, scores, category/player display) |
| `Kiosk` | C# | WinForms WinExe | Kiosk front-end (Google Calendar / OAuth hooks) |
| `Haidenban` (Switchboard) | C# | WinForms WinExe | Switchboard for tournaments, routine, and administration |
| `WillissConverter` | C# | WinForms WinExe | Maps entrant CSV/XLS columns into tournament import format |
| `App Starter` | C# | Windows service | Service that launches configured apps (Key Remapper product title) |
| `Classes` (Kurasu) | C# | Class library | Domain model: players, belts, matches, clubs, techniques |
| `Utilities` | C# | Class library | Shared helpers including SQL Data.Execute |
| `Comms` | C# | Class library | Client/server messaging (folder project; solution also references external ClientServer/Interface) |
| `ConsoleTest` | C# | Console Exe | Console harness for library testing |
| `GUITest` | C# | WinForms WinExe | GUI test harness |
| `Scoreboard` | C# | WPF WinExe | Alternate WPF scoreboard (present in tree; not listed in `Shisutemu.sln`) |

Solution folders also group Resources (technique images, national flags), Data, Images, and Web/Service placeholders. `packages/` holds NuGet restores (gitignored). External solution references to `Personal\Development\Comms\ClientServer` and `Interface` are outside this folder.

## How to open

Open `Shisutemu.sln` in Visual Studio (2017+ recommended for .NET Framework 4.7.1). Restore NuGet packages, then fix or remove the broken absolute paths to ClientServer/Interface if those projects are not on disk. For Kiosk Google OAuth, copy `Kiosk/client_secret.json.json.example` to `Kiosk/client_secret.json.json` and fill in your Google API client credentials. Entrant CSVs with live emails/phones are not in the repo; see `Data/*.example.csv` for column shape. Category XML under `Data/` and `Prefs.TournamentManager.xml` are safe sample configuration.

## Requirements

- Visual Studio 2017, .NET Framework 4.7.1

## Attribution and provenance

- **Assembly product titles:** Judo Scoreboard, Kiosk, Haidenban, WillissConverter, Kurasu (Classes), Utilities, Comms, Scoreboard; App Starter assembly title "Key Remapper"
- **Assembly copyright:** Copyright © 2016-2017; App Starter: Copyright © Vader Consulting 2017
- **References:** IJF sport/organisation and refereeing rules PDFs linked in `References.txt` (Rackspace CDN URLs)
- **Certificate:** `judowa.com.cer` (Judo WA TLS cert present in the tree)
- Working copy from my Historical Dev folder `Shisutemu`

## License

MIT. Copyright (c) 2026 VaderConsulting. See `LICENSE`. Third-party NuGet packages (Newtonsoft.Json, Google.Apis, Entity Framework, ASP.NET Identity, etc.) remain under their own licenses when restored from NuGet.
