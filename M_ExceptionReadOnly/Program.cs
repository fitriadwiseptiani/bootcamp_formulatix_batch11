class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		Thread t1 = new Thread(Execution);		
		
		t1.Start();
		
		t1.Join();
		Console.WriteLine("Program Finished");
	}
	static void CheckMethod()
	{
		throw new NullReferenceException();
	}
	static void Execution()
	{
		try
		{
			CheckMethod();
		}
		catch(Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
}