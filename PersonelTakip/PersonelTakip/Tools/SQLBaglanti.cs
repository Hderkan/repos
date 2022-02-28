using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip.Tools
{
    class SQLBaglanti
    {


        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti == null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["CsPersonel"].ConnectionString); ;

                }
                return baglanti;
            }
                set
                {
                    baglanti = value;
                }

            }
        public static void baglantiAc()
        {
            if (Baglanti.State == ConnectionState.Closed)

            {
                baglanti.Open();

            }
        

        }
        public static void baglantiKapat()
        {
            if (baglanti.State != ConnectionState.Closed)
            {
                baglanti.Close();
            }
        }


    }

}

