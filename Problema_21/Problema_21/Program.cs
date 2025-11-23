using System;
namespace Problema_21
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("   GHICESTE NUMARUL  ");
            Console.WriteLine("Gandeste-te la un numar intre 1 si 1024.");
            Console.WriteLine("Voi incerca sa-l ghicesc folosind intrebari de forma:");
            Console.WriteLine("Numarul este mai mare sau egal decât x?");
            Console.WriteLine("Răspunde cu 'da' , 'd' sau 'nu' , 'n'.");

            int min = 1;
            int max = 1024;
            int incercari = 0;
            
            while (true)
            {
                incercari++;
                int mijloc = min + (max - min) / 2;// calcularea mijlocului se face astfel încât să evităm overflow

                if (min == max)
                {
                    Console.WriteLine($"Numarul tău este {min}!");
                    break;
                }

                if (max - min == 1)
                {
                    Console.Write($"Este numarul {min}? ");
                    string raspuns = Console.ReadLine().ToLower().Trim();

                    switch (raspuns)
                    {
                        case "da":
                        case "d":
                            Console.WriteLine($"Am ghicit! Numarul este {min}!");
                            return;
                        case "nu":
                        case "n":
                            Console.WriteLine($"Atunci numarul este {max}!");
                            return;
                        default:
                            Console.WriteLine("Te rog sa raspunzi doar cu 'da', 'd' sau 'nu', 'n'.");
                            incercari--;
                            continue;
                    }
                }

                Console.Write($"Intrebarea #{incercari}: Numarul este mai mare sau egal decât {mijloc}? ");
                string raspunsMijloc = Console.ReadLine().ToLower().Trim();

                switch(raspunsMijloc)
                {
                    case "da":
                    case "d":
                        min = mijloc;
                        break;
                    case "nu":
                    case "n":
                        max = mijloc - 1;
                        break;
                    default:
                        Console.WriteLine("Te rog sa raspunzi doar cu 'da', 'd' sau 'nu', 'n'.");
                        incercari--;
                        continue;
                }
                Console.WriteLine($"Interval curent: {min} - {max}"); 
            }

            Console.WriteLine($"Am ghicit in {incercari} intrebari!");
        }
    }
}

