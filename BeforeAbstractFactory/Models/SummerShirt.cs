namespace BeforeAbstractFactory.Models;

public class SummerShirt
{
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }

    public void Details()
    {
        Console.WriteLine("Kemeja musim panas yang terbuat dari bahan ringan dan bernapas.");
    }
}