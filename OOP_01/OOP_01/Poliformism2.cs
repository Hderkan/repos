using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_01.myclasses;

namespace OOP_01
{
    public partial class Poliformism2 : Form
    {
        Sepet sepet = new Sepet();
        public Poliformism2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Tekstil tekstil = new Tekstil("Gömlek",300,"ipek",3);
            sepet.Ekle(tekstil);
            dgvSepet.Rows.Add(tekstil.UrunAdi,tekstil.Fiyat,tekstil.KDVUygula());
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CepTelefonu cepTelefonu = new CepTelefonu("İphone",20000,"Apple");
            sepet.Ekle(cepTelefonu);
            dgvSepet.Rows.Add(cepTelefonu.UrunAdi, cepTelefonu.Fiyat,cepTelefonu.KDVUygula() ,cepTelefonu.Marka);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ekmek ekmek = new Ekmek("Uno",100,"Kepekli",400);
            sepet.Ekle(ekmek);
            dgvSepet.Rows.Add(ekmek.UrunAdi, ekmek.Fiyat,ekmek.KDVUygula(), ekmek.EkmekTuru);
        }
    }
}
