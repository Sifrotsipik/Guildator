namespace Guildator
{
    partial class frmRaidDetails
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidParticipantsNumber = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidParticipantsTitle = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidDate = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidDateTitle = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidDetails = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Roster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rôle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHomeGuildMasterRaidInvitations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "0/14";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "0/4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "0/2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "DPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "HEAL";
            // 
            // fd
            // 
            this.fd.AutoSize = true;
            this.fd.Location = new System.Drawing.Point(24, 138);
            this.fd.Name = "fd";
            this.fd.Size = new System.Drawing.Size(45, 17);
            this.fd.TabIndex = 28;
            this.fd.Text = "TANK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "En attente :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Invités : ";
            // 
            // lblHomeGuildMasterRaidParticipantsNumber
            // 
            this.lblHomeGuildMasterRaidParticipantsNumber.AutoSize = true;
            this.lblHomeGuildMasterRaidParticipantsNumber.Location = new System.Drawing.Point(228, 70);
            this.lblHomeGuildMasterRaidParticipantsNumber.Name = "lblHomeGuildMasterRaidParticipantsNumber";
            this.lblHomeGuildMasterRaidParticipantsNumber.Size = new System.Drawing.Size(0, 17);
            this.lblHomeGuildMasterRaidParticipantsNumber.TabIndex = 25;
            // 
            // lblHomeGuildMasterRaidParticipantsTitle
            // 
            this.lblHomeGuildMasterRaidParticipantsTitle.AutoSize = true;
            this.lblHomeGuildMasterRaidParticipantsTitle.Location = new System.Drawing.Point(24, 85);
            this.lblHomeGuildMasterRaidParticipantsTitle.Name = "lblHomeGuildMasterRaidParticipantsTitle";
            this.lblHomeGuildMasterRaidParticipantsTitle.Size = new System.Drawing.Size(90, 17);
            this.lblHomeGuildMasterRaidParticipantsTitle.TabIndex = 24;
            this.lblHomeGuildMasterRaidParticipantsTitle.Text = "Participants :";
            // 
            // lblHomeGuildMasterRaidDate
            // 
            this.lblHomeGuildMasterRaidDate.AutoSize = true;
            this.lblHomeGuildMasterRaidDate.Location = new System.Drawing.Point(124, 40);
            this.lblHomeGuildMasterRaidDate.Name = "lblHomeGuildMasterRaidDate";
            this.lblHomeGuildMasterRaidDate.Size = new System.Drawing.Size(82, 17);
            this.lblHomeGuildMasterRaidDate.TabIndex = 23;
            this.lblHomeGuildMasterRaidDate.Text = "dd.mm.yyyy";
            // 
            // lblHomeGuildMasterRaidDateTitle
            // 
            this.lblHomeGuildMasterRaidDateTitle.AutoSize = true;
            this.lblHomeGuildMasterRaidDateTitle.Location = new System.Drawing.Point(24, 40);
            this.lblHomeGuildMasterRaidDateTitle.Name = "lblHomeGuildMasterRaidDateTitle";
            this.lblHomeGuildMasterRaidDateTitle.Size = new System.Drawing.Size(94, 17);
            this.lblHomeGuildMasterRaidDateTitle.TabIndex = 22;
            this.lblHomeGuildMasterRaidDateTitle.Text = "Date du raid :";
            // 
            // lblHomeGuildMasterRaidDetails
            // 
            this.lblHomeGuildMasterRaidDetails.AutoSize = true;
            this.lblHomeGuildMasterRaidDetails.Location = new System.Drawing.Point(9, 11);
            this.lblHomeGuildMasterRaidDetails.Name = "lblHomeGuildMasterRaidDetails";
            this.lblHomeGuildMasterRaidDetails.Size = new System.Drawing.Size(133, 17);
            this.lblHomeGuildMasterRaidDetails.TabIndex = 21;
            this.lblHomeGuildMasterRaidDetails.Text = "Informations du raid";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Roster,
            this.Nom,
            this.Classe,
            this.Rôle,
            this.Status});
            this.dataGridView2.Location = new System.Drawing.Point(12, 218);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(530, 343);
            this.dataGridView2.TabIndex = 20;
            // 
            // Roster
            // 
            this.Roster.HeaderText = "Roster";
            this.Roster.MinimumWidth = 6;
            this.Roster.Name = "Roster";
            this.Roster.Width = 125;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // Classe
            // 
            this.Classe.HeaderText = "Classe";
            this.Classe.MinimumWidth = 6;
            this.Classe.Name = "Classe";
            this.Classe.Width = 125;
            // 
            // Rôle
            // 
            this.Rôle.HeaderText = "Rôle";
            this.Rôle.MinimumWidth = 6;
            this.Rôle.Name = "Rôle";
            this.Rôle.Width = 50;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 50;
            // 
            // lblHomeGuildMasterRaidInvitations
            // 
            this.lblHomeGuildMasterRaidInvitations.AutoSize = true;
            this.lblHomeGuildMasterRaidInvitations.Location = new System.Drawing.Point(9, 198);
            this.lblHomeGuildMasterRaidInvitations.Name = "lblHomeGuildMasterRaidInvitations";
            this.lblHomeGuildMasterRaidInvitations.Size = new System.Drawing.Size(109, 17);
            this.lblHomeGuildMasterRaidInvitations.TabIndex = 19;
            this.lblHomeGuildMasterRaidInvitations.Text = "Liste des invités";
            // 
            // frmRaidDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 676);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHomeGuildMasterRaidParticipantsNumber);
            this.Controls.Add(this.lblHomeGuildMasterRaidParticipantsTitle);
            this.Controls.Add(this.lblHomeGuildMasterRaidDate);
            this.Controls.Add(this.lblHomeGuildMasterRaidDateTitle);
            this.Controls.Add(this.lblHomeGuildMasterRaidDetails);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblHomeGuildMasterRaidInvitations);
            this.Name = "frmRaidDetails";
            this.Text = "frmRaidDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHomeGuildMasterRaidParticipantsNumber;
        private System.Windows.Forms.Label lblHomeGuildMasterRaidParticipantsTitle;
        private System.Windows.Forms.Label lblHomeGuildMasterRaidDate;
        private System.Windows.Forms.Label lblHomeGuildMasterRaidDateTitle;
        private System.Windows.Forms.Label lblHomeGuildMasterRaidDetails;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rôle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label lblHomeGuildMasterRaidInvitations;
    }
}