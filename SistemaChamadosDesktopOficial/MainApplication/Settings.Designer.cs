namespace SistemaChamadosDesktopOficial.MainApplication
{
    partial class Settings
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
            dgvUsers = new System.Windows.Forms.DataGridView();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnRefreshList = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtNome = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtTelefone = new System.Windows.Forms.TextBox();
            chkAtivo = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            cboCargo = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            cboDepartamento = new System.Windows.Forms.ComboBox();
            btnRstPassword = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnAnonymizeUser = new System.Windows.Forms.Button();
            btnClearForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUsers.Location = new System.Drawing.Point(0, 0);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new System.Drawing.Size(897, 786);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnRefreshList);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtNome);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtEmail);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtTelefone);
            flowLayoutPanel1.Controls.Add(chkAtivo);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(cboCargo);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(cboDepartamento);
            flowLayoutPanel1.Controls.Add(btnRstPassword);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnAnonymizeUser);
            flowLayoutPanel1.Controls.Add(btnClearForm);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(897, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(344, 786);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnRefreshList
            // 
            btnRefreshList.BackColor = System.Drawing.SystemColors.Highlight;
            btnRefreshList.FlatAppearance.BorderSize = 0;
            btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnRefreshList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnRefreshList.Location = new System.Drawing.Point(3, 3);
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new System.Drawing.Size(338, 33);
            btnRefreshList.TabIndex = 17;
            btnRefreshList.Text = "Recarregar base de dados";
            btnRefreshList.UseVisualStyleBackColor = false;
            btnRefreshList.Click += btnRefreshList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(3, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new System.Drawing.Point(3, 63);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(338, 23);
            txtNome.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(3, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(3, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(338, 23);
            txtEmail.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(3, 139);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 21);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new System.Drawing.Point(3, 163);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new System.Drawing.Size(338, 23);
            txtTelefone.TabIndex = 8;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkAtivo.Location = new System.Drawing.Point(3, 192);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new System.Drawing.Size(169, 25);
            chkAtivo.TabIndex = 15;
            chkAtivo.Text = "Colaborador Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(3, 220);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 21);
            label5.TabIndex = 4;
            label5.Text = "Cargo";
            // 
            // cboCargo
            // 
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new System.Drawing.Point(3, 244);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new System.Drawing.Size(338, 23);
            cboCargo.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label6.Location = new System.Drawing.Point(3, 270);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(121, 21);
            label6.TabIndex = 5;
            label6.Text = "Departamento";
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new System.Drawing.Point(3, 294);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new System.Drawing.Size(338, 23);
            cboDepartamento.TabIndex = 14;
            // 
            // btnRstPassword
            // 
            btnRstPassword.BackColor = System.Drawing.Color.Red;
            btnRstPassword.FlatAppearance.BorderSize = 0;
            btnRstPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRstPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnRstPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnRstPassword.Location = new System.Drawing.Point(3, 323);
            btnRstPassword.Name = "btnRstPassword";
            btnRstPassword.Size = new System.Drawing.Size(338, 33);
            btnRstPassword.TabIndex = 12;
            btnRstPassword.Text = "Restaurar Senha";
            btnRstPassword.UseVisualStyleBackColor = false;
            btnRstPassword.Click += btnRstPassword_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnSave.Location = new System.Drawing.Point(3, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(338, 33);
            btnSave.TabIndex = 16;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAnonymizeUser
            // 
            btnAnonymizeUser.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            btnAnonymizeUser.FlatAppearance.BorderSize = 2;
            btnAnonymizeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAnonymizeUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAnonymizeUser.ForeColor = System.Drawing.Color.Red;
            btnAnonymizeUser.Location = new System.Drawing.Point(3, 401);
            btnAnonymizeUser.Name = "btnAnonymizeUser";
            btnAnonymizeUser.Size = new System.Drawing.Size(338, 34);
            btnAnonymizeUser.TabIndex = 19;
            btnAnonymizeUser.Text = "Anonimizar Usuário";
            btnAnonymizeUser.UseVisualStyleBackColor = true;
            btnAnonymizeUser.Visible = false;
            btnAnonymizeUser.Click += btnAnonymizeUser_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.FlatAppearance.BorderSize = 0;
            btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClearForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            btnClearForm.Location = new System.Drawing.Point(3, 441);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new System.Drawing.Size(338, 27);
            btnClearForm.TabIndex = 18;
            btnClearForm.Text = "Limpar formulário";
            btnClearForm.UseVisualStyleBackColor = true;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dgvUsers);
            Controls.Add(flowLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Settings";
            Size = new System.Drawing.Size(1241, 786);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRstPassword;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnAnonymizeUser;
    }
}
