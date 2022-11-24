using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DigitalSignature
{
    public partial class CreateSymKey : UserControl
    {
        public CreateSymKey()
        {
            InitializeComponent();
            succes.Visible = false;
            error.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "" && tbSurname.Text != "")
            {
                error.Visible = false;
                succes.Visible = true;
                Aes aes = Aes.Create();
                aes.KeySize = 256;
                aes.GenerateIV();
                aes.GenerateKey();
                //var hexString = Convert.ToBase64String(aes.Key);
                //MessageBox.Show(hexString);

                //byte[] test = Convert.FromBase64String(hexString);

                string fileName = @"..\..\Keys\tajni_kljuc.txt";
                FileStream fs = File.Create(fileName);
                fs.Close();
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine(Convert.ToBase64String(aes.Key));
                sw.WriteLine(Convert.ToBase64String(aes.IV));
                sw.Close();

                //string symKey;
                //StreamReader sr = new StreamReader(fileName);
                //symKey = sr.ReadLine();
                //sr.Close();
                //byte[] test = Convert.FromBase64String(symKey);

                //ICryptoTransform encr = aes.CreateEncryptor(aes.Key, aes.IV);
                //byte[] encrypted;
                //using (MemoryStream msEncrypt = new MemoryStream())
                //{
                //    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encr, CryptoStreamMode.Write))
                //    {
                //        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                //        {
                //            //Write all data to the stream.
                //            swEncrypt.Write("Test 123");
                //        }
                //        encrypted = msEncrypt.ToArray();
                //    }
                //}
                //MessageBox.Show(Convert.ToBase64String(encrypted));


                //ICryptoTransform decrypter = aes.CreateDecryptor(test, aes.IV);
                //using (MemoryStream msDecrypt = new MemoryStream(encrypted))
                //{
                //    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decrypter, CryptoStreamMode.Read))
                //    {
                //        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                //        {

                //            // Read the decrypted bytes from the decrypting stream
                //            // and place them in a string.
                //            MessageBox.Show(srDecrypt.ReadToEnd());
                //        }
                //    }
                //}
            }
            else
            {
                error.Visible = true;
                succes.Visible = false;
            }
        }
    }
}
