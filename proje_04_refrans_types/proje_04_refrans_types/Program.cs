using System;

namespace proje_04_refrans_types
{
    class Program
    {
        class Kisi
        {
            public string Ad { get; set; }
            public int yas { get; set; }

        }

        static void Main(string[] args)
        {
            Kisi person1 = new Kisi();
            person1.Ad = "mehmet";
            person1.yas = 47;
           

            Console.WriteLine($"{person1.Ad  }, sen {person1.yas} yasındasın.");
            Kisi person2 = new Kisi();
            person2.Ad = "sıla";
            person2.yas = 32;

            Console.WriteLine($"{person2.Ad}, sen {person2.yas} yasındasın");

            person2 = person1;

            Console.WriteLine($"{person1.Ad  }, sen {person1.yas} yasındasın.");
            Console.WriteLine($"{person2.Ad  }, sen {person2.yas} yasındasın.");



            Console.ReadLine();





            Console.ReadLine();
            
            
            Console.ReadLine();


        }
    
    }
} 
