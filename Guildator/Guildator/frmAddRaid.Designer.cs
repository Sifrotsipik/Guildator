namespace Guildator
{
    partial class frmAddRaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRaid));
            this.gbAddRaidInformations = new System.Windows.Forms.GroupBox();
            this.cbAddRaidGuildMasterOk = new System.Windows.Forms.CheckBox();
            this.lbAddRaidRoster = new System.Windows.Forms.ListBox();
            this.lblAddRaidRosterTitle = new System.Windows.Forms.Label();
            this.lblAddRaidDateTitle = new System.Windows.Forms.Label();
            this.dtpAddRaidDate = new System.Windows.Forms.DateTimePicker();
            this.lbAddRaidName = new System.Windows.Forms.ListBox();
            this.lblAddRaidNameTitle = new System.Windows.Forms.Label();
            this.gbAddRaidParticipantsInformations = new System.Windows.Forms.GroupBox();
            this.btnAddRaidAddPlayer = new System.Windows.Forms.Button();
            this.btnAddRaidClose = new System.Windows.Forms.Button();
            this.btnAddRaidSave = new System.Windows.Forms.Button();
            this.dgvAddRaidParticipantsList = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rôle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbAddRaidInformations.SuspendLayout();
            this.gbAddRaidParticipantsInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRaidParticipantsList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddRaidInformations
            // 
            this.gbAddRaidInformations.Controls.Add(this.cbAddRaidGuildMasterOk);
            this.gbAddRaidInformations.Controls.Add(this.lbAddRaidRoster);
            this.gbAddRaidInformations.Controls.Add(this.lblAddRaidRosterTitle);
            this.gbAddRaidInformations.Controls.Add(this.lblAddRaidDateTitle);
            this.gbAddRaidInformations.Controls.Add(this.dtpAddRaidDate);
            this.gbAddRaidInformations.Controls.Add(this.lbAddRaidName);
            this.gbAddRaidInformations.Controls.Add(this.lblAddRaidNameTitle);
            this.gbAddRaidInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddRaidInformations.Location = new System.Drawing.Point(12, 12);
            this.gbAddRaidInformations.Name = "gbAddRaidInformations";
            this.gbAddRaidInformations.Size = new System.Drawing.Size(586, 258);
            this.gbAddRaidInformations.TabIndex = 0;
            this.gbAddRaidInformations.TabStop = false;
            this.gbAddRaidInformations.Text = "Informations du raid";
            // 
            // cbAddRaidGuildMasterOk
            // 
            this.cbAddRaidGuildMasterOk.AutoSize = true;
            this.cbAddRaidGuildMasterOk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAddRaidGuildMasterOk.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddRaidGuildMasterOk.Location = new System.Drawing.Point(164, 206);
            this.cbAddRaidGuildMasterOk.Name = "cbAddRaidGuildMasterOk";
            this.cbAddRaidGuildMasterOk.Size = new System.Drawing.Size(157, 30);
            this.cbAddRaidGuildMasterOk.TabIndex = 8;
            this.cbAddRaidGuildMasterOk.Text = "J\'y participe :";
            this.cbAddRaidGuildMasterOk.UseVisualStyleBackColor = true;
            // 
            // lbAddRaidRoster
            // 
            this.lbAddRaidRoster.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddRaidRoster.FormattingEnabled = true;
            this.lbAddRaidRoster.ItemHeight = 24;
            this.lbAddRaidRoster.Items.AddRange(new object[] {
            "Sélectionnez un roster",
            "Roster 1",
            "Test"});
            this.lbAddRaidRoster.Location = new System.Drawing.Point(164, 155);
            this.lbAddRaidRoster.Name = "lbAddRaidRoster";
            this.lbAddRaidRoster.Size = new System.Drawing.Size(221, 28);
            this.lbAddRaidRoster.TabIndex = 6;
            // 
            // lblAddRaidRosterTitle
            // 
            this.lblAddRaidRosterTitle.AutoSize = true;
            this.lblAddRaidRosterTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRaidRosterTitle.Location = new System.Drawing.Point(52, 155);
            this.lblAddRaidRosterTitle.Name = "lblAddRaidRosterTitle";
            this.lblAddRaidRosterTitle.Size = new System.Drawing.Size(82, 26);
            this.lblAddRaidRosterTitle.TabIndex = 5;
            this.lblAddRaidRosterTitle.Text = "Roster :";
            // 
            // lblAddRaidDateTitle
            // 
            this.lblAddRaidDateTitle.AutoSize = true;
            this.lblAddRaidDateTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRaidDateTitle.Location = new System.Drawing.Point(50, 57);
            this.lblAddRaidDateTitle.Name = "lblAddRaidDateTitle";
            this.lblAddRaidDateTitle.Size = new System.Drawing.Size(66, 26);
            this.lblAddRaidDateTitle.TabIndex = 4;
            this.lblAddRaidDateTitle.Text = "Date :";
            // 
            // dtpAddRaidDate
            // 
            this.dtpAddRaidDate.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddRaidDate.Location = new System.Drawing.Point(164, 57);
            this.dtpAddRaidDate.Name = "dtpAddRaidDate";
            this.dtpAddRaidDate.Size = new System.Drawing.Size(309, 33);
            this.dtpAddRaidDate.TabIndex = 3;
            // 
            // lbAddRaidName
            // 
            this.lbAddRaidName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddRaidName.FormattingEnabled = true;
            this.lbAddRaidName.ItemHeight = 24;
            this.lbAddRaidName.Items.AddRange(new object[] {
            "Sélectionnez un raid",
            "Onyxia",
            "Coeur du Magma",
            "Repaire de l\'Aile Noire"});
            this.lbAddRaidName.Location = new System.Drawing.Point(164, 106);
            this.lbAddRaidName.Name = "lbAddRaidName";
            this.lbAddRaidName.Size = new System.Drawing.Size(196, 28);
            this.lbAddRaidName.TabIndex = 1;
            // 
            // lblAddRaidNameTitle
            // 
            this.lblAddRaidNameTitle.AutoSize = true;
            this.lblAddRaidNameTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRaidNameTitle.Location = new System.Drawing.Point(52, 106);
            this.lblAddRaidNameTitle.Name = "lblAddRaidNameTitle";
            this.lblAddRaidNameTitle.Size = new System.Drawing.Size(64, 26);
            this.lblAddRaidNameTitle.TabIndex = 0;
            this.lblAddRaidNameTitle.Text = "Nom :";
            // 
            // gbAddRaidParticipantsInformations
            // 
            this.gbAddRaidParticipantsInformations.Controls.Add(this.dgvAddRaidParticipantsList);
            this.gbAddRaidParticipantsInformations.Controls.Add(this.btnAddRaidAddPlayer);
            this.gbAddRaidParticipantsInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddRaidParticipantsInformations.Location = new System.Drawing.Point(12, 276);
            this.gbAddRaidParticipantsInformations.Name = "gbAddRaidParticipantsInformations";
            this.gbAddRaidParticipantsInformations.Size = new System.Drawing.Size(586, 349);
            this.gbAddRaidParticipantsInformations.TabIndex = 1;
            this.gbAddRaidParticipantsInformations.TabStop = false;
            this.gbAddRaidParticipantsInformations.Text = "Liste des participants";
            // 
            // btnAddRaidAddPlayer
            // 
            this.btnAddRaidAddPlayer.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRaidAddPlayer.Location = new System.Drawing.Point(348, 309);
            this.btnAddRaidAddPlayer.Name = "btnAddRaidAddPlayer";
            this.btnAddRaidAddPlayer.Size = new System.Drawing.Size(220, 34);
            this.btnAddRaidAddPlayer.TabIndex = 22;
            this.btnAddRaidAddPlayer.Text = "Ajouter un participant";
            this.btnAddRaidAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddRaidAddPlayer.Click += new System.EventHandler(this.btnAddRaidAddPlayer_Click);
            // 
            // btnAddRaidClose
            // 
            this.btnAddRaidClose.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRaidClose.Location = new System.Drawing.Point(12, 631);
            this.btnAddRaidClose.Name = "btnAddRaidClose";
            this.btnAddRaidClose.Size = new System.Drawing.Size(116, 37);
            this.btnAddRaidClose.TabIndex = 23;
            this.btnAddRaidClose.Text = "Fermer";
            this.btnAddRaidClose.UseVisualStyleBackColor = true;
            this.btnAddRaidClose.Click += new System.EventHandler(this.btnAddRaidClose_Click);
            // 
            // btnAddRaidSave
            // 
            this.btnAddRaidSave.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRaidSave.Location = new System.Drawing.Point(472, 631);
            this.btnAddRaidSave.Name = "btnAddRaidSave";
            this.btnAddRaidSave.Size = new System.Drawing.Size(126, 39);
            this.btnAddRaidSave.TabIndex = 24;
            this.btnAddRaidSave.Text = "Enregistrer";
            this.btnAddRaidSave.UseVisualStyleBackColor = true;
            this.btnAddRaidSave.Click += new System.EventHandler(this.btnAddRaidSave_Click);
            // 
            // dgvAddRaidParticipantsList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddRaidParticipantsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddRaidParticipantsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddRaidParticipantsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Column2,
            this.Column1,
            this.Classe,
            this.Rôle,
            this.Delete});
            this.dgvAddRaidParticipantsList.Location = new System.Drawing.Point(12, 47);
            this.dgvAddRaidParticipantsList.Name = "dgvAddRaidParticipantsList";
            this.dgvAddRaidParticipantsList.RowHeadersVisible = false;
            this.dgvAddRaidParticipantsList.RowHeadersWidth = 51;
            this.dgvAddRaidParticipantsList.RowTemplate.Height = 24;
            this.dgvAddRaidParticipantsList.Size = new System.Drawing.Size(562, 255);
            this.dgvAddRaidParticipantsList.TabIndex = 24;
            this.dgvAddRaidParticipantsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddRaidParticipantsList_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Grade";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Race";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
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
            this.Rôle.Width = 70;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Retirer";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 125;
            // 
            // frmAddRaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 680);
            this.Controls.Add(this.btnAddRaidSave);
            this.Controls.Add(this.btnAddRaidClose);
            this.Controls.Add(this.gbAddRaidParticipantsInformations);
            this.Controls.Add(this.gbAddRaidInformations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddRaid";
            this.Text = "Page d\'ajout de raid";
            this.gbAddRaidInformations.ResumeLayout(false);
            this.gbAddRaidInformations.PerformLayout();
            this.gbAddRaidParticipantsInformations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRaidParticipantsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddRaidInformations;
        private System.Windows.Forms.Label lblAddRaidDateTitle;
        private System.Windows.Forms.DateTimePicker dtpAddRaidDate;
        private System.Windows.Forms.ListBox lbAddRaidName;
        private System.Windows.Forms.Label lblAddRaidNameTitle;
        private System.Windows.Forms.ListBox lbAddRaidRoster;
        private System.Windows.Forms.Label lblAddRaidRosterTitle;
        private System.Windows.Forms.GroupBox gbAddRaidParticipantsInformations;
        private System.Windows.Forms.Button btnAddRaidAddPlayer;
        private System.Windows.Forms.Button btnAddRaidClose;
        private System.Windows.Forms.Button btnAddRaidSave;
        private System.Windows.Forms.CheckBox cbAddRaidGuildMasterOk;
        private System.Windows.Forms.DataGridView dgvAddRaidParticipantsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rôle;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}