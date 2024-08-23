using Database;

namespace ProgramDatabase;
public partial class Program
{
	public static async Task Trial()
	{
		using (ExampleDatabase db = new())
		{
			// try
			// {
			// 	Task<int> task = FirstMethod(db);
			// 	await task;
			// 	int a = task.Result;
			// 	Console.WriteLine(a);
			// }
			// catch (AggregateException e)
			// {
			// 	Console.WriteLine(e.Message);
			// }

			try
			{
				Task<int> task = SecondMethod(db);
				await task;
				int b = task.Result;
				Console.WriteLine(b);
			}
			catch (AggregateException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
	public static async Task<int> FirstMethod(ExampleDatabase myDb)
	{
		myDb.Categories.Add(new Category
		{
			CategoryId = 1,
			CategoryName = "Test"
		});
		return await myDb.SaveChangesAsync();
	}
	public static Task<int> SecondMethod(ExampleDatabase myDb)
	{
		myDb.Categories.Add(new Category
		{
			CategoryId = 1,
			CategoryName = "Test"
		});
		return myDb.SaveChangesAsync();
	}
}