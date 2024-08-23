namespace MyCalculator;

public class Calculator
{
	public int Add(int a, int b)
	{
		if(a == 0 && b == 0)
		{
			throw new Exception("yang bener aja");
		}
		return a+b;
	}
}