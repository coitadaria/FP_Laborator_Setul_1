using System;
namespace Rezolvarea_Ecuatie_De_Gradul_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Rezolvarea ecuatiei de gradul 2: ax^2 + bx + c = 0");

            Console.Write("Introduceti coeficientul a: ");
            double a = Citire("a");

            Console.Write("Introduceti coeficientul b: ");
            double b = Citire("b");

            Console.Write("Introduceti coeficientul c: ");
            double c = Citire("c");

            RezolvaEcuatieGradul2(a, b, c);
        }
        static double Citire(string x)
        {
            while (true)
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
        static void RezolvaEcuatieGradul2(double a, double b, double c)
        {
            Console.WriteLine($"Ecuatia: {a}x² + {b}x + {c} = 0");
            if (a == 0)
            {
                Console.WriteLine("Atentie! Deoarece coeficientul a este 0, ecuatia este de gradul 1.");
                RezolvareaEcuatieGadul1(b, c);
                return;
            }

            double delta = b * b - 4 * a * c;
            Console.WriteLine($"Discriminatul (delta) = {b}^2-4x{a}x{c} = {delta} ");
            if (delta < 0)
            {
                Console.WriteLine("Ecuatia nu are solutii reale.");
                double parteReala = -b / (2 * a);
                double parteImaginara = Math.Sqrt(-delta) / (2 * a);

                Console.WriteLine("delta < 0 → Ecuatia are două solutii complexe conjugate:");
                Console.WriteLine($"x1 = {parteReala} + {parteImaginara}i");
                Console.WriteLine($"x2 = {parteReala} - {parteImaginara}i");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Ecuatia are o solutie reala dubla: x = {x}");
                if (x == Math.Round(x))
                Console.WriteLine($"x1=x2={x}");
                else
                    Console.WriteLine($"x1=x2={x:F6}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Ecuatia are doua solutii reale distincte: ");
                if (x1 == Math.Round(x1))
                    Console.WriteLine($"x1={x1}");
                else
                    Console.WriteLine($"x1={x1:F6}");
                if (x2 == Math.Round(x2))
                    Console.WriteLine($"x2={x2}");
                else
                    Console.WriteLine($"x2={x2:F6}");
            }

            static void RezolvareaEcuatieGadul1(double b, double c)
            {
                if (b == 0)
                {
                    if (c == 0)
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
                    double x = -c / b;
                    if (x == Math.Round(x))
                        Console.WriteLine($"Solutia ecuatiei este: x = {x:F0} sau ca fractie x={-c}/{b}");
                    else
                        Console.WriteLine($"Solutia ecuatiei este: x = {x:F6} sau ca fractie x={-c}/{b}");
                }
            }
        }
    }
}
        