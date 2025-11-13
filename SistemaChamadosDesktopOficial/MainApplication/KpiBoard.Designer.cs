namespace SistemaChamadosDesktopOficial.MainApplication
{
    partial class KpiBoard
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
            plotTicketsByTechnician = new OxyPlot.WindowsForms.PlotView();
            plotTicketsOpenedPerDay = new OxyPlot.WindowsForms.PlotView();
            plotTicketsByPriority = new OxyPlot.WindowsForms.PlotView();
            plotTicketsByStatus = new OxyPlot.WindowsForms.PlotView();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // plotTicketsByTechnician
            // 
            plotTicketsByTechnician.BackColor = System.Drawing.SystemColors.ControlLight;
            plotTicketsByTechnician.Dock = System.Windows.Forms.DockStyle.Left;
            plotTicketsByTechnician.Location = new System.Drawing.Point(3, 3);
            plotTicketsByTechnician.MinimumSize = new System.Drawing.Size(0, 325);
            plotTicketsByTechnician.Name = "plotTicketsByTechnician";
            plotTicketsByTechnician.PanCursor = System.Windows.Forms.Cursors.Hand;
            plotTicketsByTechnician.Size = new System.Drawing.Size(610, 325);
            plotTicketsByTechnician.TabIndex = 7;
            plotTicketsByTechnician.Text = "plotView4";
            plotTicketsByTechnician.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            plotTicketsByTechnician.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            plotTicketsByTechnician.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotTicketsOpenedPerDay
            // 
            plotTicketsOpenedPerDay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            plotTicketsOpenedPerDay.Dock = System.Windows.Forms.DockStyle.Left;
            plotTicketsOpenedPerDay.Location = new System.Drawing.Point(3, 3);
            plotTicketsOpenedPerDay.MinimumSize = new System.Drawing.Size(0, 325);
            plotTicketsOpenedPerDay.Name = "plotTicketsOpenedPerDay";
            plotTicketsOpenedPerDay.PanCursor = System.Windows.Forms.Cursors.Hand;
            plotTicketsOpenedPerDay.Size = new System.Drawing.Size(610, 325);
            plotTicketsOpenedPerDay.TabIndex = 6;
            plotTicketsOpenedPerDay.Text = "plotView3";
            plotTicketsOpenedPerDay.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            plotTicketsOpenedPerDay.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            plotTicketsOpenedPerDay.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotTicketsByPriority
            // 
            plotTicketsByPriority.BackColor = System.Drawing.SystemColors.ControlLight;
            plotTicketsByPriority.Dock = System.Windows.Forms.DockStyle.Left;
            plotTicketsByPriority.Location = new System.Drawing.Point(619, 3);
            plotTicketsByPriority.MinimumSize = new System.Drawing.Size(0, 325);
            plotTicketsByPriority.Name = "plotTicketsByPriority";
            plotTicketsByPriority.PanCursor = System.Windows.Forms.Cursors.Hand;
            plotTicketsByPriority.Size = new System.Drawing.Size(610, 325);
            plotTicketsByPriority.TabIndex = 5;
            plotTicketsByPriority.Text = "plotView2";
            plotTicketsByPriority.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            plotTicketsByPriority.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            plotTicketsByPriority.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotTicketsByStatus
            // 
            plotTicketsByStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            plotTicketsByStatus.Dock = System.Windows.Forms.DockStyle.Left;
            plotTicketsByStatus.Location = new System.Drawing.Point(619, 3);
            plotTicketsByStatus.MinimumSize = new System.Drawing.Size(0, 325);
            plotTicketsByStatus.Name = "plotTicketsByStatus";
            plotTicketsByStatus.PanCursor = System.Windows.Forms.Cursors.Hand;
            plotTicketsByStatus.Size = new System.Drawing.Size(610, 325);
            plotTicketsByStatus.TabIndex = 4;
            plotTicketsByStatus.Text = "plotView1";
            plotTicketsByStatus.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            plotTicketsByStatus.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            plotTicketsByStatus.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(plotTicketsByTechnician);
            flowLayoutPanel1.Controls.Add(plotTicketsByStatus);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 329);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1241, 329);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(plotTicketsOpenedPerDay);
            flowLayoutPanel2.Controls.Add(plotTicketsByPriority);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(1241, 329);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // KpiBoard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Name = "KpiBoard";
            Size = new System.Drawing.Size(1241, 659);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotTicketsByTechnician;
        private OxyPlot.WindowsForms.PlotView plotTicketsOpenedPerDay;
        private OxyPlot.WindowsForms.PlotView plotTicketsByPriority;
        private OxyPlot.WindowsForms.PlotView plotTicketsByStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
