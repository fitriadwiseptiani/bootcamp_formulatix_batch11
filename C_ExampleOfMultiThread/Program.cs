class Program
{
	static void Main()
	{
		Console.WriteLine("Program akan dijalankan");
		Cat cat= new Cat();
		Dog dog= new Dog();
		
		Thread t1 = new Thread(cat.Eat);			//Contoh 2
		Thread t2 = new Thread(dog.Eat);
		
		t1.Start();
		t2.Start();
		
		t1.Join();
		t2.Join();
		
		Console.WriteLine("Program selesai");
		// cat.Eat();
		// dog.Eat();
	}
}

class Cat
{
	public void Eat()
	{
		Console.WriteLine("Aturan makan kucing");
		Thread.Sleep(5000);
		Console.WriteLine("Kucing akan diberi makan tiap pukul 8");
	}
}
class Dog
{
	public void Eat()
	{
		Console.WriteLine("Aturan makan anjing");
		Thread.Sleep(5000);
		Console.WriteLine("Anjing akan diberi makan tiap pukul 7");
	}
}
class Rabbit
{
	
}