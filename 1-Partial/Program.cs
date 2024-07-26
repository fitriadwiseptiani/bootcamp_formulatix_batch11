namespace Programku
{
	class Program
	{
		static void Main()
		{
			Cake cake = new Cake();
			cake.Run();
		}
	}
	partial class Cake
	{
		
	}
}

// syarat = 
// 1. nama namespace harus sama
// 2. nama class sama
// 3. ditambahkan "partial" sebelum penulisan class pada kedua file