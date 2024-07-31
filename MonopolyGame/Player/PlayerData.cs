namespace MonopolyGame;

public class PlayerData
{
    public PlayerPieces Piece;
	public decimal Balance {get; private set;}
	public List<Property> PropertyPlayer;
    public List<CardChance> CardChanceSave;
    public ISquare playerPosition;

    public PlayerData(PlayerPieces piece, decimal money){
        Piece = piece;
        Balance = money;
        PropertyPlayer = new List<Property>();
        CardChanceSave = new List<CardChance>();
    }
    public bool HaveAdvanceToGoCard(){
        // untuk mengetahuinya dari riwayat mendapatkan cardchance
        // periksa apakah pemain memiliki kartu "advance to go"
        return CardChanceSave.Any(card.Chan);
    }
    public bool HaveJailFreeCard()
    {
        
    }
    public void AddBalance(decimal cash)
    {

    }
    public void DeductBalance(decimal cash)
    {

    }
}
