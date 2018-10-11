namespace ResoflexClientHandlingSystem
{
    partial class MemberListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberListForm));
            this.MembersGrid = new MetroFramework.Controls.MetroGrid();
            this.UpdateMemBtn = new MetroFramework.Controls.MetroButton();
            this.GotoAddmemBtn = new MetroFramework.Controls.MetroButton();
            this.DelMemBtn = new MetroFramework.Controls.MetroButton();
            this.TotalProjectsTile = new MetroFramework.Controls.MetroTile();
            this.TotalEventsTile = new MetroFramework.Controls.MetroTile();
            this.TotalHrsTile = new MetroFramework.Controls.MetroTile();
            this.StaffEvaBtn = new MetroFramework.Controls.MetroButton();
            this.RecordAtteBtn = new MetroFramework.Controls.MetroButton();
            this.homeBtn = new MetroFramework.Controls.MetroButton();
            this.selectMemberTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.profilebtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.MembersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MembersGrid
            // 
            this.MembersGrid.AllowUserToAddRows = false;
            this.MembersGrid.AllowUserToDeleteRows = false;
            this.MembersGrid.AllowUserToResizeRows = false;
            this.MembersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MembersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MembersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MembersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MembersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MembersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MembersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MembersGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MembersGrid.EnableHeadersVisualStyles = false;
            this.MembersGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MembersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MembersGrid.Location = new System.Drawing.Point(48, 230);
            this.MembersGrid.Name = "MembersGrid";
            this.MembersGrid.ReadOnly = true;
            this.MembersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MembersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MembersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MembersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembersGrid.Size = new System.Drawing.Size(713, 298);
            this.MembersGrid.TabIndex = 0;
            this.MembersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MembersGrid_CellClick);
            this.MembersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MembersGrid_CellContentClick);
            // 
            // UpdateMemBtn
            // 
            this.UpdateMemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateMemBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.UpdateMemBtn.Location = new System.Drawing.Point(565, 201);
            this.UpdateMemBtn.Name = "UpdateMemBtn";
            this.UpdateMemBtn.Size = new System.Drawing.Size(83, 23);
            this.UpdateMemBtn.TabIndex = 1;
            this.UpdateMemBtn.Text = "Update";
            this.UpdateMemBtn.UseSelectable = true;
            this.UpdateMemBtn.Click += new System.EventHandler(this.UpdateMemBtn_Click);
            // 
            // GotoAddmemBtn
            // 
            this.GotoAddmemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GotoAddmemBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.GotoAddmemBtn.Location = new System.Drawing.Point(407, 201);
            this.GotoAddmemBtn.Name = "GotoAddmemBtn";
            this.GotoAddmemBtn.Size = new System.Drawing.Size(136, 23);
            this.GotoAddmemBtn.TabIndex = 2;
            this.GotoAddmemBtn.Text = "Add new member";
            this.GotoAddmemBtn.UseSelectable = true;
            this.GotoAddmemBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DelMemBtn
            // 
            this.DelMemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelMemBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.DelMemBtn.Location = new System.Drawing.Point(667, 201);
            this.DelMemBtn.Name = "DelMemBtn";
            this.DelMemBtn.Size = new System.Drawing.Size(95, 23);
            this.DelMemBtn.TabIndex = 3;
            this.DelMemBtn.Text = "Delete";
            this.DelMemBtn.UseSelectable = true;
            this.DelMemBtn.Click += new System.EventHandler(this.DelMemBtn_Click);
            // 
            // TotalProjectsTile
            // 
            this.TotalProjectsTile.ActiveControl = null;
            this.TotalProjectsTile.Location = new System.Drawing.Point(48, 61);
            this.TotalProjectsTile.Name = "TotalProjectsTile";
            this.TotalProjectsTile.Size = new System.Drawing.Size(157, 65);
            this.TotalProjectsTile.TabIndex = 4;
            this.TotalProjectsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalProjectsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TotalProjectsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TotalProjectsTile.UseSelectable = true;
            // 
            // TotalEventsTile
            // 
            this.TotalEventsTile.ActiveControl = null;
            this.TotalEventsTile.Location = new System.Drawing.Point(219, 61);
            this.TotalEventsTile.Name = "TotalEventsTile";
            this.TotalEventsTile.Size = new System.Drawing.Size(157, 65);
            this.TotalEventsTile.TabIndex = 4;
            this.TotalEventsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalEventsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TotalEventsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TotalEventsTile.UseSelectable = true;
            // 
            // TotalHrsTile
            // 
            this.TotalHrsTile.ActiveControl = null;
            this.TotalHrsTile.Location = new System.Drawing.Point(389, 61);
            this.TotalHrsTile.Name = "TotalHrsTile";
            this.TotalHrsTile.Size = new System.Drawing.Size(157, 65);
            this.TotalHrsTile.TabIndex = 4;
            this.TotalHrsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalHrsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TotalHrsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TotalHrsTile.UseSelectable = true;
            // 
            // StaffEvaBtn
            // 
            this.StaffEvaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StaffEvaBtn.Location = new System.Drawing.Point(631, 63);
            this.StaffEvaBtn.Name = "StaffEvaBtn";
            this.StaffEvaBtn.Size = new System.Drawing.Size(131, 27);
            this.StaffEvaBtn.TabIndex = 5;
            this.StaffEvaBtn.Text = "Staff Evalution";
            this.StaffEvaBtn.UseSelectable = true;
            this.StaffEvaBtn.Click += new System.EventHandler(this.StaffEvaBtn_Click);
            // 
            // RecordAtteBtn
            // 
            this.RecordAtteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordAtteBtn.Location = new System.Drawing.Point(631, 99);
            this.RecordAtteBtn.Name = "RecordAtteBtn";
            this.RecordAtteBtn.Size = new System.Drawing.Size(131, 27);
            this.RecordAtteBtn.TabIndex = 6;
            this.RecordAtteBtn.Text = "Record Attendance";
            this.RecordAtteBtn.UseSelectable = true;
            this.RecordAtteBtn.Click += new System.EventHandler(this.RecordAtteBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.BackgroundImage")));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.Location = new System.Drawing.Point(379, 7);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(30, 24);
            this.homeBtn.TabIndex = 22;
            this.homeBtn.UseSelectable = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // selectMemberTxtbox
            // 
            // 
            // 
            // 
            this.selectMemberTxtbox.CustomButton.Image = null;
            this.selectMemberTxtbox.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.selectMemberTxtbox.CustomButton.Name = "";
            this.selectMemberTxtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.selectMemberTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.selectMemberTxtbox.CustomButton.TabIndex = 1;
            this.selectMemberTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.selectMemberTxtbox.CustomButton.UseSelectable = true;
            this.selectMemberTxtbox.CustomButton.Visible = false;
            this.selectMemberTxtbox.Lines = new string[0];
            this.selectMemberTxtbox.Location = new System.Drawing.Point(103, 201);
            this.selectMemberTxtbox.MaxLength = 32767;
            this.selectMemberTxtbox.Name = "selectMemberTxtbox";
            this.selectMemberTxtbox.PasswordChar = '\0';
            this.selectMemberTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.selectMemberTxtbox.SelectedText = "";
            this.selectMemberTxtbox.SelectionLength = 0;
            this.selectMemberTxtbox.SelectionStart = 0;
            this.selectMemberTxtbox.ShortcutsEnabled = true;
            this.selectMemberTxtbox.Size = new System.Drawing.Size(274, 23);
            this.selectMemberTxtbox.TabIndex = 24;
            this.selectMemberTxtbox.UseSelectable = true;
            this.selectMemberTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.selectMemberTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.selectMemberTxtbox.TextChanged += new System.EventHandler(this.selectEmployeeTxtbox_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(49, 205);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Search";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(48, 107);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(157, 44);
            this.metroTile1.TabIndex = 25;
            this.metroTile1.Text = "Total Projects";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(219, 108);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(157, 43);
            this.metroTile2.TabIndex = 26;
            this.metroTile2.Text = "Total Events";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(389, 107);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(157, 44);
            this.metroTile3.TabIndex = 27;
            this.metroTile3.Text = "Total Hours";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(630, 136);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(131, 27);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.Text = "Task Time Comparison";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // profilebtn
            // 
            this.profilebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.profilebtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.profilebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.profilebtn.Location = new System.Drawing.Point(709, 7);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(105, 28);
            this.profilebtn.TabIndex = 25;
            this.profilebtn.UseCustomBackColor = true;
            this.profilebtn.UseSelectable = true;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // MemberListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.profilebtn);
            this.Controls.Add(this.selectMemberTxtbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.RecordAtteBtn);
            this.Controls.Add(this.StaffEvaBtn);
            this.Controls.Add(this.TotalHrsTile);
            this.Controls.Add(this.TotalEventsTile);
            this.Controls.Add(this.TotalProjectsTile);
            this.Controls.Add(this.DelMemBtn);
            this.Controls.Add(this.GotoAddmemBtn);
            this.Controls.Add(this.UpdateMemBtn);
            this.Controls.Add(this.MembersGrid);
            this.Name = "MemberListForm";
            this.Text = "Member List";
            this.Load += new System.EventHandler(this.MemberListForm_Load);
            this.Shown += new System.EventHandler(this.MemberListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.MembersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid MembersGrid;
        private MetroFramework.Controls.MetroButton UpdateMemBtn;
        public MetroFramework.Controls.MetroButton GotoAddmemBtn;
        private MetroFramework.Controls.MetroButton DelMemBtn;
        private MetroFramework.Controls.MetroTile TotalProjectsTile;
        private MetroFramework.Controls.MetroTile TotalEventsTile;
        private MetroFramework.Controls.MetroTile TotalHrsTile;
        private MetroFramework.Controls.MetroButton StaffEvaBtn;
        private MetroFramework.Controls.MetroButton RecordAtteBtn;
        private MetroFramework.Controls.MetroButton homeBtn;
        private MetroFramework.Controls.MetroTextBox selectMemberTxtbox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton profilebtn;
    }
}