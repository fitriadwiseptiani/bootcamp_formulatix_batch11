using AfterAbstractFactory.Model;
using AfterAbstractFactory.Interface ;

namespace AfterAbstractFactory.Implementation;

public class SummerFactory : IFactory
{
    public IShirt createShirt()
    {
        return new SummerShirt();
    }

    public IPant createPant()
    {
        return new SummerPant();
    }

    public IJacket createJacket()
    {
        return new SummerJacket();
    }
}
