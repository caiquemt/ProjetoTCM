﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class telaLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
        );

        //Enter code here for your version of username and userpassword 
        Login login = new Login("caique", "zxc");

        public telaLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void lusuario_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            telaMenu telamenu = new telaMenu();

            //define local variables from the user inputs 
            string user = txtUsuarioLogin.Text;
            string pass = txtSenhaLogin.Text;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("Logado com sucesso");
                telamenu.Show();
                this.Hide();
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Erro ao conectar");
                txtUsuarioLogin.Clear();
                txtSenhaLogin.Clear();
                txtUsuarioLogin.Focus();
            }
   
        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            txtUsuarioLogin.Clear();
            txtSenhaLogin.Clear();
            txtUsuarioLogin.Focus();
        }

        private void lkEsqueciSenhaLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Entre em contato com o administrador para redefinir sua senha.");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            fecharAbrirMenus fecharform = new fecharAbrirMenus();

            fecharform.FecharTela(this);
        }
    }
}
