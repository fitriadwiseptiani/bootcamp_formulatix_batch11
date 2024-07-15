class Lego
{
	private int _price;
	public string model;
	//untuk mendapatkan nilai dari variabel harga (Read)
	public int GetPrice()
	{
		return _price;
	}
	//mengatur nilai dari price (Write)
	public void SetPrice(int value)
	{
		_price = value;
	}
}

class Program 
{
	static void Main()
	{
		Lego lego = new Lego();
	
		lego.SetPrice(500000);
	
		int harga = lego.GetPrice();
	
		lego.model = "Stitch";
		
		Console.WriteLine("Model dari Lego yang kami miliki musim ini adalah " + lego.model);
		Console.WriteLine("Harga lego tersebut adalah Rp." + harga);
	}
	
	
}