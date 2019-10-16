namespace Guildator
{
    partial class frmHomeGuildMaster
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
            this.tcHomeGuildInfomations = new System.Windows.Forms.TabControl();
            this.tpHomeGuildMembers = new System.Windows.Forms.TabPage();
            this.tpHomeGuildEvents = new System.Windows.Forms.TabPage();
            this.tpHomeGuildRaid = new System.Windows.Forms.TabPage();
            this.lblHomeRaidList = new System.Windows.Forms.Label();
            this.lblHomeRaidDateSelection = new System.Windows.Forms.Label();
            this.dgvRaidList = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tpRoster = new System.Windows.Forms.TabPage();
            this.raidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidinvites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidRoster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidParticipants = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbHomeGuildMasterGuildMembersList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbHomeGuildMasterGuildDemands = new System.Windows.Forms.GroupBox();
            this.tcHomeGuildInfomations.SuspendLayout();
            this.tpHomeGuildMembers.SuspendLayout();
            this.tpHomeGuildRaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaidList)).BeginInit();
            this.gbHomeGuildMasterGuildMembersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcHomeGuildInfomations
            // 
            this.tcHomeGuildInfomations.AccessibleName = "";
            this.tcHomeGuildInfomations.Controls.Add(this.tpHomeGuildMembers);
            this.tcHomeGuildInfomations.Controls.Add(this.tpHomeGuildEvents);
            this.tcHomeGuildInfomations.Controls.Add(this.tpHomeGuildRaid);
            this.tcHomeGuildInfomations.Controls.Add(this.tpRoster);
            this.tcHomeGuildInfomations.Location = new System.Drawing.Point(2, 0);
            this.tcHomeGuildInfomations.Name = "tcHomeGuildInfomations";
            this.tcHomeGuildInfomations.SelectedIndex = 0;
            this.tcHomeGuildInfomations.Size = new System.Drawing.Size(754, 642);
            this.tcHomeGuildInfomations.TabIndex = 0;
            // 
            // tpHomeGuildMembers
            // 
            this.tpHomeGuildMembers.Controls.Add(this.gbHomeGuildMasterGuildDemands);
            this.tpHomeGuildMembers.Controls.Add(this.gbHomeGuildMasterGuildMembersList);
            this.tpHomeGuildMembers.Location = new System.Drawing.Point(4, 25);
            this.tpHomeGuildMembers.Name = "tpHomeGuildMembers";
            this.tpHomeGuildMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomeGuildMembers.Size = new System.Drawing.Size(746, 613);
            this.tpHomeGuildMembers.TabIndex = 0;
            this.tpHomeGuildMembers.Text = "Membres";
            this.tpHomeGuildMembers.UseVisualStyleBackColor = true;
            // 
            // tpHomeGuildEvents
            // 
            this.tpHomeGuildEvents.Location = new System.Drawing.Point(4, 25);
            this.tpHomeGuildEvents.Name = "tpHomeGuildEvents";
            this.tpHomeGuildEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomeGuildEvents.Size = new System.Drawing.Size(746, 613);
            this.tpHomeGuildEvents.TabIndex = 2;
            this.tpHomeGuildEvents.Text = "Evénements";
            this.tpHomeGuildEvents.UseVisualStyleBackColor = true;
            // 
            // tpHomeGuildRaid
            // 
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeRaidList);
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeRaidDateSelection);
            this.tpHomeGuildRaid.Controls.Add(this.dgvRaidList);
            this.tpHomeGuildRaid.Controls.Add(this.monthCalendar1);
            this.tpHomeGuildRaid.Location = new System.Drawing.Point(4, 25);
            this.tpHomeGuildRaid.Name = "tpHomeGuildRaid";
            this.tpHomeGuildRaid.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomeGuildRaid.Size = new System.Drawing.Size(746, 613);
            this.tpHomeGuildRaid.TabIndex = 3;
            this.tpHomeGuildRaid.Text = "Raids";
            this.tpHomeGuildRaid.UseVisualStyleBackColor = true;
            // 
            // lblHomeRaidList
            // 
            this.lblHomeRaidList.AutoSize = true;
            this.lblHomeRaidList.Location = new System.Drawing.Point(9, 298);
            this.lblHomeRaidList.Name = "lblHomeRaidList";
            this.lblHomeRaidList.Size = new System.Drawing.Size(100, 17);
            this.lblHomeRaidList.TabIndex = 3;
            this.lblHomeRaidList.Text = "Liste des raids";
            // 
            // lblHomeRaidDateSelection
            // 
            this.lblHomeRaidDateSelection.AutoSize = true;
            this.lblHomeRaidDateSelection.Location = new System.Drawing.Point(9, 23);
            this.lblHomeRaidDateSelection.Name = "lblHomeRaidDateSelection";
            this.lblHomeRaidDateSelection.Size = new System.Drawing.Size(335, 17);
            this.lblHomeRaidDateSelection.TabIndex = 2;
            this.lblHomeRaidDateSelection.Text = "Sélectionner une date pour afficher les raids prévus";
            // 
            // dgvRaidList
            // 
            this.dgvRaidList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaidList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raidName,
            this.raidinvites,
            this.raidRoster,
            this.raidParticipants});
            this.dgvRaidList.Location = new System.Drawing.Point(12, 318);
            this.dgvRaidList.Name = "dgvRaidList";
            this.dgvRaidList.RowHeadersWidth = 51;
            this.dgvRaidList.RowTemplate.Height = 24;
            this.dgvRaidList.Size = new System.Drawing.Size(528, 255);
            this.dgvRaidList.TabIndex = 1;
            this.dgvRaidList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(12, 62);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tpRoster
            // 
            this.tpRoster.Location = new System.Drawing.Point(4, 25);
            this.tpRoster.Name = "tpRoster";
            this.tpRoster.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoster.Size = new System.Drawing.Size(746, 613);
            this.tpRoster.TabIndex = 4;
            this.tpRoster.Text = "Roster";
            this.tpRoster.UseVisualStyleBackColor = true;
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
            // raidParticipants
            // 
            this.raidParticipants.HeaderText = "Participants";
            this.raidParticipants.MinimumWidth = 6;
            this.raidParticipants.Name = "raidParticipants";
            this.raidParticipants.Width = 125;
            // 
            // gbHomeGuildMasterGuildMembersList
            // 
            this.gbHomeGuildMasterGuildMembersList.Controls.Add(this.dataGridView1);
            this.gbHomeGuildMasterGuildMembersList.Location = new System.Drawing.Point(16, 6);
            this.gbHomeGuildMasterGuildMembersList.Name = "gbHomeGuildMasterGuildMembersList";
            this.gbHomeGuildMasterGuildMembersList.Size = new System.Drawing.Size(331, 601);
            this.gbHomeGuildMasterGuildMembersList.TabIndex = 0;
            this.gbHomeGuildMasterGuildMembersList.TabStop = false;
            this.gbHomeGuildMasterGuildMembersList.Text = "Liste des membres";
            this.gbHomeGuildMasterGuildMembersList.Enter += new System.EventHandler(this.gbHomeGuildMasterGuildMembersList_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerName,
            this.playerGrade,
            this.playerDetails});
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(310, 501);
            this.dataGridView1.TabIndex = 0;
            // 
            // playerName
            // 
            this.playerName.HeaderText = "Nom";
            this.playerName.MinimumWidth = 6;
            this.playerName.Name = "playerName";
            // 
            // playerGrade
            // 
            this.playerGrade.HeaderText = "Grade";
            this.playerGrade.MinimumWidth = 6;
            this.playerGrade.Name = "playerGrade";
            // 
            // playerDetails
            // 
            this.playerDetails.HeaderText = "Détails";
            this.playerDetails.MinimumWidth = 6;
            this.playerDetails.Name = "playerDetails";
            this.playerDetails.Width = 50;
            // 
            // gbHomeGuildMasterGuildDemands
            // 
            this.gbHomeGuildMasterGuildDemands.Location = new System.Drawing.Point(362, 7);
            this.gbHomeGuildMasterGuildDemands.Name = "gbHomeGuildMasterGuildDemands";
            this.gbHomeGuildMasterGuildDemands.Size = new System.Drawing.Size(369, 600);
            this.gbHomeGuildMasterGuildDemands.TabIndex = 1;
            this.gbHomeGuildMasterGuildDemands.TabStop = false;
            this.gbHomeGuildMasterGuildDemands.Text = "Demandes de recrutement";
            // 
            // frmHomeGuildMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 646);
            this.Controls.Add(this.tcHomeGuildInfomations);
            this.Name = "frmHomeGuildMaster";
            this.Text = "Tableau de bord du Maître de guilde";
            this.tcHomeGuildInfomations.ResumeLayout(false);
            this.tpHomeGuildMembers.ResumeLayout(false);
            this.tpHomeGuildRaid.ResumeLayout(false);
            this.tpHomeGuildRaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaidList)).EndInit();
            this.gbHomeGuildMasterGuildMembersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcHomeGuildInfomations;
        private System.Windows.Forms.TabPage tpHomeGuildMembers;
        private System.Windows.Forms.TabPage tpHomeGuildEvents;
        private System.Windows.Forms.TabPage tpHomeGuildRaid;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgvRaidList;
        private System.Windows.Forms.Label lblHomeRaidList;
        private System.Windows.Forms.Label lblHomeRaidDateSelection;
        private System.Windows.Forms.TabPage tpRoster;
        private System.Windows.Forms.GroupBox gbHomeGuildMasterGuildMembersList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidName;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidinvites;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidRoster;
        private System.Windows.Forms.DataGridViewButtonColumn raidParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerGrade;
        private System.Windows.Forms.DataGridViewButtonColumn playerDetails;
        private System.Windows.Forms.GroupBox gbHomeGuildMasterGuildDemands;
    }
}