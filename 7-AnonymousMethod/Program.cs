// Anonymous Method
// digunakan ketika menggunakan method yang singkat
// class Program 
// {
// 	static void Main()
// 	{
// 		var multiply = (int a, int b) => a * b;
// 		int result = multiply(4,5);
// 		Console.WriteLine(result);
// 	}
// }
// tidak perlu membuat kelas ini
// class Multiply
// {
// 	public int Mul(int a, int b)
// 	{
// 		return a+b;
// 	}
// }

// class Program
// {
// 	static void Main(string[] args)
// 	{
// 		Action<string> sms = (string pesan) => Console.WriteLine(pesan);
// 		sms("Tolong buka pintu");
// 	}
// }
// class Printer
// {
// 	public void Message(string pesan)
// 	{
// 		Console.WriteLine(pesan);
// 	}
// }


// class Program {
// 	static void Main() {
// 		Func<int> printer = () => 3;
// 		printer().Dump();
// 	}
// }
// //class Printer {
// //	public int Print() {
// //		return 3;
// //	}
// //}

class Program {
	static void Main() {
		var print = () => Console.WriteLine(3);
		print();
	}
}
//class Printer {
//	public void Print() {
//		Console.WriteLine(3);
//	}
//}