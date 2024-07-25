class Program
{
	static void Main()
	{
		MyMethod();
	}
	static void MyMethod()
	{
		FileStream fs = new();
		AnotherMethod(fs);
		fs.Dispose();
	}
	static void AnotherMethod(FileStream fs)
	{
		
	}
}

//tidak bisa release unmanaged resource, karena belum tahu kondisi yang ada di method AnotherMethod