// Generic
// Ditandai dengan huru <T> best practice ===> tapi bisa yang lain
// dapat menggantikan berbagai tipe data sehingga tidak perlu membuat kelas secara berulang
using System.Numerics;

class Calculator<T> where T : INumber<T>
{
	public T Add(T a, T b)
	{
		return a + b;
	}
}
class Program
{
	static void Main()
	{
		Calculator<int> calc = new Calculator<int>();
		calc.Add(2, 1);
		Calculator<double> calc2 = new Calculator<double>();
		calc2.Add(2.0, 4.0);
		Calculator<float> calc3 = new Calculator<float>();
		calc3.Add(4.0f, 9.0f);
		Calculator<decimal> calc4 = new Calculator<decimal>();
		calc4.Add(7.0M, 2.0M);
		
		
		
	}
}