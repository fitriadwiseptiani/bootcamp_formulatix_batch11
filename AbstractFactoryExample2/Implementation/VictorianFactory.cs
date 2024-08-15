using AbstractFactoryExample2.Interface;
using AbstractFactoryExample2.Model;

namespace AbstractFactoryExample2.Implementation;

public class VictorianFactory : IFactory
{
    public IChair createChair()
    {
        return new VictoriaChair();
    }

    public ICoffeTable createCoffeetable()
    {
        return new VictorianCoffeeTable();
    }

    public ISofa createSofa()
    {
        return new VictoriaSofa();
    }

}
