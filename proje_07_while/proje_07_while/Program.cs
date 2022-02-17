/*using System;

namespace proje_07_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            int toplam = 0;

            while (sayac<=5)
            {
                Console.WriteLine(sayac);
                toplam = toplam += sayac;

                sayac++;

            }
            Console.WriteLine($"toplam: {toplam}");


            Console.ReadLine();
        }
                
    }*/
//} 

//klavyeden eit yazana kadar 
/*using System;

namespace proje_07_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input != "exit")
            {
                Console.WriteLine("hello world");
                input = Console.ReadLine();
                

            }

            Console.ReadLine();
        }
    }
}*/



/*using System;

namespace proje_07_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string girilecek;
            do
            {
                Console.WriteLine("hello world");
                girilecek = Console.ReadLine();

            }
            while (girilecek != "exit");
            {
                


            }

            Console.ReadLine();
        }
    }
}*/

/*using System;

namespace proje_07_while
{
    class Program
    {
        static void Main(string[] args)
        {

            string KullanıcıAdı = "";
            int sifre = 0;
            do
            {
                Console.Write($"kullanıcı girişi ");
                KullanıcıAdı = Console.ReadLine();
                Console.Write($"sifre giriniz");
                sifre = int.Parse(Console.ReadLine());
                Console.Clear();



            }
            while (KullanıcıAdı == "admin" && sifre == 1234);

            Console.WriteLine($"kullanıcı girisi basarılı");
        }
    }
}*/

//klavyeden sayı girisi yapılmasını sağlayan ve girilen sayıların toplamı
//1000 gecene kadar sayı girilmesi devm eden ve sonra toplamı 1000 geçene kadar yada 10 adet sa
//yı girilene kadar v sonra toplamı ve girilen sayı adedini ekrana yazan program
//
using System;

namespace proje_07_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int toplam = 0;
            int adet = 0;
            do
            {
                adet++;
                Console.WriteLine($"{adet}. sayı giriniz:");
                sayi = int.Parse(Console.ReadLine());
                toplam += sayi;
            } while (adet < 5 && toplam <= 100);
            Console.WriteLine($"toplam : {toplam}");
            Console.WriteLine($"sayı adedi : {adet}");
            Console.ReadLine();
        }
    }
}



