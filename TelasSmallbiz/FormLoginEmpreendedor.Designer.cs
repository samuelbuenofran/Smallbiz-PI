
namespace TelasSmallbiz
{
    partial class FormLoginEmpreendedor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.checkBoxLembrarCredenciais = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.linkLabelCadastro = new System.Windows.Forms.LinkLabel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxGlobo = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.linkLabelRecuperarSenha = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlobo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.labelSenha.Location = new System.Drawing.Point(591, 280);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(92, 28);
            this.labelSenha.TabIndex = 18;
            this.labelSenha.Text = "Senha:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.labelEmail.Location = new System.Drawing.Point(587, 181);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(93, 28);
            this.labelEmail.TabIndex = 17;
            this.labelEmail.Text = "E-mail:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 14F);
            this.textBoxEmail.Location = new System.Drawing.Point(590, 212);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(359, 34);
            this.textBoxEmail.TabIndex = 15;
            this.textBoxEmail.Text = "usuario@email.com";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.AcceptsTab = true;
            this.textBoxSenha.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxSenha.Font = new System.Drawing.Font("Arial", 14F);
            this.textBoxSenha.Location = new System.Drawing.Point(590, 310);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(359, 34);
            this.textBoxSenha.TabIndex = 16;
            this.textBoxSenha.Text = "sua senha";
            // 
            // checkBoxLembrarCredenciais
            // 
            this.checkBoxLembrarCredenciais.AutoSize = true;
            this.checkBoxLembrarCredenciais.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLembrarCredenciais.Location = new System.Drawing.Point(590, 412);
            this.checkBoxLembrarCredenciais.Name = "checkBoxLembrarCredenciais";
            this.checkBoxLembrarCredenciais.Size = new System.Drawing.Size(170, 26);
            this.checkBoxLembrarCredenciais.TabIndex = 20;
            this.checkBoxLembrarCredenciais.Text = "Lembrar Credenciais.";
            this.checkBoxLembrarCredenciais.UseVisualStyleBackColor = true;
            this.checkBoxLembrarCredenciais.CheckedChanged += new System.EventHandler(this.checkBoxLembrarCredenciais_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLogin.Location = new System.Drawing.Point(664, 487);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(104, 42);
            this.buttonLogin.TabIndex = 22;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCancelar.Location = new System.Drawing.Point(815, 487);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(104, 42);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // linkLabelCadastro
            // 
            this.linkLabelCadastro.AutoSize = true;
            this.linkLabelCadastro.Font = new System.Drawing.Font("Arial", 11F);
            this.linkLabelCadastro.Location = new System.Drawing.Point(800, 368);
            this.linkLabelCadastro.Name = "linkLabelCadastro";
            this.linkLabelCadastro.Size = new System.Drawing.Size(220, 22);
            this.linkLabelCadastro.TabIndex = 24;
            this.linkLabelCadastro.TabStop = true;
            this.linkLabelCadastro.Text = "Ainda não é cadastrado?";
            this.linkLabelCadastro.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 22F);
            this.labelTitulo.Location = new System.Drawing.Point(550, 80);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(523, 41);
            this.labelTitulo.TabIndex = 128;
            this.labelTitulo.Text = "LOGIN EMPREENDEDOR";
            this.labelTitulo.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(561, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(502, 49);
            this.label4.TabIndex = 129;
            this.label4.Text = "                                ";
            this.label4.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TelasSmallbiz.Properties.Resources.Meio_globo;
            this.pictureBox2.Location = new System.Drawing.Point(528, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 127;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::TelasSmallbiz.Properties.Resources.Logo_sem_fundo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 368);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(582, 269);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 27;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxGlobo
            // 
            this.pictureBoxGlobo.Image = global::TelasSmallbiz.Properties.Resources.Meio_globo;
            this.pictureBoxGlobo.Location = new System.Drawing.Point(880, 12);
            this.pictureBoxGlobo.Name = "pictureBoxGlobo";
            this.pictureBoxGlobo.Size = new System.Drawing.Size(143, 156);
            this.pictureBoxGlobo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGlobo.TabIndex = 26;
            this.pictureBoxGlobo.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::TelasSmallbiz.Properties.Resources.user;
            this.pictureBoxUser.Location = new System.Drawing.Point(211, 151);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(142, 135);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 25;
            this.pictureBoxUser.TabStop = false;
            // 
            // linkLabelRecuperarSenha
            // 
            this.linkLabelRecuperarSenha.AutoSize = true;
            this.linkLabelRecuperarSenha.Font = new System.Drawing.Font("Arial", 11F);
            this.linkLabelRecuperarSenha.Location = new System.Drawing.Point(592, 368);
            this.linkLabelRecuperarSenha.Name = "linkLabelRecuperarSenha";
            this.linkLabelRecuperarSenha.Size = new System.Drawing.Size(178, 22);
            this.linkLabelRecuperarSenha.TabIndex = 21;
            this.linkLabelRecuperarSenha.TabStop = true;
            this.linkLabelRecuperarSenha.Text = "Esqueceu a senha?";
            this.linkLabelRecuperarSenha.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelRecuperarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRecuperarSenha_LinkClicked);
            // 
            // FormLoginEmpreendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1077, 682);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxGlobo);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.linkLabelCadastro);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.linkLabelRecuperarSenha);
            this.Controls.Add(this.checkBoxLembrarCredenciais);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormLoginEmpreendedor";
            this.Text = "Login Empreendedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlobo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxGlobo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.CheckBox checkBoxLembrarCredenciais;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.LinkLabel linkLabelCadastro;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelRecuperarSenha;
    }
}

