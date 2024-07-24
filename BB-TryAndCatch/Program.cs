// Try And Catch

//Bisa diatasi dengan menggunakan try anda catch
//try dimana kondisi program akan dijalankan, catch akan menangkap kesalahan yang terjadi
//kelemahan : resource yang dibutuhkan terlalu besar
void Main()
{
	Console.WriteLine("Program Start");
	int[]myArray = {1,2,3};
	try
	{
		myArray[4].Dump();
	}
	catch(Exception e)
	{
		Console.WriteLine("Maaf ada kesalahan");
		Console.WriteLine(e.Message);
	}
	
	
	Console.WriteLine("Program Finish");
}
