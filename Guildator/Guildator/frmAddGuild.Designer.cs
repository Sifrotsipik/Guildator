namespace Guildator
{
    partial class frmAddGuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGuild));
            this.gbAddGuildInformations = new System.Windows.Forms.GroupBox();
            this.tbAddGuildName = new System.Windows.Forms.TextBox();
            this.lblAddGuildName = new System.Windows.Forms.Label();
            this.btnAddGuildSave = new System.Windows.Forms.Button();
            this.btnAddGuildClose = new System.Windows.Forms.Button();
            this.gbAddGuildInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddGuildInformations
            // 
            this.gbAddGuildInformations.Controls.Add(this.tbAddGuildName);
            this.gbAddGuildInformations.Controls.Add(this.lblAddGuildName);
            this.gbAddGuildInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddGuildInformations.Location = new System.Drawing.Point(12, 12);
            this.gbAddGuildInformations.Name = "gbAddGuildInformations";
            this.gbAddGuildInformations.Size = new System.Drawing.Size(495, 142);
            this.gbAddGuildInformations.TabIndex = 0;
            this.gbAddGuildInformations.TabStop = false;
            this.gbAddGuildInformations.Text = "Créer une Guilde";
            // 
            // tbAddGuildName
            // 
            this.tbAddGuildName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddGuildName.Location = new System.Drawing.Point(139, 69);
            this.tbAddGuildName.Name = "tbAddGuildName";
            this.tbAddGuildName.Size = new System.Drawing.Size(192, 33);
            this.tbAddGuildName.TabIndex = 1;
            // 
            // lblAddGuildName
            // 
            this.lblAddGuildName.AutoSize = true;
            this.lblAddGuildName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGuildName.Location = new System.Drawing.Point(49, 69);
            this.lblAddGuildName.Name = "lblAddGuildName";
            this.lblAddGuildName.Size = new System.Drawing.Size(64, 26);
            this.lblAddGuildName.TabIndex = 0;
            this.lblAddGuildName.Text = "Nom :";
            // 
            // btnAddGuildSave
            // 
            this.btnAddGuildSave.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuildSave.Location = new System.Drawing.Point(376, 169);
            this.btnAddGuildSave.Name = "btnAddGuildSave";
            this.btnAddGuildSave.Size = new System.Drawing.Size(131, 38);
            this.btnAddGuildSave.TabIndex = 1;
            this.btnAddGuildSave.Text = "Enregistrer";
            this.btnAddGuildSave.UseVisualStyleBackColor = true;
            // 
            // btnAddGuildClose
            // 
            this.btnAddGuildClose.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuildClose.Location = new System.Drawing.Point(12, 169);
            this.btnAddGuildClose.Name = "btnAddGuildClose";
            this.btnAddGuildClose.Size = new System.Drawing.Size(113, 38);
            this.btnAddGuildClose.TabIndex = 2;
            this.btnAddGuildClose.Text = "Quitter";
            this.btnAddGuildClose.UseVisualStyleBackColor = true;
            this.btnAddGuildClose.Click += new System.EventHandler(this.btnAddGuildClose_Click);
            // 
            // frmAddGuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 229);
            this.Controls.Add(this.btnAddGuildClose);
            this.Controls.Add(this.btnAddGuildSave);
            this.Controls.Add(this.gbAddGuildInformations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddGuild";
            this.Text = "Page de création de Guilde";
            this.Load += new System.EventHandler(this.frmAddGuild_Load);
            this.gbAddGuildInformations.ResumeLayout(false);
            this.gbAddGuildInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddGuildInformations;
        private System.Windows.Forms.TextBox tbAddGuildName;
        private System.Windows.Forms.Label lblAddGuildName;
        private System.Windows.Forms.Button btnAddGuildSave;
        private System.Windows.Forms.Button btnAddGuildClose;
    }
}