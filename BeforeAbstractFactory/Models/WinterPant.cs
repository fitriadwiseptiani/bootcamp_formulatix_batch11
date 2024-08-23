namespace BeforeAbstractFactory.Models;

public class WinterPant
{
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }

    public void Details()
    {
        Console.WriteLine("Celana musim dingin dengan fitur khusus untuk cuaca dingin.");
    }
}