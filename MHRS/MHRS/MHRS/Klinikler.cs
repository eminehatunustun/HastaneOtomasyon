using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS
{
    class Klinikler
    {
        public int KlinikID { get; set; }
        public string KlinikAdi { get; set; }
        public int HastaneID { get; set; }
        public override string ToString()
        {
            return KlinikAdi;
        }
    }
}
