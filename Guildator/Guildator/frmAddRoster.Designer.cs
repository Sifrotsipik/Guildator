namespace Guildator
{
    partial class frmAddRoster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRoster));
            this.dgvAddRosterTankList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbAddRosterCompositionInformations = new System.Windows.Forms.GroupBox();
            this.lblAddRosterTitle = new System.Windows.Forms.Label();
            this.lblAddRosterGuildMembersListTitle = new System.Windows.Forms.Label();
            this.lblAddRosterTotalMembersNumber = new System.Windows.Forms.Label();
            this.lblAddRaidNumberDps = new System.Windows.Forms.Label();
            this.lblAddRaidNumberHeal = new System.Windows.Forms.Label();
            this.lblAddRaidNumberTank = new System.Windows.Forms.Label();
            this.dgvAddRosterMembersList = new System.Windows.Forms.DataGridView();
            this.playerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuildMemberRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvAddRosterDpsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvAddRosterHealList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbAddRosterInformations = new System.Windows.Forms.GroupBox();
            this.lblAddRosterNameError = new System.Windows.Forms.Label();
            this.tbAddRosterName = new System.Windows.Forms.TextBox();
            this.lblAddRosterNameTitle = new System.Windows.Forms.Label();
            this.btnAddRosterSave = new System.Windows.Forms.Button();
            this.btnAddRosterClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRosterTankList)).BeginInit();
            this.gbAddRosterCompositionInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRosterMembersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRosterDpsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRosterHealList)).BeginInit();
            this.gbAddRosterInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAddRosterTankList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddRosterTankList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddRosterTankList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddRosterTankList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvAddRosterTankList.Location = new System.Drawing.Point(33, 393);
            this.dgvAddRosterTankList.Name = "dgvAddRosterTankList";
            this.dgvAddRosterTankList.RowHeadersVisible = false;
            this.dgvAddRosterTankList.RowHeadersWidth = 51;
            this.dgvAddRosterTankList.RowTemplate.Height = 24;
            this.dgvAddRosterTankList.Size = new System.Drawing.Size(288, 150);
            this.dgvAddRosterTankList.TabIndex = 0;
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
            // gbAddRosterCompositionInformations
            // 
            this.gbAddRosterCompositionInformations.Controls.Add(this.lblAddRosterTitle);
            this.gbAddRosterCompositionInformations.Controls.Add(this.lblAddRosterGuildMembersListTitle);
            this.gbAddRosterCompositionInformations.Controls.Add(this.lblAddRosterTotalMembersNumber);
            this.gbAddRosterCompositionInformations.Controls.Add(this.lblAddRaidNumberDps);
            this.gbAddRosterCompositionInformations.Controls.Add(this.lblAddRaidNumberHeal);
            this.gbAddRosterCompositionInformations.Controls.Add(this.lblAddRaidNumberTank);
            this.gbAddRosterCompositionInformations.Controls.Add(this.dgvAddRosterMembersList);
            this.gbAddRosterCompositionInformations.Controls.Add(this.dgvAddRosterDpsList);
            this.gbAddRosterCompositionInformations.Controls.Add(this.dgvAddRosterHealList);
            this.gbAddRosterCompositionInformations.Controls.Add(this.dgvAddRosterTankList);
            this.gbAddRosterCompositionInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddRosterCompositionInformations.Location = new System.Drawing.Point(26, 115);
            this.gbAddRosterCompositionInformations.Name = "gbAddRosterCompositionInformations";
            this.gbAddRosterCompositionInformations.Size = new System.Drawing.Size(1053, 611);
            this.gbAddRosterCompositionInformations.TabIndex = 1;
            this.gbAddRosterCompositionInformations.TabStop = false;
            this.gbAddRosterCompositionInformations.Text = "Composition";
            // 
            // lblAddRosterTitle
            // 
            this.lblAddRosterTitle.AutoSize = true;
            this.lblAddRosterTitle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRosterTitle.Location = new System.Drawing.Point(474, 297);
            this.lblAddRosterTitle.Name = "lblAddRosterTitle";
            this.lblAddRosterTitle.Size = new System.Drawing.Size(106, 39);
            this.lblAddRosterTitle.TabIndex = 9;
            this.lblAddRosterTitle.Text = "Roster";
            // 
            // lblAddRosterGuildMembersListTitle
            // 
            this.lblAddRosterGuildMembersListTitle.AutoSize = true;
            this.lblAddRosterGuildMembersListTitle.Location = new System.Drawing.Point(349, 36);
            this.lblAddRosterGuildMembersListTitle.Name = "lblAddRosterGuildMembersListTitle";
            this.lblAddRosterGuildMembersListTitle.Size = new System.Drawing.Size(345, 35);
            this.lblAddRosterGuildMembersListTitle.TabIndex = 8;
            this.lblAddRosterGuildMembersListTitle.Text = "Liste des membres de guilde";
            // 
            // lblAddRosterTotalMembersNumber
            // 
            this.lblAddRosterTotalMembersNumber.AutoSize = true;
            this.lblAddRosterTotalMembersNumber.Location = new System.Drawing.Point(467, 560);
            this.lblAddRosterTotalMembersNumber.Name = "lblAddRosterTotalMembersNumber";
            this.lblAddRosterTotalMembersNumber.Size = new System.Drawing.Size(144, 35);
            this.lblAddRosterTotalMembersNumber.TabIndex = 7;
            this.lblAddRosterTotalMembersNumber.Text = "TOTAL : 0";
            // 
            // lblAddRaidNumberDps
            // 
            this.lblAddRaidNumberDps.AutoSize = true;
            this.lblAddRaidNumberDps.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRaidNumberDps.Location = new System.Drawing.Point(839, 362);
            this.lblAddRaidNumberDps.Name = "lblAddRaidNumberDps";
            this.lblAddRaidNumberDps.Size = new System.Drawing.Size(80, 28);
            this.lblAddRaidNumberDps.TabIndex = 6;
            this.lblAddRaidNumberDps.Text = "DPS : 0";
            this.lblAddRaidNumberDps.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAddRaidNumberHeal
            // 
            this.lblAddRaidNumberHeal.AutoSize = true;
            this.lblAddRaidNumberHeal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRaidNumberHeal.Location = new System.Drawing.Point(486, 362);
            this.lblAddRaidNumberHeal.Name = "lblAddRaidNumberHeal";
            this.lblAddRaidNumberHeal.Size = new System.Drawing.Size(94, 28);
            this.lblAddRaidNumberHeal.TabIndex = 5;
            this.lblAddRaidNumberHeal.Text = "HEAL : 0";
            // 
            // lblAddRaidNumberTank
            // 
            this.lblAddRaidNumberTank.AutoSize = true;
            this.lblAddRaidNumberTank.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRaidNumberTank.Location = new System.Drawing.Point(105, 362);
            this.lblAddRaidNumberTank.Name = "lblAddRaidNumberTank";
            this.lblAddRaidNumberTank.Size = new System.Drawing.Size(98, 28);
            this.lblAddRaidNumberTank.TabIndex = 4;
            this.lblAddRaidNumberTank.Text = "TANK : 0";
            this.lblAddRaidNumberTank.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvAddRosterMembersList
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddRosterMembersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddRosterMembersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddRosterMembersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerName,
            this.playerGrade,
            this.Column4,
            this.Column5,
            this.GuildMemberRole,
            this.playerDetails});
            this.dgvAddRosterMembersList.Location = new System.Drawing.Point(158, 81);
            this.dgvAddRosterMembersList.Name = "dgvAddRosterMembersList";
            this.dgvAddRosterMembersList.RowHeadersVisible = false;
            this.dgvAddRosterMembersList.RowHeadersWidth = 51;
            this.dgvAddRosterMembersList.RowTemplate.Height = 24;
            this.dgvAddRosterMembersList.Size = new System.Drawing.Size(725, 200);
            this.dgvAddRosterMembersList.TabIndex = 3;
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
            // dgvAddRosterDpsList
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddRosterDpsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddRosterDpsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddRosterDpsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvAddRosterDpsList.Location = new System.Drawing.Point(738, 393);
            this.dgvAddRosterDpsList.Name = "dgvAddRosterDpsList";
            this.dgvAddRosterDpsList.RowHeadersVisible = false;
            this.dgvAddRosterDpsList.RowHeadersWidth = 51;
            this.dgvAddRosterDpsList.RowTemplate.Height = 24;
            this.dgvAddRosterDpsList.Size = new System.Drawing.Size(288, 150);
            this.dgvAddRosterDpsList.TabIndex = 2;
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
            // dgvAddRosterHealList
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddRosterHealList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAddRosterHealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddRosterHealList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvAddRosterHealList.Location = new System.Drawing.Point(392, 393);
            this.dgvAddRosterHealList.Name = "dgvAddRosterHealList";
            this.dgvAddRosterHealList.RowHeadersVisible = false;
            this.dgvAddRosterHealList.RowHeadersWidth = 51;
            this.dgvAddRosterHealList.RowTemplate.Height = 24;
            this.dgvAddRosterHealList.Size = new System.Drawing.Size(288, 150);
            this.dgvAddRosterHealList.TabIndex = 1;
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
            // gbAddRosterInformations
            // 
            this.gbAddRosterInformations.Controls.Add(this.lblAddRosterNameError);
            this.gbAddRosterInformations.Controls.Add(this.tbAddRosterName);
            this.gbAddRosterInformations.Controls.Add(this.lblAddRosterNameTitle);
            this.gbAddRosterInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddRosterInformations.Location = new System.Drawing.Point(26, 12);
            this.gbAddRosterInformations.Name = "gbAddRosterInformations";
            this.gbAddRosterInformations.Size = new System.Drawing.Size(1066, 97);
            this.gbAddRosterInformations.TabIndex = 0;
            this.gbAddRosterInformations.TabStop = false;
            this.gbAddRosterInformations.Text = "Informations du roster";
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
            // tbAddRosterName
            // 
            this.tbAddRosterName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddRosterName.Location = new System.Drawing.Point(223, 45);
            this.tbAddRosterName.Name = "tbAddRosterName";
            this.tbAddRosterName.Size = new System.Drawing.Size(190, 33);
            this.tbAddRosterName.TabIndex = 1;
            // 
            // lblAddRosterNameTitle
            // 
            this.lblAddRosterNameTitle.AutoSize = true;
            this.lblAddRosterNameTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRosterNameTitle.Location = new System.Drawing.Point(153, 45);
            this.lblAddRosterNameTitle.Name = "lblAddRosterNameTitle";
            this.lblAddRosterNameTitle.Size = new System.Drawing.Size(64, 26);
            this.lblAddRosterNameTitle.TabIndex = 0;
            this.lblAddRosterNameTitle.Text = "Nom :";
            // 
            // btnAddRosterSave
            // 
            this.btnAddRosterSave.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRosterSave.Location = new System.Drawing.Point(950, 732);
            this.btnAddRosterSave.Name = "btnAddRosterSave";
            this.btnAddRosterSave.Size = new System.Drawing.Size(129, 38);
            this.btnAddRosterSave.TabIndex = 2;
            this.btnAddRosterSave.Text = "Enregistrer";
            this.btnAddRosterSave.UseVisualStyleBackColor = true;
            this.btnAddRosterSave.Click += new System.EventHandler(this.btnAddRosterSave_Click);
            // 
            // btnAddRosterClose
            // 
            this.btnAddRosterClose.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRosterClose.Location = new System.Drawing.Point(26, 733);
            this.btnAddRosterClose.Name = "btnAddRosterClose";
            this.btnAddRosterClose.Size = new System.Drawing.Size(96, 36);
            this.btnAddRosterClose.TabIndex = 3;
            this.btnAddRosterClose.Text = "Fermer";
            this.btnAddRosterClose.UseVisualStyleBackColor = true;
            this.btnAddRosterClose.Click += new System.EventHandler(this.btnAddRosterClose_Click);
            // 
            // frmAddRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1125, 783);
            this.Controls.Add(this.btnAddRosterClose);
            this.Controls.Add(this.btnAddRosterSave);
            this.Controls.Add(this.gbAddRosterCompositionInformations);
            this.Controls.Add(this.gbAddRosterInformations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddRoster";
            this.Text = "Page d\'ajout d\'un roster";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRosterTankList)).EndInit();
            this.gbAddRosterCompositionInformations.ResumeLayout(false);
            this.gbAddRosterCompositionInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRosterMembersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRosterDpsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRosterHealList)).EndInit();
            this.gbAddRosterInformations.ResumeLayout(false);
            this.gbAddRosterInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAddRosterTankList;
        private System.Windows.Forms.GroupBox gbAddRosterCompositionInformations;
        private System.Windows.Forms.DataGridView dgvAddRosterDpsList;
        private System.Windows.Forms.DataGridView dgvAddRosterHealList;
        private System.Windows.Forms.Label lblAddRaidNumberDps;
        private System.Windows.Forms.Label lblAddRaidNumberHeal;
        private System.Windows.Forms.Label lblAddRaidNumberTank;
        private System.Windows.Forms.DataGridView dgvAddRosterMembersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuildMemberRole;
        private System.Windows.Forms.DataGridViewButtonColumn playerDetails;
        private System.Windows.Forms.GroupBox gbAddRosterInformations;
        private System.Windows.Forms.TextBox tbAddRosterName;
        private System.Windows.Forms.Label lblAddRosterNameTitle;
        private System.Windows.Forms.Button btnAddRosterSave;
        private System.Windows.Forms.Button btnAddRosterClose;
        private System.Windows.Forms.Label lblAddRosterTitle;
        private System.Windows.Forms.Label lblAddRosterGuildMembersListTitle;
        private System.Windows.Forms.Label lblAddRosterTotalMembersNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblAddRosterNameError;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn6;
    }
}