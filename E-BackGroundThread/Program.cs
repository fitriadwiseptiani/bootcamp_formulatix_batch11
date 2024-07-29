class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		
		Thread t1 = new Thread(Print);		
		Thread t2 = new Thread(Fax);
		Thread t3 = new Thread(Scan);
		
		t1.IsBackground = true;
		t2.IsBackground = true;
		t3.IsBackground = true;
		
		t1.Start();
		t2.Start();
		t3.Start();

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


// digunakan apabila ingin memberhentikan program sebelum proses thread selesai