class LegowithProperty
{
    // Properti Price hanya bisa dibaca (get) oleh kelas lain dan ditulis (set) hanya oleh kelas sendiri
    public int Price { get; private set; }
    public string model;
    public bool stock;
    
    public LegowithProperty(int price, string modelName, bool available)
    {
        Price = price; // Inisialisasi Price di dalam konstruktor
        model = modelName;
        stock = available;
    }
}

class LegoSet : LegowithProperty
{
    public LegoSet(int price, string modelName, bool available) : base(price, modelName, available)
    {
        
    }
}

class Rubrik
{
    public void RubrikInfo(LegowithProperty lego)
    {
        // Upaya untuk mengubah nilai Price di luar kelas LegowithProperty akan menghasilkan error
//         lego.Price = 600000; // Ini akan menghasilkan error karena set Price adalah private
        
        int currentPrice = lego.Price;
        Console.WriteLine("Harga Lego di Rubrik: Rp." + currentPrice);
    }
}

class Program
{
    static void Main()
    {
        // Membuat objek Lego dengan menggunakan konstruktor
        LegoSet legoset = new LegoSet(2000000, "Taj Mahal", false);
        
        // Memanggil method RubrikInfo dari kelas Rubrik
        Rubrik rubrik = new Rubrik();
        rubrik.RubrikInfo(legoset); // Mengirim objek LegoSet ke RubrikInfo
        
        // Menampilkan informasi dari LegoSet
        int currentPrice = legoset.Price;
        string currentModel = legoset.model;
        bool isAvailable = legoset.stock;
        
        Console.WriteLine("Model: " + currentModel);
        Console.WriteLine("Harga: Rp." + currentPrice);
        Console.WriteLine("Ketersediaan: " + (isAvailable ? "Ada" : "Habis"));
    }
}
