# 📋 Setup Guide

Guida completa per configurare l'ambiente di sviluppo.

## 🔧 Prerequisiti

### Obbligatori
- **.NET 8.0 SDK** - [Download](https://dotnet.microsoft.com/download/dotnet/8.0)
- **Visual Studio 2022** (Community edition) o **VS Code**
- **SQL Server 2019+** o **PostgreSQL 12+**
- **Git**

### Consigliati
- **SQL Server Management Studio (SSMS)** - Gestione database
- **Postman** - Testing API
- **Unity 2022 LTS+** - Se usi Unity per il client

## 📥 Installazione

### 1. Clone Repository

```bash
git clone https://github.com/Alertix/habbo-rp-game.git
cd habbo-rp-game
```

### 2. Configurazione Database

#### Opzione A: SQL Server

```bash
# Crea database
sqlcmd -S localhost -U sa -P YourPassword -Q "CREATE DATABASE HabboRPGame"

# Update connection string in appsettings.json
# Server=localhost;Database=HabboRPGame;User Id=sa;Password=YourPassword;Encrypt=false;TrustServerCertificate=true;
```

#### Opzione B: PostgreSQL

```bash
# Crea database
createdb habbo_rp_game

# Update connection string in appsettings.json
# Server=localhost;Port=5432;Database=habbo_rp_game;User Id=postgres;Password=YourPassword;
```

### 3. Restore Dependencies

```bash
dotnet restore
```

### 4. Update Database (Migrations)

```bash
cd Server/HabboServer.Api
dotnet ef database update
```

### 5. Run Server

```bash
dotnet run
```

Server sarà disponibile a: `https://localhost:5001`

## 🚀 Struttura Cartelle

```
Server/
├── HabboServer.Api/
│   ├── Controllers/          # REST endpoints
│   ├── Hubs/                 # SignalR hubs
│   ├── Program.cs            # Startup configuration
│   ├── appsettings.json      # Configuration
│   └── HabboServer.Api.csproj
│
├── HabboServer.Core/
│   ├── Enums/                # Game enums
│   ├── Models/               # Domain models
│   └── HabboServer.Core.csproj
│
├── HabboServer.Data/
│   ├── Context/              # DbContext
│   ├── Repositories/         # Data access layer
│   ├── Migrations/           # EF Core migrations
│   └── HabboServer.Data.csproj
│
└── HabboServer.Services/
    ├── Services/             # Business logic
    ├── Interfaces/           # Service contracts
    └── HabboServer.Services.csproj
```

## 🔐 Configurazione appsettings.json

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=HabboRPGame;User Id=sa;Password=YourPassword;Encrypt=false;TrustServerCertificate=true;"
  },
  "Jwt": {
    "SecretKey": "your-super-secret-key-min-32-characters-long!!!",
    "Issuer": "HabboRPGame",
    "Audience": "HabboRPGameClient",
    "ExpirationMinutes": 1440
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

## 🗄️ Database Migrations

### Creare una nuova migration

```bash
cd Server/HabboServer.Data
dotnet ef migrations add MigrationName
```

### Apply migration

```bash
dotnet ef database update
```

### Rollback ultimo migration

```bash
dotnet ef database update PreviousMigrationName
```

## 🧪 Testing

### Unit Tests

```bash
dotnet test
```

### API Testing con Postman

1. Importa collection da `docs/postman-collection.json`
2. Configura environment
3. Run requests

## 🐛 Troubleshooting

### Errore: "EF Core tools version does not match"

```bash
dotnet tool update --global dotnet-ef
```

### Errore: "Connection timeout to database"

- Verifica che SQL Server sia running
- Controlla connection string
- Verifica firewall

### Errore: "Port 5001 already in use"

```bash
# Cambia port in appsettings.json
"Urls": "https://localhost:5002"
```

### Errore: "Migration not found"

```bash
# Remove pending migrations
dotnet ef migrations remove

# Create fresh migration
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 📝 Environment Variables

Crea file `.env` root folder:

```env
DATABASE_URL=Server=localhost;Database=HabboRPGame;...
JWT_SECRET_KEY=your-super-secret-key-min-32-characters-long!!!
ASPNETCORE_ENVIRONMENT=Development
```

## 🔄 Development Workflow

```bash
# 1. Create feature branch
git checkout develop
git checkout -b feature/your-feature

# 2. Make changes
# 3. Test locally
dotnet run

# 4. Commit changes
git add .
git commit -m "feat: add your feature"

# 5. Push to remote
git push origin feature/your-feature

# 6. Create Pull Request on GitHub
```

## 📚 Risorse Utili

- [ASP.NET Core Docs](https://docs.microsoft.com/aspnet/core)
- [Entity Framework Core](https://docs.microsoft.com/ef/core)
- [SignalR Documentation](https://docs.microsoft.com/aspnet/core/signalr)
- [SQL Server Documentation](https://docs.microsoft.com/sql)

## 🆘 Support

Se hai problemi:
1. Controlla [Troubleshooting](#-troubleshooting) section
2. Apri un issue su GitHub
3. Contatta il team di sviluppo

---

Prossimo step: Leggi [ARCHITECTURE.md](ARCHITECTURE.md) per capire il design del sistema.
