﻿namespace WindowsFormsApp1
{
    partial class telaAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAgenda));
            this.rbuNome = new System.Windows.Forms.RadioButton();
            this.rbuCPF = new System.Windows.Forms.RadioButton();
            this.rbuMedico = new System.Windows.Forms.RadioButton();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.lblConsultasHoje = new System.Windows.Forms.Label();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.btnPacienteConsulta = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnEstoqueFuncionario = new System.Windows.Forms.Button();
            this.btnProntuario = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.barraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbuNome
            // 
            this.rbuNome.AutoSize = true;
            this.rbuNome.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.rbuNome.Location = new System.Drawing.Point(26, 94);
            this.rbuNome.Name = "rbuNome";
            this.rbuNome.Size = new System.Drawing.Size(82, 28);
            this.rbuNome.TabIndex = 10;
            this.rbuNome.TabStop = true;
            this.rbuNome.Text = "Nome";
            this.rbuNome.UseVisualStyleBackColor = true;
            this.rbuNome.UseWaitCursor = true;
            // 
            // rbuCPF
            // 
            this.rbuCPF.AutoSize = true;
            this.rbuCPF.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.rbuCPF.Location = new System.Drawing.Point(114, 94);
            this.rbuCPF.Name = "rbuCPF";
            this.rbuCPF.Size = new System.Drawing.Size(67, 28);
            this.rbuCPF.TabIndex = 11;
            this.rbuCPF.TabStop = true;
            this.rbuCPF.Text = "CPF";
            this.rbuCPF.UseVisualStyleBackColor = true;
            this.rbuCPF.UseWaitCursor = true;
            // 
            // rbuMedico
            // 
            this.rbuMedico.AutoSize = true;
            this.rbuMedico.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.rbuMedico.Location = new System.Drawing.Point(187, 94);
            this.rbuMedico.Name = "rbuMedico";
            this.rbuMedico.Size = new System.Drawing.Size(96, 28);
            this.rbuMedico.TabIndex = 12;
            this.rbuMedico.TabStop = true;
            this.rbuMedico.Text = "Médico";
            this.rbuMedico.UseVisualStyleBackColor = true;
            this.rbuMedico.UseWaitCursor = true;
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPesquisaNome.Location = new System.Drawing.Point(27, 128);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPesquisaNome.Size = new System.Drawing.Size(477, 20);
            this.txtPesquisaNome.TabIndex = 13;
            this.txtPesquisaNome.Tag = "";
            this.txtPesquisaNome.Text = "Pesquisar por nome";
            this.txtPesquisaNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisaNome.UseWaitCursor = true;
            // 
            // lblConsultasHoje
            // 
            this.lblConsultasHoje.AutoSize = true;
            this.lblConsultasHoje.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.lblConsultasHoje.Location = new System.Drawing.Point(21, 183);
            this.lblConsultasHoje.Name = "lblConsultasHoje";
            this.lblConsultasHoje.Size = new System.Drawing.Size(316, 31);
            this.lblConsultasHoje.TabIndex = 14;
            this.lblConsultasHoje.Text = "Consultas marcas para hoje:";
            this.lblConsultasHoje.UseWaitCursor = true;
            this.lblConsultasHoje.Click += new System.EventHandler(this.lblConsultasHoje_Click);
            // 
            // barraSuperior
            // 
            this.barraSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.barraSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barraSuperior.Controls.Add(this.btnPacienteConsulta);
            this.barraSuperior.Controls.Add(this.button11);
            this.barraSuperior.Controls.Add(this.btnPagamento);
            this.barraSuperior.Controls.Add(this.btnEstoqueFuncionario);
            this.barraSuperior.Controls.Add(this.btnProntuario);
            this.barraSuperior.Controls.Add(this.btnAgenda);
            this.barraSuperior.Controls.Add(this.btnMedico);
            this.barraSuperior.Controls.Add(this.button5);
            this.barraSuperior.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraSuperior.Location = new System.Drawing.Point(-1, -2);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1350, 81);
            this.barraSuperior.TabIndex = 23;
            this.barraSuperior.UseWaitCursor = true;
            // 
            // btnPacienteConsulta
            // 
            this.btnPacienteConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPacienteConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacienteConsulta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacienteConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnPacienteConsulta.Image")));
            this.btnPacienteConsulta.Location = new System.Drawing.Point(-1, 0);
            this.btnPacienteConsulta.Name = "btnPacienteConsulta";
            this.btnPacienteConsulta.Size = new System.Drawing.Size(101, 80);
            this.btnPacienteConsulta.TabIndex = 23;
            this.btnPacienteConsulta.Text = "Paciente";
            this.btnPacienteConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPacienteConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPacienteConsulta.UseVisualStyleBackColor = false;
            this.btnPacienteConsulta.UseWaitCursor = true;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(605, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 80);
            this.button11.TabIndex = 22;
            this.button11.Text = "Funcionário";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.UseWaitCursor = true;
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamento.Image")));
            this.btnPagamento.Location = new System.Drawing.Point(504, 0);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(101, 80);
            this.btnPagamento.TabIndex = 21;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.UseWaitCursor = true;
            // 
            // btnEstoqueFuncionario
            // 
            this.btnEstoqueFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEstoqueFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoqueFuncionario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoqueFuncionario.Image")));
            this.btnEstoqueFuncionario.Location = new System.Drawing.Point(403, 0);
            this.btnEstoqueFuncionario.Name = "btnEstoqueFuncionario";
            this.btnEstoqueFuncionario.Size = new System.Drawing.Size(101, 80);
            this.btnEstoqueFuncionario.TabIndex = 20;
            this.btnEstoqueFuncionario.Text = "Estoque";
            this.btnEstoqueFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoqueFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstoqueFuncionario.UseVisualStyleBackColor = false;
            this.btnEstoqueFuncionario.UseWaitCursor = true;
            // 
            // btnProntuario
            // 
            this.btnProntuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnProntuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProntuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProntuario.Image = ((System.Drawing.Image)(resources.GetObject("btnProntuario.Image")));
            this.btnProntuario.Location = new System.Drawing.Point(302, 0);
            this.btnProntuario.Name = "btnProntuario";
            this.btnProntuario.Size = new System.Drawing.Size(101, 80);
            this.btnProntuario.TabIndex = 19;
            this.btnProntuario.Text = "Prontuário";
            this.btnProntuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProntuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProntuario.UseVisualStyleBackColor = false;
            this.btnProntuario.UseWaitCursor = true;
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.Location = new System.Drawing.Point(201, 0);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(101, 80);
            this.btnAgenda.TabIndex = 18;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.UseWaitCursor = true;
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedico.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnMedico.Image")));
            this.btnMedico.Location = new System.Drawing.Point(100, 0);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(101, 80);
            this.btnMedico.TabIndex = 17;
            this.btnMedico.Text = "Médico";
            this.btnMedico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMedico.UseVisualStyleBackColor = false;
            this.btnMedico.UseWaitCursor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(706, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 80);
            this.button5.TabIndex = 16;
            this.button5.Text = "Pesquisa";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            // 
            // telaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1330, 686);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.lblConsultasHoje);
            this.Controls.Add(this.txtPesquisaNome);
            this.Controls.Add(this.rbuMedico);
            this.Controls.Add(this.rbuCPF);
            this.Controls.Add(this.rbuNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaAgenda";
            this.Text = "telaAgenda";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.telaAgenda_Load);
            this.barraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbuNome;
        private System.Windows.Forms.RadioButton rbuCPF;
        private System.Windows.Forms.RadioButton rbuMedico;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label lblConsultasHoje;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Button btnPacienteConsulta;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnEstoqueFuncionario;
        private System.Windows.Forms.Button btnProntuario;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button button5;
    }
}