// Human + Human = new Human

class Program
{
	static void Main(string[] args)
	{
		Human human = new Human();
		Human human2 = new Human();
		Human result = human2 + human;		//harus dibuat suatu method yang berisi overloading agar bisa menambahkan sesama object
		Console.WriteLine(result.namaAnak1);		
		
	}
}
class Human
{
	public int gaji = 10_000_000;
	public string namaAnak1 = "Bawang ";
	public string namaAnak2 = "Merah";

	public static Human operator+(Human x, Human y)
	{
		string namaLengkap = x.namaAnak1 + y.namaAnak2;
		Human human= new Human();
		human.namaAnak1 = namaLengkap;
		human.namaAnak2 = namaLengkap;
		return human;
	}
	
	
}
