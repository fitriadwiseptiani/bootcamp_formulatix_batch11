using AfterAbstractFactory.Interface;

namespace AfterAbstractFactory.Model;

public class WinterShirt : IShirt
{
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }
    public void Details()
    {
        Console.WriteLine("Kemeja musim dingin yang dirancang untuk memberikan kehangatan dan kenyamanan ekstra saat suhu menurun.");
    }
}
