using System;

namespace Degervereferanstipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

            int a = 12;
            int b = 24;
            var item = Topla(ref a, b);
            Console.WriteLine(item);
            Console.WriteLine(a);
        }
        static int Topla(ref int a, int b)
        {
            a = 32;
            var item = a + b;
            return item;
        }
    }
}
