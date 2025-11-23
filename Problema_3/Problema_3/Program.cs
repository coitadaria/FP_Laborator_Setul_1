using System;
namespace Problema_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul verifica daca n se divide cu k.");
            int n, k;
            n = Citire("n");
            k = Citire("k");
            VerificareDivizibilitate(n, k);
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
                    return Citire(numar);
                }
            }
        }
        static void VerificareDivizibilitate(int n, int k)
        {
            if (k == 0)
            {
                Console.WriteLine("Impartirea la zero nu este permisa.");
                return;
            }
            if (n % k == 0)
            {
                if (Math.Abs(k) != 1 && Math.Abs(k) != Math.Abs(n))
                {
                    Console.WriteLine($"{k} este divizor propriu al lui {n}.");
                }
                else
                    Console.WriteLine($"{k} este divizor impropriu al lui {n}.");
            }
            else
            {
                Console.WriteLine($"{n} nu este divizibil cu {k}.");
            }
        }
    }

}