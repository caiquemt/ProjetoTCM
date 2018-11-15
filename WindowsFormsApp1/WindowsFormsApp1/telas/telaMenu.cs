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
    public partial class telaMenu : Form
    {
        public telaMenu()
        {
            InitializeComponent();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            // this.Hide();
            // telaMedico Menu = new telaMedico();
            // Menu.Show();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            // this.Hide();
            // telaPesquisa Menu = new telaPesquisa();
            // Menu.Show();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            // this.Hide();
            // telaPaciente Menu = new telaPaciente();
            // Menu.Show();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaAgenda Menu = new telaAgenda();
            Menu.Show();
        }

        private void btnProntuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaSubMenuProntuario Menu = new telaSubMenuProntuario();
            Menu.Show();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPagamento Menu = new telaPagamento();
            Menu.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaEstoque Menu = new telaEstoque();
            Menu.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaCadastroDoFuncionario Menu = new telaCadastroDoFuncionario();
            Menu.Show();
        }
    }
}
