// Soal diberikan input = 15
// Output : 0, 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14, foobar
// Penyelesaian : 
// a. apabila bilangan habis dibagi 3 = foo ==> input % 3 == 0
// b. apabila bilangan habis dibagi 5 = bar ==> input % 5 == 0
// c. apabila bilangan merupakan kelipatan dari 3 dan 5 (3 x 5 = 15), maka hasilnya "foobar" ==> bilangan harus habis apabila dibagi 3 dan 5 ==> input % 3 == 0 && input % 5 == 0
// poin c harus PRIORITAS terlebih dahulu dibanding kondisi lain karena kalau tidak akan masuk pada kondisi yang memenuhi syarat pertama kali
// untuk menghasilkan output 0 harus dibuatkan kondisi khusus dan PRIORITAS UTAMA karena kalau tidak angka tersebut dapat masuk ke semua kondisi

using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int inputData = 15;
        var conditionData = new Dictionary<int, string>{
            {3, "foo"},
            {5, "bar"},
            {15, "foobar"}
        };
        for (int input = 0; input <= inputData; input++)
        {
            Console.WriteLine(GetOutputData(input, conditionData));
        }
    }
    static string GetOutputData(int input, Dictionary<int, string> condition){
        foreach (var key in condition){
            if(input != 0 && input % key.Key == 0){
                return key.Value;
            }
        }
        return input.ToString();
    }
}
