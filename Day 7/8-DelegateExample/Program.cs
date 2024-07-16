public delegate void MyZoo();

class Program
{
	static void Main(string[] args)
	{
		Monkey monkey= new Monkey();
		// dipanggil class dengan method yang ingin ditampilkan
		MyZoo zoo = monkey.MakeSound;
		zoo = monkey.Eat;
		zoo();
	}
}
class Animal
{
	public virtual void MakeSound()
	
	{
		
	}
}
class Monkey : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("uuuuuuuuuuuaaaaauuuu akulah dewa monyet");
	}
	public void Eat()
	{
		Console.WriteLine("Aku suka makan pisangg");
	}
}
