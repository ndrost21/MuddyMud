using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuddyMud
{
    public partial class MuddyMud : Form
    {
        public MuddyMud()
        {
            InitializeComponent();
        }

        private void MuddyMud_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblGold.Text += 1;
        }
    }
}
