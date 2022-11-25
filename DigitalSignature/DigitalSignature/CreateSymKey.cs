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
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            succes.Visible = true;

            Aes aes = Aes.Create();
            aes.KeySize = 256;
            aes.GenerateIV();
            aes.GenerateKey();

            string fileName = @"..\..\Keys\tajni_kljuc.txt";
            FileStream fs = File.Create(fileName);
            fs.Close();
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(Convert.ToBase64String(aes.Key));
            sw.WriteLine(Convert.ToBase64String(aes.IV));
            sw.Close();
        }
    }
}
