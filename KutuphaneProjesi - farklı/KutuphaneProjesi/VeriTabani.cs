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

        DataTable dt;
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
        public DataTable DT = new DataTable();
        public void Islem()
        {
            sorguCumlesi = $"select * from {TableName} ";
            adaaptor = new SqlDataAdapter(sorguCumlesi, baglanti);
            
            adaaptor.Fill(DT);
                   
                      
        }

    }
}
