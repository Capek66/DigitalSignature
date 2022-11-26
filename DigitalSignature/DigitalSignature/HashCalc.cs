using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignature
{
    public partial class HashCalc : UserControl
    {
        private string filePath = "";

        public HashCalc()
        {
            InitializeComponent();
            succes.Visible = false;
            error.Visible = false;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog chooseFile = new OpenFileDialog();
                chooseFile.ShowDialog();
                filePath = Path.GetFullPath(chooseFile.FileName);
                tbDat.Text = Path.GetFileName(filePath);
            }
            catch
            {

            }
        }

        private void btnGetHash_Click(object sender, EventArgs e)
        {
            if(tbDat.Text != "")
            {
                succes.Visible = true;
                error.Visible = false;

                string hash = CalculateHash();
                tbHash.Text = hash;
                SaveHash(hash);
            }
            else
            {
                succes.Visible = false;
                error.Visible = true;
            }
        }

        private string CalculateHash()
        {
            SHA256 hashCalc = SHA256.Create();
            FileStream fs = File.OpenRead(filePath);
            byte[] bytes = hashCalc.ComputeHash(fs);
            fs.Close();

            return BitConverter.ToString(bytes).Replace("-", "");
        }

        private void SaveHash(string hash)
        {
            string path = "";
            var tempArray = filePath.Split('.');
            for (int i = 0; i < tempArray.Length - 2; i++)
            {
                path += tempArray[i] + ".";
                if (i == tempArray.Length - 3)
                {
                    path += tempArray[i + 1] + "-hash.txt";
                }
            }

            FileStream fs = File.Create(path);
            fs.Close();
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(hash);
            sw.Close();
        }
    }
}
