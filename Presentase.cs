using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menghitungkeuangan
{
    class Presentase
    {
        public double persepuluhan(int dana)
        {
            return dana * 0.1;
        }

        public double keinginan(int dana)
        {
            return dana * 0.2;
        }

        public double investasi(int dana)
        {
            return dana * 0.3;
        }

        public double kebutuhan(int dana)
        {
            return dana * 0.4;
        }
    }
}
