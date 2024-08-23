namespace BeforeAbstractFactory.Models;

public class WinterShirt
{
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }

    public void Details()
    {
        Console.WriteLine("Kemeja musim dingin yang dirancang untuk memberikan kehangatan dan kenyamanan ekstra saat suhu menurun.");
    }
}
