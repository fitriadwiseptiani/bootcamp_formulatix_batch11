using AbstractFactoryExample2.Interface;
using AbstractFactoryExample2.Model;

namespace AbstractFactoryExample2.Implementation;

public class ModernFactory : IFactory
{
    public IChair createChair()
    {
        return new ModernChair();
    }

    public ICoffeTable createCoffeetable()
    {
    	return new ModernCoffeTable();
    }

    public ISofa createSofa()
    {
        return new ModernSofa();
    }

}
