using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Collections;
using DamienG.Security.Cryptography;
using System.Diagnostics;

namespace GakkiFileHashCalc
{
    public partial class Form1 : Form
    {
        string[] filesname;
        Stopwatch sw = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (checkBoxIsAppend.Checked==false)
                textBoxCodeDump.Clear();
            foreach (string fname in filesname)
            {
                string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
                long fileLengthInByte = new FileInfo(fname).Length;
                uint place = Convert.ToUInt32(Math.Floor(Math.Log(fileLengthInByte, 1024)));
                double fileLengthReadable = Math.Round(fileLengthInByte / Math.Pow(1024, place), 3);

                string dumpCodeText = "";
                sw.Start();
                if (checkBoxMD5.Checked)
                    dumpCodeText += string.Format("{1}\tMD5:\t{0}{2}", HashCode.CalculateMD5(fname), fname, Environment.NewLine);
                if (checkBoxSHA1.Checked)
                    dumpCodeText += string.Format("{1}\tSHA1:\t{0}{2}", HashCode.CalculateSHA1(fname), fname, Environment.NewLine);
                if (checkBoxSHA256.Checked)
                    dumpCodeText += string.Format("{1}\tSHA256:\t{0}{2}", HashCode.CalculateSHA256(fname), fname, Environment.NewLine);
                if (checkBoxSHA512.Checked)
                    dumpCodeText += string.Format("{1}\tSHA512:\t{0}{2}", HashCode.CalculateSHA512(fname), fname, Environment.NewLine);
                if (checkBoxCRC32.Checked)
                    dumpCodeText += string.Format("{1}\tCRC32:\t{0}{2}", HashCode.CalculateCRC32(fname), fname, Environment.NewLine);
                dumpCodeText += string.Format("Time consumed:\t\t{0} ms{1}", sw.Elapsed.TotalMilliseconds, Environment.NewLine);
                sw.Reset();
                dumpCodeText += string.Format("File size in bytes:\t{0}{1}", fileLengthInByte, Environment.NewLine);
                dumpCodeText += string.Format("File size readable:\t{0:0.000} {1}{2}", fileLengthReadable, suf[place], Environment.NewLine);
                dumpCodeText += string.Format("{0}", Environment.NewLine);
                textBoxCodeDump.AppendText(dumpCodeText);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.*|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filesname = new string[openFileDialog1.FileNames.Length];
                int i = 0;
                foreach (string s in openFileDialog1.FileNames)
                {
                    filesname[i] = s;
                    i++;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCodeDump.Clear();
        }
    }
    class HashCode
    {
        static public string CalculateMD5(string filename)
        {
            using var md5 = MD5.Create();
            using FileStream stream = File.OpenRead(filename);
            return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToUpperInvariant();
        }
        static public string CalculateSHA1(string filename)
        {
            using var sha1 = SHA1.Create();
            using var stream = File.OpenRead(filename);
            return BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", "").ToUpperInvariant();
        }
        static public string CalculateSHA256(string filename)
        {
            using var sha256 = SHA256.Create();
            using var stream = File.OpenRead(filename);
            return BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", "").ToUpperInvariant();
        }
        static public string CalculateSHA512(string filename)
        {
            using var sha512 = SHA512.Create();
            using var stream = File.OpenRead(filename);
            return BitConverter.ToString(sha512.ComputeHash(stream)).Replace("-", "").ToUpperInvariant();
        }
        static public string CalculateCRC32(string filename)
        {
            var crc32 = new Crc32();
            var hashcrc32 = string.Empty;
            using var stream = File.OpenRead(filename);
            foreach (byte b in crc32.ComputeHash(stream))
                hashcrc32 += b.ToString("x2").ToUpper();
            return hashcrc32;
        }
    }
}
