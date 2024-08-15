using AbstractFactoryExample2.Client;
using AbstractFactoryExample2.Implementation;
using AbstractFactoryExample2.Interface;

class Program
{
	public static void Main(string[] args)
	{
		IFactory factory;
		string style = "Modern";
		
		if(style == "Modern"){
			factory = new ModernFactory();
		}
		else if(style == "Victoria")
		{
			factory = new VictorianFactory();
		}
		else
		{
			throw new Exception("gaya tidak dikenal" + style);
		}
		FurnitureShop furnitureShop= new FurnitureShop(factory);
		furnitureShop.DisplayFurniture();
	}
}