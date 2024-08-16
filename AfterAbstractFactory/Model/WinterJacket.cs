using AfterAbstractFactory.Interface;

namespace AfterAbstractFactory.Model;

public class WinterJacket :IJacket
{
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }
    public void Details()
    {
        Console.WriteLine("Celana musim panas yang dirancang untuk memberikan kenyamanan maksimal di cuaca hangat. ");
    }
}
