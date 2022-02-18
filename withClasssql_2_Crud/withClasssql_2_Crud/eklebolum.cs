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
    public partial class eklebolum : Form
    {
        VeriTabani vt = new VeriTabani();
        string sorguCumlesi;

        public eklebolum()
        {
            InitializeComponent();
        }
        void tazele()
        {
            sorguCumlesi = "select * from tblBolum";
            dgvBolumler.DataSource = vt.KayitListele(sorguCumlesi);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            

            sorguCumlesi = $"insert into tblBolum values ('{txtEkle.Text}')";
            vt.islem(sorguCumlesi);
            tazele();
        }

        private void eklebolum_Load(object sender, EventArgs e)
        {
            tazele();
        }
    }
}
