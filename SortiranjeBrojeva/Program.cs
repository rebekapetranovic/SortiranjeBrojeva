
using System;
namespace Prvi
{
    class Program
    {
        /// <summary>
        /// Učitava 5 brojeva i ispisuje ih sortirano, obrnutim redoslijedom
        /// </summary>
        static void Main()
        {
            int[] br = new int[5];
            int broj = br.Length;
            int pret;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Upišite {0} broj: ", i + 1);
                br[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(br);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sortirani brojevi: {0}", br[i]);
            }
            Console.Write("Upišite dodatan broj: ");
            int dodBr = int.Parse(Console.ReadLine());
            pret = Array.IndexOf(br, dodBr);
            if (pret == -1)
            {
                Array.Reverse(br);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Sortirani brojevi obrnutim redoslijedom: {0}", br[i]);
                }
            }
        }
    }
}