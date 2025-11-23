using System;
namespace Problema_12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul calculeaza cate numere intregi diizibile cu n se afla in intervalul [a,b]. ");
            int a = Citire("a");
            int b = Citire("b");
            int n = Citire("n");
            int k = 0;    // contorul pentru numere divizibile cu n in intervalul [a,b]
            if (a>b)
            {
                Console.WriteLine($"Intervalul este invalid! Variabila a trebuie sa fie mai mica sau egala decat b. Ai introdus a={a} si b={b}.");
                return;
            }
            if(n==0)
            {
                Console.WriteLine("Diviziunea cu zero nu este permisa!");
                return;
            }

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    k++;
                }
            }
            Console.WriteLine($"In intervalul [{a},{b}] sunt {k} numere intregi divizibile cu {n}.");
        }
        static int Citire(string x)
        {
            Console.WriteLine($"Introduceti valoarea pentru {x}: ");
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Valoarea pentru {x} nu este valida. Introduceti un numar intreg.");
                    return Citire(x);
                }
            }
        }
    }
}