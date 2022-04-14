using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // to list metodu ile bolumleri listele
            void BolumleriListele()
            {

                HastaneSabahEntities hastane = new HastaneSabahEntities();
                var bolumler = hastane.Bolumler.ToList();
                Console.WriteLine($"Bölüm ID\t  Bolum Adı");
                foreach (var bolum in bolumler)
                {

                    Console.WriteLine($"{bolum.ID}\t \t {bolum.BolumAd}");

                }
                Console.ReadLine();
            }

            //where methoduyla sorgulama; Diş bölümünü getir
            void BolumGetir()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {

                    var sonuc = hastane.Bolumler.Where(x => x.BolumAd.StartsWith("D"));
                    //var sonuc = hastane.Bolumler.Where(x => x.BolumAd == "Diş");
                    foreach (var item in sonuc)
                    {

                        Console.WriteLine($"{item.ID} Bolum Adı:{item.BolumAd}");

                    }
                    Console.ReadLine();
                }

            }
            //select ile veri cekme 
            void DoktorAdListele()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var adlar = hastane.Doktorlar.Select(x => x.AdSoyad);
                    Console.WriteLine($"Doktor Adı");
                    foreach (var doktor in adlar)
                    {
                        
                    }
                }
            }
            //BolumGetir();

            //find ile arama yapma
            void HızlıArama()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities()) 
                {
                    Doktorlar doktor = hastane.Doktorlar.Find(4);
                    //find metodu ilgili tablodaki primary key üzerinden arama yapar buda omu oldukca hızlı hale getirir.
                    Console.WriteLine($"doktor adı: {doktor.AdSoyad}: Bolum : {doktor.Bolumler.BolumAd}");
                }
            }
      
            //ilk demet evgarı getir

            void IlkKayit()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    Doktorlar doktor = hastane.Doktorlar
                        .Where(x => x.AdSoyad == "Demet Evgar")
                        .First();
                    Console.WriteLine($"Doktor Adı: {doktor.AdSoyad} bolum ad : {doktor.Bolumler.BolumAd}");
                }
                Console.ReadLine();
            }

            //IlkKayit(); 

            //void IlkUcDoktor()
            //{
            //    using (HastaneSabahEntities hastane = new HastaneSabahEntities())
            //    {
            //        var ilkuc = hastane.
            //    }
            //}
            
            //HızlıArama();
      
        //var mı?

            void VarMi()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    bool sonuc = hastane.Doktorlar.Any(x => x.AdSoyad == "Demet Evgar ");
                    if (sonuc)
                    {
                        Console.WriteLine("Aradıgınız doktor var ");
                    }
                    else
                    {
                        Console.WriteLine("Aradıgınız doktor yok");
                    }

                }
                Console.ReadLine();
            }
            //VarMi();
        
            //uygunluk var mı?

            void UyuyorMu()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    bool sonuc = hastane.Doktorlar.All(x => x.Bolumler.BolumAd == "Dahiliye");

                    if (sonuc)
                    {
                        Console.WriteLine("evet tumu uygun");
                    }
                    else
                    {
                        Console.WriteLine("hayır uygun olmayanlar var");
                    }

                }
                Console.ReadLine();
            }
            //UyuyorMu();



            //ascendig sıralama ; a dan z ye
            void SiralaAsc()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var siraliDoktorlar = hastane.Doktorlar.OrderBy(x => x.AdSoyad);
                    foreach (var doktor in siraliDoktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                }
                Console.ReadLine();
            }
            //SiralaAsc();

            //descending siralama
            void SiralaDesc()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var tersSirliDoktorlar = hastane.Doktorlar.OrderByDescending(x => x.AdSoyad);
                    foreach (var doktor in tersSirliDoktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                }
                Console.ReadLine();
            }
            //SiralaDesc();   
        //son uc doktoru getir


            void SonUcDoktor()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var sonUcdoktor = hastane.Doktorlar.OrderByDescending(x => x.ID).Take(3);
                    foreach (var doktor in sonUcdoktor)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                }
                Console.ReadLine();
            }
            //SonUcDoktor();
        
            //bolumlere gore doktor sayısı
            void BolumlereGoreDoktorSayisiniGetir()
            {
                using(HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var sonuc = hastane.Doktorlar
                        .GroupBy(a => a.Bolumler.BolumAd)
                        .Select(b => new
                        {
                            name = b.Key,
                            count = b.Count()

                        });
                    foreach (var item in sonuc)
                    {
                        Console.WriteLine($"{item.name}\t {item.count}");
                    }
                }
                Console.ReadLine();
            }
            //BolumlereGoreDoktorSayisiniGetir();


        }
        
        //BolumleriListele();
       
    }
}

