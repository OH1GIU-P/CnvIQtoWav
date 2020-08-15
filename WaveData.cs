using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnvIQtoWav
{
    class WaveData
    {
        public string sChunk;
        public uint dwChunkSize;
        public sbyte[] sbyteArray;  // 8-bit signed audio

        public WaveData()
        {
            sChunk = "data";
            dwChunkSize = 0;
            sbyteArray = new sbyte[0];
        }
    }
}
