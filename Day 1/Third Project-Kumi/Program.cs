class Cat 
{
    public bool manja;      //sifat
    public string colour;
    public bool isMale;

    public void Poop()      //fungsi
    {
        Console.WriteLine("Poop");
    }
    public void Eat()
    {
        Console.WriteLine("Eat");
    }
}
class Program 
{
    static void Main()
    {
        Cat kumi = new Cat();  //new instance untuk membuat objek baru
        kumi.manja = true;  //karena tipe bool maka antara true dan false
        kumi.colour = "Green";
        kumi.isMale = true;
        Console.WriteLine(kumi.manja);
        Console.WriteLine(kumi.colour);
        Console.WriteLine(kumi.isMale);

        kumi.Poop();    //memanggil fungsi poop dan eat
        kumi.Eat();

        Cat nana = new Cat();   //membuat instance baru dan nilai pada objectnya nanti kembali seperti awal
        nana.manja = true;
        nana.colour = "Pink";
        nana.isMale = false;
        Console.WriteLine(nana.manja);
        Console.WriteLine(nana.colour);
        Console.WriteLine(nana.isMale);
    }
}