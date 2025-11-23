using System;
namespace Problema_14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul determina daca un numar intreg pozitiv n este palindrom.");
            int n = Citire("n");
            int cn = n;// copie a numarului n
            int og = 0;// construi oglinditul pentru verificarea palindromului
            while(cn!=0)
            {
                og = og * 10 + cn % 10;
                cn = cn / 10;
            }
            if(og==n)
                Console.WriteLine($"Numarul {n} este palindrom.");
            else
                Console.WriteLine($"Numarul {n} NU este palindrom.");
        }
        static int Citire(string x)
        {
            while (true)
            {
                Console.WriteLine("Introduceti un numar intreg pozitiv:");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n > 0)
                        return n;
                    else
                    {
                        Console.WriteLine("Numarul trebuie sa fie pozitiv. Introduceti alt numar.");
                        return Citire(x);
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Input invalid. Va rugam sa introduceti un numar intreg pozitiv.");
                    return Citire(x);
                }
            }
        }
    }
}
