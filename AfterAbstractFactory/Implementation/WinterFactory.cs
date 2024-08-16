using AfterAbstractFactory.Model;
using AfterAbstractFactory.Interface;

namespace AfterAbstractFactory.Implementation;

public class WinterFactory : IFactory
{
    public IShirt createShirt()
    {
        return new WinterShirt();
    }

    public IPant createPant()
    {
        return new WinterPant();
    }

    public IJacket createJacket()
    {
        return new WinterJacket();
    }
}
