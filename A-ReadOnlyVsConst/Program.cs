class Car{
	//Int biasa bisa dideklarasikan di awal atau pada program
	public int price = 6;
	public readonly int price2; //hanya Read tapi bisa changeable lewat constructor
	
	//Contoh const yang hanya bisa diassigned sebelum program di build
	public const int price3 = 6;
	
	//Readonly 
	//public Car(int price2){
	//	this.price = price;
	//}
}
class Program
{
	static void Main()
	{
		
		//Car car = new();
		////Contoh int biasa
		////Bisa diubah untuk nilainya
		//car.price = 10;
		////Bisa Read untuk nilainya
		//car.price.Dump();
		
		//Contoh int readonly
		//Car car2 = new(129);
		//car2.price2.Dump();
		
		//Contoh const
		//Langsung dipanggil Classnya karena kalau dipanggil dari object dia akan error
		Console.WriteLine(Car.price3);
		
	}
}