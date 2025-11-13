namespace SistemaChamadosDesktopOficial.MainApplication
{
    partial class NewTicket
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
            pnlDepartments = new System.Windows.Forms.FlowLayoutPanel();
            rbTI = new System.Windows.Forms.RadioButton();
            rbRH = new System.Windows.Forms.RadioButton();
            rbFinanceiro = new System.Windows.Forms.RadioButton();
            rbInfra = new System.Windows.Forms.RadioButton();
            rbIntSist = new System.Windows.Forms.RadioButton();
            rbOthers = new System.Windows.Forms.RadioButton();
            cboUserName = new System.Windows.Forms.ComboBox();
            NameLabel = new System.Windows.Forms.Label();
            TitleLabel = new System.Windows.Forms.Label();
            txtTitle = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.RichTextBox();
            PriorityLabel = new System.Windows.Forms.Label();
            cboPriority = new System.Windows.Forms.ComboBox();
            DescLabel = new System.Windows.Forms.Label();
            btnSubmit = new System.Windows.Forms.Button();
            Form = new System.Windows.Forms.Panel();
            FormTitle = new System.Windows.Forms.Label();
            pnlDepartments.SuspendLayout();
            Form.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDepartments
            // 
            pnlDepartments.Controls.Add(rbTI);
            pnlDepartments.Controls.Add(rbRH);
            pnlDepartments.Controls.Add(rbFinanceiro);
            pnlDepartments.Controls.Add(rbInfra);
            pnlDepartments.Controls.Add(rbIntSist);
            pnlDepartments.Controls.Add(rbOthers);
            pnlDepartments.Dock = System.Windows.Forms.DockStyle.Top;
            pnlDepartments.Location = new System.Drawing.Point(0, 0);
            pnlDepartments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlDepartments.Name = "pnlDepartments";
            pnlDepartments.Size = new System.Drawing.Size(520, 75);
            pnlDepartments.TabIndex = 0;
            // 
            // rbTI
            // 
            rbTI.AutoSize = true;
            rbTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbTI.Location = new System.Drawing.Point(4, 3);
            rbTI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbTI.Name = "rbTI";
            rbTI.Size = new System.Drawing.Size(168, 28);
            rbTI.TabIndex = 0;
            rbTI.TabStop = true;
            rbTI.Tag = "1";
            rbTI.Text = "Suporte Técnico";
            rbTI.UseVisualStyleBackColor = true;
            // 
            // rbRH
            // 
            rbRH.AutoSize = true;
            rbRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbRH.Location = new System.Drawing.Point(180, 3);
            rbRH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbRH.Name = "rbRH";
            rbRH.Size = new System.Drawing.Size(195, 28);
            rbRH.TabIndex = 1;
            rbRH.TabStop = true;
            rbRH.Tag = "4";
            rbRH.Text = "Recursos Humanos";
            rbRH.UseVisualStyleBackColor = true;
            // 
            // rbFinanceiro
            // 
            rbFinanceiro.AutoSize = true;
            rbFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbFinanceiro.Location = new System.Drawing.Point(383, 3);
            rbFinanceiro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbFinanceiro.Name = "rbFinanceiro";
            rbFinanceiro.Size = new System.Drawing.Size(118, 28);
            rbFinanceiro.TabIndex = 2;
            rbFinanceiro.TabStop = true;
            rbFinanceiro.Tag = "3";
            rbFinanceiro.Text = "Financeiro";
            rbFinanceiro.UseVisualStyleBackColor = true;
            // 
            // rbInfra
            // 
            rbInfra.AutoSize = true;
            rbInfra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbInfra.Location = new System.Drawing.Point(4, 37);
            rbInfra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbInfra.Name = "rbInfra";
            rbInfra.Size = new System.Drawing.Size(135, 28);
            rbInfra.TabIndex = 3;
            rbInfra.TabStop = true;
            rbInfra.Tag = "2";
            rbInfra.Text = "Infraestrutura";
            rbInfra.UseVisualStyleBackColor = true;
            // 
            // rbIntSist
            // 
            rbIntSist.AutoSize = true;
            rbIntSist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbIntSist.Location = new System.Drawing.Point(147, 37);
            rbIntSist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbIntSist.Name = "rbIntSist";
            rbIntSist.Size = new System.Drawing.Size(175, 28);
            rbIntSist.TabIndex = 4;
            rbIntSist.TabStop = true;
            rbIntSist.Tag = "5";
            rbIntSist.Text = "Sistemas internos";
            rbIntSist.UseVisualStyleBackColor = true;
            // 
            // rbOthers
            // 
            rbOthers.AutoSize = true;
            rbOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbOthers.Location = new System.Drawing.Point(330, 37);
            rbOthers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbOthers.Name = "rbOthers";
            rbOthers.Size = new System.Drawing.Size(84, 28);
            rbOthers.TabIndex = 5;
            rbOthers.TabStop = true;
            rbOthers.Tag = "6";
            rbOthers.Text = "Outros";
            rbOthers.UseVisualStyleBackColor = true;
            // 
            // cboUserName
            // 
            cboUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboUserName.FormattingEnabled = true;
            cboUserName.Location = new System.Drawing.Point(0, 117);
            cboUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboUserName.Name = "cboUserName";
            cboUserName.Size = new System.Drawing.Size(248, 24);
            cboUserName.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            NameLabel.Location = new System.Drawing.Point(-2, 84);
            NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(66, 24);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Nome";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            TitleLabel.Location = new System.Drawing.Point(-1, 151);
            TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new System.Drawing.Size(184, 24);
            TitleLabel.TabIndex = 4;
            TitleLabel.Text = "Título do chamado";
            // 
            // txtTitle
            // 
            txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTitle.Location = new System.Drawing.Point(0, 184);
            txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(516, 23);
            txtTitle.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(-4, 250);
            txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(520, 230);
            txtDescription.TabIndex = 6;
            txtDescription.Text = "";
            // 
            // PriorityLabel
            // 
            PriorityLabel.AutoSize = true;
            PriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PriorityLabel.Location = new System.Drawing.Point(266, 84);
            PriorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PriorityLabel.Name = "PriorityLabel";
            PriorityLabel.Size = new System.Drawing.Size(106, 24);
            PriorityLabel.TabIndex = 8;
            PriorityLabel.Text = "Prioridade";
            // 
            // cboPriority
            // 
            cboPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboPriority.FormattingEnabled = true;
            cboPriority.Location = new System.Drawing.Point(268, 117);
            cboPriority.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboPriority.Name = "cboPriority";
            cboPriority.Size = new System.Drawing.Size(248, 24);
            cboPriority.TabIndex = 7;
            // 
            // DescLabel
            // 
            DescLabel.AutoSize = true;
            DescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            DescLabel.Location = new System.Drawing.Point(-5, 217);
            DescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DescLabel.Name = "DescLabel";
            DescLabel.Size = new System.Drawing.Size(103, 24);
            DescLabel.TabIndex = 9;
            DescLabel.Text = "Descrição";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = System.Drawing.Color.DarkSlateBlue;
            btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnSubmit.Location = new System.Drawing.Point(0, 490);
            btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(520, 50);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Enviar";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // Form
            // 
            Form.Controls.Add(pnlDepartments);
            Form.Controls.Add(NameLabel);
            Form.Controls.Add(cboUserName);
            Form.Controls.Add(PriorityLabel);
            Form.Controls.Add(cboPriority);
            Form.Controls.Add(TitleLabel);
            Form.Controls.Add(txtTitle);
            Form.Controls.Add(DescLabel);
            Form.Controls.Add(txtDescription);
            Form.Controls.Add(btnSubmit);
            Form.Location = new System.Drawing.Point(323, 77);
            Form.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Form.Name = "Form";
            Form.Size = new System.Drawing.Size(520, 540);
            Form.TabIndex = 11;
            // 
            // FormTitle
            // 
            FormTitle.AutoSize = true;
            FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormTitle.Location = new System.Drawing.Point(322, 43);
            FormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            FormTitle.Name = "FormTitle";
            FormTitle.Size = new System.Drawing.Size(279, 31);
            FormTitle.TabIndex = 12;
            FormTitle.Text = "Abrir novo Chamado";
            // 
            // NewTicket
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(FormTitle);
            Controls.Add(Form);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "NewTicket";
            Size = new System.Drawing.Size(1241, 786);
            pnlDepartments.ResumeLayout(false);
            pnlDepartments.PerformLayout();
            Form.ResumeLayout(false);
            Form.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlDepartments;
        private System.Windows.Forms.RadioButton rbTI;
        private System.Windows.Forms.RadioButton rbRH;
        private System.Windows.Forms.RadioButton rbFinanceiro;
        private System.Windows.Forms.ComboBox cboUserName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel Form;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.RadioButton rbInfra;
        private System.Windows.Forms.RadioButton rbIntSist;
        private System.Windows.Forms.RadioButton rbOthers;
    }
}
