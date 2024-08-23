using AbstractFactoryExample2.Interface;

namespace AbstractFactoryExample2.Model;

public class ModernChair : IChair
{
    public void Duduk()
    {
		Console.WriteLine("Membeli kursi modern");
    }

}
