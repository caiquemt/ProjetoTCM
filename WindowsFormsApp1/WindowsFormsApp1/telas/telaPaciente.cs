using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class telaPaciente : Form
    {
        public telaPaciente()
        {
            InitializeComponent();
            panel3.AutoScroll = false;
            panel3.HorizontalScroll.Enabled = false;
            panel3.HorizontalScroll.Visible = false;
            panel3.HorizontalScroll.Maximum = 0;
            panel3.AutoScroll = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
