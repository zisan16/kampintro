using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirme ve yetiştirme kursu";
            string kurs2 = "başlangıç seviyesi";
            string kurs3 = "java kursu";

            string[] kurslar = new string[] { "yazılım geliştirme ve yetiştirme kursu", "başlangıç seviyesi", "java kursu", "python kursu" };

            for(int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            //dizileri tek tek dolaşmaya yarıyor foreach
            foreach(string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            int j = 0;
            while(j<kurslar.Length)
            {
                Console.WriteLine(kurslar[j]);
                j++;
            }
        }
    }
}
