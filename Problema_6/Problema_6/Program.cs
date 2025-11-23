using System;
namespace Problema_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Determinare daca trei numere pozitive a,b,c pot fi lungimile laturilor unui triunghi.");
            Console.Write("Introduceti valoarea lui a: ");
            double a = Citire("a");
            Console.WriteLine("Introduceti valoarea lui b: ");
            double b = Citire("b");
            Console.WriteLine("Introduceti valoarea lui c: ");
            double c = Citire("c");

            if((a+b)>c && (a+c)>b && (b+c)>a)
                Console.WriteLine($"Numerele {a},{b},{c} pot fi lungimile laturilor unui triunghi.");
            else
                Console.WriteLine($"Numerele {a},{b},{c} NU pot fi lungimile laturilor unui triunghi.");


        }
        static double Citire(string a)
        {
            while (true)
            {
                try
                {
                    double latura = Convert.ToDouble(Console.ReadLine());
                    if (latura > 0)
                    {
                        return latura;
                    }
                    else
                    {
                        Console.WriteLine("Numarul trebuie sa fie pozitiv. Va rugam sa introduceti un numar valid:");
                        return Citire(a);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input invalid. Va rugam sa introduceti un numar valid:");
                    return Citire(a);
                }
            }
        }
    }
}