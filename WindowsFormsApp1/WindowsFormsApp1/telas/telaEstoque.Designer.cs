﻿namespace WindowsFormsApp1
{
    partial class telaEstoque
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaEstoque));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.btnSairCadastro = new System.Windows.Forms.Button();
            this.btnVoltarCadastro = new System.Windows.Forms.Button();
            this.btnPacienteConsulta = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnEstoqueFuncionario = new System.Windows.Forms.Button();
            this.btnProntuario = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.barraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(691, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 233);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // barraSuperior
            // 
            this.barraSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.barraSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barraSuperior.Controls.Add(this.btnSairCadastro);
            this.barraSuperior.Controls.Add(this.btnVoltarCadastro);
            this.barraSuperior.Controls.Add(this.btnPacienteConsulta);
            this.barraSuperior.Controls.Add(this.button11);
            this.barraSuperior.Controls.Add(this.btnPagamento);
            this.barraSuperior.Controls.Add(this.btnEstoqueFuncionario);
            this.barraSuperior.Controls.Add(this.btnProntuario);
            this.barraSuperior.Controls.Add(this.btnAgenda);
            this.barraSuperior.Controls.Add(this.btnMedico);
            this.barraSuperior.Controls.Add(this.button5);
            this.barraSuperior.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1350, 81);
            this.barraSuperior.TabIndex = 23;
            // 
            // btnSairCadastro
            // 
            this.btnSairCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSairCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnSairCadastro.Image")));
            this.btnSairCadastro.Location = new System.Drawing.Point(1257, -2);
            this.btnSairCadastro.Name = "btnSairCadastro";
            this.btnSairCadastro.Size = new System.Drawing.Size(92, 81);
            this.btnSairCadastro.TabIndex = 26;
            this.btnSairCadastro.Text = "Sair";
            this.btnSairCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSairCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSairCadastro.UseVisualStyleBackColor = true;
            this.btnSairCadastro.Click += new System.EventHandler(this.btnSairCadastro_Click);
            // 
            // btnVoltarCadastro
            // 
            this.btnVoltarCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarCadastro.Image")));
            this.btnVoltarCadastro.Location = new System.Drawing.Point(1161, -2);
            this.btnVoltarCadastro.Name = "btnVoltarCadastro";
            this.btnVoltarCadastro.Size = new System.Drawing.Size(90, 81);
            this.btnVoltarCadastro.TabIndex = 27;
            this.btnVoltarCadastro.Text = "Voltar";
            this.btnVoltarCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnPacienteConsulta
            // 
            this.btnPacienteConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPacienteConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacienteConsulta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacienteConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnPacienteConsulta.Image")));
            this.btnPacienteConsulta.Location = new System.Drawing.Point(-1, -1);
            this.btnPacienteConsulta.Name = "btnPacienteConsulta";
            this.btnPacienteConsulta.Size = new System.Drawing.Size(101, 80);
            this.btnPacienteConsulta.TabIndex = 23;
            this.btnPacienteConsulta.Text = "Paciente";
            this.btnPacienteConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPacienteConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPacienteConsulta.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(605, -1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 80);
            this.button11.TabIndex = 22;
            this.button11.Text = "Funcionário";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamento.Image")));
            this.btnPagamento.Location = new System.Drawing.Point(504, -1);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(101, 80);
            this.btnPagamento.TabIndex = 21;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPagamento.UseVisualStyleBackColor = false;
            // 
            // btnEstoqueFuncionario
            // 
            this.btnEstoqueFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEstoqueFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoqueFuncionario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoqueFuncionario.Image")));
            this.btnEstoqueFuncionario.Location = new System.Drawing.Point(403, -1);
            this.btnEstoqueFuncionario.Name = "btnEstoqueFuncionario";
            this.btnEstoqueFuncionario.Size = new System.Drawing.Size(101, 80);
            this.btnEstoqueFuncionario.TabIndex = 20;
            this.btnEstoqueFuncionario.Text = "Estoque";
            this.btnEstoqueFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoqueFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstoqueFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnProntuario
            // 
            this.btnProntuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnProntuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProntuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProntuario.Image = ((System.Drawing.Image)(resources.GetObject("btnProntuario.Image")));
            this.btnProntuario.Location = new System.Drawing.Point(302, -1);
            this.btnProntuario.Name = "btnProntuario";
            this.btnProntuario.Size = new System.Drawing.Size(101, 80);
            this.btnProntuario.TabIndex = 19;
            this.btnProntuario.Text = "Prontuário";
            this.btnProntuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProntuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProntuario.UseVisualStyleBackColor = false;
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.Location = new System.Drawing.Point(201, -1);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(101, 80);
            this.btnAgenda.TabIndex = 18;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgenda.UseVisualStyleBackColor = false;
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedico.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnMedico.Image")));
            this.btnMedico.Location = new System.Drawing.Point(100, -1);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(101, 80);
            this.btnMedico.TabIndex = 17;
            this.btnMedico.Text = "Médico";
            this.btnMedico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMedico.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(706, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 80);
            this.button5.TabIndex = 16;
            this.button5.Text = "Pesquisa";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // telaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.barraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Button btnSairCadastro;
        private System.Windows.Forms.Button btnVoltarCadastro;
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