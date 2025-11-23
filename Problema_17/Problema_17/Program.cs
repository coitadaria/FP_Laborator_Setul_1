using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Programul determina cel mai mare divizor comun si cel mai mic multiplu comun a doua numere intregi a si b. Programul foloseste algoritmul lui Euclid.");
        Console.Write("Introduceti primul numar (a): ");
        int a = Citire("a");
        Console.Write("Introduceti al doilea numar (b): ");
        int b = Citire("b");
        if (a < 0)
        {
            a = Math.Abs(a);
            Console.WriteLine($"Pentru a putea calcula vom folosii valoarea absoluta a numarului -{a}.");
        }
        if (b < 0)
        { 
            b = Math.Abs(b); 
            Console.WriteLine($"Pentru a putea calcula vom folosii valoarea absoluta a numarului -{b}.");
        }
        //Algoritmul lui Euclid
        int copialuia = a;
        int copialuib = b;
        int r = a % b;
        while (r != 0)
        {
            a = b;
            b = r;
            r = a % b;
        }
        Console.WriteLine($"Cel mai mare divizor comun a numerelor {copialuia} si {copialuib} este: {b}.");
        Console.WriteLine($"Cel mai mic multiplu comun a numerelor {copialuia} si {copialuib} este: {copialuia / b * copialuib}.");

    }
    static int Citire(string x)
    {
        int numar;
        while (true)
        {
            try
            {
                numar = Convert.ToInt32(Console.ReadLine());
                return numar;
            }
            catch (FormatException)
            {
                Console.Write($"Eroare: Introduceti o valoare intreaga pentru {x}: ");
                return Citire(x);
            }
        }

    }
}