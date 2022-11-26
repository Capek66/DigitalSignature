using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignature
{
    public partial class DSMain : Form
    {
        public DSMain()
        {
            InitializeComponent();
        }

        private void StSim_Click(object sender, EventArgs e)
        {
            CreateSymKey createSymKey = new CreateSymKey();
            panel.Controls.Clear();
            panel.Controls.Add(createSymKey);
        }

        private void StAsim_Click(object sender, EventArgs e)
        {
            CreateAsymKey createAsymKey = new CreateAsymKey();
            panel.Controls.Clear();
            panel.Controls.Add(createAsymKey);
        }

        private void KDSim_Click(object sender, EventArgs e)
        {
            EncDecSym encDecSym = new EncDecSym();
            panel.Controls.Clear();
            panel.Controls.Add(encDecSym);
        }

        private void KDAsim_Click(object sender, EventArgs e)
        {

            EncDecAsym encDecAsym = new EncDecAsym();
            panel.Controls.Clear();
            panel.Controls.Add(encDecAsym);
        }
    }
}
