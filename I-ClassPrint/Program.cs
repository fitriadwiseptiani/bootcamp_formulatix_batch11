class Program
{
	static void Main()
	{
		Car car = new Car();;
		car.name = "tesla";
		// Console.WriteLine(car.name); //bila dieksekusi ini maka outputnya akan tesla
		Console.WriteLine(car); //bila dieksekusi ini maka output adalah Car
	}
}
class Car
{
	public string name;

    public override string ToString()
    {
        return name;
    }

}

// output bisa Car karena sebenarnya object itu sudah menyimpan dirinya sendiri dalam bentuk ToString()
// semua object merupakan child dari sebuah parent ultimate base
// apabila ingin tetap memunculkan output berupa tesla maka bisa di override dengan mengembalikan variabelnya.. ==> virtual atau bapaknya dari ultimate base