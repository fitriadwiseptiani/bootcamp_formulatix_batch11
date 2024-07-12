// Contoh reference type
class Cake
{
	public int price;
	public Cake(int price)
	{
		this.price = price;
	}
}
class Program 
{
	static void Main()
	{
		Cake cake = new Cake(3);
		Cake cake2 = cake;
		cake2.price += 2;
		
		Console.WriteLine(cake.price);	//hasil 5
		Console.WriteLine(cake2.price);	//hasil 5
		
	}
}
