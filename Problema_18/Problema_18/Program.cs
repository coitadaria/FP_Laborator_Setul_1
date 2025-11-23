using System;
namespace Problema_18
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul afiseaza descompunerea unui numar n citit de la tastatura in factori primi.");
            Console.Write("Introduceti un numar natural n = ");
            int x = Citire("x");
            Console.Write($"Descompunerea numarului {x} in factori primi este:");
            int d = 2, e;
            bool este_format_sir = false;
            while (x != 1 && d * d <= x)
            {
                e = 0;
                while (x % d == 0)
                {
                    e++;
                    x = x / d;
                }
                if (este_format_sir == true && e != 0)
                {
                    Console.Write(" X");
                }
                if (e != 0)
                {
                    Console.Write($" {d}^{e}");
                    este_format_sir = true;
                }
                if (d == 2)
                    d++;
                else d = d + 2;
            }
            if (x != 1 && este_format_sir)
            {
                Console.Write($" X {x}^1.");
            }
            else
                   if (x != 1 && este_format_sir == false)
                    {
                        Console.Write($" {x}^1.");
                    }
        }
        static int Citire(string denumire)
        {
            int x;
            while (true)
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x < 2)
                    {
                        Console.Write($"Eroare: numarul {denumire} trebuie sa fie un numar natural mai mare sau egal cu 2. Introduceti alta valoare: ");
                    }
                    else
                    {
                        return x;
                    }
                }
                catch
                {
                    Console.Write($"Eroare: valoarea introdusa pentru {denumire} nu este un numar natural. Introduceti alta valoare: ");
                    return Citire(denumire);
                }
            }
        }
    }
}