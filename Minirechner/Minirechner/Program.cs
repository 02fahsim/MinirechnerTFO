using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Erste Zahl: ");
            int ErsteZahl = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zweite Zahl: ");
            int ZweiteZahl = Convert.ToInt32(Console.ReadLine());

            int Summe = Addiere(ErsteZahl, ZweiteZahl);
            int Differenz = Subtrahiere(ErsteZahl, ZweiteZahl);

            Console.WriteLine("\nSumme = " + Summe);
            Console.WriteLine("Differenz = " + Differenz);
            Console.ReadKey();
                
        }

        static int Addiere(int Zahl1, int Zahl2)
        {
            int Ergebnis = Zahl1 + Zahl2;
            return Ergebnis;
        }

        static int Subtrahiere(int Zahl1, int Zahl2)
        {
            int Ergebnis = Zahl1 - Zahl2;
            return Ergebnis;
        }

    }
}
