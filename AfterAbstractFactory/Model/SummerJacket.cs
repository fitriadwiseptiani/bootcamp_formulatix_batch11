using AfterAbstractFactory.Interface;

namespace AfterAbstractFactory.Model;

public class SummerJacket : IJacket
{
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }
    public void Details()
    {
        Console.WriteLine("Jaket musim panas yang dirancang dengan material ringan dan bernapas, ideal untuk menjaga kenyamanan saat cuaca hangat.");
    }
}
