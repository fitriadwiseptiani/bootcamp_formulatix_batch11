// Function 
// hampir sama dengan action tapi digunakan untuk yang ada return type nya

// WITOUT FUNCTION
// public delegate int MyDelegate(int a, int b);
// class Program
// {
// 	static void Main()
// 	{
// 		MyDelegate del = Sub;
// 		del.Invoke(5,8);
// 	}
// 	static int Sub(int x, int y)
// 	{
// 		return (x - y);
// 	}
// }


// WITH FUNCTION

class Program
{
	static void Main()
	{
        Func<int, int, int> del = Sub;
		del.Invoke(5,8);
	}
	static int Sub(int x, int y)
	{
		return (x - y);
	}
}