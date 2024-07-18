class Program
{
	static void Main()
	{
		StatusCheker stat = new();
		// Ada kemungkinan bisa typo
		// string status = "NotFound";
		Status status= Status.NotFound;
		stat.Check(status);
	}
}

// Enum dibuat agar tidak ada kesalahan saat pemanggilan atau penulisan suatu value
// bisa digunakan untuk value yang paten
public enum Status
{
	NotFound,
	Redirected,
	
	WrongPassword,
	Qwertyuiop
}

class StatusCheker
{
	public void Check(Status status)
	{
		// Bila dibuat seperti ini ada kemungkinan input data salah tulis typo
		// if (Status == "NotFound")
		// {
		// 	Console.WriteLine("Error : Not Found");
		// }
		
		if (status == Status.NotFound)
		{
			Console.WriteLine("Error : Not Found");
		}
		else if (status == Status.Redirected)
		{
			Console.WriteLine("Error : Redirected");
		}
		else if (status == Status.WrongPassword)
		{
			Console.WriteLine("Error : Password Salah");
		}
		else if (status == Status.Qwertyuiop)
		{
			Console.WriteLine("Error : Qwertuiop");
		}
		else
		{
			Console.WriteLine("Ga ada bisa coba lagi");
		}
	}
}