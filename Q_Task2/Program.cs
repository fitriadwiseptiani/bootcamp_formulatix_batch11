class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		Task t1 = Task.Run(() => CheckArray());		//biar tidak usah memmanggil start lagi
		Task t2 = Task.Run(() => CheckAbjad());
		
		// Task.WaitAll(t1, t2);	//program akan brhenti ketika jika semua proses sudah selesai
		Task.WaitAny(t1);	//program akan selesai bila proses yang dimaksud sudah dijalankan
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