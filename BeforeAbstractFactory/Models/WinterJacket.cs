namespace BeforeAbstractFactory.Models;

public class WinterJacket
{
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }

    public void Details()
    {
        Console.WriteLine("Jaket musim dingin dengan bahan hangat dan tahan air.");
    }
}