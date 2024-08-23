// bisa dihilangkan dan diganti dengan action
// public delegate void MyDelegate(string message);

class Publisher
{
	// MyDelegate diganti dengan Action<string> secara keselruhan
	private Action<string> _del;
	private List<Action<string>> _listhistory = new(); //untuk menyimpan history dari subs yang pernah terdaftar
	
	// menggunakan bool karena agar mempermudah untuk validasi terhadap member yang masuk
	public bool AddSubscriber(Action<string> subscriber)
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
	
	public bool RemoveSubscriber(Action<string> subscriber)
	{
		if(CheckDelegate(subscriber))
		{
			_del -= subscriber;
			return true;
		}
		return false;
		
	}
	// method baru untuk mengecek apakah subs sudah terdaftar
	private bool CheckDelegate(Action<string> subscriber)
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
	public List<Action<string>> GetListHistory()
	{
		return _listhistory;
	}
	
	// mendapatkan rekaman apakah salah satu nama subs pernah terdaftar
	public bool CheckHistory(Action<string> subscriber)
	{
		if(_listhistory.Contains(subscriber))
		{
			return true;
		}
		return false;
	}
}