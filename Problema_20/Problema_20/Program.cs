using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Programul afiseaza o fractie m/n in format zecimal.");
        Console.WriteLine("Introduceti numaratorul (m):");
        int m = Citire("m");
        Console.WriteLine("Introduceti numitorul (n):");
        int n = Citire("n");
        if (n == 0)
        {
            Console.WriteLine("Numitorul nu poate fi zero! Introduceti alta valoare pentru numitor.");
            n = Citire("n");
        }
        int cmmdc = CMMDC(Math.Abs(m), Math.Abs(n));
        int numarator, numitor;
        // numerele simplificate <=> fractia m/n ireductibila
        if (cmmdc != 1)
        {
            numarator = m / cmmdc;
            numitor = n / cmmdc;
            Console.WriteLine($"Fractia a fost simplificata la {numarator}/{numitor}.");
        }
        else
        {
            numarator = m;
            numitor = n;
        }
        Console.WriteLine($"Fractia data in format zecimal este: ");
        //semnul fractiei
        if ((numarator < 0 && numitor > 0) || (numarator > 0 && numitor < 0))
            Console.Write("-");
        numarator = Math.Abs(numarator);
        numitor = Math.Abs(numitor);

        int ParteaIntreaga, ParteaFractionala;
        ParteaIntreaga = numarator / numitor;
        ParteaFractionala = numarator % numitor;
        Console.Write($"{ParteaIntreaga}");
        if(ParteaFractionala==0)
        {
            Console.WriteLine();
            Console.WriteLine($"Fractia {numarator*cmmdc}/{numitor*cmmdc} reprezinta o impartire exacta.");
            return;
        }
        Console.Write(",");
        int cifra, rest;
        List<int> resturi = new List<int>();
        List<int> cifre = new List<int>();
        resturi.Add(ParteaFractionala);
        bool periodic = false;
        do
        {
            cifra = ParteaFractionala * 10 / numitor;
            cifre.Add(cifra);
            rest = ParteaFractionala * 10 % numitor;
            if(!resturi.Contains(rest))
            {
                resturi.Add(rest);
            }
            else
            {
                periodic = true;
                break;
            }
            ParteaFractionala = rest;
        } while (rest != 0);

        if (!periodic)
        {
            foreach (var item in cifre)
            { 
                Console.Write(item);
            }
            Console.WriteLine();
        }
        else
        {
            for(int i=0;i<resturi.Count;i++)
            {
                if (resturi[i] == rest)
                {
                    Console.Write("(");
                }
                    
                Console.Write(cifre[i]);
            }
            Console.WriteLine(")");
        }
        
        DeterminareTipFractie(numitor);
    }
    private static int Citire(string x)
    {
        while (true)
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Input invalid. Introduceti un numar intreg.");
                return Citire(x);
            }
        }
    }
    static int CMMDC(int a, int b)
    {
        int r=a%b;
        while(r!=0)
        {
            a = b;
            b = r;
            r = a % b;
        }
        return b;
    }
    
    static void DeterminareTipFractie(int numitor)
    {
        int copieNumitor = numitor;
        while (numitor % 2 == 0)
            numitor /= 2;
        while (numitor % 5 == 0)
            numitor /= 5;
        if (numitor == 1)
            Console.WriteLine("Fractia este neperiodica.");
        else
        {
            if (copieNumitor == numitor)
                Console.WriteLine("Fractia este periodica simpla (numitorul nu se divide cu 2 sau 5).");
            else
                Console.WriteLine("Fractia este periodica mixta (numitorul se divide cu 2 si/sau 5, dar mai raman si alti factori primi).");
        }
    }
}