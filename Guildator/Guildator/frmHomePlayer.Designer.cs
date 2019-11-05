﻿namespace Guildator
{
    partial class frmHomePlayer
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
            this.tcHomeGuildMasterInfomations = new System.Windows.Forms.TabControl();
            this.tpHomeGuildMembers = new System.Windows.Forms.TabPage();
            this.lblHomeGuildMasterMembersTitle = new System.Windows.Forms.Label();
            this.gbHomeGuildMasterGuildMembersList = new System.Windows.Forms.GroupBox();
            this.dgvHomeGuildMasterMembersList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tpHomeGuildRaid = new System.Windows.Forms.TabPage();
            this.lblHomeGuildMasterRaids = new System.Windows.Forms.Label();
            this.gbHomeGuildMasterRaidList = new System.Windows.Forms.GroupBox();
            this.mcHomeGuildMasterRaidCalendar = new System.Windows.Forms.MonthCalendar();
            this.dgvHomeGuildMasterRaidList = new System.Windows.Forms.DataGridView();
            this.raidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidinvites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidRoster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblHomeRaidList = new System.Windows.Forms.Label();
            this.tpComposants = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHomeGuildMasterComponentDemand = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.PlayerDemandComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerDemandQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerDemandDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ComponantPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentContribution = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblkHomeGuildMasterNotifications = new System.Windows.Forms.LinkLabel();
            this.lblkHomeGuildMasterProfil = new System.Windows.Forms.LinkLabel();
            this.lblHomeGuildMasterNotificationsTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcHomeGuildMasterInfomations.SuspendLayout();
            this.tpHomeGuildMembers.SuspendLayout();
            this.gbHomeGuildMasterGuildMembersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeGuildMasterMembersList)).BeginInit();
            this.tpHomeGuildRaid.SuspendLayout();
            this.gbHomeGuildMasterRaidList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeGuildMasterRaidList)).BeginInit();
            this.tpComposants.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tcHomeGuildMasterInfomations
            // 
            this.tcHomeGuildMasterInfomations.AccessibleName = "";
            this.tcHomeGuildMasterInfomations.Controls.Add(this.tpHomeGuildMembers);
            this.tcHomeGuildMasterInfomations.Controls.Add(this.tpHomeGuildRaid);
            this.tcHomeGuildMasterInfomations.Controls.Add(this.tpComposants);
            this.tcHomeGuildMasterInfomations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcHomeGuildMasterInfomations.Location = new System.Drawing.Point(12, 39);
            this.tcHomeGuildMasterInfomations.Name = "tcHomeGuildMasterInfomations";
            this.tcHomeGuildMasterInfomations.SelectedIndex = 0;
            this.tcHomeGuildMasterInfomations.Size = new System.Drawing.Size(1168, 760);
            this.tcHomeGuildMasterInfomations.TabIndex = 1;
            // 
            // tpHomeGuildMembers
            // 
            this.tpHomeGuildMembers.Controls.Add(this.lblHomeGuildMasterMembersTitle);
            this.tpHomeGuildMembers.Controls.Add(this.gbHomeGuildMasterGuildMembersList);
            this.tpHomeGuildMembers.Location = new System.Drawing.Point(4, 40);
            this.tpHomeGuildMembers.Name = "tpHomeGuildMembers";
            this.tpHomeGuildMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomeGuildMembers.Size = new System.Drawing.Size(1160, 716);
            this.tpHomeGuildMembers.TabIndex = 0;
            this.tpHomeGuildMembers.Text = "Membres";
            this.tpHomeGuildMembers.UseVisualStyleBackColor = true;
            // 
            // lblHomeGuildMasterMembersTitle
            // 
            this.lblHomeGuildMasterMembersTitle.AutoSize = true;
            this.lblHomeGuildMasterMembersTitle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeGuildMasterMembersTitle.Location = new System.Drawing.Point(410, 25);
            this.lblHomeGuildMasterMembersTitle.Name = "lblHomeGuildMasterMembersTitle";
            this.lblHomeGuildMasterMembersTitle.Size = new System.Drawing.Size(274, 39);
            this.lblHomeGuildMasterMembersTitle.TabIndex = 2;
            this.lblHomeGuildMasterMembersTitle.Text = "Membres de guilde";
            // 
            // gbHomeGuildMasterGuildMembersList
            // 
            this.gbHomeGuildMasterGuildMembersList.Controls.Add(this.dgvHomeGuildMasterMembersList);
            this.gbHomeGuildMasterGuildMembersList.Location = new System.Drawing.Point(16, 67);
            this.gbHomeGuildMasterGuildMembersList.Name = "gbHomeGuildMasterGuildMembersList";
            this.gbHomeGuildMasterGuildMembersList.Size = new System.Drawing.Size(1125, 646);
            this.gbHomeGuildMasterGuildMembersList.TabIndex = 0;
            this.gbHomeGuildMasterGuildMembersList.TabStop = false;
            this.gbHomeGuildMasterGuildMembersList.Text = "Liste des membres";
            // 
            // dgvHomeGuildMasterMembersList
            // 
            this.dgvHomeGuildMasterMembersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeGuildMasterMembersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1});
            this.dgvHomeGuildMasterMembersList.Location = new System.Drawing.Point(35, 39);
            this.dgvHomeGuildMasterMembersList.Name = "dgvHomeGuildMasterMembersList";
            this.dgvHomeGuildMasterMembersList.RowHeadersVisible = false;
            this.dgvHomeGuildMasterMembersList.RowHeadersWidth = 51;
            this.dgvHomeGuildMasterMembersList.RowTemplate.Height = 24;
            this.dgvHomeGuildMasterMembersList.Size = new System.Drawing.Size(1050, 580);
            this.dgvHomeGuildMasterMembersList.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Rôle";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Détails";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 90;
            // 
            // tpHomeGuildRaid
            // 
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeGuildMasterRaids);
            this.tpHomeGuildRaid.Controls.Add(this.gbHomeGuildMasterRaidList);
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeRaidList);
            this.tpHomeGuildRaid.Location = new System.Drawing.Point(4, 40);
            this.tpHomeGuildRaid.Name = "tpHomeGuildRaid";
            this.tpHomeGuildRaid.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomeGuildRaid.Size = new System.Drawing.Size(1160, 716);
            this.tpHomeGuildRaid.TabIndex = 3;
            this.tpHomeGuildRaid.Text = "Raids";
            this.tpHomeGuildRaid.UseVisualStyleBackColor = true;
            // 
            // lblHomeGuildMasterRaids
            // 
            this.lblHomeGuildMasterRaids.AutoSize = true;
            this.lblHomeGuildMasterRaids.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeGuildMasterRaids.Location = new System.Drawing.Point(207, 26);
            this.lblHomeGuildMasterRaids.Name = "lblHomeGuildMasterRaids";
            this.lblHomeGuildMasterRaids.Size = new System.Drawing.Size(89, 39);
            this.lblHomeGuildMasterRaids.TabIndex = 6;
            this.lblHomeGuildMasterRaids.Text = "Raids";
            // 
            // gbHomeGuildMasterRaidList
            // 
            this.gbHomeGuildMasterRaidList.Controls.Add(this.mcHomeGuildMasterRaidCalendar);
            this.gbHomeGuildMasterRaidList.Controls.Add(this.dgvHomeGuildMasterRaidList);
            this.gbHomeGuildMasterRaidList.Location = new System.Drawing.Point(12, 68);
            this.gbHomeGuildMasterRaidList.Name = "gbHomeGuildMasterRaidList";
            this.gbHomeGuildMasterRaidList.Size = new System.Drawing.Size(561, 614);
            this.gbHomeGuildMasterRaidList.TabIndex = 4;
            this.gbHomeGuildMasterRaidList.TabStop = false;
            this.gbHomeGuildMasterRaidList.Text = "Liste des raids";
            // 
            // mcHomeGuildMasterRaidCalendar
            // 
            this.mcHomeGuildMasterRaidCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.mcHomeGuildMasterRaidCalendar.Location = new System.Drawing.Point(12, 45);
            this.mcHomeGuildMasterRaidCalendar.Name = "mcHomeGuildMasterRaidCalendar";
            this.mcHomeGuildMasterRaidCalendar.TabIndex = 0;
            // 
            // dgvHomeGuildMasterRaidList
            // 
            this.dgvHomeGuildMasterRaidList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeGuildMasterRaidList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raidName,
            this.raidinvites,
            this.raidRoster,
            this.raidDetails});
            this.dgvHomeGuildMasterRaidList.Location = new System.Drawing.Point(12, 275);
            this.dgvHomeGuildMasterRaidList.Name = "dgvHomeGuildMasterRaidList";
            this.dgvHomeGuildMasterRaidList.RowHeadersVisible = false;
            this.dgvHomeGuildMasterRaidList.RowHeadersWidth = 51;
            this.dgvHomeGuildMasterRaidList.RowTemplate.Height = 24;
            this.dgvHomeGuildMasterRaidList.Size = new System.Drawing.Size(543, 318);
            this.dgvHomeGuildMasterRaidList.TabIndex = 1;
            // 
            // raidName
            // 
            this.raidName.HeaderText = "Nom";
            this.raidName.MinimumWidth = 6;
            this.raidName.Name = "raidName";
            this.raidName.Width = 125;
            // 
            // raidinvites
            // 
            this.raidinvites.HeaderText = "Invités";
            this.raidinvites.MinimumWidth = 6;
            this.raidinvites.Name = "raidinvites";
            this.raidinvites.Width = 125;
            // 
            // raidRoster
            // 
            this.raidRoster.HeaderText = "Roster";
            this.raidRoster.MinimumWidth = 6;
            this.raidRoster.Name = "raidRoster";
            this.raidRoster.Width = 125;
            // 
            // raidDetails
            // 
            this.raidDetails.HeaderText = "Détails";
            this.raidDetails.MinimumWidth = 6;
            this.raidDetails.Name = "raidDetails";
            this.raidDetails.Width = 125;
            // 
            // lblHomeRaidList
            // 
            this.lblHomeRaidList.AutoSize = true;
            this.lblHomeRaidList.Location = new System.Drawing.Point(9, 298);
            this.lblHomeRaidList.Name = "lblHomeRaidList";
            this.lblHomeRaidList.Size = new System.Drawing.Size(179, 33);
            this.lblHomeRaidList.TabIndex = 3;
            this.lblHomeRaidList.Text = "Liste des raids";
            // 
            // tpComposants
            // 
            this.tpComposants.Controls.Add(this.label5);
            this.tpComposants.Controls.Add(this.groupBox2);
            this.tpComposants.Controls.Add(this.groupBox1);
            this.tpComposants.Location = new System.Drawing.Point(4, 40);
            this.tpComposants.Name = "tpComposants";
            this.tpComposants.Padding = new System.Windows.Forms.Padding(3);
            this.tpComposants.Size = new System.Drawing.Size(1160, 716);
            this.tpComposants.TabIndex = 4;
            this.tpComposants.Text = "Composants";
            this.tpComposants.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = "Demandes de composants";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHomeGuildMasterComponentDemand);
            this.groupBox2.Controls.Add(this.dataGridView5);
            this.groupBox2.Location = new System.Drawing.Point(615, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 590);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mes demandes";
            // 
            // btnHomeGuildMasterComponentDemand
            // 
            this.btnHomeGuildMasterComponentDemand.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeGuildMasterComponentDemand.Location = new System.Drawing.Point(264, 543);
            this.btnHomeGuildMasterComponentDemand.Name = "btnHomeGuildMasterComponentDemand";
            this.btnHomeGuildMasterComponentDemand.Size = new System.Drawing.Size(217, 41);
            this.btnHomeGuildMasterComponentDemand.TabIndex = 1;
            this.btnHomeGuildMasterComponentDemand.Text = "Demander un composant";
            this.btnHomeGuildMasterComponentDemand.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerDemandComponent,
            this.PlayerDemandQuantity,
            this.PlayerDemandDetails});
            this.dataGridView5.Location = new System.Drawing.Point(22, 52);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(459, 480);
            this.dataGridView5.TabIndex = 0;
            // 
            // PlayerDemandComponent
            // 
            this.PlayerDemandComponent.HeaderText = "Composant";
            this.PlayerDemandComponent.MinimumWidth = 6;
            this.PlayerDemandComponent.Name = "PlayerDemandComponent";
            this.PlayerDemandComponent.Width = 125;
            // 
            // PlayerDemandQuantity
            // 
            this.PlayerDemandQuantity.HeaderText = "Quantité";
            this.PlayerDemandQuantity.MinimumWidth = 6;
            this.PlayerDemandQuantity.Name = "PlayerDemandQuantity";
            this.PlayerDemandQuantity.Width = 125;
            // 
            // PlayerDemandDetails
            // 
            this.PlayerDemandDetails.HeaderText = "Détails";
            this.PlayerDemandDetails.MinimumWidth = 6;
            this.PlayerDemandDetails.Name = "PlayerDemandDetails";
            this.PlayerDemandDetails.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Location = new System.Drawing.Point(6, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 577);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toutes les demandes";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponantPlayerName,
            this.ComponentName,
            this.ComponentQuantity,
            this.ComponentContribution});
            this.dataGridView4.Location = new System.Drawing.Point(20, 52);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(519, 508);
            this.dataGridView4.TabIndex = 0;
            // 
            // ComponantPlayerName
            // 
            this.ComponantPlayerName.HeaderText = "Nom Joueur";
            this.ComponantPlayerName.MinimumWidth = 6;
            this.ComponantPlayerName.Name = "ComponantPlayerName";
            this.ComponantPlayerName.Width = 125;
            // 
            // ComponentName
            // 
            this.ComponentName.HeaderText = "Composant";
            this.ComponentName.MinimumWidth = 6;
            this.ComponentName.Name = "ComponentName";
            this.ComponentName.Width = 125;
            // 
            // ComponentQuantity
            // 
            this.ComponentQuantity.HeaderText = "Quantité";
            this.ComponentQuantity.MinimumWidth = 6;
            this.ComponentQuantity.Name = "ComponentQuantity";
            this.ComponentQuantity.Width = 125;
            // 
            // ComponentContribution
            // 
            this.ComponentContribution.HeaderText = "Contribuer";
            this.ComponentContribution.MinimumWidth = 6;
            this.ComponentContribution.Name = "ComponentContribution";
            this.ComponentContribution.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComponentContribution.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ComponentContribution.Width = 125;
            // 
            // lblkHomeGuildMasterNotifications
            // 
            this.lblkHomeGuildMasterNotifications.AutoSize = true;
            this.lblkHomeGuildMasterNotifications.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkHomeGuildMasterNotifications.Location = new System.Drawing.Point(962, 7);
            this.lblkHomeGuildMasterNotifications.Name = "lblkHomeGuildMasterNotifications";
            this.lblkHomeGuildMasterNotifications.Size = new System.Drawing.Size(24, 27);
            this.lblkHomeGuildMasterNotifications.TabIndex = 10;
            this.lblkHomeGuildMasterNotifications.TabStop = true;
            this.lblkHomeGuildMasterNotifications.Text = "2";
            // 
            // lblkHomeGuildMasterProfil
            // 
            this.lblkHomeGuildMasterProfil.AutoSize = true;
            this.lblkHomeGuildMasterProfil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkHomeGuildMasterProfil.Location = new System.Drawing.Point(1022, 7);
            this.lblkHomeGuildMasterProfil.Name = "lblkHomeGuildMasterProfil";
            this.lblkHomeGuildMasterProfil.Size = new System.Drawing.Size(114, 29);
            this.lblkHomeGuildMasterProfil.TabIndex = 9;
            this.lblkHomeGuildMasterProfil.TabStop = true;
            this.lblkHomeGuildMasterProfil.Text = "Mon Profil";
            // 
            // lblHomeGuildMasterNotificationsTitle
            // 
            this.lblHomeGuildMasterNotificationsTitle.AutoSize = true;
            this.lblHomeGuildMasterNotificationsTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeGuildMasterNotificationsTitle.Location = new System.Drawing.Point(820, 9);
            this.lblHomeGuildMasterNotificationsTitle.Name = "lblHomeGuildMasterNotificationsTitle";
            this.lblHomeGuildMasterNotificationsTitle.Size = new System.Drawing.Size(146, 27);
            this.lblHomeGuildMasterNotificationsTitle.TabIndex = 8;
            this.lblHomeGuildMasterNotificationsTitle.Text = "Notifications :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "NomDeGuilde";
            // 
            // frmHomePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1221, 794);
            this.Controls.Add(this.lblkHomeGuildMasterNotifications);
            this.Controls.Add(this.lblkHomeGuildMasterProfil);
            this.Controls.Add(this.lblHomeGuildMasterNotificationsTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcHomeGuildMasterInfomations);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmHomePlayer";
            this.Text = "frmPlayerHome";
            this.tcHomeGuildMasterInfomations.ResumeLayout(false);
            this.tpHomeGuildMembers.ResumeLayout(false);
            this.tpHomeGuildMembers.PerformLayout();
            this.gbHomeGuildMasterGuildMembersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeGuildMasterMembersList)).EndInit();
            this.tpHomeGuildRaid.ResumeLayout(false);
            this.tpHomeGuildRaid.PerformLayout();
            this.gbHomeGuildMasterRaidList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeGuildMasterRaidList)).EndInit();
            this.tpComposants.ResumeLayout(false);
            this.tpComposants.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcHomeGuildMasterInfomations;
        private System.Windows.Forms.TabPage tpHomeGuildMembers;
        private System.Windows.Forms.Label lblHomeGuildMasterMembersTitle;
        private System.Windows.Forms.GroupBox gbHomeGuildMasterGuildMembersList;
        private System.Windows.Forms.DataGridView dgvHomeGuildMasterMembersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.TabPage tpHomeGuildRaid;
        private System.Windows.Forms.Label lblHomeGuildMasterRaids;
        private System.Windows.Forms.GroupBox gbHomeGuildMasterRaidList;
        private System.Windows.Forms.MonthCalendar mcHomeGuildMasterRaidCalendar;
        private System.Windows.Forms.DataGridView dgvHomeGuildMasterRaidList;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidName;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidinvites;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidRoster;
        private System.Windows.Forms.DataGridViewButtonColumn raidDetails;
        private System.Windows.Forms.Label lblHomeRaidList;
        private System.Windows.Forms.TabPage tpComposants;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHomeGuildMasterComponentDemand;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerDemandComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerDemandQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn PlayerDemandDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponantPlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn ComponentContribution;
        private System.Windows.Forms.LinkLabel lblkHomeGuildMasterNotifications;
        private System.Windows.Forms.LinkLabel lblkHomeGuildMasterProfil;
        private System.Windows.Forms.Label lblHomeGuildMasterNotificationsTitle;
        private System.Windows.Forms.Label label1;
    }
}