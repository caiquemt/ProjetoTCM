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
    public partial class telaMédico : Form
    {
        fecharAbrirMenus fecharform = new fecharAbrirMenus();

        public telaMédico()
        {
            InitializeComponent();
        }

        private void txtDataNascimentoCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHorarioExpedienteCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSairPrograma_Click(object sender, EventArgs e)
        {
            fecharform.FecharTela(this);
        }
    }
}
