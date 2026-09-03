using System;
using System.Collections.Generic;
using System.Text;

namespace Pracowniki
{
    class Program
    {
        static void Main()
        {
            List<Inzynier> inzyniers = new List<Inzynier>
    {
        new Inzynier("Andrzej", "Bielewicz", Inzynier.Skutecznosc.SLABY, 8),
        new Inzynier("Kevin", "Magnussen", Inzynier.Skutecznosc.DOBRY, 20),
        new Inzynier("Max", "Verstappen", Inzynier.Skutecznosc.WYBITNY, 6)
    };
            foreach (var inzynier in inzyniers) {
                for (int j = 1; j <= 3; j++)
                {
                    inzynier.buduj();
                }
                inzynier.pokaz();
                Console.WriteLine();
            }
           
            Inzynier.pokazGlobalneProjekty();
            Console.ReadKey();
        }
    }

}
