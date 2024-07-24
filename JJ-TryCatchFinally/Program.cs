void Main()
{
	Console.WriteLine("Program Start");
	Console.WriteLine("################################");
	try
	{
		int[] myArray = null;
		myArray[3].Dump();
	}
	catch(FormatException e)
	{
		Console.WriteLine("Maaf ada kesalahan");
		Console.WriteLine(e.Message);
	}
	finally
	{
		"...".Dump();
	}
	
	Console.WriteLine("################################");
	Console.WriteLine("Program Finish");
}

