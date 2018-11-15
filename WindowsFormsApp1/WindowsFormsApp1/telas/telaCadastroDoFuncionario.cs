using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.dominio;

namespace WindowsFormsApp1
{
    public partial class telaCadastroDoFuncionario : Form
    {
        public telaCadastroDoFuncionario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        }

        private void btnProntuario_Click(object sender, EventArgs e)
        {

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

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.exibirValores();
        }
    }
}
