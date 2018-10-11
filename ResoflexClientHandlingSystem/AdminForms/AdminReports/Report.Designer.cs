namespace ResoflexClientHandlingSystem.AdminForms.AdminReports
{
    partial class Reports
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.View = new MetroFramework.Controls.MetroButton();
            this.usercombo = new MetroFramework.Controls.MetroComboBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.viewmonthly = new MetroFramework.Controls.MetroButton();
            this.from = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.to = new MetroFramework.Controls.MetroDateTime();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.uname1 = new MetroFramework.Controls.MetroComboBox();
            this.from1 = new MetroFramework.Controls.MetroDateTime();
            this.to1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.crystalReportViewer1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(229, 34);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(762, 597);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(762, 597);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(23, 136);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(86, 31);
            this.View.TabIndex = 1;
            this.View.Text = "View report";
            this.View.UseSelectable = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // usercombo
            // 
            this.usercombo.FormattingEnabled = true;
            this.usercombo.ItemHeight = 23;
            this.usercombo.Location = new System.Drawing.Point(23, 101);
            this.usercombo.Name = "usercombo";
            this.usercombo.Size = new System.Drawing.Size(178, 29);
            this.usercombo.TabIndex = 0;
            this.usercombo.UseSelectable = true;
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(188, 29);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel2.Location = new System.Drawing.Point(23, 63);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(192, 32);
            this.htmlLabel2.TabIndex = 3;
            this.htmlLabel2.Text = "User Operations by User";
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(115, 29);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel1.Location = new System.Drawing.Point(23, 182);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(178, 32);
            this.htmlLabel1.TabIndex = 4;
            this.htmlLabel1.Text = "System Usage";
            // 
            // viewmonthly
            // 
            this.viewmonthly.Location = new System.Drawing.Point(23, 328);
            this.viewmonthly.Name = "viewmonthly";
            this.viewmonthly.Size = new System.Drawing.Size(86, 31);
            this.viewmonthly.TabIndex = 6;
            this.viewmonthly.Text = "View report";
            this.viewmonthly.UseSelectable = true;
            this.viewmonthly.Click += new System.EventHandler(this.viewmonthly_Click);
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(23, 239);
            this.from.MinimumSize = new System.Drawing.Size(0, 29);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(200, 29);
            this.from.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 271);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(22, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "To";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 217);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Usage from";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(23, 293);
            this.to.MinimumSize = new System.Drawing.Size(0, 29);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(200, 29);
            this.to.TabIndex = 9;
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(206, 27);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel3.Location = new System.Drawing.Point(23, 394);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(200, 39);
            this.htmlLabel3.TabIndex = 10;
            this.htmlLabel3.Text = "System usage vs work hours";
            // 
            // uname1
            // 
            this.uname1.FormattingEnabled = true;
            this.uname1.ItemHeight = 23;
            this.uname1.Location = new System.Drawing.Point(23, 439);
            this.uname1.Name = "uname1";
            this.uname1.PromptText = "Username";
            this.uname1.Size = new System.Drawing.Size(178, 29);
            this.uname1.TabIndex = 11;
            this.uname1.UseSelectable = true;
            // 
            // from1
            // 
            this.from1.Location = new System.Drawing.Point(23, 504);
            this.from1.MinimumSize = new System.Drawing.Size(0, 29);
            this.from1.Name = "from1";
            this.from1.Size = new System.Drawing.Size(200, 29);
            this.from1.TabIndex = 12;
            // 
            // to1
            // 
            this.to1.Location = new System.Drawing.Point(23, 565);
            this.to1.MinimumSize = new System.Drawing.Size(4, 29);
            this.to1.Name = "to1";
            this.to1.Size = new System.Drawing.Size(200, 29);
            this.to1.TabIndex = 13;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 543);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(22, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "To";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 482);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "From";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 600);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(86, 31);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "View report";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 644);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.to1);
            this.Controls.Add(this.from1);
            this.Controls.Add(this.uname1);
            this.Controls.Add(this.htmlLabel3);
            this.Controls.Add(this.to);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.from);
            this.Controls.Add(this.viewmonthly);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.usercombo);
            this.Controls.Add(this.View);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Report_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MetroFramework.Controls.MetroButton View;
        private MetroFramework.Controls.MetroComboBox usercombo;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton viewmonthly;
        private MetroFramework.Controls.MetroDateTime from;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime to;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroComboBox uname1;
        private MetroFramework.Controls.MetroDateTime from1;
        private MetroFramework.Controls.MetroDateTime to1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}