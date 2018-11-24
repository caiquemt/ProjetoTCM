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
    public partial class telaExame : Form
    {
        fecharAbrirMenus fecharform = new fecharAbrirMenus();
        AbrirPaciente abrirpac = new AbrirPaciente();
        AbrirMedico abrirmed = new AbrirMedico();
        AbrirFuncionario abrirfunc = new AbrirFuncionario();
        AbrirPagamento abrirpag = new AbrirPagamento();
        AbrirServico abrirserv = new AbrirServico();
        AbrirProntuario abrirpront = new AbrirProntuario();
        AbrirPesquisa abrirpesq = new AbrirPesquisa();
        AbrirEstoque abrirest = new AbrirEstoque();
        AbrirAgenda abriragen = new AbrirAgenda();

        public telaExame()
        {
            InitializeComponent();
        }

        private void btnPacienteExame_Click(object sender, EventArgs e)
        {
            abrirpac.AbrirCadPaciente(this);
        }

        private void btnMedicoExame_Click(object sender, EventArgs e)
        {
            abrirmed.AbrirCadMedico(this);
        }

        private void btnAgendaExame_Click(object sender, EventArgs e)
        {
            abriragen.AbrirCadAgenda(this);
        }

        private void btnProntuarioExame_Click(object sender, EventArgs e)
        {
            abrirpront.AbrirCadProntuario(this);
        }

        private void btnEstoqueExame_Click(object sender, EventArgs e)
        {
            abrirest.AbrirCadEstoque(this);
        }

        private void btnPagamentoExame_Click(object sender, EventArgs e)
        {
            abrirpag.AbrirCadPagamento(this);
        }

        private void btnFuncionarioExame_Click(object sender, EventArgs e)
        {
            abrirfunc.AbrirCadFuncionario(this);
        }

        private void btnPesquisaExame_Click(object sender, EventArgs e)
        {
            abrirpesq.AbrirCadPEsquisa(this);
        }
    }
}
