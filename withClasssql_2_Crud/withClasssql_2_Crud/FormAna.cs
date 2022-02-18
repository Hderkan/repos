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

namespace withClasssql_2_Crud
{
    public partial class FormAna : Form
    {
        string sorguCumlesi;
        
        VeriTabani vt = new VeriTabani();
        public FormAna()
        {
            InitializeComponent();
        }
        //void Doldur()
        //{
        //    sorguCumlesi = " select * from  tblHastalar";

        //    dgvHastalar.DataSource = vt.KayitListele(sorguCumlesi);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
           // Doldur();
        }

        //private void btnYeniKayıt_Click(object sender, EventArgs e)
        //{
        //    //FormYeniKayit frmYeni = new FormYeniKayit();
        //    //frmYeni.Show();
        //    //this.Hide();
        //}

        private void FormAna_Activated(object sender, EventArgs e)
        {
            //Doldur();
        }

        private void FormAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void btnHastalar_Click(object sender, EventArgs e)
        {
            FormHastalar liste = new FormHastalar();
            liste.Show();
            this.Hide();
        }

        private void tblBolumler_Click(object sender, EventArgs e)
        {
            FormBolumler formBolumler = new FormBolumler();
            formBolumler.Show();
            this.Hide();
        }
    }
}
