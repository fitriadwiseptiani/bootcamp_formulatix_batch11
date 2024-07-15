class Cat 
{
    public bool manja;      //sifat
    public string colour;
    public string gender;

    public void Eat(string jenisMakanan)      //fungsi dan ditambahkan sebuah parameter
    {
        Console.WriteLine("Cat eat " + jenisMakanan);
    }
    public void Poop()
    {
        Console.WriteLine("Cat poop");
    }
}
class Program 
{
    static void Main()
    {
        Cat cat = new Cat();
        string makan = Console.ReadLine();  //user memasukkan input
        cat.Eat(makan);     //menampilkan isi dari fungsi Eat sesuai dengan tambahan input yang diberikan
        cat.Poop();
    }
}