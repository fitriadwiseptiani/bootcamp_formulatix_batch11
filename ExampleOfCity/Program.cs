// // XMLSerializer

// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Json;

// // digunakan ketika ada variable atau property yang access modifier selain public
// [DataContract]
// public class ListOfCity
// {
// 	[DataMember]
// 	private int _id { get; set; }
// 	[DataMember]
// 	private string _name{ get; set; }
// 	[DataMember]
// 	private int _price{ get; set; }
// 	[DataMember]
// 	private int _rentPrice{get; set;}
// 	public ListOfCity(int id, string name, int price, int rentPrice)
// 	{
// 		_id = id;
// 		_name = name;
// 		_price = price;
// 		_rentPrice = rentPrice;
// 	}
// 	public int GetId() => _id;
// 	public string GetName() => _name;
// 	public int GetPrice() => _price;
// 	public int GetrentPrice() => _rentPrice;
	
// }
// class Program
// {
// 	static void Main()
// 	{
// 		ListOfCity city = new ListOfCity(2, "Salvador", 60, 2);
// 		ListOfCity city2 = new ListOfCity(4, "Rio", 60, 4);
		
// 		List<ListOfCity> cityMonopoly = new();
// 		cityMonopoly.Add(city);
// 		cityMonopoly.Add(city2);
		
// 		DataContractSerializer dataContract = new(typeof(List<ListOfCity>));
		
// 		// Write
// 		using (FileStream fs = new("./City.json", FileMode.Create))
// 		{
// 			dataContract.WriteObject(fs, cityMonopoly);
// 		}
		
// 		//Read
// 		List<ListOfCity> cityMonopoly2;
// 		using (FileStream fs = new("./City.json", FileMode.Open))
// 		{
// 			cityMonopoly2 = (List<ListOfCity>)dataContract.ReadObject(fs);
// 		}
// 		Console.WriteLine(city.GetId());
// 		Console.WriteLine(city.GetName());
// 		Console.WriteLine(city.GetPrice());
// 		Console.WriteLine(city.GetrentPrice());
		
		
// 	}	
// }

// XMLSerializer

using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

// digunakan ketika ada variable atau property yang access modifier selain public
[DataContract]
public class ListOfCity
{
	[DataMember]
	private int _id { get; set; }
	[DataMember]
	private string _name{ get; set; }
	[DataMember]
	private int _price{ get; set; }
	[DataMember]
	private int _rentPrice{get; set;}
	public ListOfCity(int id, string name, int price, int rentPrice)
	{
		_id = id;
		_name = name;
		_price = price;
		_rentPrice = rentPrice;
	}
	public int GetId() => _id;
	public string GetName() => _name;
	public int GetPrice() => _price;
	public int GetrentPrice() => _rentPrice;
	
}
class Program
{
	static void Main()
	{
		ListOfCity city = new ListOfCity(2, "Salvador", 60, 2);
		ListOfCity city2 = new ListOfCity(4, "Rio", 60, 4);
		ListOfCity city3 = new ListOfCity(7, "Tel Aviv", 100, 6);
		ListOfCity city4 = new ListOfCity(9, "Haifa", 100, 6);
		ListOfCity city5 = new ListOfCity(10, "Jerusalem", 120, 8);
		ListOfCity city6 = new ListOfCity(12, "Venice", 140, 10);
		ListOfCity city7 = new ListOfCity(14, "Milan", 140, 10);
		ListOfCity city8 = new ListOfCity(15, "Rome", 160, 12);
		ListOfCity city9 = new ListOfCity(17, "Frankfurt", 180, 14);
		ListOfCity city10 = new ListOfCity(19, "Munich", 180, 14);
		ListOfCity city11 = new ListOfCity(20, "Berlin", 200, 16);
		ListOfCity city12 = new ListOfCity(22, "Shenzhen", 220, 18);
		ListOfCity city13 = new ListOfCity(24, "Beijing", 220, 18);
		ListOfCity city14 = new ListOfCity(25, "Shanghai", 240, 20);
		ListOfCity city15 = new ListOfCity(27, "Lyon", 260, 22);
		ListOfCity city16 = new ListOfCity(28, "Toulouse", 260, 22);
		ListOfCity city17 = new ListOfCity(30, "Paris", 280, 24);
		ListOfCity city18 = new ListOfCity(32, "Liverpool", 300, 26);
		ListOfCity city19 = new ListOfCity(33, "Manchester", 300, 26);
		ListOfCity city20 = new ListOfCity(35, "London", 320, 28);
		ListOfCity city21 = new ListOfCity(38, "San Francisco", 350, 35);
		ListOfCity city22 = new ListOfCity(40, "New York", 400, 50);
		
		List<ListOfCity> cityMonopoly = new();
		cityMonopoly.Add(city);
		cityMonopoly.Add(city2);
		cityMonopoly.Add(city3);
		cityMonopoly.Add(city4);
		cityMonopoly.Add(city5);
		cityMonopoly.Add(city6);
		cityMonopoly.Add(city7);
		cityMonopoly.Add(city8);
		cityMonopoly.Add(city9);
		cityMonopoly.Add(city10);
		cityMonopoly.Add(city11);
		cityMonopoly.Add(city12);
		cityMonopoly.Add(city13);
		cityMonopoly.Add(city14);
		cityMonopoly.Add(city15);
		cityMonopoly.Add(city16);
		cityMonopoly.Add(city15);
		cityMonopoly.Add(city16);
		cityMonopoly.Add(city17);
		cityMonopoly.Add(city18);
		cityMonopoly.Add(city19);
		cityMonopoly.Add(city20);
		cityMonopoly.Add(city21);
		cityMonopoly.Add(city22);
		
		
		
		DataContractJsonSerializer dataContract = new(typeof(List<ListOfCity>));
		
		// Write
		using (FileStream fs = new("./City.json", FileMode.Create))
		{
			dataContract.WriteObject(fs, cityMonopoly);
		}
		
		//Read
		List<ListOfCity> cityMonopoly2;
		using (FileStream fs = new("./City.json", FileMode.Open))
		{
			cityMonopoly2 = (List<ListOfCity>)dataContract.ReadObject(fs);
		}
		Console.WriteLine(city.GetId());
		Console.WriteLine(city.GetName());
		Console.WriteLine(city.GetPrice());
		Console.WriteLine(city.GetrentPrice());
		
		
	}	
}