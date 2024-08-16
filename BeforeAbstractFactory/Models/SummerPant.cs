namespace BeforeAbstractFactory.Models;

public class SummerPant
{
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }

    public void Details()
    {
        Console.WriteLine("Celana musim panas yang nyaman dan ringan.");
    }
}
