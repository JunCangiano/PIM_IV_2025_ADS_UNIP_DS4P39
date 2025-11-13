namespace SistemaChamadosDesktopOficial.MainApplication
{
    partial class Calendar
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
            plannedTickets = new System.Windows.Forms.MonthCalendar();
            KPIsPanel = new System.Windows.Forms.TableLayoutPanel();
            Pending = new System.Windows.Forms.Panel();
            PendingCount = new System.Windows.Forms.Label();
            PendingLable = new System.Windows.Forms.Label();
            New = new System.Windows.Forms.Panel();
            NewCount = new System.Windows.Forms.Label();
            NewLabel = new System.Windows.Forms.Label();
            Att = new System.Windows.Forms.Panel();
            AttCount = new System.Windows.Forms.Label();
            AttLabel = new System.Windows.Forms.Label();
            Planned = new System.Windows.Forms.Panel();
            PlanCount = new System.Windows.Forms.Label();
            PlanLabel = new System.Windows.Forms.Label();
            Closed = new System.Windows.Forms.Panel();
            ClosedCount = new System.Windows.Forms.Label();
            ClosedLabel = new System.Windows.Forms.Label();
            listTickets = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            btnReloadList = new System.Windows.Forms.Button();
            KPIsPanel.SuspendLayout();
            Pending.SuspendLayout();
            New.SuspendLayout();
            Att.SuspendLayout();
            Planned.SuspendLayout();
            Closed.SuspendLayout();
            SuspendLayout();
            // 
            // plannedTickets
            // 
            plannedTickets.CalendarDimensions = new System.Drawing.Size(4, 3);
            plannedTickets.Font = new System.Drawing.Font("Segoe UI", 18F);
            plannedTickets.Location = new System.Drawing.Point(9, 157);
            plannedTickets.Name = "plannedTickets";
            plannedTickets.TabIndex = 0;
            plannedTickets.DateSelected += plannedTickets_DateSelected;
            // 
            // KPIsPanel
            // 
            KPIsPanel.BackColor = System.Drawing.SystemColors.Control;
            KPIsPanel.ColumnCount = 5;
            KPIsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            KPIsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            KPIsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            KPIsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            KPIsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            KPIsPanel.Controls.Add(Pending, 0, 0);
            KPIsPanel.Controls.Add(New, 1, 0);
            KPIsPanel.Controls.Add(Att, 2, 0);
            KPIsPanel.Controls.Add(Planned, 3, 0);
            KPIsPanel.Controls.Add(Closed, 4, 0);
            KPIsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            KPIsPanel.Location = new System.Drawing.Point(0, 0);
            KPIsPanel.Margin = new System.Windows.Forms.Padding(0);
            KPIsPanel.Name = "KPIsPanel";
            KPIsPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            KPIsPanel.RowCount = 1;
            KPIsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            KPIsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            KPIsPanel.Size = new System.Drawing.Size(1241, 127);
            KPIsPanel.TabIndex = 4;
            // 
            // Pending
            // 
            Pending.BackColor = System.Drawing.Color.LightSalmon;
            Pending.Controls.Add(PendingCount);
            Pending.Controls.Add(PendingLable);
            Pending.Dock = System.Windows.Forms.DockStyle.Fill;
            Pending.Location = new System.Drawing.Point(0, 0);
            Pending.Margin = new System.Windows.Forms.Padding(0);
            Pending.Name = "Pending";
            Pending.Padding = new System.Windows.Forms.Padding(12);
            Pending.Size = new System.Drawing.Size(248, 115);
            Pending.TabIndex = 0;
            // 
            // PendingCount
            // 
            PendingCount.Dock = System.Windows.Forms.DockStyle.Fill;
            PendingCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PendingCount.Location = new System.Drawing.Point(12, 47);
            PendingCount.Margin = new System.Windows.Forms.Padding(0);
            PendingCount.Name = "PendingCount";
            PendingCount.Size = new System.Drawing.Size(224, 56);
            PendingCount.TabIndex = 1;
            PendingCount.Text = "12";
            PendingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PendingLable
            // 
            PendingLable.Dock = System.Windows.Forms.DockStyle.Top;
            PendingLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PendingLable.Location = new System.Drawing.Point(12, 12);
            PendingLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PendingLable.Name = "PendingLable";
            PendingLable.Size = new System.Drawing.Size(224, 35);
            PendingLable.TabIndex = 0;
            PendingLable.Text = "Pendentes";
            PendingLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New
            // 
            New.BackColor = System.Drawing.Color.LightGreen;
            New.Controls.Add(NewCount);
            New.Controls.Add(NewLabel);
            New.Dock = System.Windows.Forms.DockStyle.Fill;
            New.Location = new System.Drawing.Point(248, 0);
            New.Margin = new System.Windows.Forms.Padding(0);
            New.Name = "New";
            New.Padding = new System.Windows.Forms.Padding(12);
            New.Size = new System.Drawing.Size(248, 115);
            New.TabIndex = 1;
            // 
            // NewCount
            // 
            NewCount.Dock = System.Windows.Forms.DockStyle.Fill;
            NewCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            NewCount.Location = new System.Drawing.Point(12, 47);
            NewCount.Margin = new System.Windows.Forms.Padding(0);
            NewCount.Name = "NewCount";
            NewCount.Size = new System.Drawing.Size(224, 56);
            NewCount.TabIndex = 3;
            NewCount.Text = "12";
            NewCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewLabel
            // 
            NewLabel.Dock = System.Windows.Forms.DockStyle.Top;
            NewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            NewLabel.Location = new System.Drawing.Point(12, 12);
            NewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NewLabel.Name = "NewLabel";
            NewLabel.Size = new System.Drawing.Size(224, 35);
            NewLabel.TabIndex = 2;
            NewLabel.Text = "Novos";
            NewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Att
            // 
            Att.BackColor = System.Drawing.Color.LemonChiffon;
            Att.Controls.Add(AttCount);
            Att.Controls.Add(AttLabel);
            Att.Dock = System.Windows.Forms.DockStyle.Fill;
            Att.Location = new System.Drawing.Point(496, 0);
            Att.Margin = new System.Windows.Forms.Padding(0);
            Att.Name = "Att";
            Att.Padding = new System.Windows.Forms.Padding(12);
            Att.Size = new System.Drawing.Size(248, 115);
            Att.TabIndex = 2;
            // 
            // AttCount
            // 
            AttCount.Dock = System.Windows.Forms.DockStyle.Fill;
            AttCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AttCount.Location = new System.Drawing.Point(12, 47);
            AttCount.Margin = new System.Windows.Forms.Padding(0);
            AttCount.Name = "AttCount";
            AttCount.Size = new System.Drawing.Size(224, 56);
            AttCount.TabIndex = 3;
            AttCount.Text = "12";
            AttCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttLabel
            // 
            AttLabel.Dock = System.Windows.Forms.DockStyle.Top;
            AttLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AttLabel.Location = new System.Drawing.Point(12, 12);
            AttLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AttLabel.Name = "AttLabel";
            AttLabel.Size = new System.Drawing.Size(224, 35);
            AttLabel.TabIndex = 2;
            AttLabel.Text = "Atributos";
            AttLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Planned
            // 
            Planned.BackColor = System.Drawing.Color.Violet;
            Planned.Controls.Add(PlanCount);
            Planned.Controls.Add(PlanLabel);
            Planned.Dock = System.Windows.Forms.DockStyle.Fill;
            Planned.Location = new System.Drawing.Point(744, 0);
            Planned.Margin = new System.Windows.Forms.Padding(0);
            Planned.Name = "Planned";
            Planned.Padding = new System.Windows.Forms.Padding(12);
            Planned.Size = new System.Drawing.Size(248, 115);
            Planned.TabIndex = 3;
            // 
            // PlanCount
            // 
            PlanCount.Dock = System.Windows.Forms.DockStyle.Fill;
            PlanCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PlanCount.Location = new System.Drawing.Point(12, 47);
            PlanCount.Margin = new System.Windows.Forms.Padding(0);
            PlanCount.Name = "PlanCount";
            PlanCount.Size = new System.Drawing.Size(224, 56);
            PlanCount.TabIndex = 3;
            PlanCount.Text = "12";
            PlanCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlanLabel
            // 
            PlanLabel.Dock = System.Windows.Forms.DockStyle.Top;
            PlanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PlanLabel.Location = new System.Drawing.Point(12, 12);
            PlanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PlanLabel.Name = "PlanLabel";
            PlanLabel.Size = new System.Drawing.Size(224, 35);
            PlanLabel.TabIndex = 2;
            PlanLabel.Text = "Planejados";
            PlanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Closed
            // 
            Closed.BackColor = System.Drawing.Color.HotPink;
            Closed.Controls.Add(ClosedCount);
            Closed.Controls.Add(ClosedLabel);
            Closed.Dock = System.Windows.Forms.DockStyle.Fill;
            Closed.Location = new System.Drawing.Point(992, 0);
            Closed.Margin = new System.Windows.Forms.Padding(0);
            Closed.Name = "Closed";
            Closed.Padding = new System.Windows.Forms.Padding(12);
            Closed.Size = new System.Drawing.Size(249, 115);
            Closed.TabIndex = 4;
            // 
            // ClosedCount
            // 
            ClosedCount.Dock = System.Windows.Forms.DockStyle.Fill;
            ClosedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ClosedCount.Location = new System.Drawing.Point(12, 47);
            ClosedCount.Margin = new System.Windows.Forms.Padding(0);
            ClosedCount.Name = "ClosedCount";
            ClosedCount.Size = new System.Drawing.Size(225, 56);
            ClosedCount.TabIndex = 3;
            ClosedCount.Text = "12";
            ClosedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClosedLabel
            // 
            ClosedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            ClosedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ClosedLabel.Location = new System.Drawing.Point(12, 12);
            ClosedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ClosedLabel.Name = "ClosedLabel";
            ClosedLabel.Size = new System.Drawing.Size(225, 35);
            ClosedLabel.TabIndex = 2;
            ClosedLabel.Text = "Concluídos";
            ClosedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listTickets
            // 
            listTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2 });
            listTickets.FullRowSelect = true;
            listTickets.Location = new System.Drawing.Point(928, 136);
            listTickets.Name = "listTickets";
            listTickets.Size = new System.Drawing.Size(310, 647);
            listTickets.TabIndex = 5;
            listTickets.UseCompatibleStateImageBehavior = false;
            listTickets.View = System.Windows.Forms.View.Details;
            listTickets.DoubleClick += listTickets_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Título";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Status";
            columnHeader2.Width = 100;
            // 
            // btnReloadList
            // 
            btnReloadList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnReloadList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnReloadList.FlatAppearance.BorderSize = 0;
            btnReloadList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReloadList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnReloadList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnReloadList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnReloadList.Location = new System.Drawing.Point(9, 127);
            btnReloadList.Margin = new System.Windows.Forms.Padding(0);
            btnReloadList.Name = "btnReloadList";
            btnReloadList.Size = new System.Drawing.Size(239, 29);
            btnReloadList.TabIndex = 7;
            btnReloadList.Text = "Recarregar Chamados";
            btnReloadList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnReloadList.UseVisualStyleBackColor = false;
            btnReloadList.Click += btnReloadList_Click;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnReloadList);
            Controls.Add(listTickets);
            Controls.Add(KPIsPanel);
            Controls.Add(plannedTickets);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Calendar";
            Size = new System.Drawing.Size(1241, 786);
            KPIsPanel.ResumeLayout(false);
            Pending.ResumeLayout(false);
            New.ResumeLayout(false);
            Att.ResumeLayout(false);
            Planned.ResumeLayout(false);
            Closed.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar plannedTickets;
        private System.Windows.Forms.TableLayoutPanel KPIsPanel;
        private System.Windows.Forms.Panel Pending;
        private System.Windows.Forms.Label PendingCount;
        private System.Windows.Forms.Label PendingLable;
        private System.Windows.Forms.Panel New;
        private System.Windows.Forms.Label NewCount;
        private System.Windows.Forms.Label NewLabel;
        private System.Windows.Forms.Panel Att;
        private System.Windows.Forms.Label AttCount;
        private System.Windows.Forms.Label AttLabel;
        private System.Windows.Forms.Panel Planned;
        private System.Windows.Forms.Label PlanCount;
        private System.Windows.Forms.Label PlanLabel;
        private System.Windows.Forms.Panel Closed;
        private System.Windows.Forms.Label ClosedCount;
        private System.Windows.Forms.Label ClosedLabel;
        private System.Windows.Forms.ListView listTickets;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnReloadList;
    }
}
