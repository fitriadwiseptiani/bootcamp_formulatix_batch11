class LegowithProperty
{
	//membuat agar class lain hanya bisa Read, dan yang bisa Write hanya kelas sendiri
	public int Price {get; set;}
	public string model;
	public bool stock;
	
	public LegowithProperty(int price, string modelName, bool available)
    {
        Price = price; // Inisialisasi Price di dalam konstruktor
        model = modelName;
        stock = available;
    }
	
}
class Rubrik
{
	public void RubrikInfo(LegowithProperty lego)
	{
		int currentPrice = lego.Price;
		string currentModel = lego.model;
		bool isAvailable = lego.stock;
		
		// Menampilkan informasi
        Console.WriteLine("Model: " + currentModel);
        Console.WriteLine("Harga: Rp." + currentPrice);
        Console.WriteLine("Ketersediaan: " + (isAvailable ? "Ada" : "Habis"));
		
	}
}
class Program
{
    static void Main()
    {
        // Membuat objek Lego dengan menggunakan konstruktor
        LegowithProperty legoSet = new LegowithProperty(1000000, "Colloseum", false);
        
        // Membuat objek OtherClass
        Rubrik rubrik = new Rubrik();
        
        // Memanggil method DisplayLegoInfo dari OtherClass
        rubrik.RubrikInfo(legoSet);
    }
}
