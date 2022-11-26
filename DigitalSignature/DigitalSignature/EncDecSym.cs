using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignature
{
    public partial class EncDecSym : UserControl
    {
        private string keyFilePath = "";
        private string dataFilePath = "";
        private byte[] secretKey;
        private byte[] IV;
        private string data;
        public EncDecSym()
        {
            InitializeComponent();
            succesEnc.Visible = false;
            succesDec.Visible = false;
            error.Visible = false;
        }

        private void btnChooseKey_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog chooseKey = new OpenFileDialog();
                chooseKey.ShowDialog();
                keyFilePath = Path.GetFullPath(chooseKey.FileName);
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
                dataFilePath = Path.GetFullPath(chooseFile.FileName);
                tbFile.Text = Path.GetFileName(chooseFile.FileName);
            }
            catch
            {
                
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if((keyFilePath != "") && (dataFilePath != ""))
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
            Aes aes = Aes.Create();
            aes.KeySize = 256;
            ICryptoTransform encr = aes.CreateEncryptor(secretKey, IV);
            byte[] encrypted;

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encr, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(data);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
            SaveData(Convert.ToBase64String(encrypted), 'E');
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
            Aes aes = Aes.Create();
            aes.KeySize = 256;
            ICryptoTransform decrypter = aes.CreateDecryptor(secretKey, IV);

            using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(data)))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decrypter, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        SaveData(srDecrypt.ReadToEnd(), 'D');
                    }
                }
            }
        }

        private void GetKeyAndData()
        {
            string key;
            string initVec;

            StreamReader srKey = new StreamReader(keyFilePath);
            key = srKey.ReadLine();
            initVec = srKey.ReadLine();
            srKey.Close();
            secretKey = Convert.FromBase64String(key);
            IV = Convert.FromBase64String(initVec);

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
