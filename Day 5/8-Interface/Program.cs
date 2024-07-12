using Microsoft.VisualBasic;

interface TiramisuCake
{
	public abstract void bantet();
	// {
	// 	Console.WriteLine("Cake ini tidak bisa dibuat karena prosesnya");
	// }
	
	public void raw()
	{
		Console.WriteLine("/...");
	}
	public void varian()
	{
		Console.WriteLine("....");
	}
}
public interface ICake
{
	void raw();
	// void baked();
	public void trash()
	{
		
	}
	
}
// public abstract class Bread
// {
// 	public abstract void panggang();
// 	public abstract void gosong();
// }
public class MixCake : TiramisuCake, ICake
{
	public void raw ()
	{
		Console.WriteLine ("Kue ini masih mentah, segera masak ayo Rani!!");
	}
	// public void baked ()
	// {
	// 	Console.WriteLine ("Kue ini sudah dipanggang dan dapet segera dijual");
	// }
	void trash()
	{
		Console.WriteLine ("Kue ini sudah basi lebih baik segera di buang");
	}
	public void bantet()
	{
		
	}
}
// public class Bread
// {
// 	public ICake icake;
// 	public Bread(ICake icake)
// 	{
// 		this.icake = icake;
// 	}
// }
// public class 
class Program
{
	static void Main ()
	{
		MixCake cake = new();
		cake.raw();
		// Console.WriteLine (cake.trash());
	}
}