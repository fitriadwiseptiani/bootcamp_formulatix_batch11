// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

class Airconditioner

{
	public Airconditioner(Kompresor kompresor, Kondensor kondensor)
	{
		this.kompresor = kompresor;
		this.kondensor = kondensor;
	}
	public Kompresor kompresor;
	public Kondensor kondensor;
}

class Kompresor

{
	public string jenis;
	public string brand;
	public void Start()
	
	{
		Console.WriteLine("Start " + brand + " engine");
	}
	
}
class Kondensor
{
	public string media;
	public string aliran;
	public string desain;
}

class Evaporator

{
	public string jenis;
}

class Blower

{
	public string jenis;
}

class Freon

{
	public string jenis;
}

class Program

{
	static void Main(string[] args)
	
	{
		Kompresor kompresor = new Kompresor();
		kompresor.jenis = "scroll";
		kompresor.brand = "panasonic";
		
		Kondensor kondensor = new Kondensor();
		kondensor.media = "udara";
		kondensor.aliran = "single";
		kondensor.desain = "seri";
		
		Evaporator evaporator = new Evaporator();
		evaporator.jenis = "serpentine";
		// airconditioner.evaporator = evaporator; 
		
		Blower blower= new Blower();
		blower.jenis= "double";
		
		Freon freon= new Freon();
		freon.jenis= "R12";
		
		Airconditioner airconditioner = new Airconditioner(kompresor, kondensor);
		airconditioner.kompresor = kompresor;
		airconditioner.kondensor = kondensor;		
		
		Console.WriteLine("AC ini memiliki kompresor dengan jenis " + airconditioner.kompresor.jenis + " dan berasal dari brand " + airconditioner.kompresor.brand);
		Console.WriteLine("Selain itu, AC ini memiliki keunggulan karena menggunakan kondensor berupa media " + airconditioner.kondensor.media + " yang memiliki aliran " + airconditioner.kondensor.aliran + " dengan desain " + airconditioner.kondensor.desain + " pada pembuatannya");
		// Console.WriteLine("AC ini juga mempunyai komposisi yang sangat baik dengan evaporator jenis " + airconditioner.evaporator.jenis);
		Console.ReadLine();
	}
}
