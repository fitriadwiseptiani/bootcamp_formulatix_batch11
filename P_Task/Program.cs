class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		Task t1 = new Task(CheckArray);		
		Task t2 = new Task(CheckAbjad);
		
		t1.Start();
		t2.Start();
		
		t1.Wait();
		t2.Wait();

		Console.WriteLine("Program Finished");
	}
	static void CheckArray()
	{
		Console.WriteLine("Proses cek array akan dimulai");
		Thread.Sleep(5000);
		int[]myArray = {1,2,3};
		try
		{
			Console.WriteLine(myArray[4]);
		}
		catch(Exception e)
		{
			Console.WriteLine("Maaf ada kesalahan");
			Console.WriteLine(e.Message);
		}
	}
	static void CheckAbjad()
	{
		Console.WriteLine("Proses cek abjad akan dimulai");
		Thread.Sleep(5000);
		int[]myArray = {1,2,3,9,10,6};
		try
		{
			Console.WriteLine(myArray[4]);
		}
		catch(Exception e)
	{
		Console.WriteLine("Maaf ada kesalahan");
		Console.WriteLine(e.Message);
	}
		
	}
}