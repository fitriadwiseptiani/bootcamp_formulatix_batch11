// Queue

// menggunakan prinsip FIFO (First In First Out)
// Enqueue = untuk menambah data
// dequeue = mengambil data
// Peek = melihat data yang akan ditampilkan nanti
class Program
{
	static void Main(string[] args)
	
	{
		Queue <int> myQueue = new();
		myQueue.Enqueue(1);
		myQueue.Enqueue(2);
		myQueue.Enqueue(5);
		
		int result = myQueue.Dequeue();
		Console.WriteLine(result);
		
		int result2 = myQueue.Dequeue();
		Console.WriteLine(result2);
		
		int result3 = myQueue.Peek();
		Console.WriteLine(result3);
		
		int result4 = myQueue.Peek();
		Console.WriteLine(result4);
		
		int result5 = myQueue.Dequeue();
		Console.WriteLine(result5);
		
	}
	
}