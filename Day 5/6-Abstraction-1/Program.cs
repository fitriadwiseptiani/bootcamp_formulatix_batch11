abstract class Cake
{
	public string type;
	public abstract void Material();
	public abstract void Make();
	public void Tools()
	{
		Console.WriteLine("Pembuatan cake menggunakan alatr seperti ...");
	}
}
class ChocolateCake : Cake
{
	public override void Material()
	{
		Console.WriteLine("Bahan untuk membuat cake ini coklat,...");
	}
	public override void Make()
	{
		Console.WriteLine("Cake ini dibuat dengan cara dikukus");
	}
}
class GreenteaCake : Cake
{
	public override void Material()
	{
		Console.WriteLine("Bahan untuk membuat cake ini teh pilihan,...");
	}
	public override void Make()
	{
		Console.WriteLine("Cake ini dibuat dengan cara dipanggang");
	}
}
class Dessert
{
	public Cake cake;
	public Dessert( Cake cake )
	{
		this.cake = cake;
	}
}
class Program
{
	static void Main()
	{
		// tidak bisa menggunakan Cake dikarenakan abstract dan abstract tidak bisa membuat instance baru
		ChocolateCake chocolate = new ChocolateCake(); 
		chocolate.Material();
		Dessert dessert = new Dessert(chocolate);	//dibuatkan class baru yang berisi class Cake agar program bisa berjalan
		Console.WriteLine(chocolate);	//hasilnya Chocolatecake karena sistem tidak mendefinisikan tentang fungsi atau method yang dipanggil
		Console.WriteLine(chocolate.Make);
		chocolate.Make();
		chocolate.Tools();
		Console.WriteLine(dessert);	//hasilnya Chocolatecake karena sistem tidak mendefinisikan tentang fungsi atau method yang dipanggil

	}
}