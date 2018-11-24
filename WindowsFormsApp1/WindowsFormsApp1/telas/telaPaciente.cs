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
using WindowsFormsApp1.dominio;

namespace WindowsFormsApp1
{
    public partial class telaPaciente : Form
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
    }
}
