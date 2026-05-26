# 🎮 Habbo RP Game

Un gioco multiplayer tipo **Habbo Hotel** con due modalità di gioco:
- **Modalità Normale**: Gameplay standard tipo Habbo
- **Modalità RP**: Roleplay con ruoli/lavori predefiniti

## 🌟 Features

### Modalità Normale
- Chat globale e private
- Sistema di inventario e oggetti
- Mini-giochi con reward
- Social system (amicizie, follow)
- Economia virtuale (Credits & Diamonds)

### Modalità RP
- Sistema di ruoli/lavori predefiniti
- Salari e stipendi per i lavori
- Sessioni di roleplay tracciabili
- Economy specializzata per RP
- Interazioni sociali avanzate

### Core Features
✅ Autenticazione JWT
✅ Database relazionale (SQL Server)
✅ Chat real-time (SignalR)
✅ Inventory management
✅ Economy system
✅ Mini-games framework
✅ Social network
✅ Leaderboards

## 🛠️ Tech Stack

**Backend:**
- C# 12 / .NET 8.0
- ASP.NET Core 8.0
- Entity Framework Core 8.0
- SignalR (Real-time communication)
- SQL Server / PostgreSQL

**Frontend:**
- C# / Unity (consigliato) o WPF/WinForms
- REST API Client
- SignalR Client

**Database:**
- SQL Server 2019+
- PostgreSQL (alternativa)

## 📁 Struttura Progetto

```
habbo-rp-game/
├── Server/
│   ├── HabboServer.Api/              # REST API + SignalR
│   ├── HabboServer.Core/             # Domain models
│   ├── HabboServer.Data/             # EF Core DbContext
│   ├── HabboServer.Services/         # Business logic
│   └── HabboServer.sln
├── Client/
│   ├── HabboClient.Core/             # Client logic
│   └── HabboClient.UI/               # UI (Unity/WPF)
├── Shared/
│   └── HabboGame.Common/             # DTOs, enums, constants
├── docs/
│   ├── SETUP.md                      # Setup guide
│   ├── ARCHITECTURE.md               # System design
│   ├── DATABASE.md                   # DB schema
│   ├── API.md                        # API documentation
│   └── GAMEPLAY.md                   # Game mechanics
├── .gitignore
└── README.md
```

## 🚀 Quick Start

### Prerequisiti
- .NET 8.0 SDK
- SQL Server 2019+ (o PostgreSQL)
- Visual Studio 2022 / VS Code

### Setup

```bash
# Clone repository
git clone https://github.com/Alertix/habbo-rp-game.git
cd habbo-rp-game

# Restore dependencies
dotnet restore

# Update database
dotnet ef database update

# Run server
cd Server/HabboServer.Api
dotnet run
```

Vedi `docs/SETUP.md` per la guida completa.

## 📚 Documentazione

- [Setup Guide](docs/SETUP.md) - Installazione e configurazione
- [Architecture](docs/ARCHITECTURE.md) - Design del sistema
- [Database Schema](docs/DATABASE.md) - Schema DB completo
- [API Documentation](docs/API.md) - Endpoints REST
- [Gameplay Mechanics](docs/GAMEPLAY.md) - Meccaniche di gioco

## 🎯 Roadmap

### Phase 1: Core Foundation ✅
- [x] Project structure
- [x] Database schema
- [x] Models & Enums
- [ ] Database layer (DbContext)
- [ ] Authentication (JWT)

### Phase 2: Game Systems
- [ ] Inventory system
- [ ] Chat hub (SignalR)
- [ ] Economy system
- [ ] RP Jobs system

### Phase 3: Advanced Features
- [ ] Mini-games
- [ ] Social system
- [ ] Leaderboards
- [ ] User profiles

### Phase 4: Client
- [ ] Desktop client (WPF/Unity)
- [ ] Real-time synchronization
- [ ] UI/UX implementation

## 👨‍💻 Development

Branching strategy:
- `main` - Production ready
- `develop` - Development branch
- `feature/*` - Feature branches

Workflow:
```bash
git checkout develop
git checkout -b feature/your-feature
# Make changes
git add .
git commit -m "feat: add your feature"
git push origin feature/your-feature
# Create Pull Request
```

## 📖 API Examples

### Authentication
```
POST /api/auth/register
POST /api/auth/login
POST /api/auth/logout
```

### User Management
```
GET /api/users/{id}
PUT /api/users/{id}
GET /api/users/{id}/inventory
```

### Chat
```
WS /ws/chat
POST /api/chat/message
GET /api/chat/history
```

Vedi `docs/API.md` per tutti gli endpoints.

## 🔐 Security

- JWT Authentication
- Password hashing (bcrypt)
- HTTPS/TLS
- CORS configuration
- Rate limiting
- SQL injection prevention (EF Core)

## 📝 License

MIT License

## 🤝 Contributing

Le contribuzioni sono benvenute! Per cambiamenti significativi, apri un issue per discutere le modifiche proposte.

## 📞 Support

Per problemi o domande, crea un issue su GitHub o contatta il team di sviluppo.

---

**Made with ❤️ by Alertix**
