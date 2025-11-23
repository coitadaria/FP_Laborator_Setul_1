using System;
namespace Problema_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul extrage a k-a cifra de la sfarsitul unui numar n intreg.");
            int n = Citire("n");
            int k = Citire("k");
            if (k <= 0)
            {
                Console.WriteLine("k trebuie sa fie mai mare decat 0!");
                return;
            }
            int numarCifre = n.ToString().Length;
            if(k>numarCifre)
            {
                Console.WriteLine($"Numarul are doar {numarCifre} cifre. Nu exista a {k}-a cifra!");
                return;
            }
            int numar = Math.Abs(n);
            for (int i = 1; i < k; i++)
            {
                numar = numar / 10;  
            }

            int cifra = numar % 10;
            Console.WriteLine($"REZULTAT:");
            Console.WriteLine($"A {k}-a cifră de la sfârsitul lui {n} este: {cifra}.");
        }
        static int Citire(string numar)
        {
            while (true)
            {
                Console.WriteLine($"Introduceti un numar {numar}: ");
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Va rog introduceti un numar intreg.");
                }
            }
        }
    }
}