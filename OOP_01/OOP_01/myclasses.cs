using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    class myclasses
    {
        public class Urun
        {
            public string UrunAdi { get; set; }
            public double Fiyat { get; set; }
            public virtual double KDVUygula()
            {
                return Fiyat * 1.1;
            }

            public Urun()
            {

            }
            public Urun(string uAd, double uFiyat)
            {
                UrunAdi = uAd;
                Fiyat = uFiyat;
            }




        }
        public class Tekstil : Urun
        {
            public string KumasTuru { get; set; }
            public short Beden { get; set; }
            public string UreticiFirma { get; set; }

            public Tekstil(string tAd, double tFiyat, string tKumasTuru, short tBeden)
            {
                UrunAdi = tAd;
                Fiyat = tFiyat;
                KumasTuru = tKumasTuru;
                Beden = tBeden;

            }
        }
        public class CepTelefonu : Urun
        {
            public string Ozellikler { get; set; }
            public string Marka { get; set; }
            public CepTelefonu(string cAd, double cFiyat, string cMarka)
            {
                UrunAdi = cAd;
                Fiyat = cFiyat;
                Marka = cMarka;
            }
        }
        public class Ekmek : Urun
        {
            public string EkmekTuru { get; set; }
            public double Gramaj { get; set; }
            public Ekmek(string eAd, double eFiyat, string eEkmekTuru, double eGramaj)
            {
                UrunAdi = eAd;
                Fiyat = eFiyat;
                EkmekTuru = eEkmekTuru;
                Gramaj = eGramaj;
            }
            public override double KDVUygula()
            {
                return Fiyat * 1.01;
            }
        }
        public class Sepet
        {
            List<Urun> urunler = new List<Urun>();
            public double ToplamTutar()
            {
                double toplamFiyat = 0;
                foreach (Urun item in urunler)
                {
                    toplamFiyat += item.KDVUygula();
                }
                return toplamFiyat;
            }
            public void Ekle(Urun yeniUrun)
            {
                urunler.Add(yeniUrun);
            }
        }
    }
}

// özel ders uygulaması
//Üc üyelik paketi olucak 1-) standar 2-) pro 3-) elite üyelik
//standart olarak her üyede olması gereken özellikler
// üye adı,soyadı,
//kullanıcı adı;
//bransı , yası (matematik,fizik, kimya, turkce)
//deneyim süresi;
// pro üyelerde olması gereken
//onaylı üye olduğunu gösteren rozet 
// ana sayfada görüntülenme
//herkese acık telefon numarası
//ders almakisteyenleri direk erismek (metot)

//elit üyelerde olması gereken özellikler 
//arama sonuclarında üstte yer alma (metot)
//Onerilme (metot)