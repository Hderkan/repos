using System;

namespace proje_03_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------VERİ TİPLERİ-----------------");
            Console.WriteLine("A) Tamsayılar");
            Console.WriteLine("a) isaretsiz tam sayılar ");
            Console.WriteLine("1) byte");
            Console.WriteLine($"minimum deger : {byte.MinValue}");
            Console.WriteLine($"maximum deger : {byte.MaxValue}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(byte)} byte");


            //canelCase ad, adSoyad , iseGirisTarihi 
            //en cok degosenlerde kullanılır
            // PascalCase  
            // Ad, AdSoyad , IseGirisTarihi
            //  (degisken)



            //Console.ReadLine();





            Console.WriteLine("2) ushort:");
            Console.WriteLine($"minimum deger : {ushort.MinValue}");
            Console.WriteLine($"maximum deger : {ushort.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(ushort)} byte");
            //Console.ReadLine();


            Console.WriteLine("2) uint:");
            Console.WriteLine($"minimum deger : {uint.MinValue}");
            Console.WriteLine($"maximum deger : {uint.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(uint)} byte");
            //Console.ReadLine();


            Console.WriteLine("2) ulong:");
            Console.WriteLine($"minimum deger : {ulong.MinValue}");
            Console.WriteLine($"maximum deger : {ulong.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(ulong)} byte");
            
            //Console.ReadLine();
          
            Console.WriteLine("b) isaretli tam sayılar ");


            Console.WriteLine("1) sbyte:");
            Console.WriteLine($"minimum deger : {sbyte.MinValue}");
            Console.WriteLine($"maximum deger : {sbyte.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(sbyte)} byte");

            //Console.ReadLine();

            Console.WriteLine("1) sbyte:");
            Console.WriteLine($"minimum deger : {short.MinValue}");
            Console.WriteLine($"maximum deger : {short.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(sbyte)} byte");

            //Console.ReadLine();


            Console.WriteLine("1) short:");
            Console.WriteLine($"minimum deger : {short.MinValue}");
            Console.WriteLine($"maximum deger : {short.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(short)} byte");

            //Console.ReadLine();


            Console.WriteLine("1) long:");
            Console.WriteLine($"minimum deger : {long.MinValue}");
            Console.WriteLine($"maximum deger : {long.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(long)} byte");

            //Console.ReadLine();




            Console.WriteLine("1) sbyte:");
            Console.WriteLine($"minimum deger : {int.MinValue}");
            Console.WriteLine($"maximum deger : {int.MaxValue:0,00}");
            //Console.WriteLine($"bellekteki boyutu: {sizeof(int)} byte");

            //Console.ReadLine();

            Console.WriteLine("b) ondalık sayılar ");

            Console.WriteLine("1) float:");
            Console.WriteLine($"minimum deger : {float.MinValue}");
            Console.WriteLine($"maximum deger : {float.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyutu: {sizeof(float)} byte");

            Console.ReadLine();
            //double
            //decimal


            Console.WriteLine("c)double:");
            Console.WriteLine($"minimum deger:{double.MinValue:0,00}");
            Console.WriteLine($"maximum deger:{double.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyut : {sizeof(double)} byte");

            Console.ReadLine();

            Console.WriteLine("d)decimal:");
            Console.WriteLine($"minimum deger:{decimal.MinValue:0,00}");
            Console.WriteLine($"maximum deger:{decimal.MaxValue:0,00}");
            Console.WriteLine($"bellekteki boyut : {sizeof(decimal)} byte");

            Console.ReadLine();

            Console.WriteLine("D) karakter(char) veri tipi");
            Console.WriteLine("a) char ");
            Console.WriteLine($"mininmum degeri: {(int)char.MaxValue}");
            Console.WriteLine($"maximum degeri: {(int)char.MinValue}");

            Console.ReadLine();

            Console.WriteLine("e) mantıksal (bool)");
            Console.WriteLine("a) bool ");
            Console.WriteLine($"mininmum degeri: {true}");
            Console.WriteLine($"mininmum degeri: {false}");
            Console.WriteLine($"boyut: {sizeof(bool)}");

            Console.WriteLine("e) tarh veri tipi");
            Console.WriteLine("a) DateTime ");
            Console.WriteLine($"mininmum degeri: {DateTime.MinValue}");
            Console.WriteLine($"maimum degeri: {DateTime.MaxValue}");
           
            unsafe
            {
                Console.WriteLine($"boyut: {(DateTime)} byte");
            }
            Console.ReadLine();



        }
    }
}
