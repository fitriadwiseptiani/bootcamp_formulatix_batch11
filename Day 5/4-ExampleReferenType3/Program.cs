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
		cake = cake2;
		cake2.price = 4;
		cake.price += 5;
		
		Console.WriteLine(cake.price);	//hasil 9
		Console.WriteLine(cake2.price);	//hasil 9
		
		
	}
}
