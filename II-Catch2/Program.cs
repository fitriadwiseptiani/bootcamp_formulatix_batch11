//Catch bisa digunakan lebih dari satu kali

void Main()
{
	Console.WriteLine("Program Start");
	Console.WriteLine("################################");
	try
	{
		string a = "40dfs";
		int result = int.Parse(a);
	
		int[] myArray = {1,2,3};
		myArray[5].Dump();
		
		int[] myArray2 = null;
		myArray[3].Dump();
	}
	catch(Exception e)
	{
		Console.WriteLine("Maaf ada kesalahan");
		Console.WriteLine(e.Message);
	}
	catch(IndexOutOfRangeException e)
	{
		Console.WriteLine("IndexOutOfRangeException...");
		Console.WriteLine(e.Message);
	}
	catch(NullReferenceException e)
	{
		Console.WriteLine("NullReferenceException...");
		Console.WriteLine(e.Message);
	}
	
	Console.WriteLine("################################");
	Console.WriteLine("Program Finish");
}

// Error karena yang ditulis exception general terlebih dahulu
