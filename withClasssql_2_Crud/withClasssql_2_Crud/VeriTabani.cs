using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withClasssql_2_Crud
{
    class VeriTabani
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;
        string sorguCumlesi;
        DataTable dt;

        //ilk olarak bir veri tabanı baglantısı yapacak method
        public SqlConnection Baglan()
        {
            string baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database =sHastane; User =sa; Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);
            if (baglanti.State== ConnectionState.Closed)
            {
                baglanti.Open();
            }

            //DESKTOP-8M7D7GE\SQLEXPRESS
            return baglanti;

        }
        public void Kapat()
        {
            if (baglanti.State != ConnectionState.Closed)
            {
                baglanti.Close();
            }
            
        }
        public DataTable HastalariListele()
        {
            sorguCumlesi = $"select * from tblHastalar";
            adaptor = new SqlDataAdapter(sorguCumlesi, Baglan());
            dt = new DataTable();
            adaptor.Fill(dt);
            return dt;



        }
        public void Ekle(string tcno,string ad,string soyad, string cinsiyet,string adres,string tel,string mail)
        {
            sorguCumlesi = $"INSERT INTO tblHastalar(TcNo, Ad, SoyAd, Cinsiyet , Adres , Telefon ,mail)values('{tcno}', '{ad}', '{soyad}', '{cinsiyet}','{adres}','{tel}','{mail}')";
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }
        public void Duzelt(string tcno, string ad, string soyad, string cinsiyet, string adres, string tel, string mail,string ID)
        {
            sorguCumlesi = $"UPDATE tblHastalar SET TcNo='{tcno}',Ad='{ad}',SoyAd ='{soyad}', Cinsiyet ='{cinsiyet}',Adres ='{adres}',Telefon ='{tel}',mail='{mail}' where ID ='{ID}'";
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();

        }   
        public void Silme(string ID)
        {
            
            sorguCumlesi = $"Delete tblHastalar where ID ={ID}";
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }
        public bool KontrolEt(params string[] e)
        {
            bool donus = false;
            foreach (var item in e)
            {
                if (item=="")
                {
                    donus = true;
                    break;
                }
            }
            return donus;
        }


    }
}
