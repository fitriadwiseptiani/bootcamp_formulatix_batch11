using ExampleCalc;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        int result = calc.Add(3, 4);    //untuk menerapkan fungsi Add, perlu membuat variabel baru
        Console.WriteLine(result);  // hasil = 7

        // mengambil input user dari terminal
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        // mengkonvert dari string ke int menggunakan Parse
        int input1int = int.Parse(input1);  //membuat variabel baru yang isinya hasil konvert dari string ke int pada input 1
        int input2int = int.Parse(input2);  //membuat variabel baru yang isinya hasil konvert dari string ke int pada input 1

        // hasil
        int result2 = calc.Add(input1int, input2int); //untuk menerapkan fungsi Add
        Console.WriteLine(result2); //hasil penjumlahan dari 2 bilangan yang dimasukkan
    }
}