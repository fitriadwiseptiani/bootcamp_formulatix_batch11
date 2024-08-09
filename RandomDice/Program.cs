// // class Program
// // {
// // 	static void Main()
// // 	{
// // 		string[] cardValues = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K" };
// // string[] cardSuites = { "HEARTS", "CLUBS", "DIAMONDS", "SPADES" };

// // Random rand = new Random();

// // int randomValues = rand.Next( cardValues.Length);
// // int randomSuites = rand.Next( cardSuites.Length);

// // Console.WriteLine("2 random cards ");

// // Console.WriteLine("Card1 ->" + " {0} {1}", randomValues, randomSuites);

// // // Generate again!

// // randomValues = rand.Next( cardValues.Length);
// // randomSuites = rand.Next( cardSuites.Length);

// // Console.WriteLine("Card2 ->" + " {0} {1}", randomValues, randomSuites);
// // 	}
// // }


// class Program
// {
// 	static void Main()
//     {
//     	string[] cardValues = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K" };
// string[] cardSuites = { "HEARTS", "CLUBS", "DIAMONDS", "SPADES" };

// Random rand = new Random();

// int randomValues = rand.Next( cardValues.Length);
// int randomSuites = rand.Next( cardSuites.Length);

// Console.WriteLine("2 random cards ");

// Console.WriteLine("Card1 ->" + " {0} {1}", randomValues, randomSuites);

//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Random rand = new Random();

//         // Lempar dadu pertama
//         int dice1 = rand.Next(1, 7); // Hasilnya antara 1 dan 6

//         // Lempar dadu kedua
//         int dice2 = rand.Next(1, 7); // Hasilnya antara 1 dan 6

//         // Tampilkan hasil
//         Console.WriteLine("Hasil lemparan dua dadu:");

//         Console.WriteLine(dice1 + dice2);
//         // Console.WriteLine("Dadudice2);
//     }
// }

using System;
using System.Linq;

namespace DiceGame
{
    public class Dice 
    {
        private static Random _random = new Random(); // Instance Random dibuat sekali

        public int NumberOfSides { get; private set; }
        public int[] SideValues { get; private set; }

        public Dice(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
            SideValues = Enumerable.Range(1, numberOfSides).ToArray();
        }

        public int Roll()
        {
            return _random.Next(1, NumberOfSides + 1);
        }

        public int RollTwoDice(out int firstRoll, out int secondRoll)
        {
            firstRoll = Roll();
            secondRoll = Roll();
            return firstRoll + secondRoll;
        }
    }

    class Program
    {
        static void Main()
        {
            // Membuat dadu dengan 6 sisi
            Dice dice = new Dice(6);

            // Melempar kedua dadu
            int roll1, roll2;
            int total = dice.RollTwoDice(out roll1, out roll2);

            // Menampilkan hasil
            Console.WriteLine("Hasil lemparan dua dadu:");
            Console.WriteLine($"Dadu 1 -> {roll1}");
            Console.WriteLine($"Dadu 2 -> {roll2}");
            Console.WriteLine($"Jumlah total -> {total}");
        }
    }
}


