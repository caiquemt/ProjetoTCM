namespace WindowsFormsApp1
{
    partial class telaConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConsulta));
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPacienteConsulta = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lblDataConsulta = new System.Windows.Forms.Label();
            this.lblEspecialidadeConsulta = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblHoraConsulta = new System.Windows.Forms.Label();
            this.lblMedicoConsulta = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblDiaConsulta = new System.Windows.Forms.Label();
            this.lblCRMConsulta = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblCodigoConsulta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarCons = new System.Windows.Forms.Button();
            this.btnAlterarCons = new System.Windows.Forms.Button();
            this.barraSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.barraSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barraSuperior.Controls.Add(this.btnSalvarCons);
            this.barraSuperior.Controls.Add(this.btnAlterarCons);
            this.barraSuperior.Controls.Add(this.label1);
            this.barraSuperior.Controls.Add(this.panel1);
            this.barraSuperior.Controls.Add(this.groupBox1);
            this.barraSuperior.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1371, 768);
            this.barraSuperior.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 41);
            this.label1.TabIndex = 27;
            this.label1.Text = "CONSULTA";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSairCadastro);
            this.panel1.Controls.Add(this.btnVoltarCadastro);
            this.panel1.Controls.Add(this.btnPacienteConsulta);
            this.panel1.Controls.Add(this.btnFuncionario);
            this.panel1.Controls.Add(this.btnPagamento);
            this.panel1.Controls.Add(this.btnEstoqueFuncionario);
            this.panel1.Controls.Add(this.btnProntuario);
            this.panel1.Controls.Add(this.btnAgenda);
            this.panel1.Controls.Add(this.btnMedico);
            this.panel1.Controls.Add(this.btnPesquisa);
            this.panel1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 81);
            this.panel1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.lblPacienteConsulta);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.lblDataConsulta);
            this.groupBox1.Controls.Add(this.lblEspecialidadeConsulta);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.lblHoraConsulta);
            this.groupBox1.Controls.Add(this.lblMedicoConsulta);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.lblDiaConsulta);
            this.groupBox1.Controls.Add(this.lblCRMConsulta);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.lblCodigoConsulta);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(45, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 399);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // lblPacienteConsulta
            // 
            this.lblPacienteConsulta.AutoSize = true;
            this.lblPacienteConsulta.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblPacienteConsulta.Location = new System.Drawing.Point(17, 34);
            this.lblPacienteConsulta.Name = "lblPacienteConsulta";
            this.lblPacienteConsulta.Size = new System.Drawing.Size(114, 28);
            this.lblPacienteConsulta.TabIndex = 0;
            this.lblPacienteConsulta.Text = "Paciente:";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.textBox8.Location = new System.Drawing.Point(642, 276);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(326, 36);
            this.textBox8.TabIndex = 15;
            // 
            // lblDataConsulta
            // 
            this.lblDataConsulta.AutoSize = true;
            this.lblDataConsulta.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblDataConsulta.Location = new System.Drawing.Point(17, 200);
            this.lblDataConsulta.Name = "lblDataConsulta";
            this.lblDataConsulta.Size = new System.Drawing.Size(71, 28);
            this.lblDataConsulta.TabIndex = 3;
            this.lblDataConsulta.Text = "Data:";
            // 
            // lblEspecialidadeConsulta
            // 
            this.lblEspecialidadeConsulta.AutoSize = true;
            this.lblEspecialidadeConsulta.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblEspecialidadeConsulta.Location = new System.Drawing.Point(17, 140);
            this.lblEspecialidadeConsulta.Name = "lblEspecialidadeConsulta";
            this.lblEspecialidadeConsulta.Size = new System.Drawing.Size(172, 28);
            this.lblEspecialidadeConsulta.TabIndex = 2;
            this.lblEspecialidadeConsulta.Text = "Especialidade:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.textBox7.Location = new System.Drawing.Point(513, 225);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(455, 36);
            this.textBox7.TabIndex = 14;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblHoraConsulta
            // 
            this.lblHoraConsulta.AutoSize = true;
            this.lblHoraConsulta.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblHoraConsulta.Location = new System.Drawing.Point(17, 251);
            this.lblHoraConsulta.Name = "lblHoraConsulta";
            this.lblHoraConsulta.Size = new System.Drawing.Size(74, 28);
            this.lblHoraConsulta.TabIndex = 4;
            this.lblHoraConsulta.Text = "Hora:";
            // 
            // lblMedicoConsulta
            // 
            this.lblMedicoConsulta.AutoSize = true;
            this.lblMedicoConsulta.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblMedicoConsulta.Location = new System.Drawing.Point(17, 87);
            this.lblMedicoConsulta.Name = "lblMedicoConsulta";
            this.lblMedicoConsulta.Size = new System.Drawing.Size(99, 28);
            this.lblMedicoConsulta.TabIndex = 1;
            this.lblMedicoConsulta.Text = "Médico:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(107, 297);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(262, 36);
            this.textBox6.TabIndex = 13;
            // 
            // lblDiaConsulta
            // 
            this.lblDiaConsulta.AutoSize = true;
            this.lblDiaConsulta.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblDiaConsulta.Location = new System.Drawing.Point(17, 300);
            this.lblDiaConsulta.Name = "lblDiaConsulta";
            this.lblDiaConsulta.Size = new System.Drawing.Size(57, 28);
            this.lblDiaConsulta.TabIndex = 5;
            this.lblDiaConsulta.Text = "Dia:";
            // 
            // lblCRMConsulta
            // 
            this.lblCRMConsulta.AutoSize = true;
            this.lblCRMConsulta.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblCRMConsulta.Location = new System.Drawing.Point(438, 228);
            this.lblCRMConsulta.Name = "lblCRMConsulta";
            this.lblCRMConsulta.Size = new System.Drawing.Size(69, 28);
            this.lblCRMConsulta.TabIndex = 6;
            this.lblCRMConsulta.Text = "CRM:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.textBox5.Location = new System.Drawing.Point(137, 84);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(831, 36);
            this.textBox5.TabIndex = 12;
            // 
            // lblCodigoConsulta
            // 
            this.lblCodigoConsulta.AutoSize = true;
            this.lblCodigoConsulta.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblCodigoConsulta.Location = new System.Drawing.Point(440, 279);
            this.lblCodigoConsulta.Name = "lblCodigoConsulta";
            this.lblCodigoConsulta.Size = new System.Drawing.Size(196, 28);
            this.lblCodigoConsulta.TabIndex = 7;
            this.lblCodigoConsulta.Text = "Código Consulta:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(137, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(831, 36);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(195, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(773, 36);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnSairCadastro
            // 
            this.btnSairCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSairCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnSairCadastro.Image")));
            this.btnSairCadastro.Location = new System.Drawing.Point(1256, -1);
            this.btnSairCadastro.Name = "btnSairCadastro";
            this.btnSairCadastro.Size = new System.Drawing.Size(92, 81);
            this.btnSairCadastro.TabIndex = 26;
            this.btnSairCadastro.Text = "Sair";
            this.btnSairCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSairCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSairCadastro.UseVisualStyleBackColor = true;
            // 
            // btnVoltarCadastro
            // 
            this.btnVoltarCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarCadastro.Image")));
            this.btnVoltarCadastro.Location = new System.Drawing.Point(1139, -1);
            this.btnVoltarCadastro.Name = "btnVoltarCadastro";
            this.btnVoltarCadastro.Size = new System.Drawing.Size(111, 81);
            this.btnVoltarCadastro.TabIndex = 27;
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
            this.btnPacienteConsulta.Location = new System.Drawing.Point(-1, -1);
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
            this.btnFuncionario.Location = new System.Drawing.Point(605, -1);
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
            this.btnPagamento.Location = new System.Drawing.Point(504, -1);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(101, 80);
            this.btnPagamento.TabIndex = 21;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnEstoqueFuncionario
            // 
            this.btnEstoqueFuncionario.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.btnEstoqueFuncionario.Click += new System.EventHandler(this.btnEstoqueFuncionario_Click);
            // 
            // btnProntuario
            // 
            this.btnProntuario.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.btnProntuario.Click += new System.EventHandler(this.btnProntuario_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.Location = new System.Drawing.Point(706, -1);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(101, 80);
            this.btnPesquisa.TabIndex = 16;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox1.Location = new System.Drawing.Point(107, 200);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(120, 36);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox2.Location = new System.Drawing.Point(107, 251);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(120, 36);
            this.maskedTextBox2.TabIndex = 17;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalvarCons
            // 
            this.btnSalvarCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarCons.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSalvarCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCons.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSalvarCons.Image = global::WindowsFormsApp1.Properties.Resources.saveicon2;
            this.btnSalvarCons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCons.Location = new System.Drawing.Point(1141, 561);
            this.btnSalvarCons.Name = "btnSalvarCons";
            this.btnSalvarCons.Size = new System.Drawing.Size(120, 32);
            this.btnSalvarCons.TabIndex = 66;
            this.btnSalvarCons.Text = "Salvar";
            this.btnSalvarCons.UseVisualStyleBackColor = false;
            // 
            // btnAlterarCons
            // 
            this.btnAlterarCons.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAlterarCons.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAlterarCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarCons.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAlterarCons.Image = global::WindowsFormsApp1.Properties.Resources.updateicon1;
            this.btnAlterarCons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarCons.Location = new System.Drawing.Point(1140, 465);
            this.btnAlterarCons.Name = "btnAlterarCons";
            this.btnAlterarCons.Size = new System.Drawing.Size(121, 35);
            this.btnAlterarCons.TabIndex = 67;
            this.btnAlterarCons.Text = "Alterar";
            this.btnAlterarCons.UseVisualStyleBackColor = false;
            // 
            // telaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.barraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "telaConsulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barraSuperior.ResumeLayout(false);
            this.barraSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCodigoConsulta;
        private System.Windows.Forms.Label lblCRMConsulta;
        private System.Windows.Forms.Label lblDiaConsulta;
        private System.Windows.Forms.Label lblHoraConsulta;
        private System.Windows.Forms.Label lblDataConsulta;
        private System.Windows.Forms.Label lblEspecialidadeConsulta;
        private System.Windows.Forms.Label lblMedicoConsulta;
        private System.Windows.Forms.Label lblPacienteConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSairCadastro;
        private System.Windows.Forms.Button btnVoltarCadastro;
        private System.Windows.Forms.Button btnPacienteConsulta;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnEstoqueFuncionario;
        private System.Windows.Forms.Button btnProntuario;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnSalvarCons;
        private System.Windows.Forms.Button btnAlterarCons;
    }
}