using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkboxApp
{
    public partial class naslov : Form
    {
        public naslov()
        {
            InitializeComponent();
        }
       
        private void sakrijCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sakrijCB.Checked)
            {
                odabranoTB.Hide();
            }
            else {
                odabranoTB.Show();
            }
        }
    }
}
