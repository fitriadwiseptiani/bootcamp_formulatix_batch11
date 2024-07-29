class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		Task t1 = new Task(() => CheckArray(2));		//biar tidak usah memmanggil start lagi
		// Task t2 = Task.Run(() => CheckAbjad());
		t1.Start();
		Console.WriteLine("Program Finished");
	}
	static void CheckArray(int angka)
	{
		Console.WriteLine("Proses cek array akan dimulai");
		Thread.Sleep(5000);
		int[]myArray = {1,2,3,4,5,6};
		try
		{
			Console.WriteLine(myArray[2] + " dan juga angka " + angka);
		}
		catch(Exception e)
		{
			Console.WriteLine("Maaf ada kesalahan");
			Console.WriteLine(e.Message);
		}
	}
		
	}