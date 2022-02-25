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
    public partial class Form4 : Form
    {
        class Insanlar
        {
            public string AdSoyad { get; set; }
            public short Boy { get; set; }
            public double Kilo { get; set; }

        }
        class Ogrenciler : Insanlar
        {
            public string OgrNo { get; set; }
            public string IkametIl { get; set; }

        }
        class BauOgrenciler : Ogrenciler
        {
            public string Bolum { get; set; }
            public string Cinsiyet { get; set; }

        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Insanlar insan1 = new Insanlar();
            Ogrenciler ogrenci1 = new Ogrenciler();
            
        }
    }
}
