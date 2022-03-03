using PersonelTakip.DataAccess;
using PersonelTakip.Entites;
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
        int secilenID = 0;
        Calisan calisan = null;
        string orjinalpersonelno = null;
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            Refresh();
            Aktar();

        }
        void Refresh()
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll();
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
            dtpDogumTarihi.Format = DateTimePickerFormat.Custom;
            dtpDogumTarihi.CustomFormat = " ";
            dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Custom;
            dtpIseBaslamaTarihi.CustomFormat = " ";

            dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Custom;
            txtAd.Focus(); //oraya odaklanır
            Cancel();

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clearTOOLS();
        }

        private void dtpIseBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;
        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpDogumTarihi.Format = DateTimePickerFormat.Long;
        }
        void Aktar()
        {
            
            secilenID = Convert.ToInt32(dgvCalisanlar.SelectedRows[0].Cells[0].Value);
            txtAd.Text = dgvCalisanlar.SelectedRows[0].Cells[1].Value.ToString();
            txtSoyad.Text = dgvCalisanlar.SelectedRows[0].Cells[2].Value.ToString();
            txtTcNo.Text = dgvCalisanlar.SelectedRows[0].Cells[3].Value.ToString();
            txtPersonelNo.Text = dgvCalisanlar.SelectedRows[0].Cells[4].Value.ToString();
            dtpDogumTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[5].Value.ToString());
            dtpIseBaslamaTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[6].Value.ToString());
            cmbDepartmanID.Text =dgvCalisanlar.SelectedRows[0].Cells[7].Value.ToString();
            cmbUnvanID.Text = dgvCalisanlar.SelectedRows[0].Cells[8].Value.ToString();
            cmbDurumu.Text = dgvCalisanlar.SelectedRows[0].Cells[9].Value.ToString();

            
        }
        bool BlankControl()
        {
            bool result = true;
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.Text == string.Empty || control.Text == " ")
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        private void dgvCalisanlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
               
                //orjinalpersonelno = dgvCalisanlar.SelectedRows[0].Cells[4].Value.ToString();
                secilenID = Convert.ToInt32(dgvCalisanlar.SelectedRows[0].Cells[0].Value);
                txtAd.Text = dgvCalisanlar.SelectedRows[0].Cells[1].Value.ToString();
                txtSoyad.Text = dgvCalisanlar.SelectedRows[0].Cells[2].Value.ToString();
                txtTcNo.Text = dgvCalisanlar.SelectedRows[0].Cells[3].Value.ToString();
                 orjinalpersonelno = txtPersonelNo.Text = dgvCalisanlar.SelectedRows[0].Cells[4].Value.ToString();
                dtpDogumTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[5].Value.ToString());
               
                
                dtpIseBaslamaTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[6].Value.ToString());
                cmbDepartmanID.Text = dgvCalisanlar.SelectedRows[0].Cells[7].Value.ToString();
                cmbUnvanID.Text = dgvCalisanlar.SelectedRows[0].Cells[8].Value.ToString();
                cmbDurumu.Text = dgvCalisanlar.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BlankControl())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
            else
            {
                calisan = new Calisan
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TcNo = txtTcNo.Text,
                    PersonelNo = txtPersonelNo.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    IseBaslamaTarihi = dtpIseBaslamaTarihi.Value,
                    Departman = "1",
                    Unvan = "1",
                    Durumu = cmbDurumu.SelectedItem.ToString()
                };
                bool result = calisanDAL.Insert(calisan);
                if (result)
                {
                    Refresh();
                    MessageBox.Show("kayıt islemi tamamlandı");

                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("lütfen silmek istediginiz kaydı seciniz");
            }
            else
            {
                DialogResult answer = MessageBox.Show("secilen kayıt silinicektir\n Emin misiniz?","Dikkat",MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes) // eger yes dumesine tıklandıysa
                {
                    bool result = calisanDAL.Delete(secilenID);
                    if (result)
                    {
                        Refresh();
                        MessageBox.Show($"{secilenID} li kaydı silme islemi gerceklesmistir");
                    }


                }
            }
        }
        void Cancel()
        {
            dgvCalisanlar.ClearSelection();
            secilenID = 0;
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("secilen tüm kayıtlar silinicektir\n Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
                if  (answer == DialogResult.Yes)
            {
                bool result = calisanDAL.Delete(); 
                if(result)
                {
                    Refresh();
                    MessageBox.Show("butun kayıtlar silinmistir");
                }
            }
        }

        private void dgvCalisanlar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) // basılan tus escape ise
            {
                clearTOOLS();
            }
        }
        string CreateQuaryString()
        {
            string quaryString = string.Empty;
            List<string> alanlar = new List<string>();
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.Tag == null) continue;
                if (string.IsNullOrEmpty(control.Text) || control.Text == " ") continue;
                //value = control.Text;
                //where fieldname = value 
               // alanlar.Add($"{FieldName} = '{value}'");

                string FieldName = control.Tag.ToString();

                    string value = string.Empty;

                if (control.GetType()==typeof(DateTimePicker))
                {
                    value = Convert.ToDateTime(control.Text).ToString("yyyy-MM-dd");
                    alanlar.Add($"{FieldName} = '{value}'");
                }
                else
                {
                    value = control.Text;
                    if (rbnBenzer.Checked)
                    {
                        alanlar.Add($"{FieldName} like '%{value}%'");
                    }
                    else if (rbnBasla.Checked)
                        {
                        alanlar.Add($"{FieldName} like '{value}%'");      
                        }
                    else
                    {
                        alanlar.Add($"{FieldName} like '{value}'");
                    }


                    
                }

                     
            }
            if (alanlar.Count>0)

            {
                quaryString = $"WHERE {string.Join(" AND ",alanlar)}";
            }
            return quaryString;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll(CreateQuaryString());
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            calisan = calisanDAL.GET(CreateQuaryString());
            if (calisan!=null)
            {
                txtAd.Text = calisan.Ad;
                txtSoyad.Text = calisan.Soyad;
                txtTcNo.Text = calisan.TcNo;
                txtPersonelNo.Text = calisan.PersonelNo;
                dtpDogumTarihi.Format = DateTimePickerFormat.Long;
                dtpDogumTarihi.Value = calisan.DogumTarihi;
                dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;
                dtpIseBaslamaTarihi.Value = calisan.IseBaslamaTarihi;
                cmbDepartmanID.Text = calisan.Departman.ToString();
                cmbUnvanID.Text = calisan.Unvan.ToString();
                cmbDurumu.Text = calisan.Durumu;
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediginz kaydı seciniz ");
            }
            else if(!BlankControl())
            {
                MessageBox.Show("lütfen tüm alanları doldurunuz");
            }
            else
            {
                calisan = new Calisan



                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TcNo = txtTcNo.Text,
                    PersonelNo = txtPersonelNo.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    IseBaslamaTarihi = dtpIseBaslamaTarihi.Value,
                    Departman = "1",
                    Unvan = "1",
                    Durumu = cmbDurumu.SelectedItem.ToString(),
                    ID =secilenID
                };
                bool result = calisanDAL.Update(calisan, orjinalpersonelno);
                if (result)
                {
                    Refresh();
                    MessageBox.Show("güncelleme islemi basarıyla tamamlanmıstır");
                }
               

                
            }
        }
    }
}
