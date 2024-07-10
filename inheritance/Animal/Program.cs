class Animal
{
	public string name;
	public int age;
	public string race;
	public string gender;
	
	public void Eat()
	{
		Console.WriteLine("Eat");
	}
	public void Poop(){}
	
	public Animal (string name, int age, string race, string gender)
	{
		this.name = name;
		this.age = age;
		this.race = race;
		this.gender = gender;
	}
}

class Cat : Animal
{
	public string moustache;
	public void Play(){}
	public void Meow(){}
	
	public Cat (string name, int age, string race, string gender, string moustache) : base (name, age, race, gender)
	{
		this.moustache = moustache;
	}
}
class Program 
{
	static void Main (string[] args)
	{
		Cat cat= new Cat("Poky", 2, "Anggora", "cewek", "tebal");
		Console.WriteLine(cat.name);
	}
}