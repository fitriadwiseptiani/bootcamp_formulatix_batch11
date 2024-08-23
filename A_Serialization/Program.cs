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
		
		// Human human2 = new Human();
		// human2.Name = "Ipin";
		// human2.Age = 8;
		// human2.Hobby = "Eat";
		
		XmlSerializer serializer = new(typeof(Human));
		
		using (FileStream fs = new("./human.txt", FileMode.Create))
		{
			serializer.Serialize(fs, human);
		}
	}
}