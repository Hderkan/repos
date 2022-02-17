using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace telefon_rehberi_02
{
    public partial class ListeFormu : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        SqlCommand komut;
        DataTable dt;
        string baglantiCumlesi = @"server = DESKTOP-8M7D7GE\SQLEXPRESS; Database =sRehber; User=sa;Pwd=123";
        string sorguCumlesi;
        public ListeFormu()
        {
            InitializeComponent();
        }
        void Aktar()
        {
            lblID.Text = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            if (dgvKisiler.CurrentRow.Cells[3].Value.ToString() == "K")
            {
                cmbCinsiye.Text = "Kadın";
            }
            else
            {
                cmbCinsiye.Text = "Erkek";
            }
            txtTel.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();
        }  
        private void ListeFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 anaform = new Form1();
            anaform.Show();
        }
        void KisileriGetir()
        {
            sorguCumlesi = "SELECT * FROM tblKisiler";
            baglanti = new SqlConnection (baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;
        }
        
        private void dgvKisiler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //KisileriGetir();
        }
        void duzelt()
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            char cinsiyet;
            if (cmbCinsiye.Text == "Kadın")
            {
                cinsiyet = 'K';
            }
            else
            {
                cinsiyet = 'E';

            }
            string tel = txtTel.Text;
            string ID = lblID.Text;
            sorguCumlesi = $"update tblKisiler SET Ad ='{ad}' , Soyad ='{soyad}', Cinsiyet='{cinsiyet}', Telefon ='{tel}' where ID ='{ID}'";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir();
        }
        void Sil()
        {
            string id = lblID.Text;
            sorguCumlesi = $"delete from tblKisiler where ID = {id}";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir();
        }
        private void ListeFormu_Load(object sender, EventArgs e)
        {
            KisileriGetir();
        }

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            duzelt();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }
    }
}
