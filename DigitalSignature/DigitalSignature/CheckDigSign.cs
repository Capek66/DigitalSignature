using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignature
{
    public partial class CheckDigSign : UserControl
    {
        private string pubKeyPath = "";
        private string filePath = "";
        private string signaturePath = "";
        public CheckDigSign()
        {
            InitializeComponent();
            error.Visible = false;
            valid.Visible = false;
            notValid.Visible = false;
        }

        private void btnChooseKey_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog chooseKey = new OpenFileDialog();
                chooseKey.ShowDialog();
                pubKeyPath = Path.GetFullPath(chooseKey.FileName);
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

        private void btnChooseSign_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog chooseSignature = new OpenFileDialog();
                chooseSignature.ShowDialog();
                signaturePath = Path.GetFullPath(chooseSignature.FileName);
                tbSignature.Text = Path.GetFileName(chooseSignature.FileName);
            }
            catch
            {

            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(tbKey.Text != "" && tbFile.Text != "" && tbSignature.Text != "")
            {
                error.Visible = false;

                if (DecryptSignature(GetData(signaturePath)))
                {
                    valid.Visible = true;
                    notValid.Visible = false;
                }
                else
                {
                    valid.Visible = false;
                    notValid.Visible = true;
                }
            }
            else
            {
                error.Visible = true;
                valid.Visible = false;
                notValid.Visible = false;
            }
        }

        private bool DecryptSignature(string encHash)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);

            rsa.FromXmlString(GetKey());

            return rsa.VerifyHash(CalculateHash(filePath), CryptoConfig.MapNameToOID("SHA256"), Convert.FromBase64String(encHash));
        }

        private byte[] CalculateHash(string path)
        {
            SHA256 hashCalc = SHA256.Create();
            FileStream fs = File.OpenRead(path);
            byte[] bytes = hashCalc.ComputeHash(fs);
            fs.Close();

            return bytes;
        }

        private string GetKey()
        {
            StreamReader srKey = new StreamReader(pubKeyPath);
            string key = srKey.ReadToEnd();
            srKey.Close();
            return key;
        }

        private string GetData(string path)
        {
            StreamReader srData = new StreamReader(path);
            string fileData = srData.ReadToEnd();
            srData.Close();
            return fileData;
        }
    }
}
