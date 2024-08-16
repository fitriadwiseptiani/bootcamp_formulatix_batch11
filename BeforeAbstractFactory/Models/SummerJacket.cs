namespace BeforeAbstractFactory.Models;

public class SummerJacket
{
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }

    public void Details()
    {
        Console.WriteLine("Jaket musim panas yang dirancang untuk cuaca hangat.");
    }
}