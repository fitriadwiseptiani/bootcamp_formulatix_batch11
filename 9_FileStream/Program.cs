class Program 
{
	static void Main() 
	{
		string path = @".\Fileku.txt";
		using (FileStream fs = new(path,FileMode.OpenOrCreate)) 
		{
			Console.WriteLine("File baru dibuat");
		}	
	}
}