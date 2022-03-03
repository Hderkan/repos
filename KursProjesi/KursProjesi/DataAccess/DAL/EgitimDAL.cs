using KursProjesi.DataAccess.BaglantiDAL;
using KursProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProjesi.DataAccess.DAL
{
    public class EgitimDAL
    {
        Kurs kurs = null;

        //burada crud islemlerimizi yapıcaz
        public List<Kurs> GetALL()
        {
              List<Kurs> kurslar = new List<Kurs>();
            try
            {

                using (SqlCommand cmd = new SqlCommand($"Select * from tblEgitimler", Baglanti.BaglantiNesnesi))
                {
                    Baglanti.Ac();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                               kurs = new Kurs()
                            {
                                ID = Convert.ToInt32(dr["ID"]),
                                Ad = dr["Ad"].ToString(),
                                Sorumlu = dr["Sorumlu"].ToString(),
                                BaslangıcTarihi = Convert.ToDateTime(dr["BaslangıcTarihi"]),
                                Sure = Convert.ToInt32(dr["Sure"])

                            };
                            kurslar.Add(kurs);
                        }

                    }

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Baglanti.Kapa();
            
            }


        }

    }
}
