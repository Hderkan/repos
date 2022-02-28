using PersonelTakip.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class FormAna : Form
    {
        CalisanDAL calisanDAL = new CalisanDAL();
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll("where Durumu ='Aktif'");
        }
        void clearTOOLS()
        {
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.GetType() != typeof(Label)) //sıradaki kontrol label degilse
                {
                    control.Text = string.Empty;
                }
                // buraya nasıl kod yazılmalı ki datetimepickerlarda temizlensin
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clearTOOLS();
        }
    }
}
