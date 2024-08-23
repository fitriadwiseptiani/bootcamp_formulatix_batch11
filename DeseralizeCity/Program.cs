using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.IO;

// digunakan ketika ada variable atau property yang access modifier selain public
public class ListOfCity
{
	public int Id { get; set; }
	public string Name{ get; set; }
	public int Price{ get; set; }
	public int RentPrice{get; set;}
	public ListOfCity(int id, string name, int price, int rentPrice)
	{
		Id = id;
		Name = name;
		Price = price;
		RentPrice = rentPrice;
	}
	public ListOfCity()
	{
		
	}
	
}
class Program
{
	static void Main()
	{
		string result;
		
		using(StreamReader sr = new("./City.json")) 
		{
			result = sr.ReadToEnd();
		}
		List<ListOfCity> cityMonopoly = JsonSerializer.Deserialize<List<ListOfCity>>(result);
		foreach(var i in cityMonopoly)
		{
			Console.WriteLine(i.Id);
			Console.WriteLine(i.Name);
			Console.WriteLine(i.Price);
			Console.WriteLine(i.RentPrice);
		} 
		
	}	
}