using SatisProjesi.DAL.SatislarDAL;
using SatisProjesi.Entity;
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

namespace SatisProjesi
{
    public partial class Form1 : Form
    {
        SatislarDal satislarDal = new SatislarDal();
        
        Satislar satislar = null;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {


            Satislar satislar = new Satislar()
            {
                SatisTarihi = dtpTarih.Value,
                UrunID = ,
                SatisAdedi = Convert.ToInt32(txtSatisMiktarı.Text),



            };
            bool result = satislarDal.Insert(satislar);

            if (result)
            {
                MessageBox.Show("kayıt basarılı");

            }


            //if (result)
            //{
            //    Refresh();
            //    MessageBox.Show("Kayıt işlemi başarıyla tamamlandı");
            //}
            
        }
    }
}
