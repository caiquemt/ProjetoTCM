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
    public partial class telaConsulta : Form
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

        Timer t = new Timer();

        public telaConsulta()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblConsulta_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void btnEstoqueFuncionario_Click(object sender, EventArgs e)
        {
            abrirest.AbrirCadEstoque(this);
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            abrirpag.AbrirCadPagamento(this);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            abrirfunc.AbrirCadFuncionario(this);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            abrirpesq.AbrirCadPEsquisa(this);
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

        private void barraSuperior_Paint(object sender, PaintEventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();

            lblData.Text = DateTime.Now.ToLongDateString();
        }

    }
}
