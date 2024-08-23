//String
using System.Text;
class Program {
	static void Main() {
		int iteration = 100_000;
		StringBuilder a = new("Hello");
		for (int i = 0; i < iteration; i++)
		{
			a.Append(" World");
			a.Append(" ! ! !");
			a.Replace('o','i');
			Thread.Sleep(2); //seluruh komponen pada program dihentikan
		}
	}
}