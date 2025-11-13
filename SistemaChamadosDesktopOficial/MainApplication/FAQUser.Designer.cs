namespace SistemaChamadosDesktopOficial.MainApplication
{
    partial class FAQUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstTopFaqs = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            btnOpenTicket = new System.Windows.Forms.Button();
            txtResposta = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            txtPergunta = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lstTopFaqs
            // 
            lstTopFaqs.Dock = System.Windows.Forms.DockStyle.Fill;
            lstTopFaqs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lstTopFaqs.FormattingEnabled = true;
            lstTopFaqs.ItemHeight = 21;
            lstTopFaqs.Location = new System.Drawing.Point(0, 32);
            lstTopFaqs.Name = "lstTopFaqs";
            lstTopFaqs.Size = new System.Drawing.Size(465, 754);
            lstTopFaqs.TabIndex = 11;
            lstTopFaqs.MouseDoubleClick += lstTopFaqs_MouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 32);
            label3.TabIndex = 14;
            label3.Text = "Chamados";
            // 
            // btnOpenTicket
            // 
            btnOpenTicket.BackColor = System.Drawing.SystemColors.Highlight;
            btnOpenTicket.Dock = System.Windows.Forms.DockStyle.Top;
            btnOpenTicket.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            btnOpenTicket.FlatAppearance.BorderSize = 4;
            btnOpenTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnOpenTicket.Location = new System.Drawing.Point(465, 589);
            btnOpenTicket.Name = "btnOpenTicket";
            btnOpenTicket.Size = new System.Drawing.Size(776, 38);
            btnOpenTicket.TabIndex = 15;
            btnOpenTicket.Text = "Visualizar chamado";
            btnOpenTicket.UseVisualStyleBackColor = false;
            btnOpenTicket.Click += btnOpenTicket_Click;
            // 
            // txtResposta
            // 
            txtResposta.Dock = System.Windows.Forms.DockStyle.Top;
            txtResposta.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtResposta.Location = new System.Drawing.Point(465, 93);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new System.Drawing.Size(776, 496);
            txtResposta.TabIndex = 16;
            txtResposta.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(465, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 32);
            label2.TabIndex = 13;
            label2.Text = "Solução";
            // 
            // txtPergunta
            // 
            txtPergunta.Dock = System.Windows.Forms.DockStyle.Top;
            txtPergunta.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtPergunta.Location = new System.Drawing.Point(465, 32);
            txtPergunta.Name = "txtPergunta";
            txtPergunta.Size = new System.Drawing.Size(776, 29);
            txtPergunta.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(465, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(232, 32);
            label1.TabIndex = 12;
            label1.Text = "Título do Chamado";
            // 
            // panel1
            // 
            panel1.Controls.Add(lstTopFaqs);
            panel1.Controls.Add(label3);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(465, 786);
            panel1.TabIndex = 17;
            // 
            // FAQUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnOpenTicket);
            Controls.Add(txtResposta);
            Controls.Add(label2);
            Controls.Add(txtPergunta);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FAQUser";
            Size = new System.Drawing.Size(1241, 786);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListBox lstTopFaqs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenTicket;
        private System.Windows.Forms.RichTextBox txtResposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
