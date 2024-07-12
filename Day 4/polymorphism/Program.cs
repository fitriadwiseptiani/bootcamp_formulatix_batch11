// //Overriding
// class Animal {
// 	public string name;
// 	public int age;
// 	public void Eat() {
// 		Console.WriteLine("Eat");
// 	}
// 	public virtual void MakeSound() {           //dari parents mengizinkan fungsi MakeSound untuk diambil alih (tambah virtual)
// 		Console.WriteLine("...");
// 	}
// }
// class Cat : Animal {
// 	public override void MakeSound() {          //dari child mengambil alih fungsi MakeSound dengan menambahkan override
// 		Console.WriteLine("Meow!");
// 	}
// }
// class Ant : Animal {}
// class Program {
// 	static void Main() {
// 		Animal animal = new();
// 		animal.MakeSound(); //...
// 		Cat cat = new();
// 		cat.MakeSound(); //Meow
// 		Ant ant = new();
// 		ant.MakeSound(); //...
// 	}
// }

//Overriding
class Cake {
	private int totalharga;
	public string nameproduct;
	public int stock;
	
	public virtual void Make() {
		Console.WriteLine("Kue ini dibuat dengan cara dikukus");
	}
	public virtual void Material() {           //dari parents mengizinkan fungsi MakeSound untuk diambil alih (tambah virtual)
		Console.WriteLine("Bahan kue ini adalah tepung, gula dan telur");
	}
}
class Cake1 : Cake {
	public override void Make() {
		Console.WriteLine("Kue ini harus di oven");
	}
	public override void Material() {
		Console.WriteLine("Kue ini dari cokelat dan tepung");
	}
}
class Cake2 : Cake {
}

class Program {
	static void Main() {
		Cake cake = new();
		cake.Make();
		Cake1 cake1 = new();
		cake1.Make();
}
}