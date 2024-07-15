class Home
{
    public int door;
    public int window;
    public string color;
    public string address;
    // pembuatan constructor dengan parametrer
    // apabila ingin memanggilnya harus lengkap dengan parameter yang sudah dideklarasikan
    public Home(int door, int window, string color, string address) 
    {
        this.door = door;   //wajib ada variabel ini
        this.window = window;
        this.color = color;
        this.address = address;
    }
}
class Program
{
    static void Main()
    {
        Home home = new Home(4,6,"green", "rembang");   //instance baru harus sesuai penulisan pada constructor termasuk paramaeternya
        Console.WriteLine(home.door);   //4
        Console.WriteLine(home.window); //6
        Console.WriteLine(home.color);  //green
        Console.WriteLine(home.address);    //rembang
    }
}