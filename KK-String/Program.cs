//String
using System.Diagnostics;
class Program {
	static void Main() {
		int iteration = 100_000;
		string a = "Hello";
		for (int i = 0; i < iteration; i++)
		{
			a += " World";
			a += " ! ! !";
			a.Replace('o','i');
			Thread.Sleep(2); //seluruh komponen pada program dihentikan
		}
	}
}