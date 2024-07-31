// XMLSerializer

using System.Xml.Serialization;
﻿using System.IO;
using System.Text;
using System.Text.Json;

public class Figure
{
	public string Name{ get; set; }
	public int Age{ get; set; }
	public string Hobby{ get; set; }
	
	public Gender gender{ get; set; }
	
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
		Figure figure = new Figure();
		figure.Name = "Upin";
		figure.Age = 9;
		figure.Hobby = "Play";
		figure.gender = Figure.Gender.Cowo;
		
		string result = JsonSerializer.Serialize(figure);
		Console.WriteLine(result);
		
		using(FileStream fs = new("./human.json",FileMode.OpenOrCreate)) 
		{
			byte[] bytes = Encoding.UTF8.GetBytes(result);
			fs.Write(bytes, 0, bytes.Length);
		}
		using(StreamWriter sw = new("./humansw.json")) 
		{
			sw.WriteLine(result);
		}
	}	
}