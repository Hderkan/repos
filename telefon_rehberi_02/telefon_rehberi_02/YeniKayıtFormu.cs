using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefon_rehberi_02
{
   
    public partial class YeniKayıtFormu : Form
    {
      
        string baglantiCumlesi = @"server = DESKTOP-8M7D7GE\SQLEXPRESS; Database =sRehber; User=sa;Pwd=123";
        string sorguCumlesi;
        SqlCommand komut;
        



        SqlConnection baglanti;
        public YeniKayıtFormu()
        {
            InitializeComponent();
        }
       
        void kayit()
        {
            try
            {
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string Cinsiyet = cmbCinsiyet.Text == "Erkek" ? "E" : "K";



                string tel = txtTel.Text;

                sorguCumlesi = $"INSERT INTO tblKisiler VALUES ('{ad}','{soyad}','{Cinsiyet}','{tel}')";
                baglanti = new SqlConnection(baglantiCumlesi);
                komut = new SqlCommand(sorguCumlesi, baglanti);


                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("Kayıt basarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("bir hata olustu");
                throw;
            }
        }
        void Temizle()
        {
            txtAd.ResetText();
            txtSoyad.ResetText();
            cmbCinsiyet.SelectedIndex = 0;
            txtTel.ResetText();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Hide();
        }

        private void YeniKayıtFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kayit();
        }

        private void YeniKayıtFormu_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.SelectedIndex = 0;
        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
