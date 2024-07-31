namespace MonopolyGame;

public class Railroads
{
    public int Id {get; private set;}
	public string Name {get; private set;}
	public decimal Price {get; private set;}
	public decimal Rent {get; private set;}
	public IPlayer Owner {get; set;}
	
	public Railroads(string name, decimal price, decimal rent)
	{
	}
	public bool EffecSquare(IPlayer player)
	{
	}
	public bool Buy(IPlayer player)
	{
	}
	public bool Rent(IPlayer player)
	{
	}
}
