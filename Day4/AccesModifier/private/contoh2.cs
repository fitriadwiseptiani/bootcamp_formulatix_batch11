//Private Naming Convention
public class Car {
	//pada penulisan private bisa menggunakan _ sebelum variabel
	private int _price;
	public Car(int price) {
		_price = price;
	}
}
class Program {
	static void Main() {
		Car car = new Car(2000);
	}
}