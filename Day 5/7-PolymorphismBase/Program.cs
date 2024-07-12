class Parent {
	public int UKT;
	public Parent(int UKT) 
	{
		this.UKT = UKT;
	}
	public virtual void Kuliah() {
		Console.WriteLine("UGM");
	}
}
class Child : Parent {
	public Child(int UKT) : base(UKT) 
	{
		
	}
	public override void Kuliah() {
		Console.WriteLine("Undip");
	}
	public void CheckParentKuliah() {
		base.Kuliah();      //apabila ingin menampilkan metode seperti yang ada pada Parent
	}
}
class Program {
	static void Main() {
		Child child  = new Child(8000000);
		child.Kuliah(); 
		child.CheckParentKuliah(); 
		Console.WriteLine(child.UKT);
	}
}