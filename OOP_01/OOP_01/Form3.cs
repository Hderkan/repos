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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        class Ayakkabı
        {
            public Ayakkabı(Markalar gelenMarka)
            {
                Marka = gelenMarka;
            }
            public Ayakkabı(Markalar gelenMarka, AyakkabiTipleri gelenmarkatipi)
                
            {
                Marka = gelenMarka;
                ayakkabiTipleri = gelenmarkatipi;
            }
            public Ayakkabı(Markalar geneMarka,AyakkabiTipleri gelenMarkaTipi, MalzemeTipleri malzeme
                )
            {
                Marka = geneMarka;
                ayakkabiTipleri = gelenMarkaTipi;
                malzemeTipleri = MalzemeTipleri.Deri;
            }
            // public string Marka { get; set; }
            public Markalar Marka { get; set; }
            public AyakkabiTipleri ayakkabiTipleri { get; set; }
            public MalzemeTipleri malzemeTipleri { get; set; }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Ayakkabı a = new Ayakkabı(Markalar.Adidas);

            a.Marka = Markalar.Adidas;
            MessageBox.Show(a.Marka.ToString());

            a.ayakkabiTipleri = AyakkabiTipleri.Cizme;
            a.malzemeTipleri = MalzemeTipleri.Kumas;
            MessageBox.Show($@"Markası:{a.Marka} Ayakkabı tipi :{a.ayakkabiTipleri}  malzeme:{a.malzemeTipleri}" );
            Ayakkabı markasibelliayakkabi = new Ayakkabı(Markalar.Humel);
        }
    }
}
