using BeforeAbstractFactory.Models;
class Program
{
    static void Main(string[] args)
    {
        // Memilih gaya pakaian
        Console.WriteLine("Pilih gaya pakaian: 'Winter' atau 'Summer'");
        string style = Console.ReadLine()?.Trim();

        // Set pilihan sesuai dengan style yang dipilih
        object shirt;
        object pant;
        object jacket;
        string[] availableFabrics;
        string[] availableSizes = { "S", "M", "L", "XL" }; // Ukuran yang tersedia sama untuk semua style
        string[] availableColors;

        if (style == "Summer")
        {
            Console.WriteLine("Anda akan membeli satu set pakaian summer\n");
            
            availableFabrics = new string[] { "Katun", "Linen", "Rayon" };
            availableColors = new string[] { "Putih", "Kuning", "Biru" };
            shirt = new SummerShirt();
            pant = new SummerPant();
            jacket = new SummerJacket();
        }
        else if (style == "Winter")
        {
            Console.WriteLine("Anda akan membeli satu set pakaian winter\n");
            
            availableFabrics = new string[] { "Wool", "Fleece", "Down" };
            availableColors = new string[] { "Hitam", "Abu-abu", "Merah" };
            shirt = new WinterShirt();
            pant = new WinterPant();
            jacket = new WinterJacket();
        }
        else
        {
            throw new Exception("Gaya tidak dikenal: " + style);
        }

        // Memilih bahan
        Console.WriteLine("Pilih bahan untuk pakaian Anda:");
        for (int i = 0; i < availableFabrics.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {availableFabrics[i]}");
        }
        int fabricChoice = int.Parse(Console.ReadLine()?.Trim() ?? "1") - 1;
        string fabric = availableFabrics[fabricChoice];

        // Memilih ukuran
        Console.WriteLine("Pilih ukuran untuk pakaian Anda:");
        for (int i = 0; i < availableSizes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {availableSizes[i]}");
        }
        int sizeChoice = int.Parse(Console.ReadLine()?.Trim() ?? "1") - 1;
        string size = availableSizes[sizeChoice];

        // Memilih warna
        Console.WriteLine("Pilih warna untuk pakaian Anda:");
        for (int i = 0; i < availableColors.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {availableColors[i]}");
        }
        int colorChoice = int.Parse(Console.ReadLine()?.Trim() ?? "1") - 1;
        string color = availableColors[colorChoice];

        // Set properties dan tampilkan detail
        foreach (var item in new[] { shirt, pant, jacket })
        {
            var type = item.GetType();
            var fabricProp = type.GetProperty("Fabric");
            var sizeProp = type.GetProperty("Size");
            var colorProp = type.GetProperty("Color");
            var detailsMethod = type.GetMethod("Details");

            fabricProp?.SetValue(item, fabric);
            sizeProp?.SetValue(item, size);
            colorProp?.SetValue(item, color);
            detailsMethod?.Invoke(item, null);

            Console.WriteLine($"Bahan: {fabric}, Ukuran: {size}, Warna: {color}\n");
        }
    }
}
