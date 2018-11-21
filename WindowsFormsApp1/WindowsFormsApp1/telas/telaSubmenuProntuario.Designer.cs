namespace WindowsFormsApp1
{
    partial class telaSubMenuProntuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaSubMenuProntuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.btnPacienteSubMenu = new System.Windows.Forms.Button();
            this.btnFuncionarioSubMenu = new System.Windows.Forms.Button();
            this.btnPagamentoSubMenu = new System.Windows.Forms.Button();
            this.btnEstoqueSubMenu = new System.Windows.Forms.Button();
            this.btnProntuarioSubMenu = new System.Windows.Forms.Button();
            this.btnAgendaSubMenu = new System.Windows.Forms.Button();
            this.btnMedicoSubMenu = new System.Windows.Forms.Button();
            this.btnPesquisaSubMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.barraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Submenu Proprietario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(428, 162);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 117);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.barraSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barraSuperior.Controls.Add(this.btnPacienteSubMenu);
            this.barraSuperior.Controls.Add(this.btnFuncionarioSubMenu);
            this.barraSuperior.Controls.Add(this.btnPagamentoSubMenu);
            this.barraSuperior.Controls.Add(this.btnEstoqueSubMenu);
            this.barraSuperior.Controls.Add(this.btnProntuarioSubMenu);
            this.barraSuperior.Controls.Add(this.btnAgendaSubMenu);
            this.barraSuperior.Controls.Add(this.btnMedicoSubMenu);
            this.barraSuperior.Controls.Add(this.btnPesquisaSubMenu);
            this.barraSuperior.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(800, 71);
            this.barraSuperior.TabIndex = 23;
            this.barraSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.barraSuperior_Paint);
            // 
            // btnPacienteSubMenu
            // 
            this.btnPacienteSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPacienteSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacienteSubMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacienteSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnPacienteSubMenu.Image")));
            this.btnPacienteSubMenu.Location = new System.Drawing.Point(-1, -1);
            this.btnPacienteSubMenu.Name = "btnPacienteSubMenu";
            this.btnPacienteSubMenu.Size = new System.Drawing.Size(81, 70);
            this.btnPacienteSubMenu.TabIndex = 23;
            this.btnPacienteSubMenu.Text = "Paciente";
            this.btnPacienteSubMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPacienteSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPacienteSubMenu.UseVisualStyleBackColor = false;
            // 
            // btnFuncionarioSubMenu
            // 
            this.btnFuncionarioSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFuncionarioSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarioSubMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarioSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionarioSubMenu.Image")));
            this.btnFuncionarioSubMenu.Location = new System.Drawing.Point(467, -1);
            this.btnFuncionarioSubMenu.Name = "btnFuncionarioSubMenu";
            this.btnFuncionarioSubMenu.Size = new System.Drawing.Size(81, 70);
            this.btnFuncionarioSubMenu.TabIndex = 22;
            this.btnFuncionarioSubMenu.Text = "Funcionário";
            this.btnFuncionarioSubMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionarioSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFuncionarioSubMenu.UseVisualStyleBackColor = false;
            this.btnFuncionarioSubMenu.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnPagamentoSubMenu
            // 
            this.btnPagamentoSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPagamentoSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamentoSubMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentoSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamentoSubMenu.Image")));
            this.btnPagamentoSubMenu.Location = new System.Drawing.Point(388, -1);
            this.btnPagamentoSubMenu.Name = "btnPagamentoSubMenu";
            this.btnPagamentoSubMenu.Size = new System.Drawing.Size(81, 70);
            this.btnPagamentoSubMenu.TabIndex = 21;
            this.btnPagamentoSubMenu.Text = "Pagamento";
            this.btnPagamentoSubMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamentoSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPagamentoSubMenu.UseVisualStyleBackColor = false;
            // 
            // btnEstoqueSubMenu
            // 
            this.btnEstoqueSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEstoqueSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoqueSubMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoqueSubMenu.Image")));
            this.btnEstoqueSubMenu.Location = new System.Drawing.Point(309, -1);
            this.btnEstoqueSubMenu.Name = "btnEstoqueSubMenu";
            this.btnEstoqueSubMenu.Size = new System.Drawing.Size(81, 70);
            this.btnEstoqueSubMenu.TabIndex = 20;
            this.btnEstoqueSubMenu.Text = "Estoque";
            this.btnEstoqueSubMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoqueSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstoqueSubMenu.UseVisualStyleBackColor = false;
            // 
            // btnProntuarioSubMenu
            // 
            this.btnProntuarioSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnProntuarioSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProntuarioSubMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProntuarioSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnProntuarioSubMenu.Image")));
            this.btnProntuarioSubMenu.Location = new System.Drawing.Point(232, -1);
            this.btnProntuarioSubMenu.Name = "btnProntuarioSubMenu";
            this.btnProntuarioSubMenu.Size = new System.Drawing.Size(79, 70);
            this.btnProntuarioSubMenu.TabIndex = 19;
            this.btnProntuarioSubMenu.Text = "Prontuário";
            this.btnProntuarioSubMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProntuarioSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProntuarioSubMenu.UseVisualStyleBackColor = false;
            this.btnProntuarioSubMenu.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnAgendaSubMenu
            // 
            this.btnAgendaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgendaSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendaSubMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendaSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendaSubMenu.Image")));
            this.btnAgendaSubMenu.Location = new System.Drawing.Point(154, -1);
            this.btnAgendaSubMenu.Name = "btnAgendaSubMenu";
            this.btnAgendaSubMenu.Size = new System.Drawing.Size(81, 70);
            this.btnAgendaSubMenu.TabIndex = 18;
            this.btnAgendaSubMenu.Text = "Agenda";
            this.btnAgendaSubMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgendaSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgendaSubMenu.UseVisualStyleBackColor = false;
            // 
            // btnMedicoSubMenu
            // 
            this.btnMedicoSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMedicoSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicoSubMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicoSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicoSubMenu.Image")));
            this.btnMedicoSubMenu.Location = new System.Drawing.Point(76, -1);
            this.btnMedicoSubMenu.Name = "btnMedicoSubMenu";
            this.btnMedicoSubMenu.Size = new System.Drawing.Size(81, 70);
            this.btnMedicoSubMenu.TabIndex = 17;
            this.btnMedicoSubMenu.Text = "Médico";
            this.btnMedicoSubMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMedicoSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMedicoSubMenu.UseVisualStyleBackColor = false;
            // 
            // btnPesquisaSubMenu
            // 
            this.btnPesquisaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPesquisaSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaSubMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaSubMenu.Image")));
            this.btnPesquisaSubMenu.Location = new System.Drawing.Point(546, -1);
            this.btnPesquisaSubMenu.Name = "btnPesquisaSubMenu";
            this.btnPesquisaSubMenu.Size = new System.Drawing.Size(81, 70);
            this.btnPesquisaSubMenu.TabIndex = 16;
            this.btnPesquisaSubMenu.Text = "Pesquisa";
            this.btnPesquisaSubMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisaSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisaSubMenu.UseVisualStyleBackColor = false;
            // 
            // telaSubMenuProntuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "telaSubMenuProntuario";
            this.Text = "submenuProntuario";
            this.Load += new System.EventHandler(this.submenuProntuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.barraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Button btnPacienteSubMenu;
        private System.Windows.Forms.Button btnFuncionarioSubMenu;
        private System.Windows.Forms.Button btnPagamentoSubMenu;
        private System.Windows.Forms.Button btnEstoqueSubMenu;
        private System.Windows.Forms.Button btnProntuarioSubMenu;
        private System.Windows.Forms.Button btnAgendaSubMenu;
        private System.Windows.Forms.Button btnMedicoSubMenu;
        private System.Windows.Forms.Button btnPesquisaSubMenu;
    }
}