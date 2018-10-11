namespace ResoflexClientHandlingSystem.StaffForms
{
    partial class EmployeeTaskTimeComparisonForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTaskTimeComparisonForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.selectMemCmbBox = new MetroFramework.Controls.MetroComboBox();
            this.selectTaskCmbBox = new MetroFramework.Controls.MetroComboBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.timeAtile = new MetroFramework.Controls.MetroTile();
            this.timeUtile = new MetroFramework.Controls.MetroTile();
            this.compareBtn = new MetroFramework.Controls.MetroButton();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportsBtn = new MetroFramework.Controls.MetroButton();
            this.homeBtn = new MetroFramework.Controls.MetroButton();
            this.timeDiffTile = new MetroFramework.Controls.MetroTile();
            this.comparisonChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.profilebtn = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1.SuspendLayout();
            this.htmlLabel2.SuspendLayout();
            this.htmlLabel1.SuspendLayout();
            this.htmlLabel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(41, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Controls.Add(this.selectMemCmbBox);
            this.htmlLabel2.Location = new System.Drawing.Point(58, 128);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(319, 37);
            this.htmlLabel2.TabIndex = 8;
            this.htmlLabel2.Text = "StaffId";
            // 
            // selectMemCmbBox
            // 
            this.selectMemCmbBox.FormattingEnabled = true;
            this.selectMemCmbBox.ItemHeight = 23;
            this.selectMemCmbBox.Location = new System.Drawing.Point(90, 0);
            this.selectMemCmbBox.Name = "selectMemCmbBox";
            this.selectMemCmbBox.Size = new System.Drawing.Size(227, 29);
            this.selectMemCmbBox.TabIndex = 9;
            this.selectMemCmbBox.UseSelectable = true;
            this.selectMemCmbBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(35, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Controls.Add(this.selectTaskCmbBox);
            this.htmlLabel1.Location = new System.Drawing.Point(58, 193);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(319, 37);
            this.htmlLabel1.TabIndex = 10;
            this.htmlLabel1.Text = "Task";
            // 
            // selectTaskCmbBox
            // 
            this.selectTaskCmbBox.FormattingEnabled = true;
            this.selectTaskCmbBox.ItemHeight = 23;
            this.selectTaskCmbBox.Location = new System.Drawing.Point(90, 0);
            this.selectTaskCmbBox.Name = "selectTaskCmbBox";
            this.selectTaskCmbBox.Size = new System.Drawing.Size(227, 29);
            this.selectTaskCmbBox.TabIndex = 9;
            this.selectTaskCmbBox.UseSelectable = true;
            this.selectTaskCmbBox.SelectedIndexChanged += new System.EventHandler(this.selectTaskCmbBox_SelectedIndexChanged);
            this.selectTaskCmbBox.SelectedValueChanged += new System.EventHandler(this.selectTaskCmbBox_SelectedValueChanged);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(269, 337);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(132, 50);
            this.metroTile2.TabIndex = 11;
            this.metroTile2.Text = "Time Used";
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.White;
            this.metroTile3.Location = new System.Drawing.Point(115, 337);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(132, 50);
            this.metroTile3.TabIndex = 11;
            this.metroTile3.Text = "Time Appointed";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            // 
            // timeAtile
            // 
            this.timeAtile.ActiveControl = null;
            this.timeAtile.Location = new System.Drawing.Point(115, 294);
            this.timeAtile.Name = "timeAtile";
            this.timeAtile.Size = new System.Drawing.Size(132, 44);
            this.timeAtile.TabIndex = 26;
            this.timeAtile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeAtile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.timeAtile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.timeAtile.UseSelectable = true;
            // 
            // timeUtile
            // 
            this.timeUtile.ActiveControl = null;
            this.timeUtile.Location = new System.Drawing.Point(269, 294);
            this.timeUtile.Name = "timeUtile";
            this.timeUtile.Size = new System.Drawing.Size(132, 44);
            this.timeUtile.TabIndex = 26;
            this.timeUtile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeUtile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.timeUtile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.timeUtile.UseSelectable = true;
            // 
            // compareBtn
            // 
            this.compareBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.compareBtn.Location = new System.Drawing.Point(549, 406);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(182, 43);
            this.compareBtn.TabIndex = 27;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseSelectable = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Controls.Add(this.metroLabel1);
            this.htmlLabel3.Location = new System.Drawing.Point(148, 447);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(219, 36);
            this.htmlLabel3.TabIndex = 62;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(-4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 25);
            this.metroLabel1.TabIndex = 64;
            this.metroLabel1.Text = "Difference : ";
            // 
            // timeChart
            // 
            this.timeChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.timeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.timeChart.Legends.Add(legend1);
            this.timeChart.Location = new System.Drawing.Point(471, 128);
            this.timeChart.Name = "timeChart";
            this.timeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Time";
            this.timeChart.Series.Add(series1);
            this.timeChart.Size = new System.Drawing.Size(366, 235);
            this.timeChart.TabIndex = 64;
            this.timeChart.Text = "chart1";
            // 
            // reportsBtn
            // 
            this.reportsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reportsBtn.Location = new System.Drawing.Point(549, 475);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(182, 43);
            this.reportsBtn.TabIndex = 65;
            this.reportsBtn.Text = "View Reports";
            this.reportsBtn.UseSelectable = true;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.BackgroundImage")));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.Location = new System.Drawing.Point(429, 6);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(30, 24);
            this.homeBtn.TabIndex = 66;
            this.homeBtn.UseSelectable = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // timeDiffTile
            //
            this.timeDiffTile.ActiveControl = null;
            this.timeDiffTile.BackColor = System.Drawing.Color.White;
            this.timeDiffTile.Location = new System.Drawing.Point(257, 441);
            this.timeDiffTile.Name = "timeDiffTile";
            this.timeDiffTile.Size = new System.Drawing.Size(110, 39);
            this.timeDiffTile.TabIndex = 65;
            this.timeDiffTile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timeDiffTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.timeDiffTile.UseSelectable = true;
            this.comparisonChart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comparisonChart.BorderlineColor = System.Drawing.Color.LightSteelBlue;
            chartArea2.Name = "ChartArea1";
            this.comparisonChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.comparisonChart.Legends.Add(legend2);
            this.comparisonChart.Location = new System.Drawing.Point(80, 158);
            this.comparisonChart.Name = "comparisonChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Expected time";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Committed time";
            this.comparisonChart.Series.Add(series3);
            this.comparisonChart.Series.Add(series4);
            this.comparisonChart.Size = new System.Drawing.Size(652, 337);
            this.comparisonChart.TabIndex = 3;
            this.comparisonChart.Text = "Task Chart";
            // 
            // profilebtn
            // 
            this.profilebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.profilebtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.profilebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.profilebtn.Location = new System.Drawing.Point(729, 6);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(105, 29);
            this.profilebtn.TabIndex = 18;
            this.profilebtn.UseCustomBackColor = true;
            this.profilebtn.UseSelectable = true;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // EmployeeTaskTimeComparisonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 575);
            this.Controls.Add(this.timeDiffTile);
            this.ClientSize = new System.Drawing.Size(841, 528);
            this.Controls.Add(this.profilebtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.reportsBtn);
            this.Controls.Add(this.timeChart);
            this.Controls.Add(this.htmlLabel3);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.timeUtile);
            this.Controls.Add(this.timeAtile);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.htmlLabel2);
            this.Name = "EmployeeTaskTimeComparisonForm";
            this.Text = "Task Time Comparison";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.EmployeeTaskTimeComparisonForm_Load);
            this.htmlLabel2.ResumeLayout(false);
            this.htmlLabel1.ResumeLayout(false);
            this.htmlLabel3.ResumeLayout(false);
            this.htmlLabel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroComboBox selectMemCmbBox;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroComboBox selectTaskCmbBox;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile timeAtile;
        private MetroFramework.Controls.MetroTile timeUtile;
        private MetroFramework.Controls.MetroButton compareBtn;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeChart;
        private MetroFramework.Controls.MetroButton reportsBtn;
        private MetroFramework.Controls.MetroButton homeBtn;
        private MetroFramework.Controls.MetroTile timeDiffTile;
        private System.Windows.Forms.DataVisualization.Charting.Chart comparisonChart;
        private MetroFramework.Controls.MetroButton profilebtn;
    }
}