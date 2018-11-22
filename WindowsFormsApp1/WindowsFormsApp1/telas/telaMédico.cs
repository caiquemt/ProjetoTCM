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
    public partial class telaMédico : Form
    {
        fecharAbrirMenus fecharform = new fecharAbrirMenus();
        AbrirPaciente abripac = new AbrirPaciente();
        AbrirFuncionario abrirfunc = new AbrirFuncionario();
        AbrirPagamento abrirpag = new AbrirPagamento();
        AbrirServico abrirserv = new AbrirServico();
        AbrirAgenda abriragen = new AbrirAgenda();

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

        private void btnPacienteConsulta_Click(object sender, EventArgs e)
        {
            abripac.AbrirCadPaciente(this);
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {

        }

       
        internal void AbrirCadMedico(telaCadastroDoFuncionario telaCadastroDoFuncionario)
        {
            throw new NotImplementedException();
        }
    }
}
