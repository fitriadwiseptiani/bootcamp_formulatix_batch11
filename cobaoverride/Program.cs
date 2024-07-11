class Cake 
{
	public virtual void Make()
	{
		Console.WriteLine("Dibuat dengan cara dikukus");
	}
	public virtual void Material()
	{
		Console.WriteLine("Dibuat dari tepung, susu, gula, telur");
	}
}
class ChocolateCake : Cake
{
	public override void Make()
	{
		Console.WriteLine("Tinggal di goreng");
	}
	public virtual void Material()
	{
		Console.WriteLine("Dibuat dari tepung dan cokelat");
	}
}
class Program
{
	static void Main()
	{
		Cake cake= new Cake();
		cake.Make();
		cake.Material();
		
	}
}