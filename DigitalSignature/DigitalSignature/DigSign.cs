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
    public partial class DigSign : UserControl
    {
        private string privateKeyPath = "";
        private string filePath = "";
        public DigSign()
        {
            InitializeComponent();
            error.Visible = false;
            succes.Visible = false;
            info.Visible = false;
        }

        private void btnChooseKey_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog chooseKey = new OpenFileDialog();
                chooseKey.ShowDialog();
                privateKeyPath = Path.GetFullPath(chooseKey.FileName);
                tbKey.Text = Path.GetFileName(chooseKey.FileName);
            }
            catch
            {

            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog chooseFile = new OpenFileDialog();
                chooseFile.ShowDialog();
                filePath = Path.GetFullPath(chooseFile.FileName);
                tbFile.Text = Path.GetFileName(chooseFile.FileName);
            }
            catch
            {

            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if(tbFile.Text != "" && tbKey.Text != "")
            {
                error.Visible = false;
                succes.Visible = true;
                info.Visible = true;

                EncryptData();
            }
            else
            {
                error.Visible = true;
                succes.Visible = false;
                info.Visible = false;
            }
        }

        private byte[] CalculateHash()
        {
            SHA256 hashCalc = SHA256.Create();
            FileStream fs = File.OpenRead(filePath);
            byte[] bytes = hashCalc.ComputeHash(fs);
            fs.Close();

            return bytes;
        }

        private void EncryptData()
        {
            string privateKey = GetKey();
            byte[] encData;
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);

            rsa.FromXmlString(privateKey);
            encData = rsa.SignHash(CalculateHash(), CryptoConfig.MapNameToOID("SHA256"));

            SaveData(Convert.ToBase64String(encData));
        }

        private string GetKey()
        {
            StreamReader srKey = new StreamReader(privateKeyPath);
            string key = srKey.ReadToEnd();
            srKey.Close();
            return key;
        }

        private void SaveData(string data)
        {
            string path = "";
            var tempArray = filePath.Split('.');
            for (int i = 0; i < tempArray.Length - 2; i++)
            {
                path += tempArray[i] + ".";
                if (i == tempArray.Length - 3)
                {
                    path += tempArray[i + 1] + "-potpis.txt";
                }
            }

            FileStream fs = File.Create(path);
            fs.Close();
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(data);
            sw.Close();
        }
    }
}
