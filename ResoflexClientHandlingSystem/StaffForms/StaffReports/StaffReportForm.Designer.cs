namespace ResoflexClientHandlingSystem.StaffForms.StaffReports
{
    partial class StaffReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffReportForm));
            this.ReportTask = new MetroFramework.Drawing.Html.HtmlPanel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report = new MetroFramework.Controls.MetroButton();
            this.homeBtn = new MetroFramework.Controls.MetroButton();
            this.selectStaffCmbBox = new MetroFramework.Controls.MetroComboBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.stfRep_click = new MetroFramework.Controls.MetroButton();
            this.ReportTask.SuspendLayout();
            this.htmlLabel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportTask
            // 
            this.ReportTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportTask.AutoScroll = true;
            this.ReportTask.AutoScrollMinSize = new System.Drawing.Size(631, 0);
            this.ReportTask.BackColor = System.Drawing.SystemColors.Window;
            this.ReportTask.Controls.Add(this.crystalReportViewer1);
            this.ReportTask.Location = new System.Drawing.Point(229, 80);
            this.ReportTask.Name = "ReportTask";
            this.ReportTask.Size = new System.Drawing.Size(631, 462);
            this.ReportTask.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(631, 462);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(60, 188);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(116, 35);
            this.Report.TabIndex = 2;
            this.Report.Text = "Show task reports";
            this.Report.UseSelectable = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.BackgroundImage")));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.Location = new System.Drawing.Point(448, 6);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(30, 24);
            this.homeBtn.TabIndex = 67;
            this.homeBtn.UseSelectable = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // selectStaffCmbBox
            // 
            this.selectStaffCmbBox.FormattingEnabled = true;
            this.selectStaffCmbBox.ItemHeight = 23;
            this.selectStaffCmbBox.Location = new System.Drawing.Point(47, 0);
            this.selectStaffCmbBox.Name = "selectStaffCmbBox";
            this.selectStaffCmbBox.Size = new System.Drawing.Size(126, 29);
            this.selectStaffCmbBox.TabIndex = 9;
            this.selectStaffCmbBox.UseSelectable = true;
            this.selectStaffCmbBox.SelectedIndexChanged += new System.EventHandler(this.selectStaffCmbBox_SelectedIndexChanged);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(41, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Controls.Add(this.selectStaffCmbBox);
            this.htmlLabel2.Location = new System.Drawing.Point(36, 142);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(173, 37);
            this.htmlLabel2.TabIndex = 68;
            this.htmlLabel2.Text = "StaffId";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = "Task Reports";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 357);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(151, 19);
            this.metroLabel2.TabIndex = 70;
            this.metroLabel2.Text = "Staff salary , OT Reports";
            // 
            // stfRep_click
            // 
            this.stfRep_click.Location = new System.Drawing.Point(60, 392);
            this.stfRep_click.Name = "stfRep_click";
            this.stfRep_click.Size = new System.Drawing.Size(116, 35);
            this.stfRep_click.TabIndex = 71;
            this.stfRep_click.Text = "Show reports";
            this.stfRep_click.UseSelectable = true;
            this.stfRep_click.Click += new System.EventHandler(this.stfRep_click_Click);
            // 
            // StaffReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 555);
            this.Controls.Add(this.stfRep_click);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.ReportTask);
            this.Name = "StaffReportForm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.StaffReportForm_Load);
            this.ReportTask.ResumeLayout(false);
            this.htmlLabel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlPanel ReportTask;
        private MetroFramework.Controls.MetroButton Report;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MetroFramework.Controls.MetroButton homeBtn;
        private MetroFramework.Controls.MetroComboBox selectStaffCmbBox;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton stfRep_click;
    }
}