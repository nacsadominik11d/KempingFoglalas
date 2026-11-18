using System;
using System.Collections.Generic;
using System.Text;

namespace KempingFoglalas
{
    public class Foglalas
    {
        public string VendegNev { get; set; }
        
        public string ParcellaTipus { get; set; }

        public int EjszakakSzama { get; set; }

        public int FelnottFo { get; set; }

        public int GyerekFo { get; set; }

        public Foglalas(string sor)
        {
            string[] adatok = sor.Split(';');
            VendegNev = adatok[0];
            ParcellaTipus = adatok[1];
            EjszakakSzama = int.Parse(adatok[2]);
            FelnottFo = int.Parse(adatok[3]);
            GyerekFo = int.Parse(adatok[4]);
        }
        public int FizetendoDij()
        {
            int parcellaAr = 0;

            if (ParcellaTipus == "ALAP")
            {
                parcellaAr = 6000;
            }
            else if (ParcellaTipus == "KOMFORT")
            {
                parcellaAr = 9500;
            }

            int szemelyiDij = FelnottFo * 500 +
                              GyerekFo * 1500;


            int osszeg = (parcellaAr + szemelyiDij) * EjszakakSzama;


            if (EjszakakSzama >= 5)
            {
                osszeg = (int)(osszeg * 0.9);
            }
            return osszeg;
        }

        public override string ToString()
        {
            return $"{VendegNev} - ({ParcellaTipus}) : {EjszakakSzama} éjszaka , {FelnottFo} felnőtt , {GyerekFo} gyerek - Fizetendő: {FizetendoDij()} Ft";
        }
    }
}
