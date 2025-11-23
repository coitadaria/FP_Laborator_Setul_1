using System;
namespace Problema_13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programul determina cati ani bisecti sunt intre ani y1 si y2 cititi de la tastatura.");
            int y1 = CitireAn();
            int y2 = CitireAn();
            int k = 0;    // contor pentru anii bisecti intre anii y1 si y2
            if(y1 > y2)
            {
                int aux = y1;
                y1 = y2;
                y2 = aux;
                Console.WriteLine($"Rezultatul afisat este pentru intervalul inversat: [{y1}, {y2}],");
            }
            //for (int an = y1; an <= y2; an++)
            //    if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
            //        k++;
            k=aniibisectii(y2) - aniibisectii(y1 - 1);

            Console.WriteLine($"Numarul anilor bisecti intre {y1} si {y2} este: {k}.");
        }
        static int aniibisectii(int y)
        {
           if (y >= 0)
           {
                return y / 4 - y / 100 + y / 400;
           }
           else
           {
                y = -y - 1;
                return -(y / 4 - y / 100 + y / 400);
           }
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
                }
            }
        }
    }
}