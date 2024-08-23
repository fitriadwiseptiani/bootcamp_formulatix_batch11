using AfterAbstractFactory.Client;
using AfterAbstractFactory.Implementation;
using AfterAbstractFactory.Interface;

class Program
{
    public static void Main(string[] args)
    {
        IFactory factory;
        string style = "Winter";

        if (style == "Summer")
        {
            Console.WriteLine("Anda akan membeli satu set pakaian summer\n");
            factory = new SummerFactory();
        }
        else if (style == "Winter")
        {
            Console.WriteLine("Anda akan membeli satu set pakaian winter\n");
            factory = new WinterFactory();
        }
        else
        {
            throw new Exception("gaya tidak dikenal" + style);
        }
        ClothesShop clothesShop = new ClothesShop(factory);
        clothesShop.DisplayClothes();
    }
}