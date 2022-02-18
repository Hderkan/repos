using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace withClasssql_2_Crud
{
    public partial class FormYeniKayit : Form
    {
        string sorguCumlesi;
        VeriTabani vt = new VeriTabani();
        public FormYeniKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text == "Kadın" ? "K" : "E";
            sorguCumlesi = $"INSERT INTO tblHastalar values('{txtTc.Text}', '{txtAd.Text}', '{txtSoyad.Text}', '{cinsiyet}','{txtAdres.Text}','{txtTel.Text}','{txtMail.Text}')";
            vt.islem(sorguCumlesi);
            temizle();
        }
        void temizle()
        {
            txtAd.ResetText();
            txtSoyad.ResetText();
            cmbCinsiyet.Text = "";
            txtTc.ResetText();
            txtMail.ResetText();
            txtTel.ResetText();
            txtAdres.ResetText();
        }

        private void FormYeniKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormHastalar anaForm = new FormHastalar();
            anaForm.Show();
            this.Hide();
        }
    }
}
