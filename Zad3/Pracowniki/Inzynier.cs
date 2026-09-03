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
            if (liczbaProjektow < 0)
            {
                liczbaProjektow = 0;
            }
            this.liczbaProjektow = liczbaProjektow;
   
            wszystkieProjektyFirmy += liczbaProjektow;
        }
        public void awansuj()
        {
            if (liczbaProjektow >= 10 && skutecznosc == Skutecznosc.SLABY)
            {
                skutecznosc = Skutecznosc.DOBRY;
            }
            else if (liczbaProjektow >= 20 && skutecznosc == Skutecznosc.DOBRY)
            {
                skutecznosc = Skutecznosc.WYBITNY;
            }
        }

        public void buduj()
        {
            int projekty = (int)skutecznosc;

            Console.WriteLine(imie + " " + nazwisko + " buduje " + projekty + " projekty.");

            liczbaProjektow += projekty;
            wszystkieProjektyFirmy += projekty;
            awansuj();
        }

        

        public void pokaz()
        {
            Console.WriteLine(imie + " " + nazwisko + " ma " + liczbaProjektow + " zrealizowanych projektów.Status: " + skutecznosc);
        }

        public static void pokazGlobalneProjekty()
        {
            Console.WriteLine("Cała firma zrealizowała: " +
                              wszystkieProjektyFirmy + " projektów." );
        }
    }
}
