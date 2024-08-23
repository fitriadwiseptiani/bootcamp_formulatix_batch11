namespace AbstractFactoryExample2.Interface;

public interface IFactory
{
	IChair createChair();
	ISofa createSofa();
	ICoffeTable createCoffeetable();
}
