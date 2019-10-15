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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tpRoster = new System.Windows.Forms.TabPage();
            this.lblHomeGuildMasterRaidInvitations = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblHomeGuildMasterRaidDetails = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidDateTitle = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidDate = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidParticipantsTitle = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidParticipantsNumber = new System.Windows.Forms.Label();
            this.Roster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rôle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tcHomeGuildInfomations.SuspendLayout();
            this.tpHomeGuildRaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tcHomeGuildInfomations.Size = new System.Drawing.Size(1181, 642);
            this.tcHomeGuildInfomations.TabIndex = 0;
            // 
            // tpHomeGuildMembers
            // 
            this.tpHomeGuildMembers.Location = new System.Drawing.Point(4, 25);
            this.tpHomeGuildMembers.Name = "tpHomeGuildMembers";
            this.tpHomeGuildMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomeGuildMembers.Size = new System.Drawing.Size(1173, 613);
            this.tpHomeGuildMembers.TabIndex = 0;
            this.tpHomeGuildMembers.Text = "Membres";
            this.tpHomeGuildMembers.UseVisualStyleBackColor = true;
            // 
            // tpHomeGuildEvents
            // 
            this.tpHomeGuildEvents.Location = new System.Drawing.Point(4, 25);
            this.tpHomeGuildEvents.Name = "tpHomeGuildEvents";
            this.tpHomeGuildEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomeGuildEvents.Size = new System.Drawing.Size(1173, 613);
            this.tpHomeGuildEvents.TabIndex = 2;
            this.tpHomeGuildEvents.Text = "Evénements";
            this.tpHomeGuildEvents.UseVisualStyleBackColor = true;
            // 
            // tpHomeGuildRaid
            // 
            this.tpHomeGuildRaid.Controls.Add(this.label7);
            this.tpHomeGuildRaid.Controls.Add(this.label6);
            this.tpHomeGuildRaid.Controls.Add(this.label3);
            this.tpHomeGuildRaid.Controls.Add(this.label5);
            this.tpHomeGuildRaid.Controls.Add(this.label4);
            this.tpHomeGuildRaid.Controls.Add(this.fd);
            this.tpHomeGuildRaid.Controls.Add(this.label2);
            this.tpHomeGuildRaid.Controls.Add(this.label1);
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeGuildMasterRaidParticipantsNumber);
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeGuildMasterRaidParticipantsTitle);
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeGuildMasterRaidDate);
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeGuildMasterRaidDateTitle);
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeGuildMasterRaidDetails);
            this.tpHomeGuildRaid.Controls.Add(this.dataGridView2);
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeGuildMasterRaidInvitations);
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeRaidList);
            this.tpHomeGuildRaid.Controls.Add(this.lblHomeRaidDateSelection);
            this.tpHomeGuildRaid.Controls.Add(this.dataGridView1);
            this.tpHomeGuildRaid.Controls.Add(this.monthCalendar1);
            this.tpHomeGuildRaid.Location = new System.Drawing.Point(4, 25);
            this.tpHomeGuildRaid.Name = "tpHomeGuildRaid";
            this.tpHomeGuildRaid.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomeGuildRaid.Size = new System.Drawing.Size(1173, 613);
            this.tpHomeGuildRaid.TabIndex = 3;
            this.tpHomeGuildRaid.Text = "Raids";
            this.tpHomeGuildRaid.UseVisualStyleBackColor = true;
            // 
            // lblHomeRaidList
            // 
            this.lblHomeRaidList.AutoSize = true;
            this.lblHomeRaidList.Location = new System.Drawing.Point(41, 298);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 202);
            this.dataGridView1.TabIndex = 1;
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
            this.tpRoster.Size = new System.Drawing.Size(1173, 613);
            this.tpRoster.TabIndex = 4;
            this.tpRoster.Text = "Roster";
            this.tpRoster.UseVisualStyleBackColor = true;
            // 
            // lblHomeGuildMasterRaidInvitations
            // 
            this.lblHomeGuildMasterRaidInvitations.AutoSize = true;
            this.lblHomeGuildMasterRaidInvitations.Location = new System.Drawing.Point(566, 210);
            this.lblHomeGuildMasterRaidInvitations.Name = "lblHomeGuildMasterRaidInvitations";
            this.lblHomeGuildMasterRaidInvitations.Size = new System.Drawing.Size(109, 17);
            this.lblHomeGuildMasterRaidInvitations.TabIndex = 4;
            this.lblHomeGuildMasterRaidInvitations.Text = "Liste des invités";
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
            this.dataGridView2.Location = new System.Drawing.Point(569, 230);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(530, 343);
            this.dataGridView2.TabIndex = 5;
            // 
            // lblHomeGuildMasterRaidDetails
            // 
            this.lblHomeGuildMasterRaidDetails.AutoSize = true;
            this.lblHomeGuildMasterRaidDetails.Location = new System.Drawing.Point(566, 23);
            this.lblHomeGuildMasterRaidDetails.Name = "lblHomeGuildMasterRaidDetails";
            this.lblHomeGuildMasterRaidDetails.Size = new System.Drawing.Size(133, 17);
            this.lblHomeGuildMasterRaidDetails.TabIndex = 6;
            this.lblHomeGuildMasterRaidDetails.Text = "Informations du raid";
            // 
            // lblHomeGuildMasterRaidDateTitle
            // 
            this.lblHomeGuildMasterRaidDateTitle.AutoSize = true;
            this.lblHomeGuildMasterRaidDateTitle.Location = new System.Drawing.Point(581, 52);
            this.lblHomeGuildMasterRaidDateTitle.Name = "lblHomeGuildMasterRaidDateTitle";
            this.lblHomeGuildMasterRaidDateTitle.Size = new System.Drawing.Size(94, 17);
            this.lblHomeGuildMasterRaidDateTitle.TabIndex = 7;
            this.lblHomeGuildMasterRaidDateTitle.Text = "Date du raid :";
            // 
            // lblHomeGuildMasterRaidDate
            // 
            this.lblHomeGuildMasterRaidDate.AutoSize = true;
            this.lblHomeGuildMasterRaidDate.Location = new System.Drawing.Point(681, 52);
            this.lblHomeGuildMasterRaidDate.Name = "lblHomeGuildMasterRaidDate";
            this.lblHomeGuildMasterRaidDate.Size = new System.Drawing.Size(82, 17);
            this.lblHomeGuildMasterRaidDate.TabIndex = 8;
            this.lblHomeGuildMasterRaidDate.Text = "dd.mm.yyyy";
            // 
            // lblHomeGuildMasterRaidParticipantsTitle
            // 
            this.lblHomeGuildMasterRaidParticipantsTitle.AutoSize = true;
            this.lblHomeGuildMasterRaidParticipantsTitle.Location = new System.Drawing.Point(581, 97);
            this.lblHomeGuildMasterRaidParticipantsTitle.Name = "lblHomeGuildMasterRaidParticipantsTitle";
            this.lblHomeGuildMasterRaidParticipantsTitle.Size = new System.Drawing.Size(90, 17);
            this.lblHomeGuildMasterRaidParticipantsTitle.TabIndex = 9;
            this.lblHomeGuildMasterRaidParticipantsTitle.Text = "Participants :";
            // 
            // lblHomeGuildMasterRaidParticipantsNumber
            // 
            this.lblHomeGuildMasterRaidParticipantsNumber.AutoSize = true;
            this.lblHomeGuildMasterRaidParticipantsNumber.Location = new System.Drawing.Point(785, 82);
            this.lblHomeGuildMasterRaidParticipantsNumber.Name = "lblHomeGuildMasterRaidParticipantsNumber";
            this.lblHomeGuildMasterRaidParticipantsNumber.Size = new System.Drawing.Size(0, 17);
            this.lblHomeGuildMasterRaidParticipantsNumber.TabIndex = 10;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Invités : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "En attente :";
            // 
            // fd
            // 
            this.fd.AutoSize = true;
            this.fd.Location = new System.Drawing.Point(581, 150);
            this.fd.Name = "fd";
            this.fd.Size = new System.Drawing.Size(45, 17);
            this.fd.TabIndex = 13;
            this.fd.Text = "TANK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "HEAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "DPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "0/2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "0/4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "0/14";
            // 
            // frmHomeGuildMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 646);
            this.Controls.Add(this.tcHomeGuildInfomations);
            this.Name = "frmHomeGuildMaster";
            this.Text = "Tableau de bord du Maître de guilde";
            this.tcHomeGuildInfomations.ResumeLayout(false);
            this.tpHomeGuildRaid.ResumeLayout(false);
            this.tpHomeGuildRaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcHomeGuildInfomations;
        private System.Windows.Forms.TabPage tpHomeGuildMembers;
        private System.Windows.Forms.TabPage tpHomeGuildEvents;
        private System.Windows.Forms.TabPage tpHomeGuildRaid;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblHomeRaidList;
        private System.Windows.Forms.Label lblHomeRaidDateSelection;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblHomeGuildMasterRaidInvitations;
        private System.Windows.Forms.TabPage tpRoster;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Roster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rôle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}