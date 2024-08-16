using AfterAbstractFactory.Interface;

namespace AfterAbstractFactory.Client;

public class ClothesShop
{
    private IFactory _factory;
    private IShirt _shirt;
    private IPant _pant;
    private IJacket _jacket;

    public ClothesShop(IFactory factory)
    {
        _factory = factory;
        createClothes();
    }

    private void createClothes()
    {
        _shirt = _factory.createShirt();
        _pant = _factory.createPant();
        _jacket = _factory.createJacket();
    }
    public void DisplayClothes()
    {
        _shirt.Details();
        _pant.Details();
        _jacket.Details();
    }
}
