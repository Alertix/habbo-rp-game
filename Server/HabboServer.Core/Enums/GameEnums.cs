namespace HabboServer.Core.Enums;

/// <summary>
/// Rappresenta la modalità di gioco
/// </summary>
public enum GameMode
{
    /// <summary>Modalità normale standard tipo Habbo</summary>
    Normal = 0,
    
    /// <summary>Modalità Roleplay con ruoli e lavori</summary>
    RolePlay = 1
}

/// <summary>
/// Categorie di ruoli per la modalità RP
/// </summary>
public enum RoleCategory
{
    /// <summary>Lavori civili</summary>
    Civilian = 0,
    
    /// <summary>Forze dell'ordine</summary>
    Police = 1,
    
    /// <summary>Servizi emergenza</summary>
    Emergency = 2,
    
    /// <summary>Commercio</summary>
    Business = 3,
    
    /// <summary>Intrattenimento</summary>
    Entertainment = 4,
    
    /// <summary>Criminale</summary>
    Criminal = 5,
    
    /// <summary>Governo</summary>
    Government = 6
}

/// <summary>
/// Status di amicizia tra utenti
/// </summary>
public enum FriendshipStatus
{
    /// <summary>Richiesta in sospeso</summary>
    Pending = 0,
    
    /// <summary>Amici confermati</summary>
    Accepted = 1,
    
    /// <summary>Bloccato</summary>
    Blocked = 2,
    
    /// <summary>Rifiutato</summary>
    Rejected = 3
}

/// <summary>
/// Rarità degli oggetti di gioco
/// </summary>
public enum ItemRarity
{
    /// <summary>Comune</summary>
    Common = 0,
    
    /// <summary>Non comune</summary>
    Uncommon = 1,
    
    /// <summary>Raro</summary>
    Rare = 2,
    
    /// <summary>Molto raro</summary>
    VeryRare = 3,
    
    /// <summary>Leggendario</summary>
    Legendary = 4,
    
    /// <summary>Mitico</summary>
    Mythic = 5
}

/// <summary>
/// Tipi di oggetti nel gioco
/// </summary>
public enum ItemType
{
    /// <summary>Abiti e accessori</summary>
    Clothing = 0,
    
    /// <summary>Arredamento</summary>
    Furniture = 1,
    
    /// <summary>Cosmetici e acconciature</summary>
    Cosmetics = 2,
    
    /// <summary>Badge e riconoscimenti</summary>
    Badge = 3,
    
    /// <summary>Strumenti e attrezzi</summary>
    Tool = 4,
    
    /// <summary>Consumabili</summary>
    Consumable = 5,
    
    /// <summary>Monete virtuali</summary>
    Currency = 6
}

/// <summary>
/// Canali di chat disponibili
/// </summary>
public enum ChatChannelType
{
    /// <summary>Chat globale pubblica</summary>
    Global = 0,
    
    /// <summary>Chat privata uno-a-uno</summary>
    Private = 1,
    
    /// <summary>Chat di room/stanza</summary>
    Room = 2,
    
    /// <summary>Chat di fazione/gruppo</summary>
    Faction = 3,
    
    /// <summary>Chat di lavoro/professione</summary>
    Job = 4,
    
    /// <summary>Chat di sistema (notifiche)</summary>
    System = 5
}

/// <summary>
/// Tipo di transazione economica
/// </summary>
public enum TransactionType
{
    /// <summary>Guadagno da stipendio</summary>
    Salary = 0,
    
    /// <summary>Pagamento ad altro giocatore</summary>
    PlayerPayment = 1,
    
    /// <summary>Acquisto da negozio</summary>
    ShopPurchase = 2,
    
    /// <summary>Vendita di oggetto</summary>
    ItemSale = 3,
    
    /// <summary>Reward da mini-gioco</summary>
    MiniGameReward = 4,
    
    /// <summary>Multa o penalità</summary>
    Fine = 5,
    
    /// <summary>Bonus speciale</summary>
    Bonus = 6,
    
    /// <summary>Commissione transazione</summary>
    Fee = 7
}

/// <summary>
/// Tipo di valuta virtuale
/// </summary>
public enum CurrencyType
{
    /// <summary>Credits - valuta primaria</summary>
    Credits = 0,
    
    /// <summary>Diamonds - valuta premium</summary>
    Diamonds = 1,
    
    /// <summary>Token di lavoro</summary>
    JobTokens = 2
}

/// <summary>
/// Stato di un mini-gioco
/// </summary>
public enum MiniGameStatus
{
    /// <summary>Non disponibile</summary>
    Inactive = 0,
    
    /// <summary>Disponibile per il gioco</summary>
    Active = 1,
    
    /// <summary>In manutenzione</summary>
    Maintenance = 2,
    
    /// <summary>Temporaneamente disabilitato</summary>
    Disabled = 3
}

/// <summary>
/// Rango o livello dell'utente nel gioco
/// </summary>
public enum UserRank
{
    /// <summary>Giocatore normale</summary>
    Player = 0,
    
    /// <summary>Moderatore</summary>
    Moderator = 1,
    
    /// <summary>Amministratore</summary>
    Administrator = 2,
    
    /// <summary>Creatore/Owner</summary>
    Owner = 3
}
