using System;
namespace Problema_15
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul afiseaza in ordine crescatoare cinci numere introduse de la tastatura.");
            int a = Citire("primul");
            int b = Citire("al doilea");
            int c = Citire("al treilea");
            int d= Citire("al patrulea");
            int e = Citire("al cincilea");

            // cautam cel mai mic numar si il punem in a
            if (b < a) (a, b) = (b, a);
            if (c < a) (a, c) = (c, a);
            if (d < a) (a, d) = (d, a);
            if (e < a) (a, e) = (e, a);

            // cautam penultimul cel mai mic numar si il punem in b
            if (c < b) (b, c) = (c, b);
            if (d < b) (b, d) = (d, b);
            if (e < b) (b, e) = (e, b);

            // cautam al treilea cel mai mic numar si il punem in c
            if (d < c) (c, d) = (d, c);
            if (e < c) (c, e) = (e, c);

            //comparam ultimele doua numere
            if (e < d) (d, e) = (e, d);
            Console.WriteLine($"Numerele in ordine crescatoare sunt: {a}, {b}, {c}, {d}, {e}.");
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