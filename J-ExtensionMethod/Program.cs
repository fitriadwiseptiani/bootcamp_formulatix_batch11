// class Program
// {
// 	static void Main()
// 	{
// 		string a = "Hello";
// 		a.Cetak();  //tidak bisa dijalankan karena tidak ada method dari kelas tersebut yang dipanggil
// 	}
// }

class Program
{
	static void Main()
	{
		string a = "Hello everybody";
		a.Tampilkan();
		int ax = 0;
		ax.Tampilkan();
		double[] myDouble = {3.0, 4.0, 9.0};
		myDouble.Tampilkan();
	}
}
public static class MyExtensions
{
	public static void Tampilkan(this object value)
	{
		Console.WriteLine(value);
	}
}

// ditambahkan extension untuk membuat method yang sesuai dengan yang dibutuhkan