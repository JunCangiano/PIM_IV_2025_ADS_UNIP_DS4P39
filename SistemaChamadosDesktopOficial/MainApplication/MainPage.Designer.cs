namespace SistemaChamadosDesktopOficial
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            sidebarPanel = new System.Windows.Forms.Panel();
            userProfile = new System.Windows.Forms.Button();
            btnFaq = new System.Windows.Forms.Button();
            Logout = new System.Windows.Forms.Button();
            BtnConfig = new System.Windows.Forms.Button();
            BtnPlans = new System.Windows.Forms.Button();
            BtnTickets = new System.Windows.Forms.Button();
            BtnForms = new System.Windows.Forms.Button();
            BtnHome = new System.Windows.Forms.Button();
            logoSidebar = new System.Windows.Forms.PictureBox();
            mainContent = new System.Windows.Forms.Panel();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoSidebar).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = System.Drawing.Color.FromArgb(40, 49, 77);
            sidebarPanel.Controls.Add(userProfile);
            sidebarPanel.Controls.Add(btnFaq);
            sidebarPanel.Controls.Add(Logout);
            sidebarPanel.Controls.Add(BtnConfig);
            sidebarPanel.Controls.Add(BtnPlans);
            sidebarPanel.Controls.Add(BtnTickets);
            sidebarPanel.Controls.Add(BtnForms);
            sidebarPanel.Controls.Add(BtnHome);
            sidebarPanel.Controls.Add(logoSidebar);
            sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            sidebarPanel.Location = new System.Drawing.Point(0, 0);
            sidebarPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Padding = new System.Windows.Forms.Padding(12, 23, 12, 23);
            sidebarPanel.Size = new System.Drawing.Size(233, 786);
            sidebarPanel.TabIndex = 0;
            // 
            // userProfile
            // 
            userProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            userProfile.FlatAppearance.BorderSize = 0;
            userProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            userProfile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            userProfile.ForeColor = System.Drawing.SystemColors.Control;
            userProfile.Location = new System.Drawing.Point(12, 671);
            userProfile.Name = "userProfile";
            userProfile.Size = new System.Drawing.Size(209, 54);
            userProfile.TabIndex = 12;
            userProfile.Text = "userName";
            userProfile.UseVisualStyleBackColor = true;
            userProfile.Click += userProfile_Click;
            // 
            // btnFaq
            // 
            btnFaq.BackColor = System.Drawing.Color.FromArgb(40, 49, 77);
            btnFaq.Dock = System.Windows.Forms.DockStyle.Top;
            btnFaq.FlatAppearance.BorderSize = 0;
            btnFaq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFaq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFaq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnFaq.Location = new System.Drawing.Point(12, 284);
            btnFaq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFaq.Name = "btnFaq";
            btnFaq.Size = new System.Drawing.Size(209, 38);
            btnFaq.TabIndex = 10;
            btnFaq.Text = "FAQ";
            btnFaq.UseVisualStyleBackColor = false;
            btnFaq.Click += btnFaq_Click;
            // 
            // Logout
            // 
            Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            Logout.FlatAppearance.BorderSize = 2;
            Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Logout.Location = new System.Drawing.Point(12, 725);
            Logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Logout.Name = "Logout";
            Logout.Size = new System.Drawing.Size(209, 38);
            Logout.TabIndex = 6;
            Logout.Text = "Sair";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // BtnConfig
            // 
            BtnConfig.BackColor = System.Drawing.Color.FromArgb(40, 49, 77);
            BtnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            BtnConfig.FlatAppearance.BorderSize = 0;
            BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            BtnConfig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            BtnConfig.Location = new System.Drawing.Point(12, 246);
            BtnConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnConfig.Name = "BtnConfig";
            BtnConfig.Size = new System.Drawing.Size(209, 38);
            BtnConfig.TabIndex = 5;
            BtnConfig.Text = "Usuários";
            BtnConfig.UseVisualStyleBackColor = false;
            BtnConfig.Visible = false;
            BtnConfig.Click += BtnConfig_Click;
            // 
            // BtnPlans
            // 
            BtnPlans.Dock = System.Windows.Forms.DockStyle.Top;
            BtnPlans.FlatAppearance.BorderSize = 0;
            BtnPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            BtnPlans.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            BtnPlans.Location = new System.Drawing.Point(12, 208);
            BtnPlans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnPlans.Name = "BtnPlans";
            BtnPlans.Size = new System.Drawing.Size(209, 38);
            BtnPlans.TabIndex = 4;
            BtnPlans.Text = "Planejamentos";
            BtnPlans.UseVisualStyleBackColor = true;
            BtnPlans.Click += BtnPlans_Click;
            // 
            // BtnTickets
            // 
            BtnTickets.Dock = System.Windows.Forms.DockStyle.Top;
            BtnTickets.FlatAppearance.BorderSize = 0;
            BtnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            BtnTickets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            BtnTickets.Location = new System.Drawing.Point(12, 170);
            BtnTickets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnTickets.Name = "BtnTickets";
            BtnTickets.Size = new System.Drawing.Size(209, 38);
            BtnTickets.TabIndex = 3;
            BtnTickets.Text = "Chamados";
            BtnTickets.UseVisualStyleBackColor = true;
            BtnTickets.Click += BtnTickets_Click;
            // 
            // BtnForms
            // 
            BtnForms.Dock = System.Windows.Forms.DockStyle.Top;
            BtnForms.FlatAppearance.BorderSize = 0;
            BtnForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            BtnForms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            BtnForms.Location = new System.Drawing.Point(12, 132);
            BtnForms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnForms.Name = "BtnForms";
            BtnForms.Size = new System.Drawing.Size(209, 38);
            BtnForms.TabIndex = 2;
            BtnForms.Text = "Formulários";
            BtnForms.UseVisualStyleBackColor = true;
            BtnForms.Click += BtnForms_Click;
            // 
            // BtnHome
            // 
            BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            BtnHome.FlatAppearance.BorderSize = 0;
            BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            BtnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            BtnHome.Location = new System.Drawing.Point(12, 94);
            BtnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new System.Drawing.Size(209, 38);
            BtnHome.TabIndex = 1;
            BtnHome.Text = "Home";
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // logoSidebar
            // 
            logoSidebar.Dock = System.Windows.Forms.DockStyle.Top;
            logoSidebar.Image = (System.Drawing.Image)resources.GetObject("logoSidebar.Image");
            logoSidebar.Location = new System.Drawing.Point(12, 23);
            logoSidebar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            logoSidebar.Name = "logoSidebar";
            logoSidebar.Size = new System.Drawing.Size(209, 71);
            logoSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            logoSidebar.TabIndex = 0;
            logoSidebar.TabStop = false;
            // 
            // mainContent
            // 
            mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            mainContent.Location = new System.Drawing.Point(233, 0);
            mainContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainContent.Name = "mainContent";
            mainContent.Size = new System.Drawing.Size(1242, 786);
            mainContent.TabIndex = 1;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1475, 786);
            Controls.Add(mainContent);
            Controls.Add(sidebarPanel);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Chamadin Tech";
            Load += MainPage_Load;
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoSidebar).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.PictureBox logoSidebar;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Button BtnPlans;
        private System.Windows.Forms.Button BtnTickets;
        private System.Windows.Forms.Button BtnForms;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel mainContent;
        private System.Windows.Forms.Button btnFaq;
        private System.Windows.Forms.Button userProfile;
    }
}

