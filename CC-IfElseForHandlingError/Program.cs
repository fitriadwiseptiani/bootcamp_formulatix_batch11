//Untuk mengatasi kesalahan tanpa menggunakan resource yang besar

void Main()
{
	Console.WriteLine("Program Start");
	GetValue valuedata = new();
	int[] myArray = valuedata.Value();
	if(!(myArray == null))
	{
		Console.WriteLine(myArray[4]);
	}
	
	Console.WriteLine("Program Finish");
}

class GetValue
{
	public int[] Value(){
		return null;
	}
}