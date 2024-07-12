// String merupakan class akan tetapi bersifat immutable (tidak bisa diubah) jadi tetap memiliki alokasi penyimpanan baru bila dilakukan perubahan pada datanya
class Program
{
	static void Main()
	{
		String kata1 = "Hallo ";
		String kata2 = kata1;
		
		kata2 += "Adiks "; //jika C.W jadi Hallo Adiks
		Console.WriteLine(kata2);
		
		kata2 += "Lala"; //jika C.W jadi Hallo Adiks Lala
		Console.WriteLine(kata2);
	}
}