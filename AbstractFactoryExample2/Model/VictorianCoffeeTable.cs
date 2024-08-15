using AbstractFactoryExample2.Interface;

namespace AbstractFactoryExample2.Model;

public class VictorianCoffeeTable : ICoffeTable
{
	public void TaruhKopi()
	{
        Console.WriteLine("meletakkan kopi di meja kopi victorian");
	}
}
