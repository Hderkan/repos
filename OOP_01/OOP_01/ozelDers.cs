using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    class ozelDers
    {
        public enum Dersler
        {
            Matematik,
            Fizik,
            Kimya,
            Turkce
        }
        public class StandartUyelik
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string KullanıcıAd { get; set; }



            public Dersler Brans { get; set; }

            public int Yas { get; set; }
            public int DeneyimSuresi { get; set; }
            public StandartUyelik()
            {

            }

            public StandartUyelik(string uad, string uSoyad, string uKullanıcıAd, string uBrans, int uYas, int uDeneyimSuresi)
            {
                Ad = uad;
                Soyad = uSoyad;
                KullanıcıAd = uKullanıcıAd;
                Brans = uBrans;
                Yas = uYas;
                DeneyimSuresi = uDeneyimSuresi;
            }

        }
        public class ProUye : StandartUyelik
        {
            public string OnaylıUye { get; set; }
            public int AnaSayfaGoruntulenme { get; set; }

            public int TelefonNumaras { get; set; }
            public ProUye()
            {

            }

            public void Dersler()
            {
                
            }

            public ProUye(string pad, string pSoyad, string pKullanıcıAd, string pBrans, int pYas, int pDeneyimSuresi, string pOnaylıUye, string pAnaSayfaGoruntulenme, int pTelefonNumara)
            {
                Ad = pad;
                Soyad = pSoyad;
                KullanıcıAd = pKullanıcıAd;
                Brans = pBrans;
                Yas = pYas;
                DeneyimSuresi = pDeneyimSuresi;
            
             }

        }

        public class EliteUye : ProUye
        {


        }
    }
}
