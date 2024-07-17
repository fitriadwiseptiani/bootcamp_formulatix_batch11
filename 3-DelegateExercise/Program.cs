public delegate void MyDelegate(string message);

class Publisher
{
	private MyDelegate _del;
	private List<MyDelegate> _listhistory = new(); //untuk menyimpan history dari subs yang pernah terdaftar
	
	// menggunakan bool karena agar mempermudah untuk validasi terhadap member yang masuk
	public bool AddSubscriber(MyDelegate subscriber)
	{
		//cek apabila subscriber belum digunakan sebelumnya
		if(!CheckDelegate(subscriber))
		{
			_del += subscriber; //menambahkan subscriber baru
			_listhistory.Add(subscriber); //mendapatkan list history dari subs yang telah terdaftar
			return true; //apabila terpenuhi maka true
		}
		return false; //apabila tidak terpenuhi maka false
	}
	
	public bool RemoveSubscriber(MyDelegate subscriber)
	{
		if(CheckDelegate(subscriber))
		{
			_del -= subscriber;
			return true;
		}
		return false;
		
	}
	// method baru untuk mengecek apakah subs sudah terdaftar
	private bool CheckDelegate(MyDelegate subscriber)
	{
		if(_del is not null)
		{
			Delegate[] delegates = _del.GetInvocationList();
			if(delegates.Contains(subscriber))
			{
				return true;
			}
		}
		return false;
	}
	public void ShowResult()
	{
		_del?.Invoke("Hello gaes");
	}
	
	// mendapatkan semua history yang terekan
	public List<MyDelegate> GetListHistory()
	{
		return _listhistory;
	}
	
	// mendapatkan rekaman apakah salah satu nama subs pernah terdaftar
	public bool CheckHistory(MyDelegate subscriber)
	{
		if(_listhistory.Contains(subscriber))
		{
			return true;
		}
		return false;
	}
}
class Subscriber
{
	private string _username;
	
	public Subscriber(string username)
	{
		_username = username;
	}
	public void GetNotification(string message){
		Console.WriteLine($"Terima kasih telah bergabung {_username} , {message}");
	}
}
class Program 
{
	static void Main()
	{
		Publisher publisher= new();
		Subscriber subs1 = new("member1");
		Subscriber subs2 = new("member2");
		
		// apabila ada subs yang sama maka otomatis yang ditamplkan hanya satu
		publisher.AddSubscriber(subs1.GetNotification);
		publisher.AddSubscriber(subs2.GetNotification);
		publisher.AddSubscriber(subs1.GetNotification);
		
		publisher.ShowResult();
		Console.WriteLine("#########################");
		// Console.WriteLine(publisher.GetListHistory());
		// publisher.CheckHistory();
		
		// publisher.RemoveSubscriber(subs1.GetNotification);
		// publisher.ShowResult();
				
	}
}