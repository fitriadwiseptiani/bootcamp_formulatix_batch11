//pattern matching
class Calculator {
	public object Add(object a, object b) {
		if( a is int c && b is int d) {
			return c + d;
		}
		if( a is string x && b is string y) {
			return x + y;
		}
		return null;
	}
}
class Program {
 	static void Main() {
		int a = 3;
		int b = 2;
		Calculator calc = new();
		int result = (int) calc.Add(3,2);
		Console.WriteLine(result);
		string result2 = (string) calc.Add("string","string");
		Console.WriteLine(result2);
	}
}	
class Car {}