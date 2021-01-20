using System;

namespace Meyveintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Meyve meyve1 = new Meyve();
            meyve1.MeyveAdi = "Muz";
            meyve1.UretimYeri = "Anamur";
            meyve1.KgFiyati = 10;

            Meyve meyve2 = new Meyve();
            meyve2.MeyveAdi = "elma";
            meyve2.UretimYeri = "Isparta";
            meyve2.KgFiyati = 5;

            Meyve meyve3 = new Meyve();
            meyve3.MeyveAdi = "Portakal";
            meyve3.UretimYeri = "Antalya";
            meyve3.KgFiyati = 5;

            Meyve[] meyveler = new Meyve[]
            {
                meyve1, meyve2, meyve3
            };
            foreach(var meyve in meyveler)
            {
                Console.WriteLine(meyve.MeyveAdi + ":" + meyve.UretimYeri);
            }
            for (int i = 0; i < meyveler.Length; i++)
            {
                Console.WriteLine(meyveler[i].MeyveAdi);
            }
            int j = 0;
            while (j<meyveler.Length)
            {
                Console.WriteLine(meyveler[j].MeyveAdi);
                j++;
            }
        }
    }
    class Meyve
    {
        public string MeyveAdi { get; set; }

        public string UretimYeri { get; set; }

        public int KgFiyati { get; set; }
    }
}
