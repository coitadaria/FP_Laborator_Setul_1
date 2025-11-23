using System;
namespace Problema_11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul afiseaza in ordine inversa cifrele unui numar intreg n citit de la tastatura.");
            int x = Citire("x");
            Console.WriteLine($"Cifrele numarului {x} in ordine inversa sunt:");
            if (x == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (x > 0)
                {
                    while (x > 0)
                    {
                        Console.Write(x % 10 + " ");
                        x = x / 10;
                    }
                }
                else
                {
                    x = -x;
                    while (x > 0)
                    {
                        Console.Write(x % 10 + " ");
                        x = x / 10;
                    }
                    Console.Write("(-)");
                }
            }
        }
        static int Citire(string x)
        {
            Console.WriteLine("Introduceti un numar intreg:");
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }

                catch (FormatException)
                {
                    Console.WriteLine("Numar invalid. Introduceti un numar intreg valid:");
                    return Citire(x);
                }
            }
        }
    }
}