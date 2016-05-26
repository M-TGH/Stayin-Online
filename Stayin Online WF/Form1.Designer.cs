namespace Stayin_Online_WF
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuProfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAddProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuTestProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.ActiveColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SitesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntervalColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuProfiles,
            this.toolStripMenuSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(363, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuProfiles
            // 
            this.toolStripMenuProfiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAddProfile,
            this.toolStripSeparator1,
            this.toolStripMenuTestProfile});
            this.toolStripMenuProfiles.Name = "toolStripMenuProfiles";
            this.toolStripMenuProfiles.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuProfiles.Text = "Profiles";
            // 
            // toolStripMenuAddProfile
            // 
            this.toolStripMenuAddProfile.Name = "toolStripMenuAddProfile";
            this.toolStripMenuAddProfile.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuAddProfile.Text = "Add profile";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // toolStripMenuTestProfile
            // 
            this.toolStripMenuTestProfile.Name = "toolStripMenuTestProfile";
            this.toolStripMenuTestProfile.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuTestProfile.Text = "Profile1";
            // 
            // toolStripMenuSettings
            // 
            this.toolStripMenuSettings.Name = "toolStripMenuSettings";
            this.toolStripMenuSettings.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuSettings.Text = "Settings";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActiveColumn,
            this.SitesColumn,
            this.StatusColumn,
            this.IntervalColumn});
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(363, 236);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // ActiveColumn
            // 
            this.ActiveColumn.HeaderText = "Active";
            this.ActiveColumn.Name = "ActiveColumn";
            this.ActiveColumn.Width = 50;
            // 
            // SitesColumn
            // 
            this.SitesColumn.HeaderText = "Site";
            this.SitesColumn.Name = "SitesColumn";
            this.SitesColumn.Width = 150;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Width = 70;
            // 
            // IntervalColumn
            // 
            this.IntervalColumn.HeaderText = "Interval";
            this.IntervalColumn.Items.AddRange(new object[] {
            "5s",
            "10s",
            "20s",
            "30s",
            "60s"});
            this.IntervalColumn.Name = "IntervalColumn";
            this.IntervalColumn.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 260);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Stayin Online";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuProfiles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAddProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuTestProfile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSettings;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActiveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SitesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn IntervalColumn;
    }
}

