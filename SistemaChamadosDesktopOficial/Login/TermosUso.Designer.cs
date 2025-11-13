namespace SistemaChamadosDesktopOficial.Login
{
    partial class TermosUso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermosUso));
            label2 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            btnContinuar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            linkTermos = new System.Windows.Forms.LinkLabel();
            chkAceito = new System.Windows.Forms.CheckBox();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            rtbTermos = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 306);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(264, 75);
            label2.TabIndex = 22;
            label2.Text = resources.GetString("label2.Text");
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
            // btnContinuar
            // 
            btnContinuar.BackColor = System.Drawing.Color.FromArgb(117, 140, 221);
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnContinuar.Location = new System.Drawing.Point(132, 421);
            btnContinuar.Margin = new System.Windows.Forms.Padding(0);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new System.Drawing.Size(88, 35);
            btnContinuar.TabIndex = 19;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(65, 262);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(189, 29);
            label1.TabIndex = 17;
            label1.Text = "Termos de uso";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkTermos
            // 
            linkTermos.AutoSize = true;
            linkTermos.Location = new System.Drawing.Point(4, 1);
            linkTermos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkTermos.Name = "linkTermos";
            linkTermos.Size = new System.Drawing.Size(101, 15);
            linkTermos.TabIndex = 23;
            linkTermos.TabStop = true;
            linkTermos.Text = "Ler termos de uso";
            linkTermos.LinkClicked += linkTermos_LinkClicked;
            // 
            // chkAceito
            // 
            chkAceito.AutoSize = true;
            chkAceito.Location = new System.Drawing.Point(117, 1);
            chkAceito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkAceito.Name = "chkAceito";
            chkAceito.Size = new System.Drawing.Size(98, 19);
            chkAceito.TabIndex = 24;
            chkAceito.Text = "Li e concordo";
            chkAceito.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(linkTermos);
            panel1.Controls.Add(chkAceito);
            panel1.Location = new System.Drawing.Point(64, 391);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(222, 20);
            panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(583, 519);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(rtbTermos);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(350, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(583, 519);
            panel2.TabIndex = 27;
            // 
            // rtbTermos
            // 
            rtbTermos.Location = new System.Drawing.Point(0, 0);
            rtbTermos.Name = "rtbTermos";
            rtbTermos.ReadOnly = true;
            rtbTermos.Size = new System.Drawing.Size(583, 519);
            rtbTermos.TabIndex = 27;
            rtbTermos.Text = resources.GetString("rtbTermos.Text");
            rtbTermos.Visible = false;
            // 
            // TermosUso
            // 
            AcceptButton = btnContinuar;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(btnContinuar);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "TermosUso";
            Text = "Chamadin Tech - Termos de Uso";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkTermos;
        private System.Windows.Forms.CheckBox chkAceito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbTermos;
    }
}