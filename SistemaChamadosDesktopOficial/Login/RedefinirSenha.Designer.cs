namespace SistemaChamadosDesktopOficial
{
    partial class RedefinirSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedefinirSenha));
            pictureBox3 = new System.Windows.Forms.PictureBox();
            btnLogin = new System.Windows.Forms.Button();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(50, 78);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(251, 170);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(117, 140, 221);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLogin.Location = new System.Drawing.Point(132, 383);
            btnLogin.Margin = new System.Windows.Forms.Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(88, 35);
            btnLogin.TabIndex = 19;
            btnLogin.Text = "Confirmar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(50, 346);
            txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirmar nova senha";
            txtConfirmPassword.Size = new System.Drawing.Size(250, 23);
            txtConfirmPassword.TabIndex = 18;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(61, 262);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(197, 29);
            label1.TabIndex = 17;
            label1.Text = "Redefinir senha";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(50, 309);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Nova senha";
            txtPassword.Size = new System.Drawing.Size(250, 23);
            txtPassword.TabIndex = 23;
            txtPassword.UseSystemPasswordChar = true;
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
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // RedefinirSenha
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(pictureBox4);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox3);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "RedefinirSenha";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Chamadin Tech - Redefinir Senha";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}