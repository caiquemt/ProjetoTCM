﻿namespace WindowsFormsApp1
{
    partial class barraInferior
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barraInferior));
            this.rbuNome = new System.Windows.Forms.RadioButton();
            this.rbuCPF = new System.Windows.Forms.RadioButton();
            this.rbuMedico = new System.Windows.Forms.RadioButton();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSairCadastro = new System.Windows.Forms.Button();
            this.btnVoltarCadastro = new System.Windows.Forms.Button();
            this.btnPacienteConsulta = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnEstoqueFuncionario = new System.Windows.Forms.Button();
            this.btnProntuario = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarCons = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblRelógio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barraSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbuNome
            // 
            this.rbuNome.AutoSize = true;
            this.rbuNome.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.rbuNome.Location = new System.Drawing.Point(210, 247);
            this.rbuNome.Name = "rbuNome";
            this.rbuNome.Size = new System.Drawing.Size(94, 32);
            this.rbuNome.TabIndex = 10;
            this.rbuNome.TabStop = true;
            this.rbuNome.Text = "Nome";
            this.rbuNome.UseVisualStyleBackColor = true;
            // 
            // rbuCPF
            // 
            this.rbuCPF.AutoSize = true;
            this.rbuCPF.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.rbuCPF.Location = new System.Drawing.Point(307, 247);
            this.rbuCPF.Name = "rbuCPF";
            this.rbuCPF.Size = new System.Drawing.Size(72, 32);
            this.rbuCPF.TabIndex = 11;
            this.rbuCPF.TabStop = true;
            this.rbuCPF.Text = "CPF";
            this.rbuCPF.UseVisualStyleBackColor = true;
            // 
            // rbuMedico
            // 
            this.rbuMedico.AutoSize = true;
            this.rbuMedico.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.rbuMedico.Location = new System.Drawing.Point(385, 247);
            this.rbuMedico.Name = "rbuMedico";
            this.rbuMedico.Size = new System.Drawing.Size(110, 32);
            this.rbuMedico.TabIndex = 12;
            this.rbuMedico.TabStop = true;
            this.rbuMedico.Text = "Médico";
            this.rbuMedico.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.txtPesquisaNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPesquisaNome.Location = new System.Drawing.Point(166, 195);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPesquisaNome.Size = new System.Drawing.Size(1066, 36);
            this.txtPesquisaNome.TabIndex = 13;
            this.txtPesquisaNome.Tag = "";
            this.txtPesquisaNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // barraSuperior
            // 
            this.barraSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraSuperior.BackColor = System.Drawing.Color.LightSeaGreen;
            this.barraSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barraSuperior.Controls.Add(this.btnMinimizar);
            this.barraSuperior.Controls.Add(this.btnSairCadastro);
            this.barraSuperior.Controls.Add(this.btnVoltarCadastro);
            this.barraSuperior.Controls.Add(this.btnPacienteConsulta);
            this.barraSuperior.Controls.Add(this.btnFuncionario);
            this.barraSuperior.Controls.Add(this.btnPagamento);
            this.barraSuperior.Controls.Add(this.btnEstoqueFuncionario);
            this.barraSuperior.Controls.Add(this.btnProntuario);
            this.barraSuperior.Controls.Add(this.btnAgenda);
            this.barraSuperior.Controls.Add(this.btnMedico);
            this.barraSuperior.Controls.Add(this.btnPesquisa);
            this.barraSuperior.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1280, 81);
            this.barraSuperior.TabIndex = 23;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1077, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(101, 80);
            this.btnMinimizar.TabIndex = 31;
            this.btnMinimizar.Text = "Minimizar";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSairCadastro
            // 
            this.btnSairCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSairCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnSairCadastro.Image")));
            this.btnSairCadastro.Location = new System.Drawing.Point(1177, 0);
            this.btnSairCadastro.Name = "btnSairCadastro";
            this.btnSairCadastro.Size = new System.Drawing.Size(101, 80);
            this.btnSairCadastro.TabIndex = 24;
            this.btnSairCadastro.Text = "Sair";
            this.btnSairCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSairCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSairCadastro.UseVisualStyleBackColor = true;
            this.btnSairCadastro.Click += new System.EventHandler(this.btnSairCadastro_Click_1);
            // 
            // btnVoltarCadastro
            // 
            this.btnVoltarCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarCadastro.Image")));
            this.btnVoltarCadastro.Location = new System.Drawing.Point(977, 0);
            this.btnVoltarCadastro.Name = "btnVoltarCadastro";
            this.btnVoltarCadastro.Size = new System.Drawing.Size(101, 80);
            this.btnVoltarCadastro.TabIndex = 25;
            this.btnVoltarCadastro.Text = "Voltar";
            this.btnVoltarCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnPacienteConsulta
            // 
            this.btnPacienteConsulta.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPacienteConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacienteConsulta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacienteConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnPacienteConsulta.Image")));
            this.btnPacienteConsulta.Location = new System.Drawing.Point(0, 0);
            this.btnPacienteConsulta.Name = "btnPacienteConsulta";
            this.btnPacienteConsulta.Size = new System.Drawing.Size(101, 80);
            this.btnPacienteConsulta.TabIndex = 23;
            this.btnPacienteConsulta.Text = "Paciente";
            this.btnPacienteConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPacienteConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPacienteConsulta.UseVisualStyleBackColor = false;
            this.btnPacienteConsulta.Click += new System.EventHandler(this.btnPacienteConsulta_Click_1);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
            this.btnFuncionario.Location = new System.Drawing.Point(600, 0);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(101, 80);
            this.btnFuncionario.TabIndex = 22;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamento.Image")));
            this.btnPagamento.Location = new System.Drawing.Point(500, 0);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(101, 80);
            this.btnPagamento.TabIndex = 21;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click_2);
            // 
            // btnEstoqueFuncionario
            // 
            this.btnEstoqueFuncionario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEstoqueFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoqueFuncionario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoqueFuncionario.Image")));
            this.btnEstoqueFuncionario.Location = new System.Drawing.Point(400, 0);
            this.btnEstoqueFuncionario.Name = "btnEstoqueFuncionario";
            this.btnEstoqueFuncionario.Size = new System.Drawing.Size(101, 80);
            this.btnEstoqueFuncionario.TabIndex = 20;
            this.btnEstoqueFuncionario.Text = "Estoque";
            this.btnEstoqueFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoqueFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstoqueFuncionario.UseVisualStyleBackColor = false;
            this.btnEstoqueFuncionario.Click += new System.EventHandler(this.btnEstoqueFuncionario_Click_1);
            // 
            // btnProntuario
            // 
            this.btnProntuario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnProntuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProntuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProntuario.Image = ((System.Drawing.Image)(resources.GetObject("btnProntuario.Image")));
            this.btnProntuario.Location = new System.Drawing.Point(300, 0);
            this.btnProntuario.Name = "btnProntuario";
            this.btnProntuario.Size = new System.Drawing.Size(101, 80);
            this.btnProntuario.TabIndex = 19;
            this.btnProntuario.Text = "Prontuário";
            this.btnProntuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProntuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProntuario.UseVisualStyleBackColor = false;
            this.btnProntuario.Click += new System.EventHandler(this.btnProntuario_Click_2);
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.Location = new System.Drawing.Point(200, 0);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(101, 80);
            this.btnAgenda.TabIndex = 18;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click_1);
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click_2);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.Location = new System.Drawing.Point(700, 0);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(101, 80);
            this.btnPesquisa.TabIndex = 16;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pesquisar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Pesquisar por:";
            // 
            // btnCadastrarCons
            // 
            this.btnCadastrarCons.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCadastrarCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCons.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarCons.Location = new System.Drawing.Point(1091, 242);
            this.btnCadastrarCons.Name = "btnCadastrarCons";
            this.btnCadastrarCons.Size = new System.Drawing.Size(141, 43);
            this.btnCadastrarCons.TabIndex = 26;
            this.btnCadastrarCons.Text = "Cadastrar";
            this.btnCadastrarCons.UseVisualStyleBackColor = false;
            this.btnCadastrarCons.Click += new System.EventHandler(this.btnCadastrarCons_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblRelógio);
            this.panel1.Location = new System.Drawing.Point(0, 685);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 35);
            this.panel1.TabIndex = 27;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblData.Location = new System.Drawing.Point(778, 3);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(64, 28);
            this.lblData.TabIndex = 44;
            this.lblData.Text = "Data";
            // 
            // lblRelógio
            // 
            this.lblRelógio.AutoSize = true;
            this.lblRelógio.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblRelógio.Location = new System.Drawing.Point(1163, 0);
            this.lblRelógio.Name = "lblRelógio";
            this.lblRelógio.Size = new System.Drawing.Size(110, 28);
            this.lblRelógio.TabIndex = 0;
            this.lblRelógio.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 41);
            this.label3.TabIndex = 29;
            this.label3.Text = "AGENDA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1195, 369);
            this.dataGridView1.TabIndex = 30;
            // 
            // barraInferior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastrarCons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.txtPesquisaNome);
            this.Controls.Add(this.rbuMedico);
            this.Controls.Add(this.rbuCPF);
            this.Controls.Add(this.rbuNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "barraInferior";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaAgenda";
            this.Load += new System.EventHandler(this.telaAgenda_Load);
            this.barraSuperior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbuNome;
        private System.Windows.Forms.RadioButton rbuCPF;
        private System.Windows.Forms.RadioButton rbuMedico;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Button btnPacienteConsulta;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnEstoqueFuncionario;
        private System.Windows.Forms.Button btnProntuario;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnSairCadastro;
        private System.Windows.Forms.Button btnVoltarCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarCons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRelógio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnMinimizar;
    }
}