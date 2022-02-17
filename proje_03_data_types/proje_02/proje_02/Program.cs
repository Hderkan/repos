using System;

namespace proje_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //[veriTipi] [isim] ;
            //[veriTipi] [isim] = [ilk deger]
            string adSoyad;
            int yas = 30;
            adSoyad = "hakan derkan";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("yaşım =" + " " +yas);
            int hour = DateTime.Now.Hour;
            int year = DateTime.Today.Year;
            Console.WriteLine(year + " " + hour);
            Console.WriteLine("merhaba " + adSoyad + " günün güzel gecsin");
            Console.WriteLine($"Merhaba {adSoyad}, günün güel gecsin.");
            
            
            
            
            
            Console.ReadLine();



        }
    }
}

