using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    class Kutuphane
    {
       




    }

    public class Tur //tblTurler tablosu iin
    {
        private int id;

        public int ID
        {
            get { return id; }

        }
        private string TurAd;

        public string turAd
        {
            get { return TurAd; }
            set { TurAd = value.ToUpper(); }
        }



    }
    public class YayinEvi
    {
        private int id;

        public int ID
        {
            get { return id; }

        }
        public string Ad { get; set; }
        public string Adres { get; set; }

        public string Tel { get; set; }

    }
    public class Kisi
    {
        private int id;

        public int ID
        {
            get { return id; }

        }
        public string AdSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }


    }
    public class Uye : Kisi
    {
        public Uye()
        {
            CezaDurumu = false;
        }
        public enum Utip
        {
            Standart,
            Elit
        }
        public enum EDTip
        {
            İlkokulMezunu,
            OrtaokulMezunu,
            LiseMezunu,
            UniversiteMezunu,
            Ogrenci

        }
        public DateTime UyelikTarihi { get; set; }
        public Utip UyelikTipi { get; set; }
        public string TcNo { get; set; }
        public string Meslek { get; set; }
        public EDTip EgitimDurumu { get; set; } // daha sonra revize edilebilir
        public bool CezaDurumu { get; set; }


    }
    class Yazar : Kisi
    {
        public int TurID { get; set; } // yazarın en cok onplana cıktıgı tür bilgisi


    }
    public class Kitap
    {
        public string ISBN { get; set; }
        public string Ad { get; set; }
        public string SayfaSayisi { get; set; }
        public int Stok { get; set; }
        public int TurID { get; set; }
        public int YazarID { get; set; }
        public int YayinEviID { get; set; }
    }
    class Odunc
    {
        private int id;

        public int ID
        {
            get { return id; }

        }
        public int UyeID { get; set; }
        public string KitapISBN { get; set; }
        public DateTime VerilisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public bool Iptal { get; set; }




    }
}
