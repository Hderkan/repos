using System;

namespace proje_05_convert_type
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("isim griniz:");
            //string ad = Console.ReadLine();
            // Console.WriteLine($"merhaba {ad}, hosgeldin.");

            //Console.Write("bir sayı girini:");
            //int sayi = Convert.ToInt32( Console.ReadLine()) ;
            //Console.WriteLine($"seçtiginiz sayı {sayi} dir");
            Console.Write("lutfen 1. sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("lutfen 2. sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"sayıların toplamı eittir: {sayi1 + sayi2}");
            Console.ReadLine();

            // byte b = 15;
          //  short s = b;

            //short s1 = 255;
            //byte b1 = (byte)s1;     // shor 2 bitlik bellek byte 1 dönstrmesin
            //onsole.WriteLine($"s-short: {s1} ===>  b-byte : {b1}");
            Console.ReadLine();
            Console.Write("1.kenarın uunluunu giriniz:");
            int kenar1 = int.Parse(Console.ReadLine());
            Console.Write("2.kenarın uunluunu giriniz:");
            int kenar2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"girdğimi degerlere göre alan = {kenar1 * kenar2} dir");

Console.ReadLine();

        }
    }
}
