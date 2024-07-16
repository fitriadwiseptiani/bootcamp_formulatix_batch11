class Calculator
{
    // parameter constructor
    public Calculator ()
    {
        Console.WriteLine("Calculator instance created");
    }
}
class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++) //membuat perulangan sebanyak dari 0 sampai <5
        {
            Calculator calculator = new Calculator(); 
            //hasilnya tulisan "Calculator ..." 5x
        }
    }
}
