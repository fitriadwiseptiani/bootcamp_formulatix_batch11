class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		Thread t1 = new Thread(() => 
		{
			try
			{
				CheckMethod();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		});		
		
		t1.Start();
		t1.Join();
		Console.WriteLine("Program Finished");
	}
	static void CheckMethod()
	{
		throw new NullReferenceException();
	}
}