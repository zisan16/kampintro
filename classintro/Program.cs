using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin";
            kurs1.izlenmeOrani = 80;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "php";
            kurs2.Egitmen = "zişan";
            kurs2.izlenmeOrani = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "vahide";
            kurs3.izlenmeOrani = 100;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "c++";
            kurs4.Egitmen = "şerife";
            kurs4.izlenmeOrani = 80;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4};
            foreach(Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }
            for(int i=0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].KursAdi + "." + kurslar[i].Egitmen);
            }
            int j = 0;
            while(j<kurslar.Length)
            {
                Console.WriteLine(kurslar[j].KursAdi + "," + kurslar[j].Egitmen);
                j++;
            }


        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int izlenmeOrani { get; set; }
    }
}
