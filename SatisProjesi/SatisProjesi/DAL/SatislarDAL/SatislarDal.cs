using SatisProjesi.DAL.baglantiDAL;
using SatisProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisProjesi.DAL.SatislarDAL
{
     class SatislarDal
    {
        public List<Satislar> GetAll(string kosulCumlesi = "")
        {
            List<Satislar> Satis = new List<Satislar>();
            try
            {
                //Buraya yazacağımız işlmeleri yapmayı dene, sorun yoksa çalıştır.
                using (SqlCommand command = new SqlCommand($"SELECT * FROM tblSatislar {kosulCumlesi}", BaglantiDAL.BaglantiNesnesi))
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
                            Satislar satis = new Satislar();
                            {
                                satis.UrunID = Convert.ToInt32(reader["UrunID"]);

                                satis.SatisTarihi = Convert.ToDateTime(reader["SatisTarihi"]);
                                satis.SatisAdedi = Convert.ToInt32(reader["SatisAdedi"]);

                            };
                            Satis.Add(satis);
                        }
                    }
                }
                return Satis;
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
        public bool Insert(Satislar satislar)
        {
           
                string sorguCumlesi =
                    $"INSERT INTO tblSatislar " +
                    $"(SatisTarihi,UrunID,SatisAdedi) VALUES " +
                    $"(@p1,@p2,@p3)";
                try
                {
                    using (SqlCommand command = new SqlCommand(sorguCumlesi, BaglantiDAL.BaglantiNesnesi))
                    {
                        command.Parameters.AddWithValue("@p1", satislar.SatisTarihi);
                        command.Parameters.AddWithValue("@p2", satislar.UrunID);
                        command.Parameters.AddWithValue("@p3", satislar.SatisAdedi);

                    BaglantiDAL.Ac();
                        command.ExecuteNonQuery();
                    }
                    return true;//Kayıt başarılı anlamında
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;//Kayıt başarısız anlamında
                }
                finally
                {
                BaglantiDAL.Kapa();
                }
            }
        }
        

    }

