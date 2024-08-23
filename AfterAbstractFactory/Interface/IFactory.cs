namespace AfterAbstractFactory.Interface;

public interface IFactory
{
    IShirt createShirt();
    IPant createPant();
    IJacket createJacket();
}
