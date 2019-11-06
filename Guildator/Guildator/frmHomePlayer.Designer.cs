namespace Guildator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePlayer));
            this.tcHomePlayerInfomations = new System.Windows.Forms.TabControl();
            this.tpHomePlayerMembers = new System.Windows.Forms.TabPage();
            this.lblHomePlayerMembersTitle = new System.Windows.Forms.Label();
            this.gbHomePlayerGuildMembersList = new System.Windows.Forms.GroupBox();
            this.dgvHomePlayerMembersList = new System.Windows.Forms.DataGridView();
            this.tpHomePlayerRaid = new System.Windows.Forms.TabPage();
            this.lblHomePlayerRaidsTitle = new System.Windows.Forms.Label();
            this.gbHomePlayerRaidList = new System.Windows.Forms.GroupBox();
            this.mcHomePlayerRaidCalendar = new System.Windows.Forms.MonthCalendar();
            this.dgvHomePlayerRaidList = new System.Windows.Forms.DataGridView();
            this.lblHomeRaidList = new System.Windows.Forms.Label();
            this.tpHomePlayerComposants = new System.Windows.Forms.TabPage();
            this.lblHomePlayerComponentDemandsTitle = new System.Windows.Forms.Label();
            this.gbHomePlayerMyComponentDemandsInformations = new System.Windows.Forms.GroupBox();
            this.btnHomePlayerComponentDemand = new System.Windows.Forms.Button();
            this.dgvHomePlayerMyComponentDemandsList = new System.Windows.Forms.DataGridView();
            this.PlayerDemandComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerDemandQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerDemandDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbHomePlayerAllComponentDemandsInformations = new System.Windows.Forms.GroupBox();
            this.dgvHomePlayerAllComponentDemandsList = new System.Windows.Forms.DataGridView();
            this.ComponantPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentContribution = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblkHomePlayerNotifications = new System.Windows.Forms.LinkLabel();
            this.lblkHomePlayerProfil = new System.Windows.Forms.LinkLabel();
            this.lblHomePlayerNotificationsTitle = new System.Windows.Forms.Label();
            this.lblHomePlayerGuildNameTitle = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidinvites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raidRoster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcHomePlayerInfomations.SuspendLayout();
            this.tpHomePlayerMembers.SuspendLayout();
            this.gbHomePlayerGuildMembersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayerMembersList)).BeginInit();
            this.tpHomePlayerRaid.SuspendLayout();
            this.gbHomePlayerRaidList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayerRaidList)).BeginInit();
            this.tpHomePlayerComposants.SuspendLayout();
            this.gbHomePlayerMyComponentDemandsInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayerMyComponentDemandsList)).BeginInit();
            this.gbHomePlayerAllComponentDemandsInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayerAllComponentDemandsList)).BeginInit();
            this.SuspendLayout();
            // 
            // tcHomePlayerInfomations
            // 
            this.tcHomePlayerInfomations.AccessibleName = "";
            this.tcHomePlayerInfomations.Controls.Add(this.tpHomePlayerMembers);
            this.tcHomePlayerInfomations.Controls.Add(this.tpHomePlayerRaid);
            this.tcHomePlayerInfomations.Controls.Add(this.tpHomePlayerComposants);
            this.tcHomePlayerInfomations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcHomePlayerInfomations.Location = new System.Drawing.Point(12, 24);
            this.tcHomePlayerInfomations.Name = "tcHomePlayerInfomations";
            this.tcHomePlayerInfomations.SelectedIndex = 0;
            this.tcHomePlayerInfomations.Size = new System.Drawing.Size(1168, 775);
            this.tcHomePlayerInfomations.TabIndex = 1;
            // 
            // tpHomePlayerMembers
            // 
            this.tpHomePlayerMembers.Controls.Add(this.lblHomePlayerMembersTitle);
            this.tpHomePlayerMembers.Controls.Add(this.gbHomePlayerGuildMembersList);
            this.tpHomePlayerMembers.Location = new System.Drawing.Point(4, 40);
            this.tpHomePlayerMembers.Name = "tpHomePlayerMembers";
            this.tpHomePlayerMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomePlayerMembers.Size = new System.Drawing.Size(1160, 731);
            this.tpHomePlayerMembers.TabIndex = 0;
            this.tpHomePlayerMembers.Text = "Membres";
            this.tpHomePlayerMembers.UseVisualStyleBackColor = true;
            // 
            // lblHomePlayerMembersTitle
            // 
            this.lblHomePlayerMembersTitle.AutoSize = true;
            this.lblHomePlayerMembersTitle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePlayerMembersTitle.Location = new System.Drawing.Point(428, 15);
            this.lblHomePlayerMembersTitle.Name = "lblHomePlayerMembersTitle";
            this.lblHomePlayerMembersTitle.Size = new System.Drawing.Size(274, 39);
            this.lblHomePlayerMembersTitle.TabIndex = 2;
            this.lblHomePlayerMembersTitle.Text = "Membres de guilde";
            // 
            // gbHomePlayerGuildMembersList
            // 
            this.gbHomePlayerGuildMembersList.Controls.Add(this.dgvHomePlayerMembersList);
            this.gbHomePlayerGuildMembersList.Location = new System.Drawing.Point(15, 57);
            this.gbHomePlayerGuildMembersList.Name = "gbHomePlayerGuildMembersList";
            this.gbHomePlayerGuildMembersList.Size = new System.Drawing.Size(1125, 646);
            this.gbHomePlayerGuildMembersList.TabIndex = 0;
            this.gbHomePlayerGuildMembersList.TabStop = false;
            this.gbHomePlayerGuildMembersList.Text = "Liste des membres";
            // 
            // dgvHomePlayerMembersList
            // 
            this.dgvHomePlayerMembersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomePlayerMembersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.Column2,
            this.dataGridViewTextBoxColumn3});
            this.dgvHomePlayerMembersList.Location = new System.Drawing.Point(246, 66);
            this.dgvHomePlayerMembersList.Name = "dgvHomePlayerMembersList";
            this.dgvHomePlayerMembersList.RowHeadersVisible = false;
            this.dgvHomePlayerMembersList.RowHeadersWidth = 51;
            this.dgvHomePlayerMembersList.RowTemplate.Height = 24;
            this.dgvHomePlayerMembersList.Size = new System.Drawing.Size(641, 527);
            this.dgvHomePlayerMembersList.TabIndex = 1;
            // 
            // tpHomePlayerRaid
            // 
            this.tpHomePlayerRaid.Controls.Add(this.lblHomePlayerRaidsTitle);
            this.tpHomePlayerRaid.Controls.Add(this.gbHomePlayerRaidList);
            this.tpHomePlayerRaid.Controls.Add(this.lblHomeRaidList);
            this.tpHomePlayerRaid.Location = new System.Drawing.Point(4, 40);
            this.tpHomePlayerRaid.Name = "tpHomePlayerRaid";
            this.tpHomePlayerRaid.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomePlayerRaid.Size = new System.Drawing.Size(1160, 731);
            this.tpHomePlayerRaid.TabIndex = 3;
            this.tpHomePlayerRaid.Text = "Raids";
            this.tpHomePlayerRaid.UseVisualStyleBackColor = true;
            // 
            // lblHomePlayerRaidsTitle
            // 
            this.lblHomePlayerRaidsTitle.AutoSize = true;
            this.lblHomePlayerRaidsTitle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePlayerRaidsTitle.Location = new System.Drawing.Point(508, 32);
            this.lblHomePlayerRaidsTitle.Name = "lblHomePlayerRaidsTitle";
            this.lblHomePlayerRaidsTitle.Size = new System.Drawing.Size(89, 39);
            this.lblHomePlayerRaidsTitle.TabIndex = 6;
            this.lblHomePlayerRaidsTitle.Text = "Raids";
            // 
            // gbHomePlayerRaidList
            // 
            this.gbHomePlayerRaidList.Controls.Add(this.mcHomePlayerRaidCalendar);
            this.gbHomePlayerRaidList.Controls.Add(this.dgvHomePlayerRaidList);
            this.gbHomePlayerRaidList.Location = new System.Drawing.Point(313, 74);
            this.gbHomePlayerRaidList.Name = "gbHomePlayerRaidList";
            this.gbHomePlayerRaidList.Size = new System.Drawing.Size(561, 614);
            this.gbHomePlayerRaidList.TabIndex = 4;
            this.gbHomePlayerRaidList.TabStop = false;
            this.gbHomePlayerRaidList.Text = "Liste des raids";
            // 
            // mcHomePlayerRaidCalendar
            // 
            this.mcHomePlayerRaidCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.mcHomePlayerRaidCalendar.Location = new System.Drawing.Point(12, 45);
            this.mcHomePlayerRaidCalendar.Name = "mcHomePlayerRaidCalendar";
            this.mcHomePlayerRaidCalendar.TabIndex = 0;
            // 
            // dgvHomePlayerRaidList
            // 
            this.dgvHomePlayerRaidList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomePlayerRaidList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raidName,
            this.raidinvites,
            this.raidRoster});
            this.dgvHomePlayerRaidList.Location = new System.Drawing.Point(79, 266);
            this.dgvHomePlayerRaidList.Name = "dgvHomePlayerRaidList";
            this.dgvHomePlayerRaidList.RowHeadersVisible = false;
            this.dgvHomePlayerRaidList.RowHeadersWidth = 51;
            this.dgvHomePlayerRaidList.RowTemplate.Height = 24;
            this.dgvHomePlayerRaidList.Size = new System.Drawing.Size(419, 318);
            this.dgvHomePlayerRaidList.TabIndex = 1;
            // 
            // lblHomeRaidList
            // 
            this.lblHomeRaidList.AutoSize = true;
            this.lblHomeRaidList.Location = new System.Drawing.Point(310, 304);
            this.lblHomeRaidList.Name = "lblHomeRaidList";
            this.lblHomeRaidList.Size = new System.Drawing.Size(179, 33);
            this.lblHomeRaidList.TabIndex = 3;
            this.lblHomeRaidList.Text = "Liste des raids";
            // 
            // tpHomePlayerComposants
            // 
            this.tpHomePlayerComposants.Controls.Add(this.lblHomePlayerComponentDemandsTitle);
            this.tpHomePlayerComposants.Controls.Add(this.gbHomePlayerMyComponentDemandsInformations);
            this.tpHomePlayerComposants.Controls.Add(this.gbHomePlayerAllComponentDemandsInformations);
            this.tpHomePlayerComposants.Location = new System.Drawing.Point(4, 40);
            this.tpHomePlayerComposants.Name = "tpHomePlayerComposants";
            this.tpHomePlayerComposants.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomePlayerComposants.Size = new System.Drawing.Size(1160, 731);
            this.tpHomePlayerComposants.TabIndex = 4;
            this.tpHomePlayerComposants.Text = "Composants";
            this.tpHomePlayerComposants.UseVisualStyleBackColor = true;
            // 
            // lblHomePlayerComponentDemandsTitle
            // 
            this.lblHomePlayerComponentDemandsTitle.AutoSize = true;
            this.lblHomePlayerComponentDemandsTitle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePlayerComponentDemandsTitle.Location = new System.Drawing.Point(414, 25);
            this.lblHomePlayerComponentDemandsTitle.Name = "lblHomePlayerComponentDemandsTitle";
            this.lblHomePlayerComponentDemandsTitle.Size = new System.Drawing.Size(361, 39);
            this.lblHomePlayerComponentDemandsTitle.TabIndex = 2;
            this.lblHomePlayerComponentDemandsTitle.Text = "Demandes de composants";
            // 
            // gbHomePlayerMyComponentDemandsInformations
            // 
            this.gbHomePlayerMyComponentDemandsInformations.Controls.Add(this.btnHomePlayerComponentDemand);
            this.gbHomePlayerMyComponentDemandsInformations.Controls.Add(this.dgvHomePlayerMyComponentDemandsList);
            this.gbHomePlayerMyComponentDemandsInformations.Location = new System.Drawing.Point(615, 90);
            this.gbHomePlayerMyComponentDemandsInformations.Name = "gbHomePlayerMyComponentDemandsInformations";
            this.gbHomePlayerMyComponentDemandsInformations.Size = new System.Drawing.Size(508, 590);
            this.gbHomePlayerMyComponentDemandsInformations.TabIndex = 1;
            this.gbHomePlayerMyComponentDemandsInformations.TabStop = false;
            this.gbHomePlayerMyComponentDemandsInformations.Text = "Mes demandes";
            // 
            // btnHomePlayerComponentDemand
            // 
            this.btnHomePlayerComponentDemand.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePlayerComponentDemand.Location = new System.Drawing.Point(264, 543);
            this.btnHomePlayerComponentDemand.Name = "btnHomePlayerComponentDemand";
            this.btnHomePlayerComponentDemand.Size = new System.Drawing.Size(217, 41);
            this.btnHomePlayerComponentDemand.TabIndex = 1;
            this.btnHomePlayerComponentDemand.Text = "Demander un composant";
            this.btnHomePlayerComponentDemand.UseVisualStyleBackColor = true;
            this.btnHomePlayerComponentDemand.Click += new System.EventHandler(this.btnHomePlayerComponentDemand_Click);
            // 
            // dgvHomePlayerMyComponentDemandsList
            // 
            this.dgvHomePlayerMyComponentDemandsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomePlayerMyComponentDemandsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerDemandComponent,
            this.PlayerDemandQuantity,
            this.PlayerDemandDetails});
            this.dgvHomePlayerMyComponentDemandsList.Location = new System.Drawing.Point(22, 52);
            this.dgvHomePlayerMyComponentDemandsList.Name = "dgvHomePlayerMyComponentDemandsList";
            this.dgvHomePlayerMyComponentDemandsList.RowHeadersVisible = false;
            this.dgvHomePlayerMyComponentDemandsList.RowHeadersWidth = 51;
            this.dgvHomePlayerMyComponentDemandsList.RowTemplate.Height = 24;
            this.dgvHomePlayerMyComponentDemandsList.Size = new System.Drawing.Size(459, 480);
            this.dgvHomePlayerMyComponentDemandsList.TabIndex = 0;
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
            // gbHomePlayerAllComponentDemandsInformations
            // 
            this.gbHomePlayerAllComponentDemandsInformations.Controls.Add(this.dgvHomePlayerAllComponentDemandsList);
            this.gbHomePlayerAllComponentDemandsInformations.Location = new System.Drawing.Point(6, 90);
            this.gbHomePlayerAllComponentDemandsInformations.Name = "gbHomePlayerAllComponentDemandsInformations";
            this.gbHomePlayerAllComponentDemandsInformations.Size = new System.Drawing.Size(565, 577);
            this.gbHomePlayerAllComponentDemandsInformations.TabIndex = 0;
            this.gbHomePlayerAllComponentDemandsInformations.TabStop = false;
            this.gbHomePlayerAllComponentDemandsInformations.Text = "Toutes les demandes";
            // 
            // dgvHomePlayerAllComponentDemandsList
            // 
            this.dgvHomePlayerAllComponentDemandsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomePlayerAllComponentDemandsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponantPlayerName,
            this.ComponentName,
            this.ComponentQuantity,
            this.ComponentContribution});
            this.dgvHomePlayerAllComponentDemandsList.Location = new System.Drawing.Point(20, 52);
            this.dgvHomePlayerAllComponentDemandsList.Name = "dgvHomePlayerAllComponentDemandsList";
            this.dgvHomePlayerAllComponentDemandsList.RowHeadersVisible = false;
            this.dgvHomePlayerAllComponentDemandsList.RowHeadersWidth = 51;
            this.dgvHomePlayerAllComponentDemandsList.RowTemplate.Height = 24;
            this.dgvHomePlayerAllComponentDemandsList.Size = new System.Drawing.Size(519, 508);
            this.dgvHomePlayerAllComponentDemandsList.TabIndex = 0;
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
            // lblkHomePlayerNotifications
            // 
            this.lblkHomePlayerNotifications.AutoSize = true;
            this.lblkHomePlayerNotifications.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkHomePlayerNotifications.Location = new System.Drawing.Point(962, 7);
            this.lblkHomePlayerNotifications.Name = "lblkHomePlayerNotifications";
            this.lblkHomePlayerNotifications.Size = new System.Drawing.Size(24, 27);
            this.lblkHomePlayerNotifications.TabIndex = 10;
            this.lblkHomePlayerNotifications.TabStop = true;
            this.lblkHomePlayerNotifications.Text = "2";
            this.lblkHomePlayerNotifications.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkHomePlayerNotifications_LinkClicked);
            // 
            // lblkHomePlayerProfil
            // 
            this.lblkHomePlayerProfil.AutoSize = true;
            this.lblkHomePlayerProfil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkHomePlayerProfil.Location = new System.Drawing.Point(1022, 7);
            this.lblkHomePlayerProfil.Name = "lblkHomePlayerProfil";
            this.lblkHomePlayerProfil.Size = new System.Drawing.Size(114, 29);
            this.lblkHomePlayerProfil.TabIndex = 9;
            this.lblkHomePlayerProfil.TabStop = true;
            this.lblkHomePlayerProfil.Text = "Mon Profil";
            this.lblkHomePlayerProfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkHomePlayerProfil_LinkClicked);
            // 
            // lblHomePlayerNotificationsTitle
            // 
            this.lblHomePlayerNotificationsTitle.AutoSize = true;
            this.lblHomePlayerNotificationsTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePlayerNotificationsTitle.Location = new System.Drawing.Point(820, 9);
            this.lblHomePlayerNotificationsTitle.Name = "lblHomePlayerNotificationsTitle";
            this.lblHomePlayerNotificationsTitle.Size = new System.Drawing.Size(146, 27);
            this.lblHomePlayerNotificationsTitle.TabIndex = 8;
            this.lblHomePlayerNotificationsTitle.Text = "Notifications :";
            // 
            // lblHomePlayerGuildNameTitle
            // 
            this.lblHomePlayerGuildNameTitle.AutoSize = true;
            this.lblHomePlayerGuildNameTitle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePlayerGuildNameTitle.Location = new System.Drawing.Point(484, 9);
            this.lblHomePlayerGuildNameTitle.Name = "lblHomePlayerGuildNameTitle";
            this.lblHomePlayerGuildNameTitle.Size = new System.Drawing.Size(195, 39);
            this.lblHomePlayerGuildNameTitle.TabIndex = 7;
            this.lblHomePlayerGuildNameTitle.Text = "NomDeGuilde";
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
            // Column1
            // 
            this.Column1.HeaderText = "Race";
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Rôle";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
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
            this.raidinvites.HeaderText = "Date";
            this.raidinvites.MinimumWidth = 6;
            this.raidinvites.Name = "raidinvites";
            this.raidinvites.Width = 125;
            // 
            // raidRoster
            // 
            this.raidRoster.HeaderText = "Participants";
            this.raidRoster.MinimumWidth = 6;
            this.raidRoster.Name = "raidRoster";
            this.raidRoster.Width = 150;
            // 
            // frmHomePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1221, 794);
            this.Controls.Add(this.lblkHomePlayerNotifications);
            this.Controls.Add(this.lblkHomePlayerProfil);
            this.Controls.Add(this.lblHomePlayerNotificationsTitle);
            this.Controls.Add(this.lblHomePlayerGuildNameTitle);
            this.Controls.Add(this.tcHomePlayerInfomations);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHomePlayer";
            this.Text = "Tableau de bord du joueur";
            this.tcHomePlayerInfomations.ResumeLayout(false);
            this.tpHomePlayerMembers.ResumeLayout(false);
            this.tpHomePlayerMembers.PerformLayout();
            this.gbHomePlayerGuildMembersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayerMembersList)).EndInit();
            this.tpHomePlayerRaid.ResumeLayout(false);
            this.tpHomePlayerRaid.PerformLayout();
            this.gbHomePlayerRaidList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayerRaidList)).EndInit();
            this.tpHomePlayerComposants.ResumeLayout(false);
            this.tpHomePlayerComposants.PerformLayout();
            this.gbHomePlayerMyComponentDemandsInformations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayerMyComponentDemandsList)).EndInit();
            this.gbHomePlayerAllComponentDemandsInformations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayerAllComponentDemandsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcHomePlayerInfomations;
        private System.Windows.Forms.TabPage tpHomePlayerMembers;
        private System.Windows.Forms.Label lblHomePlayerMembersTitle;
        private System.Windows.Forms.GroupBox gbHomePlayerGuildMembersList;
        private System.Windows.Forms.DataGridView dgvHomePlayerMembersList;
        private System.Windows.Forms.TabPage tpHomePlayerRaid;
        private System.Windows.Forms.Label lblHomePlayerRaidsTitle;
        private System.Windows.Forms.GroupBox gbHomePlayerRaidList;
        private System.Windows.Forms.MonthCalendar mcHomePlayerRaidCalendar;
        private System.Windows.Forms.DataGridView dgvHomePlayerRaidList;
        private System.Windows.Forms.Label lblHomeRaidList;
        private System.Windows.Forms.TabPage tpHomePlayerComposants;
        private System.Windows.Forms.Label lblHomePlayerComponentDemandsTitle;
        private System.Windows.Forms.GroupBox gbHomePlayerMyComponentDemandsInformations;
        private System.Windows.Forms.Button btnHomePlayerComponentDemand;
        private System.Windows.Forms.DataGridView dgvHomePlayerMyComponentDemandsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerDemandComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerDemandQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn PlayerDemandDetails;
        private System.Windows.Forms.GroupBox gbHomePlayerAllComponentDemandsInformations;
        private System.Windows.Forms.DataGridView dgvHomePlayerAllComponentDemandsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponantPlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn ComponentContribution;
        private System.Windows.Forms.LinkLabel lblkHomePlayerNotifications;
        private System.Windows.Forms.LinkLabel lblkHomePlayerProfil;
        private System.Windows.Forms.Label lblHomePlayerNotificationsTitle;
        private System.Windows.Forms.Label lblHomePlayerGuildNameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidName;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidinvites;
        private System.Windows.Forms.DataGridViewTextBoxColumn raidRoster;
    }
}