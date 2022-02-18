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
    public partial class FormBolumler : Form
    {
        string sorguCumlesi;
        VeriTabani vt = new VeriTabani();
        public FormBolumler()
        {
            InitializeComponent();
        }
        void tazele()
        {
            sorguCumlesi = "select * from tblBolum";
            dgvBolumler.DataSource = vt.KayitListele(sorguCumlesi);
        }
        private void FormBolumler_Load(object sender, EventArgs e)
        {
            tazele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string ID = dgvBolumler.CurrentRow.Cells[0].Value.ToString();
            
            sorguCumlesi = $"UPDATE tblBolum Set BolumAdı= '{txtBolumAd.Text}' where ID ='{ID}'";
            vt.islem(sorguCumlesi);
            tazele();
        }

        private void dgvBolumler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBolumAd.Text = dgvBolumler.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string ID = dgvBolumler.CurrentRow.Cells[0].Value.ToString();

            sorguCumlesi = $"DELETE tblBolum where ID ='{ID}'";
            vt.islem(sorguCumlesi);
            tazele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            eklebolum form = new eklebolum();
            form.Show();
            this.Hide();
        }
    }
}
