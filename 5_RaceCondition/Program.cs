class Program {
	static int Employee = 0;
	static async Task Main() 
	{
		Console.WriteLine("Masukkan kartu agar dapat keluar dari area parkir");
		Task task1 = Task.Run(Card);
		Task task2 = Task.Run(Card);
		Task task3 = Task.Run(Card);
		await Task.WhenAll(task1, task2);
		Console.WriteLine("Proses Selesai");
	}
	static async Task Card() {
		for(int i = 0; i < 100; i++) {
			Employee++;
			await Task.Delay(50);
			Console.WriteLine(Employee);
		}
	}
}