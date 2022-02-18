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
    public partial class FormHastalar : Form
    {
        string sorguCumlesi;

        VeriTabani vt = new VeriTabani();
        public FormHastalar()
        {
            InitializeComponent();
        }
        public void aktar()
        {
            txtTc.Text = dgvHastalar.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dgvHastalar.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dgvHastalar.CurrentRow.Cells[3].Value.ToString();
            if (dgvHastalar.CurrentRow.Cells[4].Value.ToString() == "K")
            {
                cmbCinsiyet.Text = "Kadın";
            }
            else
            {
                cmbCinsiyet.Text = "Erkek";
            }
            txtAdres.Text = dgvHastalar.CurrentRow.Cells[5].Value.ToString();
            txtTel.Text = dgvHastalar.CurrentRow.Cells[6].Value.ToString();
            txtMail.Text = dgvHastalar.CurrentRow.Cells[7].Value.ToString();
        }

        private void Liste_Load(object sender, EventArgs e)
        {
            sorguCumlesi = "select * from tblHastalar";

            dgvHastalar.DataSource = vt.KayitListele(sorguCumlesi);
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            string ID = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            string cinsiyet = cmbCinsiyet.Text == "Kadın" ? "K" : "E";
            sorguCumlesi = $"UPDATE tblHastalar SET TcNo='{txtTc.Text}',Ad='{txtAd.Text}',SoyAd ='{txtSoyad.Text}', Cinsiyet ='{cinsiyet}',Adres ='{txtAdres.Text}',Telefon ='{txtTel.Text}',mail='{txtMail.Text}' where ID ='{ID}'";
            vt.islem(sorguCumlesi);
            dgvHastalar.DataSource = vt.KayitListele(sorguCumlesi);
            
            Doldur();
            temizle();
        }

        private void dgvHastalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            aktar();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string ID = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"Delete tblHastalar where ID ={ID}";
            vt.islem(sorguCumlesi);
            dgvHastalar.DataSource = vt.KayitListele(sorguCumlesi);
            
            Doldur();
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
        void Doldur()
        {
            sorguCumlesi = " select * from  tblHastalar";

            dgvHastalar.DataSource = vt.KayitListele(sorguCumlesi);
        }
        private void Liste_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna form = new FormAna();
            form.Show();
            this.Hide();
        }

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            FormYeniKayit frmYeni = new FormYeniKayit();
            frmYeni.Show();
            this.Hide();
        }
    }
}
