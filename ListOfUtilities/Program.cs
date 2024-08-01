// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Json;

// // digunakan ketika ada variable atau property yang access modifier selain public
// [DataContract]
// public class ListOfUtilities
// {
// 	[DataMember]
// 	private int _id { get; set; }
// 	[DataMember]
// 	private string _name{ get; set; }
// 	[DataMember]
// 	private int _price{ get; set; }
// 	[DataMember]
// 	private int _rentPrice{get; set;}
// 	public ListOfUtilities(int id, string name, int price, int rentPrice)
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
// 		ListOfUtilities utilities = new ListOfUtilities(13, "Electric Company", 150, 5);
// 		ListOfUtilities utilities2 = new ListOfUtilities(29, "Water Company", 150, 5);
		
// 		List<ListOfUtilities> utilitiesMonopoly = new();
// 		utilitiesMonopoly.Add(utilities);
// 		utilitiesMonopoly.Add(utilities2);
		
// 		DataContractJsonSerializer dataContract = new(typeof(List<ListOfUtilities>));
		
// 		// Write
// 		using (FileStream fs = new("./utilities.json", FileMode.Create))
// 		{
// 			dataContract.WriteObject(fs, utilitiesMonopoly);
// 		}
		
// 		//Read
// 		List<ListOfUtilities> utilitiesMonopoly2;
// 		using (FileStream fs = new("./utilities.json", FileMode.Open))
// 		{
// 			utilitiesMonopoly2 = (List<ListOfUtilities>)dataContract.ReadObject(fs);
// 		}
// 		Console.WriteLine(utilities.GetId());
// 		Console.WriteLine(utilities.GetName());
// 		Console.WriteLine(utilities.GetPrice());
// 		Console.WriteLine(utilities.GetrentPrice());
		
		
// 	}	
// }


﻿using System.IO;
using System.Text;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

// digunakan ketika ada variable atau property yang access modifier selain public

public class ListOfUtilities
{
	public int Id { get; set; }
	public string Name{ get; set; }
	public int Price{ get; set; }
	public int RentPrice{get; set;}
	public ListOfUtilities(int id, string name, int price, int rentPrice)
	{
		Id = id;
		Name = name;
		Price = price;
		RentPrice = rentPrice;
	}
	public ListOfUtilities(){}
	
}
class Program
{
	static void Main()
	{
		ListOfUtilities utilities = new ListOfUtilities(13, "Electric Company", 150, 5);
		ListOfUtilities utilities2 = new ListOfUtilities(29, "Water Company", 150, 5);
		
		List<ListOfUtilities> utilitiesMonopoly = new();
		utilitiesMonopoly.Add(utilities);
		utilitiesMonopoly.Add(utilities2);	
		
		string result = JsonSerializer.Serialize(utilitiesMonopoly);
		
		// Write
		using (FileStream fs = new("./Utilities.json", FileMode.Create))
		{
			byte[] bytes = Encoding.UTF8.GetBytes(result);
			fs.Write(bytes, 0, bytes.Length);
		}
		
		// // //Read
		// // List<ListOfCity> cityMonopoly2;
		// using (FileStream fs = new("./Utilities.json", FileMode.Create))
		// {
		// 	byte[] bytes = Encoding.UTF8.GetBytes(result);
		// 	fs.Write(bytes, 0, bytes.Length);
		// }
		// Console.WriteLine(city.GetId());
		// Console.WriteLine(city.GetName());
		// Console.WriteLine(city.GetPrice());
		// Console.WriteLine(city.GetrentPrice());
		
		
	}	
}