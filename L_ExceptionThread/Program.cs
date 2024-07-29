class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		try{
		Thread t1 = new Thread(CheckArray);		
		Thread t2 = new Thread(CheckAbjad);
		
		t1.Start();
		t2.Start();
		
		t1.Join();
		t2.Join();
		}
		catch(Exception e)
		{
			throw new NullReferenceException("Ada yang salah bro");
		}
		Console.WriteLine("Program Finished");
	}
	static void CheckArray()
	{
		Console.WriteLine("Proses cek array akan dimulai");
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
		// try
		// {
		// 	string a = "40dfs";
		// 	int result = int.Parse(a);
		// }
		Console.WriteLine("Proses cek abjad akan dimulai");
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
	// static void Scan()
	// {
	// 	Console.WriteLine("Proses scan akan dimulai");
	// 	Thread.Sleep(5000);
	// 	Console.WriteLine("Scan selesai");
	// }
}