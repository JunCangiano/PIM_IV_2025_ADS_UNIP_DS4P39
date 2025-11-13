using System.Windows.Forms;

namespace SistemaChamadosDesktopOficial.Controls
{
    partial class MessageBubble
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUser;
        private Label lblText;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUser = new Label();
            lblText = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            lblUser.ForeColor = System.Drawing.Color.Gray;
            lblUser.Location = new System.Drawing.Point(10, 5);
            lblUser.MaximumSize = new System.Drawing.Size(350, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(29, 13);
            lblUser.TabIndex = 0;
            lblUser.Text = "teste";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblText.Location = new System.Drawing.Point(10, 25);
            lblText.MaximumSize = new System.Drawing.Size(350, 0);
            lblText.Name = "lblText";
            lblText.Size = new System.Drawing.Size(32, 15);
            lblText.TabIndex = 1;
            lblText.Text = "teste";
            // 
            // MessageBubble
            // 
            AutoSize = true;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(lblUser);
            Controls.Add(lblText);
            Margin = new Padding(10);
            Name = "MessageBubble";
            Padding = new Padding(8);
            Size = new System.Drawing.Size(370, 60);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
