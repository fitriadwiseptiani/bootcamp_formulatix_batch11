class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		Print();
		Fax();
		Scan();
		Console.WriteLine("Program Finished");
	}
	static void Print()
	{
		Console.WriteLine("Proses print akan dimulai");
		Thread.Sleep(10000);
		Console.WriteLine("Print selesai");
	}
	static void Fax()
	{
		Console.WriteLine("Proses pengiriman fax akan dimulai");
		Thread.Sleep(15000);
		Console.WriteLine("Fax selesai dikirimkan");
	}
	static void Scan()
	{
		Console.WriteLine("Proses scan akan dimulai");
		Thread.Sleep(5000);
		Console.WriteLine("Scan selesai");
	}
}

// program di atas tidak menggunakan thread yang mengakibatkan harus memakan waktu yang lama dalam menjalankannya
// program menjalankan perintah dari baris teratas dan diselesaikan satu persatu"