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
        fecharAbrirMenus fecharform = new fecharAbrirMenus();

        public telaPaciente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSairPrograma1_Click(object sender, EventArgs e)
        {
            fecharform.FecharTela(this);
        }
    }
}
