using AfterAbstractFactory.Interface;

namespace AfterAbstractFactory.Model;

public class SummerShirt :IShirt
{
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }
    public void Details()
    {
        Console.WriteLine("Terbuat dari bahan ringan, kemeja ini memberikan kesegaran sepanjang hari.");
    }
}
