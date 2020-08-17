using System;
using System.IO;
using System.Windows.Forms;

namespace CnvIQtoWav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelInfile.Text = "";
            labelOutfile.Text = "";
            labelError.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelInfile.Text = "";
            labelOutfile.Text = "";
            labelError.Text = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.UseWaitCursor = true;
                string infile = openFileDialog1.FileName;
                labelInfile.Text = infile;
                Application.DoEvents();
                string outfile = Path.GetDirectoryName(openFileDialog1.FileName) + "\\" + Path.GetFileName(openFileDialog1.FileName).Replace(".iq", ".wav");
                uint fileLen = (uint) new FileInfo(infile).Length;
                try
                {
                    if (File.Exists(outfile)) { File.Delete(outfile); }
                    WaveHdr header = new WaveHdr();
                    WaveFmt fmt = new WaveFmt();
                    WaveData data = new WaveData();
                    header.dwLen = fileLen + 36;
                    data.dwChunkSize = fileLen;
                    FileStream fs = new FileStream(outfile, FileMode.Create);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(header.sRiff.ToCharArray());
                    bw.Write(header.dwLen);
                    bw.Write(header.sType.ToCharArray());
                    bw.Write(fmt.sChunk.ToCharArray());
                    bw.Write(fmt.dwChunkSize);
                    bw.Write(fmt.wFormatTag);
                    bw.Write(fmt.wChannels);
                    bw.Write(fmt.dwSamplesPerSec);
                    bw.Write(fmt.dwAvgBytesPerSec);
                    bw.Write(fmt.wBlockAlign);
                    bw.Write(fmt.wBitsPerSample);
                    bw.Write(data.sChunk.ToCharArray());
                    bw.Write(data.dwChunkSize);
                    BinaryReader br = new BinaryReader(File.Open(infile, FileMode.Open));
                    bw.Write(br.ReadBytes((int)fileLen));
                    /*for (uint i = 0; i < fileLen; i++)
                    {
                        bw.Write((sbyte)br.ReadSByte());
                    }*/
                    bw.Flush();
                    br.Close();
                    bw.Close();
                    fs.Close();
                    labelOutfile.Text = outfile;
                    labelError.Text = fileLen.ToString();
                }
                catch (Exception ex)
                {
                    labelError.Text = ex.Message;
                }
                this.UseWaitCursor = false;
            }
        }
    }
}
