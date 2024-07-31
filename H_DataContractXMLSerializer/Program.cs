// XMLSerializer

using System.Runtime.Serialization;

// digunakan ketika ada variable atau property yang access modifier selain public
[DataContract]
public class Figure
{
	private string _name{ get; set; }
	public int _age{ get; set; }
	
	public Gender gender{ get; set; }
	private string _hobby{ get; set; }
	public Figure(string name, int age,Gender gender, string hobby)
	{
		_name = name;
		_age = age;
		gender = gender;
		_hobby = hobby;
	}
	public enum Gender
	{
		Cowo,
		Cewe,
		Fiftyfifty
	}
}
class Program
{
	static void Main()
	{
		Figure figure = new Figure("Bang Salli", 27, Figure.Gender.Fiftyfifty, "Sewing");
		
		DataContractSerializer dataContract = new(typeof(Figure));
		
		// Write
		using (FileStream fs = new("./castFilm.xml", FileMode.Create))
		{
			dataContract.WriteObject(fs, figure);
		}
		
		// Read
		
	}	
}