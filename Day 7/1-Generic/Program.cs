// Generic
// Ditandai dengan huru <T> best practice ===> tapi bisa yang lain
// dapat menggantikan berbagai tipe data sehingga tidak perlu membuat kelas secara berulang
class MyCollection<T>
{
	public int[] myCollection = new int[10];
	public int count = 0;
	public void Add(int input)
	{
		if (count == myCollection.Length)
		{
			return;
		}
		myCollection[count] = input;
		count++;
		Console.WriteLine("Data berhasil ditambahkan yaitu " + input);

	}
	public int Get(int index)
	{
		// Console.WriteLine("Nilai pada indeks ke " + index + " adalah " + myCollection[index]);
		return myCollection[index];
	}
	public void Remove(int index)
	{
		myCollection[index] = default;  //apabila int maka defaultnya jadi 0, akan tetapu kalau class maka defaultnya null
	}
}
class Program
{
	static void Main()
	{
		MyCollection<int> collection1 = new MyCollection<int>();
		collection1.Add(56);
		collection1.Add(12);
		collection1.Add(7);
		collection1.Add(1);
		collection1.Add(9);

		for(int i = 0; i < collection1.count; i++)
		{
			Console.WriteLine(collection1.Get(i));
		} 
		
		// melakukan remove data
		collection1.Remove(0);
		
		// menampilkan data setelah di remove
		
		for(int i = 0; i < collection1.count; i++)
		{
			Console.WriteLine(collection1.Get(i));
		} 
		
		
	}
	
	// collection1.Add(1);
	// MyCollection<string> myCollection= new MyCollection<string>();

}