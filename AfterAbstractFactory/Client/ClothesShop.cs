using AfterAbstractFactory.Interface;

namespace AfterAbstractFactory.Client;

public class ClothesShop
{
    private IFactory _factory;
    public ClothesShop(IFactory factory)
    {
        _factory = factory;
    }

    public void DisplayClothes()
        {
            var shirt = _factory.createShirt();
            var pant = _factory.createPant();
            var jacket = _factory.createJacket();

            // Display details
            Console.WriteLine("Detail Pakaian:");
            shirt.Details(); 
            pant.Details(); 
            jacket.Details();
        }
}
