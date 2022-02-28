using PersonelTakip.Entites;
using PersonelTakip.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip.DataAccess
{
    class CalisanDAL
    {
        //burada data access layer hazırlıyoruz calısan entitymizle crud islemleri gerceklesecek
        /// <summary>
        /// bu method geriye icinde calısan tipinde degerler barındıran bir list tipinde deger dondurucek
        /// </summary>
        /// <param name="kosulCumlesi"></param>
        /// bu parametre bos brakılırsa tüm kayıtları döndurucek eger buraya uygun bir where ifsdesi yazılırsa kosula uygun döndürücek
        /// <returns></returns>
        public List<Calisan> GetAll(string kosulCumlesi ="")
        {
            List<Calisan> calisanlar = new List<Calisan>();
            try
            {
                // buraya yazacagımız islemleri yapmayı dene sorun yoksa calıstır
                using (SqlCommand command = new SqlCommand($"Select * from tblCalisanlar {kosulCumlesi}", SQLBaglanti.Baglanti))
                {
                    //using adlı yaratılan nesme sadece command adlı nesle ,, bu nesneninn yok edilmesini garbage collecter insiyatifine brakmamıs olduk
                    SQLBaglanti.baglantiAc();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) //geri dönen degerlerin hepsine bakmasını saglar
                        {
                            Calisan calisan = new Calisan
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Ad = reader["Ad"].ToString(),
                                Soyad = reader["Soyad"].ToString(),
                                TcNo = reader["TcNo"].ToString(),
                                PersonelNo = reader["PersonelNo"].ToString(),
                                DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"].ToString()),
                                IseBaslamaTarihi = Convert.ToDateTime(reader["IseBaslamaTarihi"].ToString()),
                                Departman = reader["Departman"].ToString(),
                                Unvan = reader["Unvan"].ToString(),
                                Durumu = reader["Durumu"].ToString()


                            };
                            calisanlar.Add(calisan);
                        }
                    }
                }
                return calisanlar;
            }


            
    
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                SQLBaglanti.baglantiKapat();
            }

}
        public bool Insert(Calisan calisan)
        {
            string sorguCumlesi = $"Insert into tblCalisanlar (Ad,Soyad,TcNo,PersonelNo,DogumTarihi,IseBaslamaTarihi,Departman,Unvan,Durumu) Values" +
                $"(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCumlesi, SQLBaglanti.Baglanti))
                {
                    command.Parameters.AddWithValue("@p1", calisan.Ad);
                    command.Parameters.AddWithValue("@p2", calisan.Soyad);
                    command.Parameters.AddWithValue("@p3", calisan.TcNo);
                    command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                    command.Parameters.AddWithValue("@p5", calisan.DogumTarihi);
                    command.Parameters.AddWithValue("@p6", calisan.IseBaslamaTarihi);
                    command.Parameters.AddWithValue("@p7", calisan.Departman);
                    command.Parameters.AddWithValue("@p8", calisan.Unvan);
                    command.Parameters.AddWithValue("@p9", calisan.Durumu);
                    SQLBaglanti.baglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                SQLBaglanti.baglantiKapat();
            }
        }
        public bool Update(Calisan calisan)
        {
            string sorguCumlesi = $"Update tblCalisanlar set Ad=@p1,Soyad=@p2,TcNo =@p3," +
                $"PersonelNo =@p4, DogumTarihi = @p5, IseBaslamaTarihi = @p6, Departman =@p7" +
                $"Unvan =@p8, Durumu =@p9 where ID =@p10";
            try
            {
                using (SqlCommand command =new SqlCommand(sorguCumlesi, SQLBaglanti.Baglanti))
                {
                    command.Parameters.AddWithValue("@p1", calisan.Ad);
                    command.Parameters.AddWithValue("@p2", calisan.Soyad);
                    command.Parameters.AddWithValue("@p3", calisan.TcNo);
                    command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                    command.Parameters.AddWithValue("@p5", calisan.DogumTarihi);
                    command.Parameters.AddWithValue("@p6", calisan.IseBaslamaTarihi);
                    command.Parameters.AddWithValue("@p7", calisan.Departman);
                    command.Parameters.AddWithValue("@p8", calisan.Unvan);
                    command.Parameters.AddWithValue("@p9", calisan.Durumu);
                    command.Parameters.AddWithValue("@p10", calisan.ID);
                    SQLBaglanti.baglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                SQLBaglanti.baglantiKapat();
            }
        }

        public bool Delete(int id)
        {
            string sorguCumlesi = $"Delete from tblCalisanlar where ID = @p1";
            try
            {
                using(SqlCommand command = new SqlCommand(sorguCumlesi,SQLBaglanti.Baglanti))
                {
                    command.Parameters.AddWithValue("@p1", id);
                    SQLBaglanti.baglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                
            }
            finally
            {
                SQLBaglanti.baglantiKapat();
            }
        }

        public bool Delete(string kosulCumlesi)
        {
            string sorguCumlesi =
                $"Delete from tblCalisanlar @p1";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCumlesi, SQLBaglanti.Baglanti)) 
                {
                    command.Parameters.AddWithValue("@p1", kosulCumlesi);
                    SQLBaglanti.baglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                
            }
        }


    }
}
