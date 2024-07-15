class Car {
	public int productionNumber = 5;
	public static int count = 5 ;
	public Car() {
		count++;
		productionNumber++;
		// productionNumber = count;
	}
	public int GetNumber() {
		return count;
	}
	public static int GetNumbers() {
		//return productionNumber; //jadi error karena dari static tidak bisa akses ke yang lainnya
		return count;
	}
}
class Program {
	static void Main() {
		Car car = new();
		// Console.WriteLine(car.productionNumber);
		Console.WriteLine(Car.GetNumbers());
		Console.WriteLine(Car.count);
		
		Car car2 = new();
		// Console.WriteLine(car2.productionNumber);
		Console.WriteLine(Car.count);
		
		Car car3 = new();
		// Console.WriteLine(car3.productionNumber);
		Console.WriteLine(Car.count);
	}
}