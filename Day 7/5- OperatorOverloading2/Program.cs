// Human + Human = new Human
using System.Numerics;
class Calculator
{
	public T Decrement<T>(T a)where T : IDecrementOperators<T>
	{
		return a--;
	}

}
class Program
{
	static void Main(string[] args)
	{
		Calculator calculator= new Calculator();
		Human human = new Human();
		Human human2 = new Human();
		Human result = calculator.Decrement(human);		
		Console.WriteLine(result.salary);
		
	}
}
class Human : IDecrementOperators<Human>
{
	public int salary = 1000000;
	public static Human operator--(Human x)
	{
		int hasil = x.salary--;
		Human human = new Human();
		human.salary = hasil;
		return human;
	}
}

