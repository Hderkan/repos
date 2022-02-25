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
        string sorguCumlesi;
        public VeriTabani()
        {

        }

        public VeriTabani(string tabloAdi, params string[] sutunlar)
        {
            string sutunmetni = string.Join(",", sutunlar);
               string sorguCumlesi = $"Select {sutunmetni} from {tabloAdi} ";
            


            //foreach (var siradakşsutunAd in sutunlar)
            //{


            //        sutunmetni += siradakşsutunAd + ",";


            //}
            //sutunmetni = sutunmetni.Substring(1, sutunmetni.Length - 1);
            
        }








        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;
        
        DataTable dt;

        

        //ilk olarak bir veri tabanı baglantısı yapacak method
        public SqlConnection Baglan()
        {
            string baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database =sKutuphane; User =sa; Pwd=123";
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
        private DataTable KayitListele()
        {
            
            adaptor = new SqlDataAdapter(sorguCumlesi, Baglan());
            dt = new DataTable();
            adaptor.Fill(dt);
            return dt;



        }
        public void islem(string sorguCumlesi)
        {
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();

        }
        //public void Ekle(string sorguCumlesi)
        //{
            
        //    komut = new SqlCommand(sorguCumlesi, Baglan());
        //    komut.ExecuteNonQuery();
        //    Kapat();
        //}
        //public void Duzelt(string sorguCumlesi)
        //{
            
        //    komut = new SqlCommand(sorguCumlesi, Baglan());
        //    komut.ExecuteNonQuery();
        //    Kapat();

        //}   
        //public void Silme(string sorguCumlesi)
        //{
            
            
        //    komut = new SqlCommand(sorguCumlesi, Baglan());
        //    komut.ExecuteNonQuery();
        //    Kapat();
        //}
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
