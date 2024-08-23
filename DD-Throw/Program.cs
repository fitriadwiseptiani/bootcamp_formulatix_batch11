// Throw

void Main()
{
	Console.WriteLine("Program Start");
	int[]myArray = {1,2,3};
	try
	{
		myArray[4].Dump();
	}
	catch(Exception e)
	{
		throw new NullReferenceException("Ada yang salah bro");
	}
	
	
	Console.WriteLine("Program Finish");
}
