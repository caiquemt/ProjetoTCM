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
using WindowsFormsApp1.dominio;

namespace WindowsFormsApp1
{
    public partial class telaCadastroDoFuncionario : Form
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

        Timer t = new Timer();

        public telaCadastroDoFuncionario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void barraSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            abrirpag.AbrirCadPagamento(this);
        }

        private void btnProntuario_Click(object sender, EventArgs e)
        {
            abrirpront.AbrirCadProntuario(this);
        }

        private void lbCidadeCadastro_Click(object sender, EventArgs e)
        {

        }

        private void lbMatriculaCadastro_Click(object sender, EventArgs e)
        {

        }

        private void txtHorarioExpedienteCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefoneCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSairCadastro_Click(object sender, EventArgs e)
        {
            fecharform.FecharTela(this);
        }

        private void btnPacienteConsulta_Click(object sender, EventArgs e)
        {
            abrirpac.AbrirCadPaciente(this);
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            abrirmed.AbrirCadMedico(this);
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            abriragen.AbrirCadAgenda(this);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            abrirpesq.AbrirCadPEsquisa(this);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnPacienteConsulta_Click_1(object sender, EventArgs e)
        {
            abrirpac.AbrirCadPaciente(this);
        }

        private void btnMedico_Click_1(object sender, EventArgs e)
        {
            abrirmed.AbrirCadMedico(this);
        }

        private void btnAgenda_Click_1(object sender, EventArgs e)
        {
            abriragen.AbrirCadAgenda(this);
        }

        private void btnEstoqueFuncionario_Click(object sender, EventArgs e)
        {
            abrirest.AbrirCadEstoque(this);
        }

        private void btnFuncionario_Click_1(object sender, EventArgs e)
        {
            abrirfunc.AbrirCadFuncionario(this);
        }

        private void btnPesquisa_Click_1(object sender, EventArgs e)
        {
            abrirpesq.AbrirCadPEsquisa(this);
        }

        private void btnSairCadastro_Click_1(object sender, EventArgs e)
        {
            fecharform.FecharTela(this);
        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.exibirValores();
        }

        private void txtNascFunc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
    }
}
