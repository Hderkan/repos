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

namespace KutuphaneProjesi
{
    public partial class FormKutuphane : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormKutuphane()
        {
            InitializeComponent();
        }
        void OduncRefresh()
        {
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;

        }
        void aktar()
        {
            int aranan = Convert.ToInt32(dgvOdunc.SelectedRows[0].Cells[1].Value.ToString());
            foreach (DataGridViewRow satir in dgvUye.Rows)
            {
                DataGridViewCell hucre = satir.Cells[0];
                if(Convert.ToInt32(hucre.Value.ToString())== aranan)
                {
                    satir.Selected = true;
                    break;
                }
            }

            int arananKitap = Convert.ToInt32(dgvOdunc.CurrentRow.Cells[2].Value.ToString());
            foreach (DataGridViewRow satir in dgvKitap.Rows)
            {
                DataGridViewCell hucre = satir.Cells[0];
                if (Convert.ToInt32(hucre.Value.ToString()) == arananKitap)
                {
                    satir.Selected = true;
                    break;
                }
            }




           
        }

        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;
            vt.Islem(1);
            //Uye
            vt.TableName = "tblUyeler";
            vt.Islem();
            dgvUye.DataSource = vt.dt;

            for (int i = 2; i < dgvUye.Columns.Count ; i++)
            {
                dgvUye.Columns[0].Width = 20;
                dgvUye.Columns[i].Visible = false;
            }
            dgvUye.Columns[1].Visible = true;

            vt.TableName = "tblKitaplar";
            vt.Islem();
            dgvKitap.DataSource = vt.dt;
            for (int i = 0; i < dgvKitap.Columns.Count; i++)
            {
                dgvKitap.Columns[0].Width = 20;
                dgvKitap.Columns[i].Visible = false;
            }
            dgvKitap.Columns[1].Visible = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dgvOdunc.CurrentRow.Cells[0].Value.ToString());
            vt.TableName = "tblOdunc";
            vt.Islem(ID);
            OduncRefresh();
        }

        private void btnOducVer_Click(object sender, EventArgs e)
        {   
            vt.TableName = "tblOdunc";
            Odunc yeniOdunc = new Odunc();
            yeniOdunc.UyeID = int.Parse(dgvUye.SelectedRows[0].Cells[0].Value.ToString());
            yeniOdunc.KitapISBN = dgvKitap.SelectedRows[0].Cells[0].Value.ToString();
            yeniOdunc.VerilisTarihi = dtpVerilisTarihi.Value;
            yeniOdunc.Iptal = false;
           
            vt.Islem(yeniOdunc);
            OduncRefresh();
        }

        private void dgvOdunc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aktar();
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
