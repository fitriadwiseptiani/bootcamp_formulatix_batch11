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
		Cake cakea = new Cake(3);
		Cake cakeb = new Cake(4);
		cakeb.price += 2;
		
		Console.WriteLine(cakea.price);	//hasil 3
		Console.WriteLine(cakeb.price);	//hasil 6
		
	}
}
