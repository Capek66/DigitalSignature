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
    public partial class EncDecAsym : UserControl
    {
        private string keyFilePath = "";
        private string dataFilePath = "";
        private string asymKey;
        private string data;
        public EncDecAsym()
        {
            InitializeComponent();
            succesEnc.Visible = false;
            succesDec.Visible = false;
            error.Visible = false;
        }

        private void btnChooseKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseKey = new OpenFileDialog();
            chooseKey.ShowDialog();
            keyFilePath = Path.GetFullPath(chooseKey.FileName);
            tbKey.Text = Path.GetFileName(chooseKey.FileName);
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.ShowDialog();
            dataFilePath = Path.GetFullPath(chooseFile.FileName);
            tbFile.Text = Path.GetFileName(chooseFile.FileName);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if ((keyFilePath != "") && (dataFilePath != ""))
            {
                error.Visible = false;
                succesEnc.Visible = true;
                succesDec.Visible = false;

                GetKeyAndData();
                EncryptData();
            }
            else
            {
                error.Visible = true;
                succesEnc.Visible = false;
                succesDec.Visible = false;
            }
        }

        private void EncryptData()
        {
            byte[] encData;
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);

            rsa.FromXmlString(asymKey);
            encData = rsa.Encrypt(Encoding.Unicode.GetBytes(data), false);

            SaveData(Convert.ToBase64String(encData), 'E');
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if ((keyFilePath != "") && (dataFilePath != ""))
            {
                error.Visible = false;
                succesEnc.Visible = false;
                succesDec.Visible = true;

                GetKeyAndData();
                DecryptData();
            }
            else
            {
                error.Visible = true;
                succesEnc.Visible = false;
                succesDec.Visible = false;
            }
        }

        private void DecryptData()
        {
            byte[] decData;
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
            
            rsa.FromXmlString(asymKey);
            RSAParameters privateKey = rsa.ExportParameters(true);

            decData = rsa.Decrypt(Convert.FromBase64String(data), false);
            
            SaveData(Encoding.Unicode.GetString(decData), 'D');
        }

        private void GetKeyAndData()
        {
            StreamReader srKey = new StreamReader(keyFilePath);
            asymKey = srKey.ReadToEnd();
            srKey.Close();

            StreamReader srData = new StreamReader(dataFilePath);
            data = srData.ReadToEnd();
            srData.Close();
        }

        private void SaveData(string data, char action)
        {
            string path = "";
            var tempArray = dataFilePath.Split('.');
            for (int i = 0; i < tempArray.Length - 2; i++)
            {
                path += tempArray[i] + ".";
                if (i == tempArray.Length - 3)
                {
                    if (action == 'E')
                        path += tempArray[i + 1] + "-encrypted." + tempArray[i + 2];
                    else
                        path += tempArray[i + 1] + "-decrypted." + tempArray[i + 2];
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
