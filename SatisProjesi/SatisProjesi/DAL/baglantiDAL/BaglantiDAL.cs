using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisProjesi.DAL.baglantiDAL
{
    public class BaglantiDAL
    {
        private static SqlConnection baglantiNesnesi;

        public static SqlConnection BaglantiNesnesi
        {
            get
            {
                if (baglantiNesnesi == null)
                {
                    baglantiNesnesi = new SqlConnection(ConfigurationManager.ConnectionStrings["CSatislar"].ToString());

                }

                return baglantiNesnesi;
            }
            set
            {
                baglantiNesnesi = value;
            }

        }
        public static void Ac()
        {
            if (baglantiNesnesi.State == ConnectionState.Closed) baglantiNesnesi.Open();


        }
        public static void Kapa()

        {
            if (baglantiNesnesi.State == ConnectionState.Open) baglantiNesnesi.Close();




        }

    }
}

