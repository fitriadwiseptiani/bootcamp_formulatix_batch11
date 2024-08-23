using AbstractFactoryExample2.Interface;

namespace AbstractFactoryExample2.Model;

public class VictoriaChair : IChair
{
    public void Duduk()
    {
        Console.WriteLine("membeli kursi victorian");
    }

}
