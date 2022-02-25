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

        SqlConnection baglanti;
        public FormKutuphane()
        {
            InitializeComponent();
        }

        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            pnlTeslimTarihi.Visible = false;
        }

        private void btnTurYeni_Click(object sender, EventArgs e)
        {
            Turler yeniTur = new Turler();
            yeniTur.turAd = txtTurAd.Text;
            string sorguCumlesi = $"INSERT into tblTurler Values (@TurAd)";
            vt.turEkle(sorguCumlesi, yeniTur.turAd);

          
            

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            //Kitaplar yeniKitap = new Kitaplar();
            //yeniKitap.ISBN = txtISBN.Text;
            //yeniKitap.Ad = txtKitapAdı.Text;
            //yeniKitap.SayfaSayisi = Convert.ToString(txtSayfaSayısı.Text);
            //yeniKitap.Stok = Convert.ToInt32(txtStok.Text);
            //yeniKitap.TurID = int.Parse(cmbKitapTuru.Text);
            //yeniKitap.YazarID = int.Parse(cbmYazar.Text);
            //yeniKitap.YayinEviID = int.Parse(cmbYayinevi.Text);




            //string sorguCumlesi = $"Insert into tblKitaplar  values (@ISBN,@Ad,@SayfaSayısı,@Stok,@TurID,@YazarID,@YayinEviID)";
            //vt.kitapEkle(sorguCumlesi,   yeniKitap.ISBN,yeniKitap.Ad, yeniKitap.SayfaSayisi,yeniKitap.Stok,yeniKitap.TurID,yeniKitap.YazarID,yeniKitap.YayinEviID);



        }

        private void btnYayineviYeni_Click(object sender, EventArgs e)
        //{
        //    YayinEvleri yeniYayin = new YayinEvleri();
        //    yeniYayin.Ad = txtYayineviAd.Text;
        //    yeniYayin.Adres = txtYayineviAdres.Text;
        //    yeniYayin.Tel = txtYayıneviTel.Text;
        //    string sorguCumlesi = $"INSERT into tblYayinevleri values (@Ad,@Adres,@Tel)";
        //    vt.yayineviEkle(sorguCumlesi, yeniYayin.Ad, yeniYayin.Adres, yeniYayin.Tel);
        }
    }
}
