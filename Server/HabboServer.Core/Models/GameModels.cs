namespace HabboServer.Core.Models;

/// <summary>
/// Rappresenta un utente del gioco
/// </summary>
public class User
{
    public int Id { get; set; }
    
    /// <summary>Nome utente unico</summary>
    public string Username { get; set; } = string.Empty;
    
    /// <summary>Email univoca</summary>
    public string Email { get; set; } = string.Empty;
    
    /// <summary>Password hashata</summary>
    public string PasswordHash { get; set; } = string.Empty;
    
    /// <summary>Nome display visibile nel gioco</summary>
    public string DisplayName { get; set; } = string.Empty;
    
    /// <summary>Avatar/Profilo picture URL</summary>
    public string? AvatarUrl { get; set; }
    
    /// <summary>Bio/Descrizione utente</summary>
    public string? Bio { get; set; }
    
    /// <summary>Valuta primaria (Credits)</summary>
    public long Credits { get; set; }
    
    /// <summary>Valuta premium (Diamonds)</summary>
    public long Diamonds { get; set; }
    
    /// <summary>Livello esperienza del giocatore</summary>
    public int Level { get; set; } = 1;
    
    /// <summary>Esperienza totale accumulata</summary>
    public long Experience { get; set; }
    
    /// <summary>Modalità di gioco attuale</summary>
    public GameMode CurrentGameMode { get; set; } = GameMode.Normal;
    
    /// <summary>Rango/Permessi dell'utente</summary>
    public UserRank Rank { get; set; } = UserRank.Player;
    
    /// <summary>Se l'account è attivo</summary>
    public bool IsActive { get; set; } = true;
    
    /// <summary>Se l'account è bannato</summary>
    public bool IsBanned { get; set; }
    
    /// <summary>Motivo del ban se presente</summary>
    public string? BanReason { get; set; }
    
    /// <summary>Data di creazione account</summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    /// <summary>Ultimo accesso</summary>
    public DateTime? LastLogin { get; set; }
    
    /// <summary>Ultima modifica profilo</summary>
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    // Relazioni
    public virtual ICollection<Inventory> Inventory { get; set; } = new List<Inventory>();
    public virtual ICollection<ChatMessage> SentMessages { get; set; } = new List<ChatMessage>();
    public virtual ICollection<EconomyTransaction> Transactions { get; set; } = new List<EconomyTransaction>();
    public virtual ICollection<MiniGameScore> MiniGameScores { get; set; } = new List<MiniGameScore>();
    public virtual ICollection<Friendship> FriendshipsInitiated { get; set; } = new List<Friendship>();
    public virtual ICollection<Friendship> FriendshipsReceived { get; set; } = new List<Friendship>();
    public virtual ICollection<RPJobSession> JobSessions { get; set; } = new List<RPJobSession>();
}

/// <summary>
/// Rappresenta un ruolo/lavoro per la modalità RP
/// </summary>
public class Role
{
    public int Id { get; set; }
    
    /// <summary>Nome del ruolo</summary>
    public string Name { get; set; } = string.Empty;
    
    /// <summary>Descrizione del ruolo</summary>
    public string Description { get; set; } = string.Empty;
    
    /// <summary>Categoria del ruolo</summary>
    public RoleCategory Category { get; set; }
    
    /// <summary>Stipendio orario in Credits</summary>
    public decimal HourlySalary { get; set; }
    
    /// <summary>Colore identificativo del ruolo (hex)</summary>
    public string ColorHex { get; set; } = "#FFFFFF";
    
    /// <summary>Numero massimo di giocatori con questo ruolo</summary>
    public int MaxSlots { get; set; }
    
    /// <summary>Numero attuale di giocatori con questo ruolo</summary>
    public int CurrentSlots { get; set; }
    
    /// <summary>Livello minimo richiesto</summary>
    public int MinimumLevel { get; set; } = 1;
    
    /// <summary>Se il ruolo è disponibile</summary>
    public bool IsActive { get; set; } = true;
    
    /// <summary>Permessi speciali (JSON)</summary>
    public string? Permissions { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    // Relazioni
    public virtual ICollection<RPJobSession> JobSessions { get; set; } = new List<RPJobSession>();
}

/// <summary>
/// Rappresenta un oggetto/item nel gioco
/// </summary>
public class Item
{
    public int Id { get; set; }
    
    /// <summary>Nome dell'oggetto</summary>
    public string Name { get; set; } = string.Empty;
    
    /// <summary>Descrizione dell'oggetto</summary>
    public string Description { get; set; } = string.Empty;
    
    /// <summary>Tipo di oggetto</summary>
    public ItemType Type { get; set; }
    
    /// <summary>Rarità dell'oggetto</summary>
    public ItemRarity Rarity { get; set; }
    
    /// <summary>Prezzo in Credits</summary>
    public long PriceCredits { get; set; }
    
    /// <summary>Prezzo in Diamonds</summary>
    public long PriceDiamonds { get; set; }
    
    /// <summary>URL immagine dell'oggetto</summary>
    public string? ImageUrl { get; set; }
    
    /// <summary>Se è equipaggiabile</summary>
    public bool IsEquippable { get; set; }
    
    /// <summary>Se è consumabile (usa una volta)</summary>
    public bool IsConsumable { get; set; }
    
    /// <summary>Numero massimo posseduto</summary>
    public int MaxStackSize { get; set; } = 1;
    
