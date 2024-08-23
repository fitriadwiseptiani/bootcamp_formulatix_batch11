// Queue

// menggunakan prinsip FIFO (First In First Out)
// Push = untuk menambah data
// Pop = mengambil data
// Peek = melihat data yang akan ditampilkan nanti
class Program
{
	static void Main(string[] args)
	
	{
		Stack <int> myQueue = new();
		myQueue.Push(1);
		myQueue.Push(2);
		myQueue.Push(5);
		
		int result = myQueue.Pop();
		Console.WriteLine(result);
		
		int result2 = myQueue.Pop();
		Console.WriteLine(result2);
		
		int result3 = myQueue.Peek();
		Console.WriteLine(result3);
		
		int result4 = myQueue.Peek();
		Console.WriteLine(result4);
		
		int result5 = myQueue.Pop();
		Console.WriteLine(result5);
		
	}
	
}