using overloading;

class Program {
	static void Main() {
		Calc calc = new Calc();
		int a = 1;
		int b = 2;
		int result = calc.Add(a, b);
		Console.WriteLine(result);

		float fa = 1;
		float fb = 2;
		float fresult = calc.Add(a, b);
		Console.WriteLine(fresult);

		string sa = "1";
		string sb = "2";
		string sresult = calc.Add(sa, sb);
		Console.WriteLine(sresult);
	}
}