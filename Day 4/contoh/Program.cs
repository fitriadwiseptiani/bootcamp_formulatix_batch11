using contoh;
class Program {
	static void Main() {
		Human human = new Human();
		Console.WriteLine(human.CheckNIK("Admin#1234"));
		human.SetNIK(2000);
		Console.WriteLine(human.CheckNIK("Admin#1234"));
	}
}