using SatisProjesi.DAL.baglantiDAL;
using SatisProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisProjesi.DAL.UrunlerDAL
{
    class UrunlerDal
    {
        public List<Satislar> GetAll(string kosulCumlesi = "")
        {
            List<Satislar> Satis = new List<Satislar>();
            try
            {
                //Buraya yazacağımız işlmeleri yapmayı dene, sorun yoksa çalıştır.
                using (SqlCommand command = new SqlCommand($"SELECT * FROM tblUrunler {kosulCumlesi}", BaglantiDAL.BaglantiNesnesi))
                {
                    //Using satrında yaratılan command adlı nesne, sadece
                    //bu scopeda yaşayacak. Bu scope dışında yok olmuş olacak.
                    //Bu nesnenin yok edilmesini Garbage Collector'ün
                    //insiyatifine bırakmamış olduk.
                    BaglantiDAL.Ac();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())//geri dönen değerlerin hepsine bakmamızı sağlıyor
                        {
                            Urunler urun = new Urunler();
                            {
                                urun.ID = Convert.ToInt32(reader["ID"]);

                                urun.UrunAd = reader["Ad"].ToString();
                                urun.StokMiktarı = Convert.ToInt32(reader["StokMiktarı"]);
                               
                            };
                            Satis.Add(urun);
                        }
                    }
                }
                return Urunler;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                BaglantiDAL.Kapa();
            }
        }
    }
}
