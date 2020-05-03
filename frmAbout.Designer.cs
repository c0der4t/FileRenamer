namespace FileRenamer
{
    partial class frmAbout
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGithub = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnResources = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.pnlVersionInfo = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlVersionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Headache", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "About FileRenamer";
            // 
            // btnGithub
            // 
            this.btnGithub.BackColor = System.Drawing.Color.Transparent;
            this.btnGithub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGithub.Font = new System.Drawing.Font("Headache", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnGithub.ForeColor = System.Drawing.Color.White;
            this.btnGithub.Image = global::FileRenamer.Properties.Resources.github_logo;
            this.btnGithub.Location = new System.Drawing.Point(34, 51);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(246, 101);
            this.btnGithub.TabIndex = 2;
            this.btnGithub.Text = "FileRenamer on Github";
            this.btnGithub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGithub.UseVisualStyleBackColor = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            this.btnGithub.MouseEnter += new System.EventHandler(this.btnGithub_MouseEnter);
            this.btnGithub.MouseLeave += new System.EventHandler(this.btnGithub_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Headache", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(407, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 149);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnResources
            // 
            this.btnResources.BackColor = System.Drawing.Color.Transparent;
            this.btnResources.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResources.Font = new System.Drawing.Font("Headache", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnResources.ForeColor = System.Drawing.Color.White;
            this.btnResources.Image = global::FileRenamer.Properties.Resources.ideasbugs_logo2;
            this.btnResources.Location = new System.Drawing.Point(277, 51);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(217, 101);
            this.btnResources.TabIndex = 4;
            this.btnResources.Text = "Bug/Feature Request";
            this.btnResources.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnResources.UseVisualStyleBackColor = false;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            this.btnResources.MouseEnter += new System.EventHandler(this.btnResources_MouseEnter);
            this.btnResources.MouseLeave += new System.EventHandler(this.btnGithub_MouseLeave);
            // 
            // btnCredits
            // 
            this.btnCredits.BackColor = System.Drawing.Color.Transparent;
            this.btnCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredits.Font = new System.Drawing.Font("Headache", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCredits.ForeColor = System.Drawing.Color.White;
            this.btnCredits.Image = global::FileRenamer.Properties.Resources.resources_logo;
            this.btnCredits.Location = new System.Drawing.Point(34, 152);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(460, 97);
            this.btnCredits.TabIndex = 3;
            this.btnCredits.Text = "Resources";
            this.btnCredits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCredits.UseVisualStyleBackColor = false;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            this.btnCredits.MouseEnter += new System.EventHandler(this.btnCredits_MouseEnter);
            this.btnCredits.MouseLeave += new System.EventHandler(this.btnGithub_MouseLeave);
            // 
            // pnlVersionInfo
            // 
            this.pnlVersionInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlVersionInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVersionInfo.Controls.Add(this.linkLabel1);
            this.pnlVersionInfo.Controls.Add(this.lblReleaseDate);
            this.pnlVersionInfo.Controls.Add(this.lblVersion);
            this.pnlVersionInfo.ForeColor = System.Drawing.Color.White;
            this.pnlVersionInfo.Location = new System.Drawing.Point(34, 248);
            this.pnlVersionInfo.Name = "pnlVersionInfo";
            this.pnlVersionInfo.Size = new System.Drawing.Size(375, 149);
            this.pnlVersionInfo.TabIndex = 7;
            this.pnlVersionInfo.MouseEnter += new System.EventHandler(this.pnlVersionInfo_MouseEnter);
            this.pnlVersionInfo.MouseLeave += new System.EventHandler(this.pnlVersionInfo_MouseLeave);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Headache", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(14, 34);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(218, 16);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version 1.0.0 - Jackdaw";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Headache", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblReleaseDate.Location = new System.Drawing.Point(156, 64);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(198, 16);
            this.lblReleaseDate.TabIndex = 2;
            this.lblReleaseDate.Text = "Released 05/03/2020";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel1.Font = new System.Drawing.Font("Headache", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(48, 107);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(272, 18);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click to View Release Notes";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FileRenamer.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 416);
            this.Controls.Add(this.pnlVersionInfo);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnResources);
            this.Controls.Add(this.btnCredits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAbout";
            this.Text = "frmAbout";
            this.pnlVersionInfo.ResumeLayout(false);
            this.pnlVersionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnResources;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlVersionInfo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}