using System;

namespace if_soru_01
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.Write("1 inci ürün fiyatı :");
            int urun_fiyat1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 inci ürün fiyat :");
            int urun_fiyat2 = Convert.ToInt32(Console.ReadLine());
            int kargo_bedel = 25;
            int kargo_bedel_indirim = 0;
            double urun22 = urun_fiyat2;
            double urun1 = urun_fiyat1 ;
            double urun2_indirim = urun_fiyat2 * 0.65;
 
            double toplam = urun1 + urun22;
                  if(toplam >= 250)

                Console.WriteLine($"birinci ürün fiyatı : {urun1}, ikinci ürün fiyatı: {urun22}, genel tutar: {urun1+urun22}, kargo bedeli : {kargo_bedel_indirim}, indirimli tutar : {urun2_indirim+ urun1}");
           
                 else
                Console.WriteLine($"birinci ürün fiyatı : {urun1}, ikinci ürün fiyatı: {urun22}, genel tutar: {urun1 + urun22+kargo_bedel}, kargo bedeli : {kargo_bedel}, indirimli tutar : {urun1 + urun22+kargo_bedel}");
                   

            Console.ReadLine();



            // Console.WriteLine($"toplam ücret  {urun1_fiyat + urun_indirim} dır");


            //          else
            //        {
            //                Console.WriteLine($"toplam cret {urun1_fiyat + urun2_fiyat}");

            // }


            Console.ReadLine();
        }
    }
}
//bir rencinin not ortalaması 60 zeri ise basarılı değilse basarısız , öğrenci ortalaması vize final notlarından vize %0 ile f
//inal 
//  %60 toplanıyor. bu duruma göre vize ve final notları klavyeden girilen
//  not ortalamsı ve baarı durumunu azdıran. program
//bir mağzadan alınan rünn fiyatı 100 liradan byk ve eitse 5 lira olan kargo creti alınmamaktadır . ürnün fiyatı girildiğinde tolam 
//ödenmesi gereken creti yazdıran program nedir.
// klavyeden girilicek 2 ürün fiyatı 200 lira ve üerinde ise ikinci üründen yüzde 30 indirim
// yapılması gerekmektedir buna göre 2 ürün fiyatı girdiren ve gerekli hesaplama yapıp tutarı gösteren program.

//1inci soruya devam ; birde vize ve final notları dıında devamsızlık giriliyor ayrıca öğrencilerin devamsızlık sınırı 0 gündür
//vize ve final notları ile devam sılık yaptığı gün sayısı klavyeden girilen öğrencinin not durumunu ve devam szlığı kalı kalmadığı
//int a = 10;
//int b = 20
    //if(a>5 && 









