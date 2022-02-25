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
    class Ogrenci
    {
        /// <summary>
        /// Bu constructor metodunu kullanırsan yasın varsayılan degeri 15 olucaktır.
        /// </summary>
        public Ogrenci()
        {
            yas = 15;

        }
        /// <summary>
        /// Bu overloads kullanırsan varsayılan yası sen belirlemelisin
        /// </summary>
        /// <param name="Gelenyas">Varsayılan Yası  yaz</param>
        public Ogrenci(short Gelenyas)
        {
            // this.yas
           yas = Gelenyas;
        }
        string ad;
        short yas;
        private int myVar;

        public string  Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        

        public short Yas
        {
            get { return yas; }
            set { yas = value; }
        }


    }
      class Ayakkabi
    {
        public Ayakkabi()
        {
            marka = "adidas";
            
        }
        private string marka;

        public string Marka
        {
            get { return marka; }
            
        }
        private int numara;

        public int Numara
        {
            get { return numara; }
            set { numara = value; }
        }

        private string cinsiyet;

        public string Cinsiyet
        {
            set { cinsiyet = value; }
            
        }



    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Ad = "Engin";
            //Ogrenci ogrenci2 = new Ogrenci();
            //MessageBox.Show($"Adı:{ogrenci2.Ad}\nYaşı: {ogrenci2.Yas}");
            //MessageBox.Show($"Adı:{ogrenci.Ad}\nYaşı: {ogrenci.Yas}");

            //Ogrenci ogrenci3 = new Ogrenci(17
            //    );
            //MessageBox.Show(ogrenci3.Yas.ToString());
            Ayakkabi ayakkabi1 = new Ayakkabi();
            ayakkabi1.Cinsiyet = "kadın";
            ayakkabi1.Numara = 42;
            MessageBox.Show(ayakkabi1.Marka + " " + ayakkabi1.Numara);

        }
    }
}
