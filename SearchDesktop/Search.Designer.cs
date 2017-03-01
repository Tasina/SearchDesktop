namespace SearchDesktop
{
    partial class Search
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDesktopSearch = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimaz = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Result = new System.Windows.Forms.ListView();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblSnippet = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.cbTermnet = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSearch.Location = new System.Drawing.Point(326, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 45);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDesktopSearch
            // 
            this.lblDesktopSearch.AutoSize = true;
            this.lblDesktopSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblDesktopSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesktopSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDesktopSearch.Location = new System.Drawing.Point(12, 12);
            this.lblDesktopSearch.Name = "lblDesktopSearch";
            this.lblDesktopSearch.Size = new System.Drawing.Size(227, 33);
            this.lblDesktopSearch.TabIndex = 3;
            this.lblDesktopSearch.Text = "DesktopSearch";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSearch.Location = new System.Drawing.Point(245, 29);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 12);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Version 1.0";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(712, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimaz
            // 
            this.btnMinimaz.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimaz.FlatAppearance.BorderSize = 0;
            this.btnMinimaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimaz.ForeColor = System.Drawing.Color.White;
            this.btnMinimaz.Location = new System.Drawing.Point(681, 12);
            this.btnMinimaz.Name = "btnMinimaz";
            this.btnMinimaz.Size = new System.Drawing.Size(25, 25);
            this.btnMinimaz.TabIndex = 6;
            this.btnMinimaz.Text = "_";
            this.btnMinimaz.UseVisualStyleBackColor = false;
            this.btnMinimaz.Click += new System.EventHandler(this.btnMinimaz_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(650, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 25);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Result);
            this.panel1.Location = new System.Drawing.Point(12, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 386);
            this.panel1.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Result.FullRowSelect = true;
            this.Result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.Result.Location = new System.Drawing.Point(6, 3);
            this.Result.MultiSelect = false;
            this.Result.Name = "Result";
            this.Result.ShowGroups = false;
            this.Result.Size = new System.Drawing.Size(416, 380);
            this.Result.TabIndex = 0;
            this.Result.UseCompatibleStateImageBehavior = false;
            this.Result.SelectedIndexChanged += new System.EventHandler(this.Result_SelectedIndexChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(14, 61);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(80, 16);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File name:";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.ForeColor = System.Drawing.Color.Black;
            this.lblFilePath.Location = new System.Drawing.Point(14, 93);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(73, 16);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "File Path:";
            // 
            // lblSnippet
            // 
            this.lblSnippet.AutoSize = true;
            this.lblSnippet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnippet.ForeColor = System.Drawing.Color.Black;
            this.lblSnippet.Location = new System.Drawing.Point(14, 131);
            this.lblSnippet.Name = "lblSnippet";
            this.lblSnippet.Size = new System.Drawing.Size(65, 16);
            this.lblSnippet.TabIndex = 2;
            this.lblSnippet.Text = "Snippet:";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(96, 323);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(87, 41);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(92, 11);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(75, 20);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "File Info";
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.lblInfo);
            this.InfoPanel.Controls.Add(this.btnOpenFile);
            this.InfoPanel.Controls.Add(this.lblFileName);
            this.InfoPanel.Controls.Add(this.lblFilePath);
            this.InfoPanel.Controls.Add(this.lblSnippet);
            this.InfoPanel.Location = new System.Drawing.Point(443, 158);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(293, 380);
            this.InfoPanel.TabIndex = 11;
            // 
            // cbTermnet
            // 
            this.cbTermnet.AutoSize = true;
            this.cbTermnet.BackColor = System.Drawing.Color.Transparent;
            this.cbTermnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTermnet.ForeColor = System.Drawing.Color.White;
            this.cbTermnet.Location = new System.Drawing.Point(18, 116);
            this.cbTermnet.Name = "cbTermnet";
            this.cbTermnet.Size = new System.Drawing.Size(65, 17);
            this.cbTermnet.TabIndex = 12;
            this.cbTermnet.Text = "Termnet";
            this.cbTermnet.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SearchDesktop.Properties.Resources.dataSearch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 553);
            this.Controls.Add(this.cbTermnet);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMinimaz);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblDesktopSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.panel1.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDesktopSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimaz;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView Result;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblSnippet;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.CheckBox cbTermnet;
    }
}

