class MyDestructor
{
	public MyDestructor ()
	{
		Console.WriteLine($"Program {GC.GetGeneration(this)} telah dibuat");
	}
	~MyDestructor ()
	{
		Console.WriteLine($"Program {GC.GetGeneration(this)} telah dihancurkan");
	}
	
}
class Program
{
	static void Main()
	{
		InstanceCreator();
		GC.Collect();
		// GC.Collect();
	}
	static void InstanceCreator()
	{
		MyDestructor myDestructor = new();
	}
}