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
		
		string result;
		
		using(StreamReader sr = new("./human.json")) 
		{
			result = sr.ReadLine();
		}
		Figure figure = JsonSerializer.Deserialize<Figure>(result);
		Console.WriteLine(figure.Name);
		Console.WriteLine(figure.Age);
		Console.WriteLine(figure.Hobby);
		Console.WriteLine(figure.gender);
	}	
}