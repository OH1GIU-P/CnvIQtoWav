using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnvIQtoWav
{
    class WaveFmt
    {
        public string sChunk;      
        public uint dwChunkSize;   
        public ushort wFormatTag;   
        public ushort wChannels;  
        public uint dwSamplesPerSec;
        public uint dwAvgBytesPerSec;
        public ushort wBlockAlign;
        public ushort wBitsPerSample;

        public WaveFmt()
        {
            sChunk = "fmt ";
            dwChunkSize = 16;
            wFormatTag = 1;
            wChannels = 2;
            dwSamplesPerSec = 1000000;
            wBitsPerSample = 8;
            wBlockAlign = (ushort)(wChannels * (wBitsPerSample / 8));
            dwAvgBytesPerSec = dwSamplesPerSec * wBlockAlign;
        }
    }
}
