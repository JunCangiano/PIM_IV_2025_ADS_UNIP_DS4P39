namespace SistemaChamadosDesktopOficial
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            panelContainer = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            txtUsuario = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            ForgotPassword = new System.Windows.Forms.Label();
            txtSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(350, 0);
            pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(583, 519);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(50, 78);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(251, 170);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(txtUsuario);
            panelContainer.Controls.Add(btnLogin);
            panelContainer.Controls.Add(ForgotPassword);
            panelContainer.Controls.Add(txtSenha);
            panelContainer.Location = new System.Drawing.Point(50, 254);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new System.Drawing.Size(250, 200);
            panelContainer.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(38, 8);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(175, 29);
            label1.TabIndex = 12;
            label1.Text = "Bem vindo(a)!";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            txtUsuario.Location = new System.Drawing.Point(0, 55);
            txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "E-mail";
            txtUsuario.Size = new System.Drawing.Size(250, 23);
            txtUsuario.TabIndex = 13;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(117, 140, 221);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLogin.Location = new System.Drawing.Point(81, 129);
            btnLogin.Margin = new System.Windows.Forms.Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(88, 35);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // ForgotPassword
            // 
            ForgotPassword.AutoSize = true;
            ForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForgotPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            ForgotPassword.Location = new System.Drawing.Point(71, 178);
            ForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ForgotPassword.Name = "ForgotPassword";
            ForgotPassword.Size = new System.Drawing.Size(108, 13);
            ForgotPassword.TabIndex = 16;
            ForgotPassword.Text = "Esqueci minha senha";
            ForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ForgotPassword.Click += ForgotPassword_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new System.Drawing.Point(0, 92);
            txtSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.Size = new System.Drawing.Size(250, 23);
            txtSenha.TabIndex = 14;
            txtSenha.Text = "Senha";
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.Enter += txtSenha_Enter;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // LoginPage
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(panelContainer);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "LoginPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Chamadin Tech - Login ";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label ForgotPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelContainer;
    }
}