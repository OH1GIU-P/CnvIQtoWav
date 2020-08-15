using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnvIQtoWav
{
    class WaveHdr
    {
        public string sRiff;
        public uint dwLen;  // total file len - 8
        public string sType;

        public WaveHdr()
        {
            sRiff = "RIFF";
            dwLen = 0;
            sType = "WAVE";
        }
    }
}
