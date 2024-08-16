using AfterAbstractFactory.Interface;

namespace AfterAbstractFactory.Model;

public class WinterPant :IPant
{
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }
    public void Details()
    {
        Console.WriteLine("Dilengkapi dengan penutup kepala yang dapat dilepas, kantong dalam yang aman, serta resleting tahan air, jaket ini adalah pilihan ideal untuk aktivitas luar ruangan maupun penggunaan sehari-hari di musim dingin");
    }
}
