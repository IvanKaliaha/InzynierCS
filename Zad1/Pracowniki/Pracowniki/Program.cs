using System;
using System.Collections.Generic;
using System.Text;

namespace Pracowniki
{
    class Program
    {
        static void Main()
        {
            Inzynier Julia = new Inzynier("Julia", "Kowalska", Inzynier.Skutecznosc.Slaby, 3);
            Inzynier Wiktor = new Inzynier("Wiktor", "Kowalski", Inzynier.Skutecznosc.DOBRY, 4);
            Inzynier Pawel = new Inzynier("Pawel", "Omarski", Inzynier.Skutecznosc.WYBITNY, 5);
            Julia.buduj();
            Julia.pokaz();
            Pawel.buduj();
            Pawel.pokaz();
            Wiktor.buduj();
            Wiktor.pokaz();
            Inzynier.pokazGlobalneProjekty();
            Console.ReadKey();
        }
    }

}
