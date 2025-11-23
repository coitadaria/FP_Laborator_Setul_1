using System;
namespace Rezolvare_Ecuatie_Gradul_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Rezolvare Ecuatie de Gradul 1: ax + b = 0");
            Console.Write("Introduceti valoarea lui a: ");
            double a = Citire("a");

            Console.Write("Introduceti valoarea lui b: ");
            double b = Citire("b");

            Console.WriteLine($"Ecuatia introdusa este : {a}*x+{b}=0");

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ecuatia are o infinitate de solutii.");
                }
                else
                {
                    Console.WriteLine("Ecuatia nu are solutii.");
                }
            }
            else
            {
                double x = -b / a;
                if(x==Math.Round(x))
                    Console.WriteLine($"Solutia ecuatiei este: x = {x:F0} sau ca fractie x={-b}/{a}");
                else
                    Console.WriteLine($"Solutia ecuatiei este: x = {x:F6} sau ca fractie x={-b}/{a}");
            }
        }
        static double Citire(string x)
        { 
            while(true)
            {
                try
                {
                    return Convert.ToDouble(Console.ReadLine());  
                }
                catch (FormatException)
                {
                    Console.Write($"Valoarea introdusa pentru {x} nu este valida. Va rugam sa introduceti o valoare numerica pentru {x}: ");
                    return Citire(x);
                }
            }
        }
    }
}