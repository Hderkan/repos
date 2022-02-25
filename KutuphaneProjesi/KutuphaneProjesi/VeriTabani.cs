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
        SqlCommand komut;
        SqlDataAdapter adaptor;
        string sorguCumlesi;
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
        public DataTable KayitListele(string sorguCumlesi)
        {
            
            adaptor = new SqlDataAdapter(sorguCumlesi, Baglan());
            dt = new DataTable();
            adaptor.Fill(dt);
            return dt;



        }
        public void turEkle(string sorguCumlesi, string turAd)
        {
            komut = new SqlCommand(sorguCumlesi, Baglan());
           // komut.ExecuteNonQuery();
            //Kapat();

            komut.Parameters.AddWithValue("@TurAd", turAd);
            komut.ExecuteNonQuery();
            Kapat();

        }
        public void kitapEkle(string sorguCumlesi, string ISBN, string kitapAd, int ss,int stok,int kitapturu,int yazar, int yayınevi)
        {
            //komut = new SqlCommand(sorguCumlesi, Baglan());
            //// komut.ExecuteNonQuery();
            ////Kapat();
            //komut.Parameters.AddWithValue("@ISBN", ISBN);
            //komut.Parameters.AddWithValue("@Ad", kitapAd );
            //komut.Parameters.AddWithValue("@SayfaSayısı", ss);
            //komut.Parameters.AddWithValue("@Stok", stok);
            //komut.Parameters.AddWithValue("@TurID", kitapturu);
            //komut.Parameters.AddWithValue("@YazarID", yazar);
            //komut.Parameters.AddWithValue("@YayinEviID", yayınevi);
            //komut.ExecuteNonQuery();
            //Kapat();

        }
        public void yayineviEkle(string sorguCumlesi ,string Ad,string Adres,string Tel)
        {
            //komut = new SqlCommand(sorguCumlesi, Baglan());
            //komut.Parameters.AddWithValue("@Ad", Ad);
            //komut.Parameters.AddWithValue("@Adres", Adres);
            //komut.Parameters.AddWithValue("@Tel", Tel);
            //komut.ExecuteNonQuery();
            //Kapat();
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
