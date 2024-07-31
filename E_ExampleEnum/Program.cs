// XMLSerializer

using System.Xml.Serialization;

public class Figure
{
	public string Name{ get; set; }
	public int Age{ get; set; }
	public string Hobby{ get; set; }
	
	public Gender gender{ get; set; }
	
	// buat constructor
	public Figure(string name, int age, string hobby, Gender gender)
	{
		Name = name;
		Age = age;
		Hobby = hobby;
	}
	
	public enum Gender
	{
		Cowo,
		Cewe,
		Fiftyfifty
	}
	// buat constructor parameterless agar mempermudah ketika proses deserialisasi
	public Figure(){}
	
	
}
class Program
{
	static void Main()
	{
		Figure figure = new Figure("Upin", 8, "Play", Figure.Gender.Cowo);
		Figure figure2 = new Figure("Ipin", 8, "Eat", Figure.Gender.Cowo);
		Figure figure3 = new Figure("Kak Ros", 19, "Mad", Figure.Gender.Cewe);
		Figure figure4 = new Figure("Bang Sally", 26, "Sewing", Figure.Gender.Fiftyfifty);
		
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