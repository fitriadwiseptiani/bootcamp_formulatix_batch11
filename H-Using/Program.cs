class Program 
{
	static void Main()
	{
		MyMethod();
	}
	static void MyMethod()
	{
		string path = "./file.txt";
		using(FileStream fs = new(path, FileMode.Create)) 
		{
			//....Process
		} // } <----- Dispose happened
	}
	static void AnotherMethod(FileStream fs)
	{
		
	}
}


//using penggunaannya sama dengan try dan finally dan sebelum akhir curly braket otomatis sudah di Dispose()