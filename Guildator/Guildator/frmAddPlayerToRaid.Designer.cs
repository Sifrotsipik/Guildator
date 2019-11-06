namespace Guildator
{
    partial class frmAddPlayerToRaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPlayerToRaid));
            this.gbAddPlayerToRaidInformations = new System.Windows.Forms.GroupBox();
            this.dgvAddPlayerToRaidMembersList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbAddPlayerToRaidParticipantsInformations = new System.Windows.Forms.GroupBox();
            this.dgvAddPlayerToRaidParticipantsList = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPlayerToRaidClose = new System.Windows.Forms.Button();
            this.btnAddPlayerToRaidSave = new System.Windows.Forms.Button();
            this.gbAddPlayerToRaidInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddPlayerToRaidMembersList)).BeginInit();
            this.gbAddPlayerToRaidParticipantsInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddPlayerToRaidParticipantsList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddPlayerToRaidInformations
            // 
            this.gbAddPlayerToRaidInformations.Controls.Add(this.dgvAddPlayerToRaidMembersList);
            this.gbAddPlayerToRaidInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddPlayerToRaidInformations.Location = new System.Drawing.Point(13, 15);
            this.gbAddPlayerToRaidInformations.Name = "gbAddPlayerToRaidInformations";
            this.gbAddPlayerToRaidInformations.Size = new System.Drawing.Size(741, 309);
            this.gbAddPlayerToRaidInformations.TabIndex = 0;
            this.gbAddPlayerToRaidInformations.TabStop = false;
            this.gbAddPlayerToRaidInformations.Text = "Liste des membres de la guilde";
            // 
            // dgvAddPlayerToRaidMembersList
            // 
            this.dgvAddPlayerToRaidMembersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddPlayerToRaidMembersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgvAddPlayerToRaidMembersList.Location = new System.Drawing.Point(6, 39);
            this.dgvAddPlayerToRaidMembersList.Name = "dgvAddPlayerToRaidMembersList";
            this.dgvAddPlayerToRaidMembersList.RowHeadersVisible = false;
            this.dgvAddPlayerToRaidMembersList.RowHeadersWidth = 51;
            this.dgvAddPlayerToRaidMembersList.RowTemplate.Height = 24;
            this.dgvAddPlayerToRaidMembersList.Size = new System.Drawing.Size(729, 249);
            this.dgvAddPlayerToRaidMembersList.TabIndex = 0;
            this.dgvAddPlayerToRaidMembersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddPlayerToRaidMembersList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Grade";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Race";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Classe";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Role";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ajouter";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // gbAddPlayerToRaidParticipantsInformations
            // 
            this.gbAddPlayerToRaidParticipantsInformations.Controls.Add(this.dgvAddPlayerToRaidParticipantsList);
            this.gbAddPlayerToRaidParticipantsInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddPlayerToRaidParticipantsInformations.Location = new System.Drawing.Point(13, 330);
            this.gbAddPlayerToRaidParticipantsInformations.Name = "gbAddPlayerToRaidParticipantsInformations";
            this.gbAddPlayerToRaidParticipantsInformations.Size = new System.Drawing.Size(741, 355);
            this.gbAddPlayerToRaidParticipantsInformations.TabIndex = 1;
            this.gbAddPlayerToRaidParticipantsInformations.TabStop = false;
            this.gbAddPlayerToRaidParticipantsInformations.Text = "Liste des participants au raid";
            // 
            // dgvAddPlayerToRaidParticipantsList
            // 
            this.dgvAddPlayerToRaidParticipantsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddPlayerToRaidParticipantsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column11,
            this.Column12,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvAddPlayerToRaidParticipantsList.Location = new System.Drawing.Point(15, 39);
            this.dgvAddPlayerToRaidParticipantsList.Name = "dgvAddPlayerToRaidParticipantsList";
            this.dgvAddPlayerToRaidParticipantsList.RowHeadersVisible = false;
            this.dgvAddPlayerToRaidParticipantsList.RowHeadersWidth = 51;
            this.dgvAddPlayerToRaidParticipantsList.RowTemplate.Height = 24;
            this.dgvAddPlayerToRaidParticipantsList.Size = new System.Drawing.Size(704, 271);
            this.dgvAddPlayerToRaidParticipantsList.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nom";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Grade";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Race";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Classe";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Role";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Invitation";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // btnAddPlayerToRaidClose
            // 
            this.btnAddPlayerToRaidClose.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayerToRaidClose.Location = new System.Drawing.Point(12, 691);
            this.btnAddPlayerToRaidClose.Name = "btnAddPlayerToRaidClose";
            this.btnAddPlayerToRaidClose.Size = new System.Drawing.Size(94, 33);
            this.btnAddPlayerToRaidClose.TabIndex = 2;
            this.btnAddPlayerToRaidClose.Text = "Fermer";
            this.btnAddPlayerToRaidClose.UseVisualStyleBackColor = true;
            this.btnAddPlayerToRaidClose.Click += new System.EventHandler(this.btnAddPlayerToRaidClose_Click);
            // 
            // btnAddPlayerToRaidSave
            // 
            this.btnAddPlayerToRaidSave.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayerToRaidSave.Location = new System.Drawing.Point(626, 691);
            this.btnAddPlayerToRaidSave.Name = "btnAddPlayerToRaidSave";
            this.btnAddPlayerToRaidSave.Size = new System.Drawing.Size(128, 32);
            this.btnAddPlayerToRaidSave.TabIndex = 3;
            this.btnAddPlayerToRaidSave.Text = "Enregistrer";
            this.btnAddPlayerToRaidSave.UseVisualStyleBackColor = true;
            this.btnAddPlayerToRaidSave.Click += new System.EventHandler(this.btnAddPlayerToRaidSave_Click);
            // 
            // frmAddPlayerToRaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 735);
            this.Controls.Add(this.btnAddPlayerToRaidSave);
            this.Controls.Add(this.btnAddPlayerToRaidClose);
            this.Controls.Add(this.gbAddPlayerToRaidParticipantsInformations);
            this.Controls.Add(this.gbAddPlayerToRaidInformations);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddPlayerToRaid";
            this.Text = "Page d\'ajout d\'un joueur à un raid";
            this.Load += new System.EventHandler(this.frmAddPlayerToRaid_Load);
            this.gbAddPlayerToRaidInformations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddPlayerToRaidMembersList)).EndInit();
            this.gbAddPlayerToRaidParticipantsInformations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddPlayerToRaidParticipantsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddPlayerToRaidInformations;
        private System.Windows.Forms.DataGridView dgvAddPlayerToRaidMembersList;
        private System.Windows.Forms.GroupBox gbAddPlayerToRaidParticipantsInformations;
        private System.Windows.Forms.DataGridView dgvAddPlayerToRaidParticipantsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnAddPlayerToRaidClose;
        private System.Windows.Forms.Button btnAddPlayerToRaidSave;
    }
}