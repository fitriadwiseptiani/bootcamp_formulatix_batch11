class Program
{
	static void Main()
	{
		Dictionary<int, string> mydictionary = new();
		mydictionary.Add(1, "hello");
		mydictionary.Add(5, "gaes");
		mydictionary.Add(3,"apa kabs");
		
		
		bool status = mydictionary.ContainsKey(1);
		Console.WriteLine(status);
		
		string result;
		bool status2 = mydictionary.TryGetValue(5, out result);
		if (status2)
		{
			Console.WriteLine(status);
		}
	}
}