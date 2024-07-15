//String
using System.Diagnostics;
class Program {
	static void Main() {
		Stopwatch sw = new Stopwatch();
		int iteration = 12;
		sw.Start();
		string a = "Hello";
		for (int i = 0; i < iteration; i++)
		{
			Console.WriteLine(a);
			a += " World";
			a += " ! ! !";
			a.Replace('o','i');
		}
		sw.Stop();
		// Console.WriteLine(a);
		Console.WriteLine(sw.ElapsedMilliseconds);
	}
}