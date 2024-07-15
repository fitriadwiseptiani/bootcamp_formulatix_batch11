class Calculator 
{
	public object Add(object a, object b)
	{
		return (int)a + (int)b;
	}
}
class Program 
{
	static void Main()
	{
		float a = 4;
		float b = 10;
		Calculator calculator= new Calculator();
		calculator.Add(5,10);
		Console.WriteLine();
	}
}