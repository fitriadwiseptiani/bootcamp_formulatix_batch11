// XMLSerializer

using System.Xml.Serialization;

public class Figure
{
	public string Name{ get; set; }
	public int Age{ get; set; }
	public string Hobby{ get; set; }
	
	// buat constructor
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
		Figure figure = new Figure("Upin", 8, "Play");
		Figure figure2 = new Figure("Ipin", 8, "Eat");
		Figure figure3 = new Figure("Kak Ros", 19, "Mad");
		Figure figure4 = new Figure("Bang Sally", 26, "Sewing");
		
		List<Figure> castFilm = new();
		castFilm.Add(figure);
		castFilm.Add(figure2);
		castFilm.Add(figure3);
		castFilm.Add(figure4);
		
		XmlSerializer serializer = new(typeof(List<Figure>		));
		
		using (FileStream fs = new("./figure.txt", FileMode.Create))
		{
			serializer.Serialize(fs, castFilm);
		}
	}
}