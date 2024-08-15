using AbstractFactoryExample2.Interface;

namespace AbstractFactoryExample2.Model;

public class ModernSofa : ISofa
{
    public void Duduk()
    {
        Console.WriteLine("Membeli sofa modern");
    }

}
