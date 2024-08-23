// // WITHOUT ACTION
// // harus deklarasi delegate terlebih dahulu

// public delegate void MyDelegate(int x, int y);
// class Program
// {
// 	static void Main()
// 	{
// 		MyDelegate del = Sub;
// 		del.Invoke(5,8);
// 	}
// 	static void Sub(int x, int y)
// 	{
// 		Console.WriteLine(x - y);
// 	}
// }



// WITH ACTION
// tidak perlu deklarasi delegate di awal

class Program
{
	static void Main()
	{
        Action<int, int> del = Sub;
		del.Invoke(5,8);
	}
	static void Sub(int x, int y)
	{
		Console.WriteLine(x - y);
	}
}