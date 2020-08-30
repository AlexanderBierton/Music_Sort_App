namespace Car_Music_Sort
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPlaylistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryTabContainer = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFolderCount = new System.Windows.Forms.Label();
            this.lblFolderSize = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addFolderBtn = new System.Windows.Forms.ToolStripButton();
            this.exportPlaylistBtn = new System.Windows.Forms.ToolStripButton();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgTitle = new System.Windows.Forms.Label();
            this.lblProgAction = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblActionOn = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.progressPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.addFolderToolStripMenuItem,
            this.exportPlaylistsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addFolderToolStripMenuItem.Text = "Add Folder";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.AddFolder);
            // 
            // exportPlaylistsToolStripMenuItem
            // 
            this.exportPlaylistsToolStripMenuItem.Name = "exportPlaylistsToolStripMenuItem";
            this.exportPlaylistsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exportPlaylistsToolStripMenuItem.Text = "Export Playlists";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // directoryTabContainer
            // 
            this.directoryTabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryTabContainer.Location = new System.Drawing.Point(12, 174);
            this.directoryTabContainer.Name = "directoryTabContainer";
            this.directoryTabContainer.SelectedIndex = 0;
            this.directoryTabContainer.Size = new System.Drawing.Size(496, 436);
            this.directoryTabContainer.TabIndex = 2;
            this.directoryTabContainer.SelectedIndexChanged += new System.EventHandler(this.OnTabChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFolderCount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFolderSize, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalTime, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 81);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Folder Size";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFolderCount
            // 
            this.lblFolderCount.AutoSize = true;
            this.lblFolderCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFolderCount.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblFolderCount.Location = new System.Drawing.Point(3, 20);
            this.lblFolderCount.Name = "lblFolderCount";
            this.lblFolderCount.Size = new System.Drawing.Size(158, 61);
            this.lblFolderCount.TabIndex = 3;
            this.lblFolderCount.Text = "0";
            this.lblFolderCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFolderSize
            // 
            this.lblFolderSize.AutoSize = true;
            this.lblFolderSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFolderSize.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblFolderSize.Location = new System.Drawing.Point(167, 20);
            this.lblFolderSize.Name = "lblFolderSize";
            this.lblFolderSize.Size = new System.Drawing.Size(159, 61);
            this.lblFolderSize.TabIndex = 4;
            this.lblFolderSize.Text = "0";
            this.lblFolderSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalTime.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblTotalTime.Location = new System.Drawing.Point(332, 20);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(160, 61);
            this.lblTotalTime.TabIndex = 5;
            this.lblTotalTime.Text = "0";
            this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFolderBtn,
            this.exportPlaylistBtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(520, 38);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "Add Folder";
            // 
            // addFolderBtn
            // 
            this.addFolderBtn.Image = global::Car_Music_Sort.Properties.Resources.Add_Folder;
            this.addFolderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFolderBtn.Name = "addFolderBtn";
            this.addFolderBtn.Size = new System.Drawing.Size(69, 35);
            this.addFolderBtn.Text = "Add Folder";
            this.addFolderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addFolderBtn.Click += new System.EventHandler(this.AddFolder);
            // 
            // exportPlaylistBtn
            // 
            this.exportPlaylistBtn.Image = global::Car_Music_Sort.Properties.Resources.Move_Folder;
            this.exportPlaylistBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportPlaylistBtn.Name = "exportPlaylistBtn";
            this.exportPlaylistBtn.Size = new System.Drawing.Size(90, 35);
            this.exportPlaylistBtn.Text = "Export Playlists";
            this.exportPlaylistBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exportPlaylistBtn.Click += new System.EventHandler(this.ExportPlaylists);
            // 
            // progressPanel
            // 
            this.progressPanel.Controls.Add(this.tableLayoutPanel2);
            this.progressPanel.Controls.Add(this.lblProgTitle);
            this.progressPanel.Controls.Add(this.progressBar);
            this.progressPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressPanel.Location = new System.Drawing.Point(0, 525);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(520, 100);
            this.progressPanel.TabIndex = 5;
            this.progressPanel.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Do_Work);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.On_Progress_Changed);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.On_Worker_Completed);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 65);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(493, 23);
            this.progressBar.TabIndex = 0;
            this.progressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblProgTitle
            // 
            this.lblProgTitle.AutoSize = true;
            this.lblProgTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgTitle.Location = new System.Drawing.Point(9, 3);
            this.lblProgTitle.Name = "lblProgTitle";
            this.lblProgTitle.Size = new System.Drawing.Size(36, 18);
            this.lblProgTitle.TabIndex = 1;
            this.lblProgTitle.Text = "Title";
            // 
            // lblProgAction
            // 
            this.lblProgAction.AutoSize = true;
            this.lblProgAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgAction.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgAction.Location = new System.Drawing.Point(3, 0);
            this.lblProgAction.Name = "lblProgAction";
            this.lblProgAction.Size = new System.Drawing.Size(125, 25);
            this.lblProgAction.TabIndex = 2;
            this.lblProgAction.Text = "Action";
            this.lblProgAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.57201F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.42799F));
            this.tableLayoutPanel2.Controls.Add(this.lblProgAction, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblActionOn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(493, 25);
            this.tableLayoutPanel2.TabIndex = 3;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // lblActionOn
            // 
            this.lblActionOn.AutoSize = true;
            this.lblActionOn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActionOn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionOn.Location = new System.Drawing.Point(134, 0);
            this.lblActionOn.Name = "lblActionOn";
            this.lblActionOn.Size = new System.Drawing.Size(356, 25);
            this.lblActionOn.TabIndex = 3;
            this.lblActionOn.Text = "Action On";
            this.lblActionOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 625);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.directoryTabContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl directoryTabContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addFolderBtn;
        private System.Windows.Forms.Label lblFolderCount;
        private System.Windows.Forms.Label lblFolderSize;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.ToolStripButton exportPlaylistBtn;
        private System.Windows.Forms.ToolStripMenuItem exportPlaylistsToolStripMenuItem;
        private System.Windows.Forms.Panel progressPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblProgAction;
        private System.Windows.Forms.Label lblActionOn;
        private System.Windows.Forms.Label lblProgTitle;
    }
}

