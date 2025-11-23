using System;
namespace Problema_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul verifica daca un an este an bisect.");
            int an= CitireAn();
            if((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
                Console.WriteLine($"Anul {an} este an bisect.");
            else
                Console.WriteLine($"Anul {an} NU este an bisect.");
        }
        static int CitireAn()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Introduceti un an: ");
                    string y = Console.ReadLine();
                    int an = Convert.ToInt32(y);
                    return an;

                }

                catch (FormatException)
                {
                    Console.WriteLine("An invalid. Introduceti un an valid: ");
                    return CitireAn();
                }
            }
        }
    }
}