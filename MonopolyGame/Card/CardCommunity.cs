namespace MonopolyGame;

public class CardCommunity : ICard
{
    public int Id {get; private set;}
	public string Description {get; private set;}
	public TypeCard typeCard { get; private set;}
    public CommunityCard CommunityCard { get; }
	
	public CardCommunity(int id, string description, CommunityCard communityCard)
	{
		Id = id;
		Description = description;
		CommunityCard = communityCard;
	}
	public bool ActionCard(IPlayer player, GameController game)
	{
		switch(CommunityCard)
		{
			case CommunityCard.BankError:

			case CommunityCard.DoctorsFee:

			case CommunityCard.IncomeTaxRefund:

			case CommunityCard.PayHospital:

			case CommunityCard.PaySchool:

			case CommunityCard.JailFree:

			case CommunityCard.GoToJail:

			case CommunityCard.FromSaleOfStock:

			case CommunityCard.ChairmanOfTheBoard:

			case CommunityCard.LifeInsuranceMatures:

			case CommunityCard.YouInherit:

			case CommunityCard.GrandOperaNight:

			case CommunityCard.YourBirthday:

			case CommunityCard.HolidayFundMatures:

			case CommunityCard.ConsultancyFee:

			case CommunityCard.StreetRepairs:

			// buat sebagai final case label
			default:
				return false;
		}
	}
}
