class Calculator{
	public int Add(int a, int b){
		return a + b;
	}
	public string Add(int c, int d){
		return (c+d).ToString();
	}
}
class Program{
	static void main(){
		Calculator clc = new Calculator();
		int c = 5;
		int d = 10;
		int result = clc.Add(c, d);
		Console.WriteLine(result);
	}
}