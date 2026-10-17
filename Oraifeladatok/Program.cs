namespace Oraifeladatok

{

    internal class Program
    {

        static int[] tomb = new int[5];

        static void Tombfeltoltes()

        {

            for (int i = 0; i < tomb.Length; i++)

            {

                Console.Write($"Kérem a(z) {i + 1}. számot: ");

                tomb[i] = Convert.ToInt32(Console.ReadLine());

            }

        }

        static void Kiiratas()

        {

            Console.WriteLine("A tömb elemei a megadas sorrendjeben: ");

            for (int i = 0; i < tomb.Length; i++)

            {

                Console.WriteLine(tomb[i]);

            }

            Console.WriteLine("A tömb elemei fordított sorrendben: ");

            for (int i = tomb.Length - 1; i >= 0; i--)

            {

                Console.WriteLine(tomb[i]);

            }

            Console.WriteLine("A tömb minden második eleme: ");

            for (int i = 1; i < tomb.Length; i += 2)

            {

                Console.WriteLine(tomb[i]);

            }

            Console.WriteLine("Adjon 1 számot 1 és 5 között: ");

            int keresett = Convert.ToInt32(Console.ReadLine());

            int j = keresett - 1;

            Console.WriteLine($"A keresett szám az {tomb[j]}");

        }

        static void Main(string[] args)

        {

            Console.WriteLine("5. feladat");

            Tombfeltoltes();

            Kiiratas();

        }

    }

}