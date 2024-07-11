namespace contoh;

class Form
{
	private int NIK;
	public string name;
	public string gender;
	public string address;
	
	public int CheckNIK(string password) {
		if(password == "Admin#1234") {
			return NIK;
		}
		return 0;
	}
	public void SetNIK(int NIKBaru) {
		if(!(NIKBaru < 0)) {
			NIK = NIKBaru;
		}
	}
	public void Save()
	{
		
	}
}
class Additional : Form 
{
	public string religion;
	
}

class Program 
{
	static void Main(string[] args)
	{
		Form form = new Form();
		Console.WriteLine(form.CheckNIK("Admin#1234"));
		form.SetNIK(2000);
		Console.WriteLine(form.CheckNIK("Admin#1234"));
	}
}
