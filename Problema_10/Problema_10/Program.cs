using System;
namespace Problema_10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul verifica daca un numar intreg pozitiv n, introdus de la tastatura, este prim.");
            int n = Citire("n");
            bool estePrim = true;
            if(n<2)
                estePrim = false;
            if(n%2==0 && n!=2)
                estePrim = false;
            for(int d=3;d*d<=n && estePrim ;d=d+2)
                if(n%d==0)
                    estePrim = false;
            if(estePrim)
                Console.WriteLine($"Numarul {n} este prim.");
            else
                Console.WriteLine($"Numarul {n} NU este prim.");

        }
        static int Citire(string x)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Introduceti un numar intreg pozitiv: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        return n;
                    }
                    else
                    {
                        Console.WriteLine("Numarul trebuie sa fie pozitiv.");
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