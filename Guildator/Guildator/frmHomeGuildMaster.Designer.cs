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
            this.tpComposants = new System.Windows.Forms.TabPage();
            this.tpHomeGuildRaid = new System.Windows.Forms.TabPage();
            this.lblHomeRaidList = new System.Windows.Forms.Label();
            this.dgvRaidList = new System.Windows.Forms.DataGridView();
            this.raidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidinvites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidRoster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidParticipants = new System.Windows.Forms.DataGridViewButtonColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tpHomeGuildMembers = new System.Windows.Forms.TabPage();
            this.gbHomeGuildMasterGuildDemands = new System.Windows.Forms.GroupBox();
            this.gbHomeGuildMasterGuildMembersList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tcHomeGuildMasterInfomations = new System.Windows.Forms.TabControl();
            this.gbHomeGuildMasterRaidList = new System.Windows.Forms.GroupBox();
            this.gbHomeGuildMasterRosterList = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnHomeGuildMasterAddRoster = new System.Windows.Forms.Button();
            this.btnHomeGuildMasterAddRaid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tpHomeGuildRaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaidList)).BeginInit();
            this.tpHomeGuildMembers.SuspendLayout();
            this.gbHomeGuildMasterGuildMembersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tcHomeGuildMasterInfomations.SuspendLayout();
            this.gbHomeGuildMasterRaidList.SuspendLayout();
            this.gbHomeGuildMasterRosterList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpComposants
            // 
            this.tpComposants.Location = new System.Drawing.Point(4, 40);
            this.tpComposants.Name = "tpComposants";
            this.tpComposants.Padding = new System.Windows.Forms.Padding(3);
            this.tpComposants.Size = new System.Drawing.Size(1160, 697);
            this.tpComposants.TabIndex = 4;
            this.tpComposants.Text = "Composants";
            this.tpComposants.UseVisualStyleBackColor = true;
            // 
            // tpHomeGuildRaid
            // 
            this.tpHomeGuildRaid.Controls.Add(this.gbHomeGuildMasterRosterList);
            this.tpHomeGuildRaid.Controls.Add(this.gbHomeGuildMasterRaidList);
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeRaidList);
            this.tpHomeGuildRaid.Location = new System.Drawing.Point(4, 40);
            this.tpHomeGuildRaid.Name = "tpHomeGuildRaid";
            this.tpHomeGuildRaid.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomeGuildRaid.Size = new System.Drawing.Size(1160, 697);
            this.tpHomeGuildRaid.TabIndex = 3;
            this.tpHomeGuildRaid.Text = "Raids";
            this.tpHomeGuildRaid.UseVisualStyleBackColor = true;
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
            // dgvRaidList
            // 
            this.dgvRaidList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaidList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raidName,
            this.raidinvites,
            this.raidRoster,
            this.raidParticipants});
            this.dgvRaidList.Location = new System.Drawing.Point(6, 253);
            this.dgvRaidList.Name = "dgvRaidList";
            this.dgvRaidList.RowHeadersWidth = 51;
            this.dgvRaidList.RowTemplate.Height = 24;
            this.dgvRaidList.Size = new System.Drawing.Size(549, 226);
            this.dgvRaidList.TabIndex = 1;
            this.dgvRaidList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(12, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tpHomeGuildMembers
            // 
            this.tpHomeGuildMembers.Controls.Add(this.gbHomeGuildMasterGuildDemands);
            this.tpHomeGuildMembers.Controls.Add(this.gbHomeGuildMasterGuildMembersList);
            this.tpHomeGuildMembers.Location = new System.Drawing.Point(4, 40);
            this.tpHomeGuildMembers.Name = "tpHomeGuildMembers";
            this.tpHomeGuildMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomeGuildMembers.Size = new System.Drawing.Size(1160, 697);
            this.tpHomeGuildMembers.TabIndex = 0;
            this.tpHomeGuildMembers.Text = "Membres";
            this.tpHomeGuildMembers.UseVisualStyleBackColor = true;
            // 
            // gbHomeGuildMasterGuildDemands
            // 
            this.gbHomeGuildMasterGuildDemands.Location = new System.Drawing.Point(639, 7);
            this.gbHomeGuildMasterGuildDemands.Name = "gbHomeGuildMasterGuildDemands";
            this.gbHomeGuildMasterGuildDemands.Size = new System.Drawing.Size(500, 600);
            this.gbHomeGuildMasterGuildDemands.TabIndex = 1;
            this.gbHomeGuildMasterGuildDemands.TabStop = false;
            this.gbHomeGuildMasterGuildDemands.Text = "Demandes de recrutement";
            // 
            // gbHomeGuildMasterGuildMembersList
            // 
            this.gbHomeGuildMasterGuildMembersList.Controls.Add(this.dataGridView1);
            this.gbHomeGuildMasterGuildMembersList.Location = new System.Drawing.Point(16, 6);
            this.gbHomeGuildMasterGuildMembersList.Name = "gbHomeGuildMasterGuildMembersList";
            this.gbHomeGuildMasterGuildMembersList.Size = new System.Drawing.Size(593, 601);
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
            this.dataGridView1.Size = new System.Drawing.Size(571, 501);
            this.dataGridView1.TabIndex = 0;
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
            // playerDetails
            // 
            this.playerDetails.HeaderText = "Détails";
            this.playerDetails.MinimumWidth = 6;
            this.playerDetails.Name = "playerDetails";
            this.playerDetails.Width = 70;
            // 
            // tcHomeGuildMasterInfomations
            // 
            this.tcHomeGuildMasterInfomations.AccessibleName = "";
            this.tcHomeGuildMasterInfomations.Controls.Add(this.tpHomeGuildMembers);
            this.tcHomeGuildMasterInfomations.Controls.Add(this.tpHomeGuildRaid);
            this.tcHomeGuildMasterInfomations.Controls.Add(this.tpComposants);
            this.tcHomeGuildMasterInfomations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcHomeGuildMasterInfomations.Location = new System.Drawing.Point(12, 18);
            this.tcHomeGuildMasterInfomations.Name = "tcHomeGuildMasterInfomations";
            this.tcHomeGuildMasterInfomations.SelectedIndex = 0;
            this.tcHomeGuildMasterInfomations.Size = new System.Drawing.Size(1168, 741);
            this.tcHomeGuildMasterInfomations.TabIndex = 0;
            // 
            // gbHomeGuildMasterRaidList
            // 
            this.gbHomeGuildMasterRaidList.Controls.Add(this.groupBox1);
            this.gbHomeGuildMasterRaidList.Controls.Add(this.monthCalendar1);
            this.gbHomeGuildMasterRaidList.Controls.Add(this.dgvRaidList);
            this.gbHomeGuildMasterRaidList.Location = new System.Drawing.Point(12, 6);
            this.gbHomeGuildMasterRaidList.Name = "gbHomeGuildMasterRaidList";
            this.gbHomeGuildMasterRaidList.Size = new System.Drawing.Size(561, 676);
            this.gbHomeGuildMasterRaidList.TabIndex = 4;
            this.gbHomeGuildMasterRaidList.TabStop = false;
            this.gbHomeGuildMasterRaidList.Text = "Liste des raids";
            // 
            // gbHomeGuildMasterRosterList
            // 
            this.gbHomeGuildMasterRosterList.Controls.Add(this.groupBox2);
            this.gbHomeGuildMasterRosterList.Controls.Add(this.dataGridView2);
            this.gbHomeGuildMasterRosterList.Location = new System.Drawing.Point(597, 6);
            this.gbHomeGuildMasterRosterList.Name = "gbHomeGuildMasterRosterList";
            this.gbHomeGuildMasterRosterList.Size = new System.Drawing.Size(542, 676);
            this.gbHomeGuildMasterRosterList.TabIndex = 5;
            this.gbHomeGuildMasterRosterList.TabStop = false;
            this.gbHomeGuildMasterRosterList.Text = "Liste des Rosters";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(480, 205);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnHomeGuildMasterAddRoster
            // 
            this.btnHomeGuildMasterAddRoster.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeGuildMasterAddRoster.Location = new System.Drawing.Point(425, 329);
            this.btnHomeGuildMasterAddRoster.Name = "btnHomeGuildMasterAddRoster";
            this.btnHomeGuildMasterAddRoster.Size = new System.Drawing.Size(99, 37);
            this.btnHomeGuildMasterAddRoster.TabIndex = 1;
            this.btnHomeGuildMasterAddRoster.Text = "Ajouter";
            this.btnHomeGuildMasterAddRoster.UseVisualStyleBackColor = true;
            // 
            // btnHomeGuildMasterAddRaid
            // 
            this.btnHomeGuildMasterAddRaid.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeGuildMasterAddRaid.Location = new System.Drawing.Point(439, 144);
            this.btnHomeGuildMasterAddRaid.Name = "btnHomeGuildMasterAddRaid";
            this.btnHomeGuildMasterAddRaid.Size = new System.Drawing.Size(104, 35);
            this.btnHomeGuildMasterAddRaid.TabIndex = 2;
            this.btnHomeGuildMasterAddRaid.Text = "Ajouter";
            this.btnHomeGuildMasterAddRaid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "NomDeGuilde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(984, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Notifications :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1136, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(24, 26);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnHomeGuildMasterAddRaid);
            this.groupBox1.Location = new System.Drawing.Point(6, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un raid";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "Sélectionnez un raid",
            "Onyxia",
            "Coeur du Magma",
            "Repaire de l\'Aile Noire"});
            this.listBox1.Location = new System.Drawing.Point(18, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 28);
            this.listBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHomeGuildMasterAddRoster);
            this.groupBox2.Location = new System.Drawing.Point(6, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 372);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Composer un Roster";
            // 
            // frmHomeGuildMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1222, 766);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcHomeGuildMasterInfomations);
            this.Name = "frmHomeGuildMaster";
            this.Text = "Tableau de bord du Maître de guilde";
            this.tpHomeGuildRaid.ResumeLayout(false);
            this.tpHomeGuildRaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaidList)).EndInit();
            this.tpHomeGuildMembers.ResumeLayout(false);
            this.gbHomeGuildMasterGuildMembersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tcHomeGuildMasterInfomations.ResumeLayout(false);
            this.gbHomeGuildMasterRaidList.ResumeLayout(false);
            this.gbHomeGuildMasterRosterList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tpComposants;
        private System.Windows.Forms.TabPage tpHomeGuildRaid;
        private System.Windows.Forms.Label lblHomeRaidList;
        private System.Windows.Forms.DataGridView dgvRaidList;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidName;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidinvites;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidRoster;
        private System.Windows.Forms.DataGridViewButtonColumn raidParticipants;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tpHomeGuildMembers;
        private System.Windows.Forms.GroupBox gbHomeGuildMasterGuildDemands;
        private System.Windows.Forms.GroupBox gbHomeGuildMasterGuildMembersList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tcHomeGuildMasterInfomations;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerGrade;
        private System.Windows.Forms.DataGridViewButtonColumn playerDetails;
        private System.Windows.Forms.GroupBox gbHomeGuildMasterRosterList;
        private System.Windows.Forms.GroupBox gbHomeGuildMasterRaidList;
        private System.Windows.Forms.Button btnHomeGuildMasterAddRoster;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHomeGuildMasterAddRaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}