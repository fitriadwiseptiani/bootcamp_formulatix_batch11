class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		Calculator calc = new();
		int result = calc.Add(3, 5);
		Console.WriteLine(result);
	}
}
class Calculator
{
	public int Add(int a, int b) => a + b; 
}