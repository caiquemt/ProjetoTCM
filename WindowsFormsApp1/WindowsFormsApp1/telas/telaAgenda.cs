﻿using System;
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
    public partial class telaAgenda : Form
    {
        fecharAbrirMenus fecharform = new fecharAbrirMenus();
        AbrirPaciente abripac = new AbrirPaciente();
        telaMédico abrirmed = new telaMédico();

        public telaAgenda()
        {
            InitializeComponent();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {

        }

        private void btnProntuario_Click(object sender, EventArgs e)
        {

        }

        private void btnMedico_Click(object sender, EventArgs e)
        {

        }

        private void lblConsultasHoje_Click(object sender, EventArgs e)
        {

        }

        private void telaAgenda_Load(object sender, EventArgs e)
        {

        }

        private void btnSairCadastro_Click(object sender, EventArgs e)
        {
            fecharform.FecharTela(this);
        }

        private void btnPacienteConsulta_Click(object sender, EventArgs e)
        {
            abripac.AbrirCadPaciente(this);
        }

        private void btnMedico_Click_1(object sender, EventArgs e)
        {
            abrirmed.AbrirCadMedico(this);
        }
    }
}
