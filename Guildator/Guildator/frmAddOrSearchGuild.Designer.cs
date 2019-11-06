namespace Guildator
{
    partial class frmAddOrSearchGuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrSearchGuild));
            this.gbAddOrSearchGuildInformations = new System.Windows.Forms.GroupBox();
            this.btnAddOrSearchGuildAdd = new System.Windows.Forms.Button();
            this.btnAddOrSearchGuildSearch = new System.Windows.Forms.Button();
            this.lblAddOrSearchGuildTitle = new System.Windows.Forms.Label();
            this.btnAddOrSearchGuildExit = new System.Windows.Forms.Button();
            this.lblkAddOrSearchGuildNotifications = new System.Windows.Forms.LinkLabel();
            this.lblkAddOrSearchGuildProfil = new System.Windows.Forms.LinkLabel();
            this.lblAddOrSearchGuildNotificationsTitle = new System.Windows.Forms.Label();
            this.gbAddOrSearchGuildInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddOrSearchGuildInformations
            // 
            this.gbAddOrSearchGuildInformations.Controls.Add(this.btnAddOrSearchGuildAdd);
            this.gbAddOrSearchGuildInformations.Controls.Add(this.btnAddOrSearchGuildSearch);
            this.gbAddOrSearchGuildInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddOrSearchGuildInformations.Location = new System.Drawing.Point(13, 88);
            this.gbAddOrSearchGuildInformations.Name = "gbAddOrSearchGuildInformations";
            this.gbAddOrSearchGuildInformations.Size = new System.Drawing.Size(350, 120);
            this.gbAddOrSearchGuildInformations.TabIndex = 0;
            this.gbAddOrSearchGuildInformations.TabStop = false;
            // 
            // btnAddOrSearchGuildAdd
            // 
            this.btnAddOrSearchGuildAdd.Location = new System.Drawing.Point(167, 39);
            this.btnAddOrSearchGuildAdd.Name = "btnAddOrSearchGuildAdd";
            this.btnAddOrSearchGuildAdd.Size = new System.Drawing.Size(143, 47);
            this.btnAddOrSearchGuildAdd.TabIndex = 2;
            this.btnAddOrSearchGuildAdd.Text = "Créer";
            this.btnAddOrSearchGuildAdd.UseVisualStyleBackColor = true;
            this.btnAddOrSearchGuildAdd.Click += new System.EventHandler(this.btnAddOrSearchGuildAdd_Click);
            // 
            // btnAddOrSearchGuildSearch
            // 
            this.btnAddOrSearchGuildSearch.Location = new System.Drawing.Point(18, 39);
            this.btnAddOrSearchGuildSearch.Name = "btnAddOrSearchGuildSearch";
            this.btnAddOrSearchGuildSearch.Size = new System.Drawing.Size(143, 47);
            this.btnAddOrSearchGuildSearch.TabIndex = 1;
            this.btnAddOrSearchGuildSearch.Text = "Chercher";
            this.btnAddOrSearchGuildSearch.UseVisualStyleBackColor = true;
            this.btnAddOrSearchGuildSearch.Click += new System.EventHandler(this.btnAddOrSearchGuildSearch_Click);
            // 
            // lblAddOrSearchGuildTitle
            // 
            this.lblAddOrSearchGuildTitle.AutoSize = true;
            this.lblAddOrSearchGuildTitle.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOrSearchGuildTitle.Location = new System.Drawing.Point(12, 50);
            this.lblAddOrSearchGuildTitle.Name = "lblAddOrSearchGuildTitle";
            this.lblAddOrSearchGuildTitle.Size = new System.Drawing.Size(351, 35);
            this.lblAddOrSearchGuildTitle.TabIndex = 0;
            this.lblAddOrSearchGuildTitle.Text = "Chercher ou créer une guilde";
            // 
            // btnAddOrSearchGuildExit
            // 
            this.btnAddOrSearchGuildExit.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrSearchGuildExit.Location = new System.Drawing.Point(12, 237);
            this.btnAddOrSearchGuildExit.Name = "btnAddOrSearchGuildExit";
            this.btnAddOrSearchGuildExit.Size = new System.Drawing.Size(91, 35);
            this.btnAddOrSearchGuildExit.TabIndex = 1;
            this.btnAddOrSearchGuildExit.Text = "Quitter";
            this.btnAddOrSearchGuildExit.UseVisualStyleBackColor = true;
            this.btnAddOrSearchGuildExit.Click += new System.EventHandler(this.btnAddOrSearchGuildExit_Click);
            // 
            // lblkAddOrSearchGuildNotifications
            // 
            this.lblkAddOrSearchGuildNotifications.AutoSize = true;
            this.lblkAddOrSearchGuildNotifications.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkAddOrSearchGuildNotifications.Location = new System.Drawing.Point(155, 7);
            this.lblkAddOrSearchGuildNotifications.Name = "lblkAddOrSearchGuildNotifications";
            this.lblkAddOrSearchGuildNotifications.Size = new System.Drawing.Size(24, 27);
            this.lblkAddOrSearchGuildNotifications.TabIndex = 9;
            this.lblkAddOrSearchGuildNotifications.TabStop = true;
            this.lblkAddOrSearchGuildNotifications.Text = "1";
            this.lblkAddOrSearchGuildNotifications.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkAddOrSearchGuildNotifications_LinkClicked);
            // 
            // lblkAddOrSearchGuildProfil
            // 
            this.lblkAddOrSearchGuildProfil.AutoSize = true;
            this.lblkAddOrSearchGuildProfil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkAddOrSearchGuildProfil.Location = new System.Drawing.Point(249, 5);
            this.lblkAddOrSearchGuildProfil.Name = "lblkAddOrSearchGuildProfil";
            this.lblkAddOrSearchGuildProfil.Size = new System.Drawing.Size(114, 29);
            this.lblkAddOrSearchGuildProfil.TabIndex = 8;
            this.lblkAddOrSearchGuildProfil.TabStop = true;
            this.lblkAddOrSearchGuildProfil.Text = "Mon Profil";
            this.lblkAddOrSearchGuildProfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkHomeGuildMasterProfil_LinkClicked);
            // 
            // lblAddOrSearchGuildNotificationsTitle
            // 
            this.lblAddOrSearchGuildNotificationsTitle.AutoSize = true;
            this.lblAddOrSearchGuildNotificationsTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOrSearchGuildNotificationsTitle.Location = new System.Drawing.Point(13, 9);
            this.lblAddOrSearchGuildNotificationsTitle.Name = "lblAddOrSearchGuildNotificationsTitle";
            this.lblAddOrSearchGuildNotificationsTitle.Size = new System.Drawing.Size(146, 27);
            this.lblAddOrSearchGuildNotificationsTitle.TabIndex = 7;
            this.lblAddOrSearchGuildNotificationsTitle.Text = "Notifications :";
            // 
            // frmAddOrSearchGuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 284);
            this.Controls.Add(this.lblkAddOrSearchGuildNotifications);
            this.Controls.Add(this.lblkAddOrSearchGuildProfil);
            this.Controls.Add(this.lblAddOrSearchGuildNotificationsTitle);
            this.Controls.Add(this.btnAddOrSearchGuildExit);
            this.Controls.Add(this.gbAddOrSearchGuildInformations);
            this.Controls.Add(this.lblAddOrSearchGuildTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddOrSearchGuild";
            this.Text = "Page de recherche ou création de guilde";
            this.Load += new System.EventHandler(this.frmAddOrSearchGuild_Load);
            this.gbAddOrSearchGuildInformations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddOrSearchGuildInformations;
        private System.Windows.Forms.Button btnAddOrSearchGuildSearch;
        private System.Windows.Forms.Label lblAddOrSearchGuildTitle;
        private System.Windows.Forms.Button btnAddOrSearchGuildExit;
        private System.Windows.Forms.LinkLabel lblkAddOrSearchGuildNotifications;
        private System.Windows.Forms.LinkLabel lblkAddOrSearchGuildProfil;
        private System.Windows.Forms.Label lblAddOrSearchGuildNotificationsTitle;
        private System.Windows.Forms.Button btnAddOrSearchGuildAdd;
    }
}