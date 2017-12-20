using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS
{
    class Iller
    {
        public int IlID { get; set; }
        public string ilAdi { get; set; }
        public override string ToString()
        {
            return ilAdi;
        }
    }
}
