namespace FileRenamer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.edtFolder = new System.Windows.Forms.TextBox();
            this.lstbxFileinDirectory = new System.Windows.Forms.ListBox();
            this.mousemenuFileList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListdeselectDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstbxCommands = new System.Windows.Forms.ListBox();
            this.mousemenuCommands = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edtCurrentSelection = new System.Windows.Forms.TextBox();
            this.edtReplaceOriginal = new System.Windows.Forms.TextBox();
            this.edtReplaceEnd = new System.Windows.Forms.TextBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblWith = new System.Windows.Forms.Label();
            this.lblCurrentSelection = new System.Windows.Forms.Label();
            this.lblSelectFolder = new System.Windows.Forms.Label();
            this.dlgBrowseFile = new System.Windows.Forms.OpenFileDialog();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.progressbarProgress = new System.Windows.Forms.ProgressBar();
            this.redtLog = new System.Windows.Forms.RichTextBox();
            this.workerRenamer = new System.ComponentModel.BackgroundWorker();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.btnCloseLog = new System.Windows.Forms.Button();
            this.btnRunRenamer = new System.Windows.Forms.Button();
            this.mousemenuFileList.SuspendLayout();
            this.mousemenuCommands.SuspendLayout();
            this.pnlLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtFolder
            // 
            this.edtFolder.Location = new System.Drawing.Point(18, 26);
            this.edtFolder.Name = "edtFolder";
            this.edtFolder.Size = new System.Drawing.Size(865, 20);
            this.edtFolder.TabIndex = 1;
            this.edtFolder.TextChanged += new System.EventHandler(this.edtFolder_TextChanged);
            // 
            // lstbxFileinDirectory
            // 
            this.lstbxFileinDirectory.ContextMenuStrip = this.mousemenuFileList;
            this.lstbxFileinDirectory.FormattingEnabled = true;
            this.lstbxFileinDirectory.Location = new System.Drawing.Point(5, 131);
            this.lstbxFileinDirectory.Name = "lstbxFileinDirectory";
            this.lstbxFileinDirectory.Size = new System.Drawing.Size(565, 472);
            this.lstbxFileinDirectory.TabIndex = 2;
            this.lstbxFileinDirectory.Click += new System.EventHandler(this.lstbxFileinDirectory_Click);
            this.lstbxFileinDirectory.SelectedIndexChanged += new System.EventHandler(this.lstbxFileinDirectory_SelectedIndexChanged);
            this.lstbxFileinDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstbxFileinDirectory_KeyDown);
            // 
            // mousemenuFileList
            // 
            this.mousemenuFileList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSelectedToolStripMenuItem,
            this.clearListdeselectDirectoryToolStripMenuItem});
            this.mousemenuFileList.Name = "mousemenuFileList";
            this.mousemenuFileList.Size = new System.Drawing.Size(227, 48);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem_Click);
            // 
            // clearListdeselectDirectoryToolStripMenuItem
            // 
            this.clearListdeselectDirectoryToolStripMenuItem.Name = "clearListdeselectDirectoryToolStripMenuItem";
            this.clearListdeselectDirectoryToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.clearListdeselectDirectoryToolStripMenuItem.Text = "Clear List (deselect directory)";
            this.clearListdeselectDirectoryToolStripMenuItem.Click += new System.EventHandler(this.clearListdeselectDirectoryToolStripMenuItem_Click);
            // 
            // lstbxCommands
            // 
            this.lstbxCommands.ContextMenuStrip = this.mousemenuCommands;
            this.lstbxCommands.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxCommands.FormattingEnabled = true;
            this.lstbxCommands.ItemHeight = 18;
            this.lstbxCommands.Location = new System.Drawing.Point(576, 131);
            this.lstbxCommands.Name = "lstbxCommands";
            this.lstbxCommands.Size = new System.Drawing.Size(575, 472);
            this.lstbxCommands.TabIndex = 3;
            this.lstbxCommands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstbxCommands_KeyDown);
            // 
            // mousemenuCommands
            // 
            this.mousemenuCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeCommandToolStripMenuItem,
            this.clearAllCommandsToolStripMenuItem});
            this.mousemenuCommands.Name = "mousemenuCommands";
            this.mousemenuCommands.Size = new System.Drawing.Size(184, 48);
            // 
            // removeCommandToolStripMenuItem
            // 
            this.removeCommandToolStripMenuItem.Name = "removeCommandToolStripMenuItem";
            this.removeCommandToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.removeCommandToolStripMenuItem.Text = "Remove Command";
            this.removeCommandToolStripMenuItem.Click += new System.EventHandler(this.removeCommandToolStripMenuItem_Click);
            // 
            // clearAllCommandsToolStripMenuItem
            // 
            this.clearAllCommandsToolStripMenuItem.Name = "clearAllCommandsToolStripMenuItem";
            this.clearAllCommandsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clearAllCommandsToolStripMenuItem.Text = "Clear All Commands";
            this.clearAllCommandsToolStripMenuItem.Click += new System.EventHandler(this.clearAllCommandsToolStripMenuItem_Click);
            // 
            // edtCurrentSelection
            // 
            this.edtCurrentSelection.Location = new System.Drawing.Point(13, 92);
            this.edtCurrentSelection.Name = "edtCurrentSelection";
            this.edtCurrentSelection.Size = new System.Drawing.Size(544, 20);
            this.edtCurrentSelection.TabIndex = 4;
            // 
            // edtReplaceOriginal
            // 
            this.edtReplaceOriginal.Location = new System.Drawing.Point(577, 92);
            this.edtReplaceOriginal.Name = "edtReplaceOriginal";
            this.edtReplaceOriginal.Size = new System.Drawing.Size(258, 20);
            this.edtReplaceOriginal.TabIndex = 5;
            this.edtReplaceOriginal.TextChanged += new System.EventHandler(this.edtReplaceOriginal_TextChanged);
            this.edtReplaceOriginal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtReplaceOriginal_KeyDown);
            // 
            // edtReplaceEnd
            // 
            this.edtReplaceEnd.Location = new System.Drawing.Point(899, 92);
            this.edtReplaceEnd.Name = "edtReplaceEnd";
            this.edtReplaceEnd.Size = new System.Drawing.Size(252, 20);
            this.edtReplaceEnd.TabIndex = 6;
            this.edtReplaceEnd.TextChanged += new System.EventHandler(this.edtReplaceEnd_TextChanged);
            this.edtReplaceEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtReplaceEnd_KeyDown);
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Font = new System.Drawing.Font("Headache", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblReplace.Location = new System.Drawing.Point(574, 75);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(292, 11);
            this.lblReplace.TabIndex = 7;
            this.lblReplace.Text = "Replace (file extensions are not affected)";
            // 
            // lblWith
            // 
            this.lblWith.AutoSize = true;
            this.lblWith.Font = new System.Drawing.Font("Headache", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblWith.Location = new System.Drawing.Point(853, 99);
            this.lblWith.Name = "lblWith";
            this.lblWith.Size = new System.Drawing.Size(30, 9);
            this.lblWith.TabIndex = 8;
            this.lblWith.Text = "with";
            // 
            // lblCurrentSelection
            // 
            this.lblCurrentSelection.AutoSize = true;
            this.lblCurrentSelection.Font = new System.Drawing.Font("Headache", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCurrentSelection.Location = new System.Drawing.Point(10, 75);
            this.lblCurrentSelection.Name = "lblCurrentSelection";
            this.lblCurrentSelection.Size = new System.Drawing.Size(125, 11);
            this.lblCurrentSelection.TabIndex = 9;
            this.lblCurrentSelection.Text = "Current Selection";
            // 
            // lblSelectFolder
            // 
            this.lblSelectFolder.AutoSize = true;
            this.lblSelectFolder.Font = new System.Drawing.Font("Headache", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSelectFolder.Location = new System.Drawing.Point(12, 9);
            this.lblSelectFolder.Name = "lblSelectFolder";
            this.lblSelectFolder.Size = new System.Drawing.Size(388, 11);
            this.lblSelectFolder.TabIndex = 10;
            this.lblSelectFolder.Text = "Containing Folder (select a file in the containing folder)";
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.BackColor = System.Drawing.Color.Transparent;
            this.lblFileCount.Font = new System.Drawing.Font("Georgia", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileCount.Location = new System.Drawing.Point(491, 115);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(68, 13);
            this.lblFileCount.TabIndex = 11;
            this.lblFileCount.Text = "Total Files: 0";
            this.lblFileCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLog
            // 
            this.pnlLog.BackColor = System.Drawing.Color.White;
            this.pnlLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLog.Controls.Add(this.progressbarProgress);
            this.pnlLog.Controls.Add(this.btnCloseLog);
            this.pnlLog.Controls.Add(this.redtLog);
            this.pnlLog.Location = new System.Drawing.Point(210, 82);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(754, 480);
            this.pnlLog.TabIndex = 14;
            this.pnlLog.Visible = false;
            // 
            // progressbarProgress
            // 
            this.progressbarProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressbarProgress.Location = new System.Drawing.Point(0, 455);
            this.progressbarProgress.Name = "progressbarProgress";
            this.progressbarProgress.Size = new System.Drawing.Size(752, 23);
            this.progressbarProgress.TabIndex = 1;
            this.progressbarProgress.Value = 50;
            // 
            // redtLog
            // 
            this.redtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redtLog.Location = new System.Drawing.Point(0, 0);
            this.redtLog.Name = "redtLog";
            this.redtLog.Size = new System.Drawing.Size(752, 456);
            this.redtLog.TabIndex = 2;
            this.redtLog.Text = "";
            // 
            // workerRenamer
            // 
            this.workerRenamer.WorkerReportsProgress = true;
            this.workerRenamer.WorkerSupportsCancellation = true;
            this.workerRenamer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerRenamer_DoWork);
            this.workerRenamer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerRenamer_ProgressChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Headache", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(1016, 52);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(65, 21);
            this.btnAbout.TabIndex = 17;
            this.btnAbout.Text = "About";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFolder.Font = new System.Drawing.Font("Headache", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnBrowseFolder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBrowseFolder.Location = new System.Drawing.Point(883, 26);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseFolder.TabIndex = 0;
            this.btnBrowseFolder.Text = "browse";
            this.btnBrowseFolder.UseVisualStyleBackColor = false;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // btnCloseLog
            // 
            this.btnCloseLog.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseLog.FlatAppearance.BorderSize = 0;
            this.btnCloseLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCloseLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCloseLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLog.Image = global::FileRenamer.Properties.Resources.close;
            this.btnCloseLog.Location = new System.Drawing.Point(722, -1);
            this.btnCloseLog.Name = "btnCloseLog";
            this.btnCloseLog.Size = new System.Drawing.Size(31, 30);
            this.btnCloseLog.TabIndex = 0;
            this.btnCloseLog.UseVisualStyleBackColor = false;
            this.btnCloseLog.Click += new System.EventHandler(this.btnCloseLog_Click);
            // 
            // btnRunRenamer
            // 
            this.btnRunRenamer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunRenamer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunRenamer.Font = new System.Drawing.Font("Headache", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRunRenamer.Image = global::FileRenamer.Properties.Resources.logo3;
            this.btnRunRenamer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRunRenamer.Location = new System.Drawing.Point(1080, 12);
            this.btnRunRenamer.Name = "btnRunRenamer";
            this.btnRunRenamer.Size = new System.Drawing.Size(65, 61);
            this.btnRunRenamer.TabIndex = 13;
            this.btnRunRenamer.Text = "Rename";
            this.btnRunRenamer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRunRenamer.UseVisualStyleBackColor = true;
            this.btnRunRenamer.Click += new System.EventHandler(this.btnRunRenamer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1157, 609);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.pnlLog);
            this.Controls.Add(this.btnRunRenamer);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.lblSelectFolder);
            this.Controls.Add(this.lblCurrentSelection);
            this.Controls.Add(this.lblWith);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.edtReplaceEnd);
            this.Controls.Add(this.edtReplaceOriginal);
            this.Controls.Add(this.edtCurrentSelection);
            this.Controls.Add(this.lstbxCommands);
            this.Controls.Add(this.lstbxFileinDirectory);
            this.Controls.Add(this.edtFolder);
            this.Controls.Add(this.btnBrowseFolder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Renamer";
            this.mousemenuFileList.ResumeLayout(false);
            this.mousemenuCommands.ResumeLayout(false);
            this.pnlLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox edtFolder;
        private System.Windows.Forms.ListBox lstbxFileinDirectory;
        private System.Windows.Forms.ListBox lstbxCommands;
        private System.Windows.Forms.TextBox edtCurrentSelection;
        private System.Windows.Forms.TextBox edtReplaceOriginal;
        private System.Windows.Forms.TextBox edtReplaceEnd;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblWith;
        private System.Windows.Forms.Label lblCurrentSelection;
        private System.Windows.Forms.Label lblSelectFolder;
        private System.Windows.Forms.OpenFileDialog dlgBrowseFile;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.ContextMenuStrip mousemenuCommands;
        private System.Windows.Forms.ToolStripMenuItem removeCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllCommandsToolStripMenuItem;
        private System.Windows.Forms.Button btnRunRenamer;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.Button btnCloseLog;
        private System.Windows.Forms.ProgressBar progressbarProgress;
        private System.Windows.Forms.RichTextBox redtLog;
        private System.ComponentModel.BackgroundWorker workerRenamer;
        private System.Windows.Forms.ContextMenuStrip mousemenuFileList;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListdeselectDirectoryToolStripMenuItem;
        private System.Windows.Forms.Button btnAbout;
    }
}

