using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisProjesi.Entity
{
    class Satislar
    {
        public int ID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public int UrunID { get; set; }
        public int SatisAdedi { get; set; }


    }
    class Urunler
    {
        public int ID { get; set; }
        public string UrunAd { get; set; }
        public int StokMiktarı { get; set; }

    }
}
