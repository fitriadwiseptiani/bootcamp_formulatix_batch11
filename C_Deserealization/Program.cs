// XMLSerializer

using System.Xml.Serialization;

public class Human
{
	public string Name{ get; set; }
	public int Age{ get; set; }
	public string Hobby{ get; set; }
}
class Program
{
	static void Main()
	{
		Human human = new Human();
		human.Name = "Upin";
		human.Age = 8;
		human.Hobby = "Play";
		
		XmlSerializer serializer = new(typeof(Human));
		
		// filemode open
		using (FileStream fs = new("./human.txt", FileMode.Open))
		{
			// jangan lupa panggil objectnya
			human = (Human)serializer.Deserialize(fs);
		}
		Console.WriteLine(human.Name);
		Console.WriteLine(human.Age);
		Console.WriteLine(human.Hobby);
	}
}