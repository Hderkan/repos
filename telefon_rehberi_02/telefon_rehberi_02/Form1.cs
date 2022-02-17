using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefon_rehberi_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniKayıtFormu yeniKayıtFormu = new YeniKayıtFormu();
            yeniKayıtFormu.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCıkıs.PerformClick();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            ListeFormu liste = new ListeFormu();
            liste.Show();
            this.Hide();
        }
    }
}
