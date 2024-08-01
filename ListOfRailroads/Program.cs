using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;

// digunakan ketika ada variable atau property yang access modifier selain public
public class ListOfRailroads
{
	public int Id { get; set; }
	public string Name{ get; set; }
	public int Price{ get; set; }
	public int RentPrice{get; set;}
	public ListOfRailroads(int id, string name, int price, int rentPrice)
	{
		Id = id;
		Name = name;
		Price = price;
		RentPrice = rentPrice;
	}
}
class Program
{
	static void Main()
	{
		ListOfRailroads railroads = new ListOfRailroads(6, "TLV Airport", 200, 25);
		ListOfRailroads railroads2 = new ListOfRailroads(16, "MUC Airport", 200, 25);
		ListOfRailroads railroads3 = new ListOfRailroads(26, "CDG Airport", 200, 25);
		ListOfRailroads railroads4 = new ListOfRailroads(36, "JFK Airport", 200, 25);
		
		List<ListOfRailroads> railroadsMonopoly = new();
		railroadsMonopoly.Add(railroads);
		railroadsMonopoly.Add(railroads2);
		railroadsMonopoly.Add(railroads3);
		railroadsMonopoly.Add(railroads4);
		
		string result = JsonSerializer.Serialize(railroadsMonopoly);
		
		// Write
		using (FileStream fs = new("./Railroads.json", FileMode.Create))
		{
			byte[] bytes = Encoding.UTF8.GetBytes(result);
			fs.Write(bytes, 0, bytes.Length);
		}
		
		// // //Read
		// // List<ListOfCity> cityMonopoly2;
		// using (FileStream fs = new("./Railroads.json", FileMode.Create))
		// {
		// 	byte[] bytes = Encoding.UTF8.GetBytes(result);
		// 	fs.Write(bytes, 0, bytes.Length);
		// }
	}
}