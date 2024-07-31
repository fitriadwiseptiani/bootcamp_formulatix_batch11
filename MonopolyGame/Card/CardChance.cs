namespace MonopolyGame;

public class CardChance : ICard
{
    public int Id {get; private set;}
	public string Description {get; private set;}
	public TypeCard typeCard { get; private set;}
    public ChanceCard ChanceCard { get; }
	
	public CardChance(int id, string description, ChanceCard chanceCard)
	{
		Id = id;
		Description = description;
		// TypeCard = typeCard;
		ChanceCard = chanceCard;
	}
	public bool ActionCard(IPlayer player, GameController game)
	// berisikan logika untuk memproses efek dari kartu (chance card atau community card)
	{	
		PlayerData playerData= game.GetPlayerData(player);
		switch(ChanceCard)
		{
			case ChanceCard.AdvanceToGo:
			// Collect 200 from bank
			game.MovePlayer(player, game.board, null);
			playerData.AddBalance(200);
				break;

			case ChanceCard.GoToJail:
			game.HandleGoToJail(player);
				break;

			case ChanceCard.GetOutOfJailFree:
			game.HandleGetOutJail(player);
				break;

			case ChanceCard.PayPoorTax:
				game.PayTax(player, 15);
				playerData.DeductBalance(15);
				break;
			
			case ChanceCard.GoBackThreeSquare:
			game.MovePlayer(player, )

			case ChanceCard.AdvanceToIllinoisAvenue:

			case ChanceCard.AdvanceToStCharlesPlace:

			case ChanceCard.TakeARideOnTheReadingPlace:

			case ChanceCard.AdvanceToBroadwalk:

			case ChanceCard.YourBuildingLoanMatures:

			case ChanceCard.BankPaysYouDividend:

			case ChanceCard.PayEachPlayer:

			case ChanceCard.BuildingAndLoanAssociation:

			case ChanceCard.GeneralRepairs:

			case ChanceCard.SpeedingFine:

			default:
			return false;
		}
		
	}
}
