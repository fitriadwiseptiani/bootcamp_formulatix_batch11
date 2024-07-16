class Program
{
    static void Main()
    {
        // // For
        // for(int i = 0; i < 10; i++) //angka mulai 0 dan bertambah hingga kurang dari 10
        // {
        //     Console.WriteLine(i);   
        //     // hasilnya 0-9
        // }

        // // Array
        // int[] myInts = new int[] {1,2,3,4,5};
        // Console.WriteLine(myInts[0]);   //menampilkan data ke-1
        // Console.WriteLine(myInts[1]);   //menampilkan data ke-2
        // // For array
        // for(int i=0; i < myInts.Length; i++)    //membuat perulangan yang dimulai dari data pertama 0 hingga kurang dari panjang array tersebut
        // {
        //     Console.WriteLine(myInts[i]);   //menampilkan deretan data dari array
        // }

        // // foreach
        // int[] myInts2 = new int[] {1,2,3,4,5};
        // foreach (int z in myInts2)
        // {
        //     Console.WriteLine(z);   //hasil = 1,2,3,4,5
        // }

        // // while
        // int start = 0;
        // int end = 10;
        // while(start < end)
        // {
        //     Console.WriteLine(start);   //hasil 0-9
        //     start++;
        // }

        // while input user
        while(Console.ReadLine() == "y")    //apabila user memberi input "y" maka akan menampilkan tulisan
        {
            Console.WriteLine("Masukkan perintah 'y' untuk melanjutkan");
        }

    }
}