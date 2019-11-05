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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOrSearchGuildSearch = new System.Windows.Forms.Button();
            this.btnAddOrSearchGuildExit = new System.Windows.Forms.Button();
            this.lblkHomeGuildMasterNotifications = new System.Windows.Forms.LinkLabel();
            this.lblkHomeGuildMasterProfil = new System.Windows.Forms.LinkLabel();
            this.lblHomeGuildMasterNotificationsTitle = new System.Windows.Forms.Label();
            this.btnAddOrSearchGuildAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddOrSearchGuildAdd);
            this.groupBox1.Controls.Add(this.btnAddOrSearchGuildSearch);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chercher ou créer une guilde";
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
            // btnAddOrSearchGuildExit
            // 
            this.btnAddOrSearchGuildExit.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrSearchGuildExit.Location = new System.Drawing.Point(12, 237);
            this.btnAddOrSearchGuildExit.Name = "btnAddOrSearchGuildExit";
            this.btnAddOrSearchGuildExit.Size = new System.Drawing.Size(91, 35);
            this.btnAddOrSearchGuildExit.TabIndex = 1;
            this.btnAddOrSearchGuildExit.Text = "Quitter";
            this.btnAddOrSearchGuildExit.UseVisualStyleBackColor = true;
            // 
            // lblkHomeGuildMasterNotifications
            // 
            this.lblkHomeGuildMasterNotifications.AutoSize = true;
            this.lblkHomeGuildMasterNotifications.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkHomeGuildMasterNotifications.Location = new System.Drawing.Point(155, 7);
            this.lblkHomeGuildMasterNotifications.Name = "lblkHomeGuildMasterNotifications";
            this.lblkHomeGuildMasterNotifications.Size = new System.Drawing.Size(24, 27);
            this.lblkHomeGuildMasterNotifications.TabIndex = 9;
            this.lblkHomeGuildMasterNotifications.TabStop = true;
            this.lblkHomeGuildMasterNotifications.Text = "1";
            // 
            // lblkHomeGuildMasterProfil
            // 
            this.lblkHomeGuildMasterProfil.AutoSize = true;
            this.lblkHomeGuildMasterProfil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkHomeGuildMasterProfil.Location = new System.Drawing.Point(249, 5);
            this.lblkHomeGuildMasterProfil.Name = "lblkHomeGuildMasterProfil";
            this.lblkHomeGuildMasterProfil.Size = new System.Drawing.Size(114, 29);
            this.lblkHomeGuildMasterProfil.TabIndex = 8;
            this.lblkHomeGuildMasterProfil.TabStop = true;
            this.lblkHomeGuildMasterProfil.Text = "Mon Profil";
            this.lblkHomeGuildMasterProfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkHomeGuildMasterProfil_LinkClicked);
            // 
            // lblHomeGuildMasterNotificationsTitle
            // 
            this.lblHomeGuildMasterNotificationsTitle.AutoSize = true;
            this.lblHomeGuildMasterNotificationsTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeGuildMasterNotificationsTitle.Location = new System.Drawing.Point(13, 9);
            this.lblHomeGuildMasterNotificationsTitle.Name = "lblHomeGuildMasterNotificationsTitle";
            this.lblHomeGuildMasterNotificationsTitle.Size = new System.Drawing.Size(146, 27);
            this.lblHomeGuildMasterNotificationsTitle.TabIndex = 7;
            this.lblHomeGuildMasterNotificationsTitle.Text = "Notifications :";
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
            // frmAddOrSearchGuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 284);
            this.Controls.Add(this.lblkHomeGuildMasterNotifications);
            this.Controls.Add(this.lblkHomeGuildMasterProfil);
            this.Controls.Add(this.lblHomeGuildMasterNotificationsTitle);
            this.Controls.Add(this.btnAddOrSearchGuildExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAddOrSearchGuild";
            this.Text = "frmAddOrSearchGuild";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddOrSearchGuildSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddOrSearchGuildExit;
        private System.Windows.Forms.LinkLabel lblkHomeGuildMasterNotifications;
        private System.Windows.Forms.LinkLabel lblkHomeGuildMasterProfil;
        private System.Windows.Forms.Label lblHomeGuildMasterNotificationsTitle;
        private System.Windows.Forms.Button btnAddOrSearchGuildAdd;
    }
}