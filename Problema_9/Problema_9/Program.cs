using System;
namespace Problema_9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul afiseaza toti divizori numarului pozitiv, intreg n introdus de la tastatura.");
            int n = Citire("n");
            if (n == 0)
                Console.WriteLine("Divizorii numarului 0 sunt toate numerele intregi nenule.");
            if (n == 1) Console.WriteLine("Divizorul numarului 1 este 1.");
            List<int> divizori = new List<int>();
            divizori.Add(1);
            divizori.Add(n);
            int d;
            for (d = 2; d * d < n; d++)
                if (n % d == 0)
                {
                    divizori.Add(d);
                    divizori.Add(n / d);
                }
            if (d * d == n)
                divizori.Add(d);
            divizori.Sort();
            Console.WriteLine($"Divizorii pozitivi a numarului {n} sunt:");
            foreach (int divizor in divizori)
                Console.Write(divizor + " ");
        }
        static int Citire(string n)
        {
            while (true)
            {
                Console.WriteLine("Introduceti un numar intreg pozitiv:");
                try
                {
                    string numar = Console.ReadLine();
                    int x = int.Parse(numar);
                    if (x > 0)
                    {
                        return x;
                    }
                    else
                    {
                        Console.WriteLine("Numarul introdus nu este pozitiv.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input invalid. Va rugam sa introduceti un numar intreg pozitiv.");
                }
            }
        }
    }
}