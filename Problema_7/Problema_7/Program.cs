using System;
namespace Problema_7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pentru doua numere a si b introduse de la tastatura, se afiseaza inversarea valorilor lor.");
            Console.Write("Introduceti numarul a: ");
            int a = Citire("a");
            Console.Write("Introduceti numarul b: ");
            int b = Citire("b");
            int aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"Dupa inversare, a = {a} si b = {b}.");
        }
        static int Citire(string a)
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Eroare: Introduceti un numar valid.");
                    return Citire(a);
                }
            }
        }
    }
}