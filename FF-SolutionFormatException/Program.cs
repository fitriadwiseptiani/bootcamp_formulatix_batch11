//Solusi untuk Format Exception

void Main()
{
	string myString = "90jtg2";
	bool status = int.TryParse(myString, out int value);
	if (status)
	{
		Console.WriteLine(value);
	}
	else
	{
		Console.WriteLine($"{value} is 0");
	}
}
