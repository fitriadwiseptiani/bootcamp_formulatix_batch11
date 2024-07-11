// // Solution
// class Component
// {
// 	public string brand;
// 	public Component (string brand)
// 	{
// 		this.brand = brand;
// 	}
// }
// class Bell : Component 
// {
// 	public int size;
// 	public Bell(string brand, int size) : base(brand)
// 	{
// 		this.size = size;
// 	}
// }
// class Program{
// 	static void Main ()
// 	{
// 		Bell bell= new Bell("yamaha", 04);
// 		Console.WriteLine();
// 	}
// }

// versi lain
// Solution
class Component
{
	public string brand;
	public Component (string brand)
	{
		this.brand = brand;
	}
	public Component(){}
}
class Bell : Component 
{
	public int size;
	public Bell(int size) : base("misal")
	{
		this.size = size;
	}
}
class Program{
	static void Main ()
	{
		Bell bell= new Bell("yamaha", 04);
		Console.WriteLine(bell.brand);
	}
}