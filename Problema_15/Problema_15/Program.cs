using System;
namespace Problema_15
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul afiseaza in ordine crescatoare trei numere introduse de la tastatura.");
            int a = Citire("primul");
            int b = Citire("al doilea");
            int c = Citire("al treilea");
            if(a>b)
                (a,b) = (b, a);
            if(a>c)
                (a, c) = (c, a);
            if (b > c)
                (b, c) = (c, b);
            Console.WriteLine($"Numerele in ordine crescatoare sunt: {a}, {b}, {c}");
        }

        static int Citire(string x)
        {
            Console.WriteLine($"Introduceti numarul {x}:");
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }

                catch (FormatException)
                {
                    Console.WriteLine("Numar invalid! Introduceti un numar intreg:");
                    return Citire(x);
                }
            }
        }
    }
}