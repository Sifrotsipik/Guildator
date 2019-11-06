namespace Guildator
{
    partial class frmRosterDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRosterDetails));
            this.btnRosterDetailsClose = new System.Windows.Forms.Button();
            this.btnRosterDetailsSave = new System.Windows.Forms.Button();
            this.gbRosterDetailsCompositionInformations = new System.Windows.Forms.GroupBox();
            this.lblRosterDetailsTitle = new System.Windows.Forms.Label();
            this.lblRosterDetailsGuildMembersListTitle = new System.Windows.Forms.Label();
            this.lblRosterDetailsTotalMembersNumber = new System.Windows.Forms.Label();
            this.lblRosterDetailsNumberDps = new System.Windows.Forms.Label();
            this.lblRosterDetailsNumberHeal = new System.Windows.Forms.Label();
            this.lblRosterDetailsNumberTank = new System.Windows.Forms.Label();
            this.dgvRosterDetailsMembersList = new System.Windows.Forms.DataGridView();
            this.playerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuildMemberRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvRosterDetailsDpsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvRosterDetailsHealList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvRosterDetailsTankList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbRosterDetailsnformations = new System.Windows.Forms.GroupBox();
            this.lblAddRosterNameError = new System.Windows.Forms.Label();
            this.tbRosterDetailsName = new System.Windows.Forms.TextBox();
            this.lblRosterDetailsNameTitle = new System.Windows.Forms.Label();
            this.gbRosterDetailsCompositionInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRosterDetailsMembersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRosterDetailsDpsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRosterDetailsHealList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRosterDetailsTankList)).BeginInit();
            this.gbRosterDetailsnformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRosterDetailsClose
            // 
            this.btnRosterDetailsClose.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRosterDetailsClose.Location = new System.Drawing.Point(12, 733);
            this.btnRosterDetailsClose.Name = "btnRosterDetailsClose";
            this.btnRosterDetailsClose.Size = new System.Drawing.Size(96, 36);
            this.btnRosterDetailsClose.TabIndex = 7;
            this.btnRosterDetailsClose.Text = "Fermer";
            this.btnRosterDetailsClose.UseVisualStyleBackColor = true;
            this.btnRosterDetailsClose.Click += new System.EventHandler(this.btnRosterDetailsClose_Click);
            // 
            // btnRosterDetailsSave
            // 
            this.btnRosterDetailsSave.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRosterDetailsSave.Location = new System.Drawing.Point(936, 732);
            this.btnRosterDetailsSave.Name = "btnRosterDetailsSave";
            this.btnRosterDetailsSave.Size = new System.Drawing.Size(129, 38);
            this.btnRosterDetailsSave.TabIndex = 6;
            this.btnRosterDetailsSave.Text = "Enregistrer";
            this.btnRosterDetailsSave.UseVisualStyleBackColor = true;
            this.btnRosterDetailsSave.Click += new System.EventHandler(this.btnRosterDetailsSave_Click);
            // 
            // gbRosterDetailsCompositionInformations
            // 
            this.gbRosterDetailsCompositionInformations.Controls.Add(this.lblRosterDetailsTitle);
            this.gbRosterDetailsCompositionInformations.Controls.Add(this.lblRosterDetailsGuildMembersListTitle);
            this.gbRosterDetailsCompositionInformations.Controls.Add(this.lblRosterDetailsTotalMembersNumber);
            this.gbRosterDetailsCompositionInformations.Controls.Add(this.lblRosterDetailsNumberDps);
            this.gbRosterDetailsCompositionInformations.Controls.Add(this.lblRosterDetailsNumberHeal);
            this.gbRosterDetailsCompositionInformations.Controls.Add(this.lblRosterDetailsNumberTank);
            this.gbRosterDetailsCompositionInformations.Controls.Add(this.dgvRosterDetailsMembersList);
            this.gbRosterDetailsCompositionInformations.Controls.Add(this.dgvRosterDetailsDpsList);
            this.gbRosterDetailsCompositionInformations.Controls.Add(this.dgvRosterDetailsHealList);
            this.gbRosterDetailsCompositionInformations.Controls.Add(this.dgvRosterDetailsTankList);
            this.gbRosterDetailsCompositionInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRosterDetailsCompositionInformations.Location = new System.Drawing.Point(12, 115);
            this.gbRosterDetailsCompositionInformations.Name = "gbRosterDetailsCompositionInformations";
            this.gbRosterDetailsCompositionInformations.Size = new System.Drawing.Size(1053, 611);
            this.gbRosterDetailsCompositionInformations.TabIndex = 5;
            this.gbRosterDetailsCompositionInformations.TabStop = false;
            this.gbRosterDetailsCompositionInformations.Text = "Composition";
            // 
            // lblRosterDetailsTitle
            // 
            this.lblRosterDetailsTitle.AutoSize = true;
            this.lblRosterDetailsTitle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRosterDetailsTitle.Location = new System.Drawing.Point(474, 295);
            this.lblRosterDetailsTitle.Name = "lblRosterDetailsTitle";
            this.lblRosterDetailsTitle.Size = new System.Drawing.Size(106, 39);
            this.lblRosterDetailsTitle.TabIndex = 9;
            this.lblRosterDetailsTitle.Text = "Roster";
            // 
            // lblRosterDetailsGuildMembersListTitle
            // 
            this.lblRosterDetailsGuildMembersListTitle.AutoSize = true;
            this.lblRosterDetailsGuildMembersListTitle.Location = new System.Drawing.Point(349, 36);
            this.lblRosterDetailsGuildMembersListTitle.Name = "lblRosterDetailsGuildMembersListTitle";
            this.lblRosterDetailsGuildMembersListTitle.Size = new System.Drawing.Size(345, 35);
            this.lblRosterDetailsGuildMembersListTitle.TabIndex = 8;
            this.lblRosterDetailsGuildMembersListTitle.Text = "Liste des membres de guilde";
            // 
            // lblRosterDetailsTotalMembersNumber
            // 
            this.lblRosterDetailsTotalMembersNumber.AutoSize = true;
            this.lblRosterDetailsTotalMembersNumber.Location = new System.Drawing.Point(467, 560);
            this.lblRosterDetailsTotalMembersNumber.Name = "lblRosterDetailsTotalMembersNumber";
            this.lblRosterDetailsTotalMembersNumber.Size = new System.Drawing.Size(159, 35);
            this.lblRosterDetailsTotalMembersNumber.TabIndex = 7;
            this.lblRosterDetailsTotalMembersNumber.Text = "TOTAL : 20";
            // 
            // lblRosterDetailsNumberDps
            // 
            this.lblRosterDetailsNumberDps.AutoSize = true;
            this.lblRosterDetailsNumberDps.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRosterDetailsNumberDps.Location = new System.Drawing.Point(839, 362);
            this.lblRosterDetailsNumberDps.Name = "lblRosterDetailsNumberDps";
            this.lblRosterDetailsNumberDps.Size = new System.Drawing.Size(89, 28);
            this.lblRosterDetailsNumberDps.TabIndex = 6;
            this.lblRosterDetailsNumberDps.Text = "DPS : 14";
            // 
            // lblRosterDetailsNumberHeal
            // 
            this.lblRosterDetailsNumberHeal.AutoSize = true;
            this.lblRosterDetailsNumberHeal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRosterDetailsNumberHeal.Location = new System.Drawing.Point(486, 362);
            this.lblRosterDetailsNumberHeal.Name = "lblRosterDetailsNumberHeal";
            this.lblRosterDetailsNumberHeal.Size = new System.Drawing.Size(94, 28);
            this.lblRosterDetailsNumberHeal.TabIndex = 5;
            this.lblRosterDetailsNumberHeal.Text = "HEAL : 4";
            // 
            // lblRosterDetailsNumberTank
            // 
            this.lblRosterDetailsNumberTank.AutoSize = true;
            this.lblRosterDetailsNumberTank.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRosterDetailsNumberTank.Location = new System.Drawing.Point(105, 362);
            this.lblRosterDetailsNumberTank.Name = "lblRosterDetailsNumberTank";
            this.lblRosterDetailsNumberTank.Size = new System.Drawing.Size(98, 28);
            this.lblRosterDetailsNumberTank.TabIndex = 4;
            this.lblRosterDetailsNumberTank.Text = "TANK : 2";
            // 
            // dgvRosterDetailsMembersList
            // 
            this.dgvRosterDetailsMembersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRosterDetailsMembersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerName,
            this.playerGrade,
            this.Column4,
            this.Column5,
            this.GuildMemberRole,
            this.playerDetails});
            this.dgvRosterDetailsMembersList.Location = new System.Drawing.Point(158, 81);
            this.dgvRosterDetailsMembersList.Name = "dgvRosterDetailsMembersList";
            this.dgvRosterDetailsMembersList.RowHeadersVisible = false;
            this.dgvRosterDetailsMembersList.RowHeadersWidth = 51;
            this.dgvRosterDetailsMembersList.RowTemplate.Height = 24;
            this.dgvRosterDetailsMembersList.Size = new System.Drawing.Size(725, 200);
            this.dgvRosterDetailsMembersList.TabIndex = 3;
            // 
            // playerName
            // 
            this.playerName.HeaderText = "Nom";
            this.playerName.MinimumWidth = 6;
            this.playerName.Name = "playerName";
            this.playerName.Width = 125;
            // 
            // playerGrade
            // 
            this.playerGrade.HeaderText = "Grade";
            this.playerGrade.MinimumWidth = 6;
            this.playerGrade.Name = "playerGrade";
            this.playerGrade.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Race";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Classe";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // GuildMemberRole
            // 
            this.GuildMemberRole.HeaderText = "Rôle";
            this.GuildMemberRole.MinimumWidth = 6;
            this.GuildMemberRole.Name = "GuildMemberRole";
            this.GuildMemberRole.Width = 125;
            // 
            // playerDetails
            // 
            this.playerDetails.HeaderText = "Ajouter";
            this.playerDetails.MinimumWidth = 6;
            this.playerDetails.Name = "playerDetails";
            this.playerDetails.Width = 90;
            // 
            // dgvRosterDetailsDpsList
            // 
            this.dgvRosterDetailsDpsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRosterDetailsDpsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvRosterDetailsDpsList.Location = new System.Drawing.Point(738, 393);
            this.dgvRosterDetailsDpsList.Name = "dgvRosterDetailsDpsList";
            this.dgvRosterDetailsDpsList.RowHeadersVisible = false;
            this.dgvRosterDetailsDpsList.RowHeadersWidth = 51;
            this.dgvRosterDetailsDpsList.RowTemplate.Height = 24;
            this.dgvRosterDetailsDpsList.Size = new System.Drawing.Size(288, 150);
            this.dgvRosterDetailsDpsList.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Classe";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Retirer";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dgvRosterDetailsHealList
            // 
            this.dgvRosterDetailsHealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRosterDetailsHealList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvRosterDetailsHealList.Location = new System.Drawing.Point(392, 393);
            this.dgvRosterDetailsHealList.Name = "dgvRosterDetailsHealList";
            this.dgvRosterDetailsHealList.RowHeadersVisible = false;
            this.dgvRosterDetailsHealList.RowHeadersWidth = 51;
            this.dgvRosterDetailsHealList.RowTemplate.Height = 24;
            this.dgvRosterDetailsHealList.Size = new System.Drawing.Size(288, 150);
            this.dgvRosterDetailsHealList.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Classe";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Retirer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dgvRosterDetailsTankList
            // 
            this.dgvRosterDetailsTankList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRosterDetailsTankList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvRosterDetailsTankList.Location = new System.Drawing.Point(33, 393);
            this.dgvRosterDetailsTankList.Name = "dgvRosterDetailsTankList";
            this.dgvRosterDetailsTankList.RowHeadersVisible = false;
            this.dgvRosterDetailsTankList.RowHeadersWidth = 51;
            this.dgvRosterDetailsTankList.RowTemplate.Height = 24;
            this.dgvRosterDetailsTankList.Size = new System.Drawing.Size(288, 150);
            this.dgvRosterDetailsTankList.TabIndex = 0;
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
            this.Column2.HeaderText = "Classe";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Retirer";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 125;
            // 
            // gbRosterDetailsnformations
            // 
            this.gbRosterDetailsnformations.Controls.Add(this.lblAddRosterNameError);
            this.gbRosterDetailsnformations.Controls.Add(this.tbRosterDetailsName);
            this.gbRosterDetailsnformations.Controls.Add(this.lblRosterDetailsNameTitle);
            this.gbRosterDetailsnformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRosterDetailsnformations.Location = new System.Drawing.Point(12, 12);
            this.gbRosterDetailsnformations.Name = "gbRosterDetailsnformations";
            this.gbRosterDetailsnformations.Size = new System.Drawing.Size(1066, 97);
            this.gbRosterDetailsnformations.TabIndex = 4;
            this.gbRosterDetailsnformations.TabStop = false;
            this.gbRosterDetailsnformations.Text = "Informations du roster";
            // 
            // lblAddRosterNameError
            // 
            this.lblAddRosterNameError.AutoSize = true;
            this.lblAddRosterNameError.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRosterNameError.ForeColor = System.Drawing.Color.Red;
            this.lblAddRosterNameError.Location = new System.Drawing.Point(443, 48);
            this.lblAddRosterNameError.Name = "lblAddRosterNameError";
            this.lblAddRosterNameError.Size = new System.Drawing.Size(0, 26);
            this.lblAddRosterNameError.TabIndex = 2;
            // 
            // tbRosterDetailsName
            // 
            this.tbRosterDetailsName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRosterDetailsName.Location = new System.Drawing.Point(223, 45);
            this.tbRosterDetailsName.Name = "tbRosterDetailsName";
            this.tbRosterDetailsName.Size = new System.Drawing.Size(190, 33);
            this.tbRosterDetailsName.TabIndex = 1;
            this.tbRosterDetailsName.Text = "NomDuRoster";
            // 
            // lblRosterDetailsNameTitle
            // 
            this.lblRosterDetailsNameTitle.AutoSize = true;
            this.lblRosterDetailsNameTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRosterDetailsNameTitle.Location = new System.Drawing.Point(153, 45);
            this.lblRosterDetailsNameTitle.Name = "lblRosterDetailsNameTitle";
            this.lblRosterDetailsNameTitle.Size = new System.Drawing.Size(64, 26);
            this.lblRosterDetailsNameTitle.TabIndex = 0;
            this.lblRosterDetailsNameTitle.Text = "Nom :";
            // 
            // frmRosterDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 781);
            this.Controls.Add(this.btnRosterDetailsClose);
            this.Controls.Add(this.btnRosterDetailsSave);
            this.Controls.Add(this.gbRosterDetailsCompositionInformations);
            this.Controls.Add(this.gbRosterDetailsnformations);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRosterDetails";
            this.Text = "Page de détails du Roster";
            this.Load += new System.EventHandler(this.frmRosterDetails_Load);
            this.gbRosterDetailsCompositionInformations.ResumeLayout(false);
            this.gbRosterDetailsCompositionInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRosterDetailsMembersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRosterDetailsDpsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRosterDetailsHealList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRosterDetailsTankList)).EndInit();
            this.gbRosterDetailsnformations.ResumeLayout(false);
            this.gbRosterDetailsnformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRosterDetailsClose;
        private System.Windows.Forms.Button btnRosterDetailsSave;
        private System.Windows.Forms.GroupBox gbRosterDetailsCompositionInformations;
        private System.Windows.Forms.Label lblRosterDetailsTitle;
        private System.Windows.Forms.Label lblRosterDetailsGuildMembersListTitle;
        private System.Windows.Forms.Label lblRosterDetailsTotalMembersNumber;
        private System.Windows.Forms.Label lblRosterDetailsNumberDps;
        private System.Windows.Forms.Label lblRosterDetailsNumberHeal;
        private System.Windows.Forms.Label lblRosterDetailsNumberTank;
        private System.Windows.Forms.DataGridView dgvRosterDetailsMembersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuildMemberRole;
        private System.Windows.Forms.DataGridViewButtonColumn playerDetails;
        private System.Windows.Forms.DataGridView dgvRosterDetailsDpsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dgvRosterDetailsHealList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgvRosterDetailsTankList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.GroupBox gbRosterDetailsnformations;
        private System.Windows.Forms.Label lblAddRosterNameError;
        private System.Windows.Forms.TextBox tbRosterDetailsName;
        private System.Windows.Forms.Label lblRosterDetailsNameTitle;
    }
}