using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.abrir_fechar_menus;

namespace WindowsFormsApp1
{
    public partial class telaMenu : Form
    {
        fecharAbrirMenus fecharform = new fecharAbrirMenus();
        AbrirPaciente abripac = new AbrirPaciente();
        AbrirMedico abrirmed = new AbrirMedico();
        AbrirFuncionario abrirfunc = new AbrirFuncionario();
        AbrirPagamento abrirpag = new AbrirPagamento();
        AbrirServico abrirserv = new AbrirServico();
        AbrirProntuario abrirpront = new AbrirProntuario();
        AbrirPesquisa abrirpesq = new AbrirPesquisa();
        AbrirEstoque abrirest = new AbrirEstoque();
        AbrirAgenda abriragen = new AbrirAgenda();

        public telaMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            abripac.AbrirCadPaciente(this);
        }
    }
}
