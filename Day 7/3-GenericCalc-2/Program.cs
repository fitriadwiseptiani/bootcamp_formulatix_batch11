// Generic
// Ditandai dengan huru <T> best practice ===> tapi bisa yang lain
// dapat menggantikan berbagai tipe data sehingga tidak perlu membuat kelas secara berulang
using System.Numerics;

class Calculator
{
	// 
	public T Add<T>(T a, T b) where T : IAdditionOperators<T,T,T> //karena hanya menggunakan penjumlahan saja
	{
		return a + b;
	}
	
	public T Substract<T>(T a, T b) where T : ISubtractionOperators<T, T, T>
	{
		return a - b;
	}
	public T Decrement<T>(T a, T b)where T : IDecrementOperators<T>
	
	{
		return a--;
	}
}
class Program
{
	static void Main()
	{
		Calculator calc = new Calculator();
		int add1 = calc.Add<int>(2, 1);
		double add2 = calc.Add<double>(2.0, 4.0);
		float add3 = calc.Add<float>(4.0f, 9.0f);
		decimal add4 = calc.Add<decimal>(7.0M, 2.0M);
		Console.WriteLine("Hasil penjumlahan dengan int adalah " + add1);
		Console.WriteLine("Hasil penjumlahan dengan double adalah " + add2);
		Console.WriteLine("Hasil penjumlahan dengan float adalah " + add3);
		Console.WriteLine("Hasil penjumlahan dengan decimal adalah " + add4);

		Console.WriteLine("#################################################");
		
		// pengurangan
		int pengurangan1 = calc.Substract<int>(5, 1);
		Console.WriteLine("Hasil pengurangan dengan int adalah " + add4);
	
		// pengurangan
		int angka1 = calc.Decrement<int>(5, 1);
		Console.WriteLine("Hasil decrement dengan int adalah " + add4);
	}
}