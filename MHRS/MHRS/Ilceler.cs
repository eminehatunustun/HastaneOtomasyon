using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS
{
    class Ilceler
    {
        public int IlceID { get; set; }
        public string ilceAdi { get; set; }
        public int IlID { get; set; }
        public override string ToString()
        {
            return ilceAdi;
        }
    }
}
