using System;

namespace proje_06_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayı girniz :");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi > 50)
            {
                Console.WriteLine("büyük");



            }
            else if (sayi < 50)
            {

                Console.WriteLine("küçük");
            }

            else
                {

                Console.WriteLine("esit");
            }


            Console.ReadLine();

               
                
                //true ise yapılacaklar


             
            }
        }
    } 

