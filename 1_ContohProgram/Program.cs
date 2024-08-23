using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		Console.WriteLine("Beautiful free images & pictures");
		CancellationTokenSource Cts = new CancellationTokenSource();
		Task t1 = Task.Run(() => ImageAccess(Cts.Token));
		Thread.Sleep(1000);
		Task t2 = t1.ContinueWith(t => DownloadImage(Cts.Token));
		Task t3 = t1.ContinueWith(t => 
		{
			Console.ReadLine();
			Cts.Cancel();
		});
		
		Task.WaitAll(t2, t3);
		Console.WriteLine("Thank you for coming...");
	}
	static void DownloadImage(CancellationToken ct)
	{
			Console.WriteLine("Gambar yang telah ditampilkan akan didownload");
			Console.WriteLine("Download starting...");
			for(int f = 0; f < 100; f++)
			{
				Console.WriteLine($"{f} %");
				Thread.Sleep(200);
				if(ct.IsCancellationRequested)
				{
					return;
				}
			}
			Console.WriteLine("Download completed.");
		
	}
	static void ImageAccess(CancellationToken img)
	{
		Console.WriteLine("Berapa gambar yang ingin download? ");
		string input = Console.ReadLine();
		int number;
		
		try
		{
			number = Int32.Parse(input);
			if (number <= 0) throw new FormatException("Nomor harus positif");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Input tidak valid: {ex.Message}");
			return;
		}

		int[] myImages = new int[number];
		for (int i = 0; i < number; i++)
		{
			myImages[i] = i + 1;
		}

		for (int i = 0; i < myImages.Length; i++)
		{
			if (img.IsCancellationRequested)
			{
				Console.WriteLine("Proses loading image dibatalkan");
				return;
			}

			Console.WriteLine($"Gambar ke {myImages[i]} terbuka");
			Thread.Sleep(1000);
		}
	}
}