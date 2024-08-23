using System.Collections;

class Program
{
	static void Main ()
	{
		ArrayList myArray = new();
		myArray.Add(1);
		myArray.Add(2);
		myArray.Add(3.0);
		myArray.Add(true);
		
		int x = (int)myArray[1];
		Console.WriteLine(x);
		// Console.WriteLine(myArray[1]);
		
	}
}