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
using System.Xml.Serialization;

namespace DigitalSignature
{
    public partial class CreateAsymKey : UserControl
    {
        public CreateAsymKey()
        {
            InitializeComponent();
            succes.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            succes.Visible = true;

            var rsa = new RSACryptoServiceProvider(2048);
            RSAParameters privateKey = rsa.ExportParameters(true);
            RSAParameters publicKey = rsa.ExportParameters(false);
            SaveKey(privateKey, "privatni_kljuc");
            SaveKey(publicKey, "javni_kljuc");
        }

        private void SaveKey(RSAParameters key, string fName)
        {
            StringWriter stringWriter = new StringWriter();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(stringWriter, key);

            string fileName = @"..\..\Keys\" + fName + ".txt";
            FileStream fs = File.Create(fileName);
            fs.Close();
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(stringWriter.ToString());
            sw.Close();
        }
    }
}
