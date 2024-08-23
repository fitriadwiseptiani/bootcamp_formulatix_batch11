using AbstractFactoryExample2.Interface;

namespace AbstractFactoryExample2.Client;

public class FurnitureShop
{
	private IFactory _factory;
	private IChair _chair;
	private ISofa _sofa;
	private ICoffeTable _coffeTable;

	public FurnitureShop(IFactory factory)
	{
		_factory = factory;
		createFurniture();
	}

	private void createFurniture()
	{
		_chair = _factory.createChair();
		_sofa = _factory.createSofa();
		_coffeTable = _factory.createCoffeetable();
	}
	public void DisplayFurniture()
	{
		_chair.Duduk();
		_sofa.Duduk();
		_coffeTable.TaruhKopi();
	}
}
