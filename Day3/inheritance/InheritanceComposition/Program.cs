
class AirConditioner

{
	public Kondensor kondensor;
	public AirConditioner(Kondensor kondensor)
	{
		this.kondensor = kondensor;
	}
	
}
class Kondensor
{
	public string jenis;
}
class Kompresor : Kondensor 
{
	
}
// class Blower : Kondensor
// {
	
// }

class Program
{
	static void Main()
	{
		Kondensor kondensor = new Kondensor();
		AirConditioner airConditioner = new AirConditioner(kondensor);
		
		Kompresor kompresor= new Kompresor();
		AirConditioner airConditioner2 = new AirConditioner(kompresor);
	}
	
}