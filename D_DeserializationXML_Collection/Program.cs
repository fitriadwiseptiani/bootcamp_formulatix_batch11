// XMLSerializer

using System.Xml.Serialization;

public class Figure
{
	public string Name{ get; set; }
	public int Age{ get; set; }
	public string Hobby{ get; set; }
	
	// buat constructor
	public Figure(string name, int age, string hobby)
	{
		Name = name;
		Age = age;
		Hobby = hobby;
	}
	// buat constructor parameterless agar mempermudah ketika proses deserialisasi
	public Figure(){}
}
class Program
{
	static void Main()
	{
		List<Figure> castFilm = new();
		
		XmlSerializer serializer = new(typeof(List<Figure>));
		
		using (FileStream fs = new("./figure.txt", FileMode.Open))
		{
			castFilm = (List<Figure>)serializer.Deserialize(fs);
		}
		foreach(var i in castFilm) 
		{
			Console.WriteLine(i.Name);
			Console.WriteLine(i.Age);
			Console.WriteLine(i.Hobby);
		}
	}
}