public delegate int MyCar();

class Program
{
	static void Main(string[] args)
	{
		Monkey monkey= new Monkey();
		// dipanggil class dengan method yang ingin ditampilkan
		MyZoo zoo = monkey.MakeSound;
		zoo += monkey.Eat;
		zoo();
	}
}
class Car
{
	
	private int price;
	public abstract int Sound();
	public void Pajak()
	{
		return 
	}
}
class Sport : Car
{
	
	public override int Sound()
	{
		Console.WriteLine("Brmmmmmmmmm");
	}
}
