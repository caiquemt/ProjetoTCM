namespace WindowsFormsApp1
{
    partial class telaExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaExame));
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.btnSairCadastro = new System.Windows.Forms.Button();
            this.btnVoltarCadastro = new System.Windows.Forms.Button();
            this.btnPacienteExame = new System.Windows.Forms.Button();
            this.btnFuncionarioExame = new System.Windows.Forms.Button();
            this.btnPagamentoExame = new System.Windows.Forms.Button();
            this.btnEstoqueExame = new System.Windows.Forms.Button();
            this.btnProntuarioExame = new System.Windows.Forms.Button();
            this.btnAgendaExame = new System.Windows.Forms.Button();
            this.btnMedicoExame = new System.Windows.Forms.Button();
            this.btnPesquisaExame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelecionarImagemExame = new System.Windows.Forms.Button();
            this.pcbExame = new System.Windows.Forms.PictureBox();
            this.lblDatadoExame = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNomedoExame = new System.Windows.Forms.Label();
            this.lblExame = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAlterarExame = new System.Windows.Forms.Button();
            this.btnSalvarExame = new System.Windows.Forms.Button();
            this.txbDataExame = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.barraSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraSuperior
            // 
            this.barraSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraSuperior.BackColor = System.Drawing.Color.LightSeaGreen;
            this.barraSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barraSuperior.Controls.Add(this.btnSairCadastro);
            this.barraSuperior.Controls.Add(this.btnVoltarCadastro);
            this.barraSuperior.Controls.Add(this.btnPacienteExame);
            this.barraSuperior.Controls.Add(this.btnFuncionarioExame);
            this.barraSuperior.Controls.Add(this.btnPagamentoExame);
            this.barraSuperior.Controls.Add(this.btnEstoqueExame);
            this.barraSuperior.Controls.Add(this.btnProntuarioExame);
            this.barraSuperior.Controls.Add(this.btnAgendaExame);
            this.barraSuperior.Controls.Add(this.btnMedicoExame);
            this.barraSuperior.Controls.Add(this.btnPesquisaExame);
            this.barraSuperior.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1367, 81);
            this.barraSuperior.TabIndex = 23;
            // 
            // btnSairCadastro
            // 
            this.btnSairCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSairCadastro.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSairCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnSairCadastro.Image")));
            this.btnSairCadastro.Location = new System.Drawing.Point(1274, -2);
            this.btnSairCadastro.Name = "btnSairCadastro";
            this.btnSairCadastro.Size = new System.Drawing.Size(92, 81);
            this.btnSairCadastro.TabIndex = 26;
            this.btnSairCadastro.Text = "Sair";
            this.btnSairCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSairCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSairCadastro.UseVisualStyleBackColor = false;
            this.btnSairCadastro.Click += new System.EventHandler(this.btnSairCadastro_Click);
            // 
            // btnVoltarCadastro
            // 
            this.btnVoltarCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarCadastro.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnVoltarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarCadastro.Image")));
            this.btnVoltarCadastro.Location = new System.Drawing.Point(1161, -2);
            this.btnVoltarCadastro.Name = "btnVoltarCadastro";
            this.btnVoltarCadastro.Size = new System.Drawing.Size(107, 81);
            this.btnVoltarCadastro.TabIndex = 27;
            this.btnVoltarCadastro.Text = "Voltar";
            this.btnVoltarCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltarCadastro.UseVisualStyleBackColor = false;
            // 
            // btnPacienteExame
            // 
            this.btnPacienteExame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPacienteExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacienteExame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacienteExame.Image = ((System.Drawing.Image)(resources.GetObject("btnPacienteExame.Image")));
            this.btnPacienteExame.Location = new System.Drawing.Point(-1, -1);
            this.btnPacienteExame.Name = "btnPacienteExame";
            this.btnPacienteExame.Size = new System.Drawing.Size(101, 80);
            this.btnPacienteExame.TabIndex = 23;
            this.btnPacienteExame.Text = "Paciente";
            this.btnPacienteExame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPacienteExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPacienteExame.UseVisualStyleBackColor = false;
            this.btnPacienteExame.Click += new System.EventHandler(this.btnPacienteExame_Click);
            // 
            // btnFuncionarioExame
            // 
            this.btnFuncionarioExame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFuncionarioExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarioExame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarioExame.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionarioExame.Image")));
            this.btnFuncionarioExame.Location = new System.Drawing.Point(605, -1);
            this.btnFuncionarioExame.Name = "btnFuncionarioExame";
            this.btnFuncionarioExame.Size = new System.Drawing.Size(101, 80);
            this.btnFuncionarioExame.TabIndex = 22;
            this.btnFuncionarioExame.Text = "Funcionário";
            this.btnFuncionarioExame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionarioExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFuncionarioExame.UseVisualStyleBackColor = false;
            this.btnFuncionarioExame.Click += new System.EventHandler(this.btnFuncionarioExame_Click);
            // 
            // btnPagamentoExame
            // 
            this.btnPagamentoExame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPagamentoExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamentoExame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentoExame.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamentoExame.Image")));
            this.btnPagamentoExame.Location = new System.Drawing.Point(504, -1);
            this.btnPagamentoExame.Name = "btnPagamentoExame";
            this.btnPagamentoExame.Size = new System.Drawing.Size(101, 80);
            this.btnPagamentoExame.TabIndex = 21;
            this.btnPagamentoExame.Text = "Pagamento";
            this.btnPagamentoExame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamentoExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPagamentoExame.UseVisualStyleBackColor = false;
            this.btnPagamentoExame.Click += new System.EventHandler(this.btnPagamentoExame_Click);
            // 
            // btnEstoqueExame
            // 
            this.btnEstoqueExame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEstoqueExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoqueExame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueExame.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoqueExame.Image")));
            this.btnEstoqueExame.Location = new System.Drawing.Point(403, -1);
            this.btnEstoqueExame.Name = "btnEstoqueExame";
            this.btnEstoqueExame.Size = new System.Drawing.Size(101, 80);
            this.btnEstoqueExame.TabIndex = 20;
            this.btnEstoqueExame.Text = "Estoque";
            this.btnEstoqueExame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoqueExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstoqueExame.UseVisualStyleBackColor = false;
            this.btnEstoqueExame.Click += new System.EventHandler(this.btnEstoqueExame_Click);
            // 
            // btnProntuarioExame
            // 
            this.btnProntuarioExame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnProntuarioExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProntuarioExame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProntuarioExame.Image = ((System.Drawing.Image)(resources.GetObject("btnProntuarioExame.Image")));
            this.btnProntuarioExame.Location = new System.Drawing.Point(302, -1);
            this.btnProntuarioExame.Name = "btnProntuarioExame";
            this.btnProntuarioExame.Size = new System.Drawing.Size(101, 80);
            this.btnProntuarioExame.TabIndex = 19;
            this.btnProntuarioExame.Text = "Prontuário";
            this.btnProntuarioExame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProntuarioExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProntuarioExame.UseVisualStyleBackColor = false;
            this.btnProntuarioExame.Click += new System.EventHandler(this.btnProntuarioExame_Click);
            // 
            // btnAgendaExame
            // 
            this.btnAgendaExame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgendaExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendaExame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendaExame.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendaExame.Image")));
            this.btnAgendaExame.Location = new System.Drawing.Point(201, -1);
            this.btnAgendaExame.Name = "btnAgendaExame";
            this.btnAgendaExame.Size = new System.Drawing.Size(101, 80);
            this.btnAgendaExame.TabIndex = 18;
            this.btnAgendaExame.Text = "Agenda";
            this.btnAgendaExame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgendaExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgendaExame.UseVisualStyleBackColor = false;
            this.btnAgendaExame.Click += new System.EventHandler(this.btnAgendaExame_Click);
            // 
            // btnMedicoExame
            // 
            this.btnMedicoExame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMedicoExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicoExame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicoExame.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicoExame.Image")));
            this.btnMedicoExame.Location = new System.Drawing.Point(100, -1);
            this.btnMedicoExame.Name = "btnMedicoExame";
            this.btnMedicoExame.Size = new System.Drawing.Size(101, 80);
            this.btnMedicoExame.TabIndex = 17;
            this.btnMedicoExame.Text = "Médico";
            this.btnMedicoExame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMedicoExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMedicoExame.UseVisualStyleBackColor = false;
            this.btnMedicoExame.Click += new System.EventHandler(this.btnMedicoExame_Click);
            // 
            // btnPesquisaExame
            // 
            this.btnPesquisaExame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPesquisaExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaExame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaExame.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaExame.Image")));
            this.btnPesquisaExame.Location = new System.Drawing.Point(706, -1);
            this.btnPesquisaExame.Name = "btnPesquisaExame";
            this.btnPesquisaExame.Size = new System.Drawing.Size(101, 80);
            this.btnPesquisaExame.TabIndex = 16;
            this.btnPesquisaExame.Text = "Pesquisa";
            this.btnPesquisaExame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisaExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisaExame.UseVisualStyleBackColor = false;
            this.btnPesquisaExame.Click += new System.EventHandler(this.btnPesquisaExame_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txbDataExame);
            this.panel1.Controls.Add(this.btnSelecionarImagemExame);
            this.panel1.Controls.Add(this.pcbExame);
            this.panel1.Controls.Add(this.lblDatadoExame);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblNomedoExame);
            this.panel1.Location = new System.Drawing.Point(43, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 426);
            this.panel1.TabIndex = 24;
            // 
            // btnSelecionarImagemExame
            // 
            this.btnSelecionarImagemExame.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btnSelecionarImagemExame.Location = new System.Drawing.Point(39, 154);
            this.btnSelecionarImagemExame.Name = "btnSelecionarImagemExame";
            this.btnSelecionarImagemExame.Size = new System.Drawing.Size(202, 34);
            this.btnSelecionarImagemExame.TabIndex = 6;
            this.btnSelecionarImagemExame.Text = "Selecionar Imagem...";
            this.btnSelecionarImagemExame.UseVisualStyleBackColor = true;
            // 
            // pcbExame
            // 
            this.pcbExame.Location = new System.Drawing.Point(39, 194);
            this.pcbExame.Name = "pcbExame";
            this.pcbExame.Size = new System.Drawing.Size(859, 488);
            this.pcbExame.TabIndex = 5;
            this.pcbExame.TabStop = false;
            // 
            // lblDatadoExame
            // 
            this.lblDatadoExame.AutoSize = true;
            this.lblDatadoExame.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblDatadoExame.Location = new System.Drawing.Point(34, 92);
            this.lblDatadoExame.Name = "lblDatadoExame";
            this.lblDatadoExame.Size = new System.Drawing.Size(183, 28);
            this.lblDatadoExame.TabIndex = 3;
            this.lblDatadoExame.Text = "Data do Exame:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(235, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(663, 36);
            this.textBox1.TabIndex = 2;
            // 
            // lblNomedoExame
            // 
            this.lblNomedoExame.AutoSize = true;
            this.lblNomedoExame.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblNomedoExame.Location = new System.Drawing.Point(34, 30);
            this.lblNomedoExame.Name = "lblNomedoExame";
            this.lblNomedoExame.Size = new System.Drawing.Size(195, 28);
            this.lblNomedoExame.TabIndex = 1;
            this.lblNomedoExame.Text = "Nome do Exame:";
            // 
            // lblExame
            // 
            this.lblExame.AutoSize = true;
            this.lblExame.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExame.Location = new System.Drawing.Point(551, 110);
            this.lblExame.Name = "lblExame";
            this.lblExame.Size = new System.Drawing.Size(129, 41);
            this.lblExame.TabIndex = 25;
            this.lblExame.Text = "Exame";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(16, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 170);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // btnAlterarExame
            // 
            this.btnAlterarExame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAlterarExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarExame.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarExame.Image = global::WindowsFormsApp1.Properties.Resources.updateicon1;
            this.btnAlterarExame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarExame.Location = new System.Drawing.Point(50, 211);
            this.btnAlterarExame.Name = "btnAlterarExame";
            this.btnAlterarExame.Size = new System.Drawing.Size(109, 30);
            this.btnAlterarExame.TabIndex = 27;
            this.btnAlterarExame.Text = "Alterar";
            this.btnAlterarExame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarExame.UseVisualStyleBackColor = false;
            // 
            // btnSalvarExame
            // 
            this.btnSalvarExame.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSalvarExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarExame.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarExame.Image = global::WindowsFormsApp1.Properties.Resources.saveicon2;
            this.btnSalvarExame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarExame.Location = new System.Drawing.Point(50, 280);
            this.btnSalvarExame.Name = "btnSalvarExame";
            this.btnSalvarExame.Size = new System.Drawing.Size(109, 31);
            this.btnSalvarExame.TabIndex = 30;
            this.btnSalvarExame.Text = "Salvar";
            this.btnSalvarExame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarExame.UseVisualStyleBackColor = false;
            // 
            // txbDataExame
            // 
            this.txbDataExame.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.txbDataExame.Location = new System.Drawing.Point(235, 89);
            this.txbDataExame.Mask = "00/00/0000";
            this.txbDataExame.Name = "txbDataExame";
            this.txbDataExame.Size = new System.Drawing.Size(152, 36);
            this.txbDataExame.TabIndex = 7;
            this.txbDataExame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalvarExame);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnAlterarExame);
            this.panel2.Location = new System.Drawing.Point(1114, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 443);
            this.panel2.TabIndex = 31;
            // 
            // telaExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1355, 690);
            this.Controls.Add(this.lblExame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barraSuperior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Button btnSairCadastro;
        private System.Windows.Forms.Button btnVoltarCadastro;
        private System.Windows.Forms.Button btnPacienteExame;
        private System.Windows.Forms.Button btnFuncionarioExame;
        private System.Windows.Forms.Button btnPagamentoExame;
        private System.Windows.Forms.Button btnEstoqueExame;
        private System.Windows.Forms.Button btnProntuarioExame;
        private System.Windows.Forms.Button btnAgendaExame;
        private System.Windows.Forms.Button btnMedicoExame;
        private System.Windows.Forms.Button btnPesquisaExame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbExame;
        private System.Windows.Forms.Label lblDatadoExame;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNomedoExame;
        private System.Windows.Forms.Label lblExame;
        private System.Windows.Forms.Button btnSelecionarImagemExame;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAlterarExame;
        private System.Windows.Forms.Button btnSalvarExame;
        private System.Windows.Forms.MaskedTextBox txbDataExame;
        private System.Windows.Forms.Panel panel2;
    }
}