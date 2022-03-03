using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip.Entities
{
    class Departman : IBaseEntity
    {
        public string Sorumlu { get; set; }
        public int ID { get ; set ; }
        public string Ad { get ; set ; }
    }
}
