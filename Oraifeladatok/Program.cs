namespace Oraifeladatok

{

    internal class Program
    {
        static Random r = new Random();
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
        static int[] tomb2 = new int[20];
        static void Tombfeltoltes2()
        {
            for (int i = 0; i < tomb2.Length; i++)
            {
                tomb2[i] = r.Next(-100, 101);
            }
        }
        static void Kiiratas2()
        {
            Console.WriteLine("A tömb elemei: ");
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.Write(tomb2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("A tömb elemei, és adatai táblázatszerűen: ");
            Console.WriteLine("Sorszám\t\tTömb-elem\tElőjel");
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t\t{tomb2[i]}\t\t{(tomb2[i] >= 0 ? "+" : "-")}");
            }
            
            for (int i = 2; i < tomb2.Length; i += 3)
            {
                tomb2[i]++;
            }
            Console.WriteLine("A módosított tömb elemei: ");
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.Write(tomb2[i] + " ");
            }
            
            for (int i = 1; i < tomb2.Length; i += 2)
            {
                tomb2[i] -= tomb2[i - 1];
            }
            Console.WriteLine("A módosított tömb elemei: ");
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.Write(tomb2[i] + " ");
            }
        }
        static void Main(string[] args)

        {

            Console.WriteLine("5. feladat");
            Tombfeltoltes();
            Kiiratas();
            Console.WriteLine("13. feladat");
            Tombfeltoltes2();
            Kiiratas2();
        }

    }

}