class Program
{
	static async Task Main()
	{
		Console.WriteLine("Program Starting");
		Task<int> t1 = Task.Run(() => Add(3,19));
		Task<int> t2 = Task.Run(() => CheckArray(2));
		
		await Task.WhenAll(t1, t2);
		Console.WriteLine(t1.Result);
		Console.WriteLine("Program Finished");
	}
	static async Task<int> CheckArray(int angka)
	{
		Console.WriteLine("Proses cek array akan dimulai");
		Thread.Sleep(5000);
		int[]myArray = {1,2,3,4,5,6};
		try
		{
			await Task.Delay(1000);
			Console.WriteLine("Nilai array adalah " + myArray[2] + " dan terdapat tambahan input angka " + angka);
		}
		catch(Exception e)
		{
			Console.WriteLine("Maaf ada kesalahan");
			Console.WriteLine(e.Message);
		}
		return myArray[0];
	}
	static async Task<int> Add(int myArray, int angka) 
	{
		return myArray + angka;
	}
}