namespace MonopolyGame;

public class Property
{
    public string Name {get; private set;}
	public decimal Price {get; private set;}
	public decimal Rent {get; private set;}
	public IPlayer Owner {get; set;};
	
	public Property(string name, decimal price, decimal rent)
	{
	}
	public bool Buy(IPlayer player)
	{
	}
	public bool Rent(IPlayer player)
	{
	}
}
