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
    public partial class CreateAsymKey : UserControl
    {
        public CreateAsymKey()
        {
            InitializeComponent();
            error.Visible = false;
            succes.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbSurname.Text != "")
            {
                error.Visible = false;
                succes.Visible = true;

                var rsa = new RSACryptoServiceProvider(2048);
                
                
               

                string fileName = @"..\..\Keys\tajni_kljuc.txt";
                FileStream fs = File.Create(fileName);
                fs.Close();
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine(Convert.ToBase64String(aes.Key));
                sw.WriteLine(Convert.ToBase64String(aes.IV));
                sw.Close();
            }
            else
            {
                error.Visible = true;
                succes.Visible = false;
            }
        }
    }
}
