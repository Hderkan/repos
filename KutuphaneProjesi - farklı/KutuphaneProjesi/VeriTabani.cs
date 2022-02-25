using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    class VeriTabani
    {
        
        SqlConnection baglanti;
        public string TableName { get; set; }
        string sorguCumlesi;
        
        SqlDataAdapter adaaptor;

        public DataTable dt;
        SqlCommand komut;

        public VeriTabani()
        {
            baglanti = Yarat();
            Ac();

        }
        SqlConnection Yarat()
        {
            baglanti = new SqlConnection(@"Server =DESKTOP-8M7D7GE\SQLEXPRESS ; Database =sKutuphane; User = sa ; Pwd = 123");
           
            return baglanti;

        }
        void Ac()
        {
            if (baglanti.State == ConnectionState.Closed)

            {
                baglanti.Open();
            }
        }
        public void Kapat()
        {
            if (baglanti.State != ConnectionState.Closed)
            {
                baglanti.Close();

            }
        }
        //public DataTable Dt { get; set; }
        
        public void Islem()
        {
            sorguCumlesi = $"select * from {TableName} ";
            adaaptor = new SqlDataAdapter(sorguCumlesi, baglanti);
            dt = new DataTable();
            adaaptor.Fill(dt);
                   
                      
        }
        /// <summary>
        /// verilen ıd ye göre silme islemi v
        /// </summary>
        /// <param name="ID"></param>
        public void Islem(int ID)
        {
            Ac();
            sorguCumlesi = $"Update {TableName} set Iptal=1 where ID={ID}";
            komut = new SqlCommand(sorguCumlesi, baglanti);
            komut.ExecuteNonQuery();
           
        Kapat();

        }
        public void Islem(Odunc yeniOdunc)
        {
            Ac();
            sorguCumlesi = $"Insert into {TableName} (UyeID,KitapISBN,VerilisTarihi,Iptal) values (@UyeID,@KitapISBN,@VerilisTarihi,@Iptal)";
            SqlCommand komut = new SqlCommand(sorguCumlesi,baglanti);
            komut.Parameters.AddWithValue("@UyeID", yeniOdunc.UyeID);
            komut.Parameters.AddWithValue("@KitapISBN", yeniOdunc.KitapISBN);
            komut.Parameters.AddWithValue("@VerilisTarihi", yeniOdunc.VerilisTarihi.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@Iptal", yeniOdunc.Iptal);
            komut.ExecuteNonQuery();
            Kapat();

        }
    }
}
