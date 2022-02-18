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

    public partial class randevu : Form
    {
        string sorguCumlesi;
        VeriTabani vt = new VeriTabani();
        public randevu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void Bolumdoldur()
        {
            cbmBolumler.DataSource = vt.KayitListele("select * from tblBolum");
            cbmBolumler.DisplayMember = "BolumAdı";
            cbmBolumler.ValueMember = "ID";
        }    
         void  Doktordoldur()
            {
                string bolumID = cbmBolumler.SelectedValue.ToString();
                string sorguCumlesi = $"Select * from tblDoktorlar where BolumID ='{bolumID}' ";
                ltbDoktorlar.DataSource = vt.KayitListele(sorguCumlesi);
                ltbDoktorlar.DisplayMember = "AdSoyad";
                ltbDoktorlar.ValueMember = "ID";
            }
        
        void    HastalariDoldur()
        {
            
            string sorguCumlesi = $"Select ID,Ad,SoyAd from tblHastalar ";
            dgvHastalar.DataSource = vt.KayitListele(sorguCumlesi);
        }
        

        private void randevu_Load(object sender, EventArgs e)
        {
            Bolumdoldur();
            Doktordoldur();
            HastalariDoldur();
        }

        private void cbmBolumler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Doktordoldur();
            }
            catch (Exception)
            {

                
            }
        }

        private void dgvHastalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtArananHasta.Text = dgvHastalar.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string bolumID = cbmBolumler.SelectedValue.ToString();
            string hastaID = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            string doktorID = ltbDoktorlar.SelectedValue.ToString();
            string tarih = dtpHasta.Text;
            string saat = dtpsaat.Text;
            

            string sorguCumlesi = $"insert into tblRandevular values ('{bolumID}','{hastaID}','{doktorID}','{tarih}','{saat}')";
            vt.islem(sorguCumlesi);
           
        }
    }
}
