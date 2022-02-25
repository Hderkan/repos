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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Kisi
        {
            string ad; //fild and private
            string soyad;
            string yas;

            public string Ad
            {
                get
                {
                    return ad;

                }
                set
                {
                    ad = value.ToUpper();
                }
            }

            public string Soyad
            {
                get
                {
                    return soyad;

                }
                set
                {
                    soyad = value.ToUpper();
                }
            }

        }

        class Personel
        {
            string adSoyad;
            int yas;
            public string AdSoyad { get; set; }
            public int Yas { get; set; }

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Kisi ogrenci1 = new Kisi();
            ogrenci1.Ad = "Osman";
            ogrenci1.Soyad = "Can";
            MessageBox.Show(ogrenci1.Ad + " " + ogrenci1.Soyad);
            Personel personel1 = new Personel();
            personel1.AdSoyad = "Kemalettin aca";
            personel1.Yas = 66;
            MessageBox.Show(personel1.AdSoyad + ", " + personel1.Yas + "Yasındasınız");
            Araba araba = new Araba();
            araba.Marka = "Opel";
            araba.ModelYili = 1977;
            MessageBox.Show(araba.Marka +" " + araba.ModelYili);
            ogrenci ogrenci10 = new ogrenci();
            ogrenci10.AdSoyad = "muhteren sevindik";
            ogrenci10.Bolum = "Degerli Taslar";
            ogrenci10.Sehir = "Madagaskar";
            ogrenci10.Yas = 25;
            ogrenci10.Ortalama = 76;
            EkranaYaz(ogrenci10);
            BuyukHrfeCevir(ogrenci10);
        }
        void EkranaYaz(ogrenci ogren)
        {
            MessageBox.Show(ogren.AdSoyad);
        }
        void BuyukHrfeCevir(ogrenci o)
        {
            o.AdSoyad = o.AdSoyad.ToUpper();
            MessageBox.Show(o.AdSoyad);
        }
        class ogrenci
        {
            public string AdSoyad { get; set; }
            public short Yas { get; set; }
            public string Bolum { get; set; }
            public string Sehir { get; set; }
            public double Ortalama { get; set; }

        }

        class Araba
        {
            public string Marka { get; set; }
            public short ModelYili { get; set; }
        }
    }
}
