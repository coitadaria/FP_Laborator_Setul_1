using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Programul verifica daca un numar citit de la tastatura este format doar cu doua cifre care se pot repeta.");
        Console.WriteLine("Introduceti un numar: ");
        string n = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(n) || !n.All(char.IsDigit))
        {
            Console.WriteLine("EROARE: Va rugam introduceti doar cifre (0-9) fără semne sau litere!");
            return;
        }
        int numarCifreDistincte = n.Distinct().Count();
        bool areDouaCifre;
        if(numarCifreDistincte==2)
            areDouaCifre = true;
        else
            areDouaCifre = false;

        if (areDouaCifre)
             Console.WriteLine($"Numarul {n} este format doar cu doua cifre care se pot repeta."); 
        else
             Console.WriteLine($"Numarul {n} NU este format doar cu doua cifre care se pot repeta."); 
    }
}