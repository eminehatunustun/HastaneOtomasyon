using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS
{
    class Hastaneler
    {
        public int HastaneID { get; set; }
        public string HastaneAdi { get; set; }
        public int IlceID { get; set; }
        public override string ToString()
        {
            return HastaneAdi;
        }
    }
}
