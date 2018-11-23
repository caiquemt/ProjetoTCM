namespace WindowsFormsApp1
{
    partial class telaLogin
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
            this.lbUsuarioLogin = new System.Windows.Forms.Label();
            this.lbSenhaLogin = new System.Windows.Forms.Label();
            this.btnConectarLogin = new System.Windows.Forms.Button();
            this.btnCancelarLogin = new System.Windows.Forms.Button();
            this.lkEsqueciSenhaLogin = new System.Windows.Forms.LinkLabel();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsuarioLogin
            // 
            this.lbUsuarioLogin.AutoSize = true;
            this.lbUsuarioLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lbUsuarioLogin.Location = new System.Drawing.Point(15, 26);
            this.lbUsuarioLogin.Name = "lbUsuarioLogin";
            this.lbUsuarioLogin.Size = new System.Drawing.Size(67, 19);
            this.lbUsuarioLogin.TabIndex = 0;
            this.lbUsuarioLogin.Text = "Usuário";
            this.lbUsuarioLogin.Click += new System.EventHandler(this.lusuario_Click);
            // 
            // lbSenhaLogin
            // 
            this.lbSenhaLogin.AutoSize = true;
            this.lbSenhaLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lbSenhaLogin.Location = new System.Drawing.Point(25, 78);
            this.lbSenhaLogin.Name = "lbSenhaLogin";
            this.lbSenhaLogin.Size = new System.Drawing.Size(54, 19);
            this.lbSenhaLogin.TabIndex = 2;
            this.lbSenhaLogin.Text = "Senha";
            this.lbSenhaLogin.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnConectarLogin
            // 
            this.btnConectarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConectarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectarLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnConectarLogin.Location = new System.Drawing.Point(23, 125);
            this.btnConectarLogin.Name = "btnConectarLogin";
            this.btnConectarLogin.Size = new System.Drawing.Size(89, 31);
            this.btnConectarLogin.TabIndex = 3;
            this.btnConectarLogin.Text = "Conectar";
            this.btnConectarLogin.UseVisualStyleBackColor = false;
            this.btnConectarLogin.Click += new System.EventHandler(this.btnConectarLogin_Click);
            // 
            // btnCancelarLogin
            // 
            this.btnCancelarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancelarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelarLogin.Location = new System.Drawing.Point(151, 125);
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.Size = new System.Drawing.Size(89, 31);
            this.btnCancelarLogin.TabIndex = 4;
            this.btnCancelarLogin.Text = "Cancelar";
            this.btnCancelarLogin.UseVisualStyleBackColor = false;
            this.btnCancelarLogin.Click += new System.EventHandler(this.btnCancelarLogin_Click);
            // 
            // lkEsqueciSenhaLogin
            // 
            this.lkEsqueciSenhaLogin.AutoSize = true;
            this.lkEsqueciSenhaLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lkEsqueciSenhaLogin.Location = new System.Drawing.Point(20, 169);
            this.lkEsqueciSenhaLogin.Name = "lkEsqueciSenhaLogin";
            this.lkEsqueciSenhaLogin.Size = new System.Drawing.Size(165, 19);
            this.lkEsqueciSenhaLogin.TabIndex = 5;
            this.lkEsqueciSenhaLogin.TabStop = true;
            this.lkEsqueciSenhaLogin.Text = "Esqueci minha senha";
            this.lkEsqueciSenhaLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkEsqueciSenhaLogin_LinkClicked);
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.txtUsuarioLogin.Location = new System.Drawing.Point(88, 23);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(152, 26);
            this.txtUsuarioLogin.TabIndex = 6;
            this.txtUsuarioLogin.TextChanged += new System.EventHandler(this.txtUsuarioLogin_TextChanged);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.txtSenhaLogin.Location = new System.Drawing.Point(88, 77);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(152, 26);
            this.txtSenhaLogin.TabIndex = 7;
            this.txtSenhaLogin.TextChanged += new System.EventHandler(this.txtSenhaLogin_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightCoral;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(191, 169);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(49, 32);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.UseWaitCursor = true;
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(268, 213);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.lkEsqueciSenhaLogin);
            this.Controls.Add(this.lbUsuarioLogin);
            this.Controls.Add(this.btnCancelarLogin);
            this.Controls.Add(this.lbSenhaLogin);
            this.Controls.Add(this.btnConectarLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuarioLogin;
        private System.Windows.Forms.Label lbSenhaLogin;
        private System.Windows.Forms.Button btnConectarLogin;
        private System.Windows.Forms.Button btnCancelarLogin;
        private System.Windows.Forms.LinkLabel lkEsqueciSenhaLogin;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btnSair;
    }
}