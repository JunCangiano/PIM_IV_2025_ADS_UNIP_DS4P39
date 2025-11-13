namespace SistemaChamadosDesktopOficial.MainApplication
{
    partial class FAQAdmin
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
            dgvFaqs = new System.Windows.Forms.DataGridView();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnApprove = new System.Windows.Forms.Button();
            txtPergunta = new System.Windows.Forms.TextBox();
            lstTopFaqs = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnOpenTicket = new System.Windows.Forms.Button();
            txtResposta = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFaqs).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFaqs
            // 
            dgvFaqs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFaqs.Dock = System.Windows.Forms.DockStyle.Left;
            dgvFaqs.Location = new System.Drawing.Point(0, 43);
            dgvFaqs.Name = "dgvFaqs";
            dgvFaqs.Size = new System.Drawing.Size(792, 743);
            dgvFaqs.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnApprove);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1241, 43);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = System.Drawing.SystemColors.Highlight;
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnApprove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnApprove.Location = new System.Drawing.Point(3, 3);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new System.Drawing.Size(213, 35);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Aprovar Solução";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // txtPergunta
            // 
            txtPergunta.Dock = System.Windows.Forms.DockStyle.Top;
            txtPergunta.Location = new System.Drawing.Point(792, 64);
            txtPergunta.Name = "txtPergunta";
            txtPergunta.Size = new System.Drawing.Size(449, 23);
            txtPergunta.TabIndex = 3;
            // 
            // lstTopFaqs
            // 
            lstTopFaqs.Dock = System.Windows.Forms.DockStyle.Top;
            lstTopFaqs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lstTopFaqs.FormattingEnabled = true;
            lstTopFaqs.ItemHeight = 21;
            lstTopFaqs.Location = new System.Drawing.Point(792, 263);
            lstTopFaqs.Name = "lstTopFaqs";
            lstTopFaqs.Size = new System.Drawing.Size(449, 508);
            lstTopFaqs.TabIndex = 4;
            lstTopFaqs.MouseDoubleClick += lstTopFaqs_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(792, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(156, 21);
            label1.TabIndex = 5;
            label1.Text = "Título do Chamado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(792, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 21);
            label2.TabIndex = 6;
            label2.Text = "Solução";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(792, 242);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 21);
            label3.TabIndex = 7;
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
            btnOpenTicket.Location = new System.Drawing.Point(792, 204);
            btnOpenTicket.Name = "btnOpenTicket";
            btnOpenTicket.Size = new System.Drawing.Size(449, 38);
            btnOpenTicket.TabIndex = 8;
            btnOpenTicket.Text = "Visualizar chamado";
            btnOpenTicket.UseVisualStyleBackColor = false;
            btnOpenTicket.Click += btnOpenTicket_Click;
            // 
            // txtResposta
            // 
            txtResposta.Dock = System.Windows.Forms.DockStyle.Top;
            txtResposta.Location = new System.Drawing.Point(792, 108);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new System.Drawing.Size(449, 96);
            txtResposta.TabIndex = 9;
            txtResposta.Text = "";
            // 
            // FAQAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lstTopFaqs);
            Controls.Add(label3);
            Controls.Add(btnOpenTicket);
            Controls.Add(txtResposta);
            Controls.Add(label2);
            Controls.Add(txtPergunta);
            Controls.Add(label1);
            Controls.Add(dgvFaqs);
            Controls.Add(flowLayoutPanel1);
            Name = "FAQAdmin";
            Size = new System.Drawing.Size(1241, 786);
            ((System.ComponentModel.ISupportInitialize)dgvFaqs).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFaqs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.ListBox lstTopFaqs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenTicket;
        private System.Windows.Forms.RichTextBox txtResposta;
    }
}
