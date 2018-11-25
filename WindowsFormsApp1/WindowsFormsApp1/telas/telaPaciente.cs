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
using WindowsFormsApp1.controlador;
using WindowsFormsApp1.dominio;

namespace WindowsFormsApp1
{
    public partial class btnSalvarFunc : Form
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

        controladorPaciente controlador = new controladorPaciente();

        Timer t = new Timer();

        public btnSalvarFunc()
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

        private void btnPacienteConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnPacienteConsulta_Click_1(object sender, EventArgs e)
        {
            abripac.AbrirCadPaciente(this);
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            abrirmed.AbrirCadMedico(this);
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            abriragen.AbrirCadAgenda(this);
        }

        private void btnProntuario_Click(object sender, EventArgs e)
        {
            abrirpront.AbrirCadProntuario(this);
        }

        private void btnEstoqueFuncionario_Click(object sender, EventArgs e)
        {
            abrirest.AbrirCadEstoque(this);
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            abrirpag.AbrirCadPagamento(this);
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            abrirfunc.AbrirCadFuncionario(this);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            abrirpesq.AbrirCadPEsquisa(this);
        }

        private void btnSairPrograma_Click(object sender, EventArgs e)
        {
            fecharform.FecharTela(this);
        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.ExibirCadPac();
        }

        private void t_Tick(object sennder, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }

            else
            {
                time += ss;
            }

            lblRelogio.Text = time;
        }

        private void telaPaciente_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();

            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            if (validarCamposVazios())
            {


                paciente.Nome_pac = txbNomePac.Text;
                paciente.Nasc_pac = TryParse(mskNascPac);
                paciente.Idade_pac = txbIdadePac.Text;
                paciente.Cpf_pac = mskCpfPac.Text;
                paciente.Rg_pac = mskRgPac.Text;
                paciente.Etnia_pac = cmbEtniaPac.Text;
                paciente.Sexo_pac = rdbFemPac.Text;
                paciente.Rua_pac = txbRuaPac.Text;
                paciente.Bairro_pac = txbBairroPac.Text;
                paciente.Numero_rua_pac = txbNumRuaPac.Text;
                paciente.Cidade_pac = txbCidadePac.Text;
                paciente.Telefone_pac = mskTelPac.Text;
                paciente.Celular_pac = mskCelPac.Text;
                paciente.Email_pac = txbEmailPac.Text;
                paciente.Pai_pac = txbPaiPac.Text;
                paciente.Mae_pac = txbMaePac.Text;
                paciente.Responsavel_pac = txbRespPac.Text;
                
                
                controlador.inserirPaciente(paciente);
                // LimparTela();

            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                
            }
        }
    }
}