    /// <summary>Se è disponibile nel negozio</summary>
    public bool IsAvailableForSale { get; set; } = true;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    // Relazioni
    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}

/// <summary>
/// Rappresenta l'inventario di un utente
/// </summary>
public class Inventory
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    public virtual User User { get; set; } = null!;
    
    public int ItemId { get; set; }
    public virtual Item Item { get; set; } = null!;
    
    /// <summary>Quantità posseduta</summary>
    public int Quantity { get; set; } = 1;
    
    /// <summary>Se l'oggetto è equipaggiato</summary>
    public bool IsEquipped { get; set; }
    
    /// <summary>Data di acquisizione</summary>
    public DateTime AcquiredAt { get; set; } = DateTime.UtcNow;
    
    /// <summary>Data di scadenza (per consumabili)</summary>
    public DateTime? ExpiresAt { get; set; }
}

/// <summary>
/// Rappresenta un messaggio di chat
/// </summary>
public class ChatMessage
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    public virtual User User { get; set; } = null!;
    
    /// <summary>Contenuto del messaggio</summary>
    public string Content { get; set; } = string.Empty;
    
    /// <summary>Tipo di canale chat</summary>
    public ChatChannelType ChannelType { get; set; }
    
    /// <summary>ID room/destinatario a seconda del tipo</summary>
    public int? ChannelId { get; set; }
    
    /// <summary>Se il messaggio è stato editato</summary>
    public bool IsEdited { get; set; }
    
    /// <summary>Se il messaggio è stato rimosso</summary>
    public bool IsDeleted { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? EditedAt { get; set; }
}

/// <summary>
/// Rappresenta una transazione economica
/// </summary>
public class EconomyTransaction
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    public virtual User User { get; set; } = null!;
    
    /// <summary>Tipo di transazione</summary>
    public TransactionType Type { get; set; }
    
    /// <summary>Tipo di valuta</summary>
    public CurrencyType Currency { get; set; }
    
    /// <summary>Importo della transazione</summary>
    public long Amount { get; set; }
    
    /// <summary>Saldo prima della transazione</summary>
    public long BalanceBefore { get; set; }
    
    /// <summary>Saldo dopo la transazione</summary>
    public long BalanceAfter { get; set; }
    
    /// <summary>Descrizione della transazione</summary>
    public string Description { get; set; } = string.Empty;
    
    /// <summary>ID dell'altro utente se applicabile</summary>
    public int? RelatedUserId { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

/// <summary>
/// Rappresenta un mini-gioco
/// </summary>
public class MiniGame
{
    public int Id { get; set; }
    
    /// <summary>Nome del mini-gioco</summary>
    public string Name { get; set; } = string.Empty;
    
    /// <summary>Descrizione</summary>
    public string Description { get; set; } = string.Empty;
    
    /// <summary>Status del mini-gioco</summary>
    public MiniGameStatus Status { get; set; } = MiniGameStatus.Active;
    
    /// <summary>Reward minimo in Credits</summary>
    public long MinReward { get; set; }
    
    /// <summary>Reward massimo in Credits</summary>
    public long MaxReward { get; set; }
    
    /// <summary>Livello minimo richiesto</summary>
    public int MinimumLevel { get; set; } = 1;
    
    /// <summary>Numero di giocatori attuali</summary>
    public int ActivePlayers { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    // Relazioni
    public virtual ICollection<MiniGameScore> Scores { get; set; } = new List<MiniGameScore>();
}

/// <summary>
/// Rappresenta un punteggio di mini-gioco
/// </summary>
public class MiniGameScore
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    public virtual User User { get; set; } = null!;
    
    public int MiniGameId { get; set; }
    public virtual MiniGame MiniGame { get; set; } = null!;
    
    /// <summary>Punteggio ottenuto</summary>
    public long Score { get; set; }
    
    /// <summary>Reward ricevuto</summary>
    public long RewardEarned { get; set; }
    
    /// <summary>Tempo di gioco in secondi</summary>
    public int DurationSeconds { get; set; }
    
    public DateTime PlayedAt { get; set; } = DateTime.UtcNow;
}

/// <summary>
/// Rappresenta un'amicizia tra utenti
/// </summary>
public class Friendship
{
    public int Id { get; set; }
    
    public int InitiatorUserId { get; set; }
    public virtual User InitiatorUser { get; set; } = null!;
    
    public int RecipientUserId { get; set; }
    public virtual User RecipientUser { get; set; } = null!;
    
    /// <summary>Status dell'amicizia</summary>
    public FriendshipStatus Status { get; set; } = FriendshipStatus.Pending;
    
    /// <summary>Note personali sull'amico</summary>
    public string? Notes { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}

/// <summary>
/// Rappresenta una sessione di lavoro in modalità RP
/// </summary>
public class RPJobSession
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    public virtual User User { get; set; } = null!;
    
    public int RoleId { get; set; }
    public virtual Role Role { get; set; } = null!;
    
    /// <summary>Data di inizio lavoro</summary>
    public DateTime StartedAt { get; set; } = DateTime.UtcNow;
    
    /// <summary>Data di fine lavoro se terminato</summary>
    public DateTime? EndedAt { get; set; }
    
    /// <summary>Salario totale guadagnato</summary>
    public decimal TotalEarned { get; set; }
    
    /// <summary>Se la sessione è ancora attiva</summary>
    public bool IsActive { get; set; } = true;
    
    /// <summary>Numero di ore lavorate</summary>
    public decimal HoursWorked { get; set; }
}
