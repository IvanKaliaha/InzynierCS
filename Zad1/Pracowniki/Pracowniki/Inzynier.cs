using System;
using System.Collections.Generic;
using System.Text;

namespace Pracowniki
{
    public class Inzynier
    {
       public enum Skutecznosc
        {
         SLABY = 1,
         DOBRY = 2,
         WYBITNY = 3


        }
        public static int wszystkieProjektyFirmy;
        public string imie;
        public string nazwisko;
        public Skutecznosc skutecznosc;
        public int liczbaProjektow;

        public Inzynier(string imie, string nazwisko, Skutecznosc skutecznosc, int liczbaProjektow)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.skutecznosc = skutecznosc;
            this.liczbaProjektow = liczbaProjektow;
        }

        public void buduj()
        {
            int projekty = (int)skutecznosc;

            Console.WriteLine(imie + " " + nazwisko + " buduje " + projekty + " projekty.");

            liczbaProjektow += projekty;
            wszystkieProjektyFirmy += projekty;
        }

        public void pokaz()
        {
            Console.WriteLine(imie + " " + nazwisko + " ma " + liczbaProjektow + " zrealizowanych projektów.");
        }

        public static void pokazGlobalneProjekty()
        {
            Console.WriteLine("Cała firma zrealizowała: " +
                              wszystkieProjektyFirmy + " projektów.");
        }
    }
}
