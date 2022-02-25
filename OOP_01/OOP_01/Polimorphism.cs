using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
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
        public Urun(string uAd,double uFiyat)
        {
            UrunAdi = uAd;
            Fiyat = uFiyat;
        }

        


    }
    class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public short Beden { get; set; }
        public string UreticiFirma { get; set; }

        public Tekstil(string tAd,double tFiyat, string tKumasTuru, short tBeden)
        {
            UrunAdi = tAd;
            Fiyat = tFiyat;
            KumasTuru = tKumasTuru;
            Beden = tBeden;

        }
    }
    class CepTelefonu : Urun
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
    class Ekmek : Urun
    {
        public string EkmekTuru { get; set; }
        public double Gramaj { get; set; }
        public Ekmek(string eAd,double eFiyat,string eEkmekTuru, double eGramaj)
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
    class Sepet
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
    public partial class Polimorphism : Form
    {
        public Polimorphism()
        {
            InitializeComponent();
        }

        private void Polimorphism_Load(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            Ekmek ekmek = new Ekmek("Uno",10,"Tava",220);
            Tekstil tekstil1 = new Tekstil("Pantolon", 135, "Keten", 42);
            Tekstil tekstil2 = new Tekstil("Hırka", 195, "İpek", 46);
            CepTelefonu cepTelefonu = new CepTelefonu("Galaxy", 4900, "Samsung");
            sepet.Ekle(ekmek);
            sepet.Ekle(tekstil1);
            sepet.Ekle(tekstil2);
            sepet.Ekle(cepTelefonu);

            MessageBox.Show($"sepette toplam tutar:{sepet.ToplamTutar().ToString()}");
        }
    }
}
