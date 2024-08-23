class A
{
	~A()
	{
		Console.WriteLine("A dihancurkan");
	}
}
class B : A
{
	~B()
	{
		Console.WriteLine("B dihancurkan");
	}
}
class C : B
{
	~C()
	{
		Console.WriteLine("C dihancurkan");
	}
}

class Program
{
	static void Main(string[] args)
	{
		InstanceCreator();
		GC.Collect();
		GC.WaitForPendingFinalizers();
	}
	static void InstanceCreator()
	{
		C c = new();
	}
}