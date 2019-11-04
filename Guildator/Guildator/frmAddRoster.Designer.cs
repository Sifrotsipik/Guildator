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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbAddRosterComposition = new System.Windows.Forms.GroupBox();
            this.lblAddRosterTitle = new System.Windows.Forms.Label();
            this.lblAddRosterListTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAddRaidNumberDps = new System.Windows.Forms.Label();
            this.lblAddRaidNumberHeal = new System.Windows.Forms.Label();
            this.lblAddRaidNumberTank = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.playerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuildMemberRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbAddRosterInformations = new System.Windows.Forms.GroupBox();
            this.tbAddRosterName = new System.Windows.Forms.TextBox();
            this.lblAddRosterName = new System.Windows.Forms.Label();
            this.btnAddRosterSave = new System.Windows.Forms.Button();
            this.btnAddRosterClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbAddRosterComposition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbAddRosterInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(33, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(288, 150);
            this.dataGridView1.TabIndex = 0;
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
            this.Column3.HeaderText = "X";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 125;
            // 
            // gbAddRosterComposition
            // 
            this.gbAddRosterComposition.Controls.Add(this.lblAddRosterTitle);
            this.gbAddRosterComposition.Controls.Add(this.lblAddRosterListTitle);
            this.gbAddRosterComposition.Controls.Add(this.label4);
            this.gbAddRosterComposition.Controls.Add(this.lblAddRaidNumberDps);
            this.gbAddRosterComposition.Controls.Add(this.lblAddRaidNumberHeal);
            this.gbAddRosterComposition.Controls.Add(this.lblAddRaidNumberTank);
            this.gbAddRosterComposition.Controls.Add(this.dataGridView4);
            this.gbAddRosterComposition.Controls.Add(this.dataGridView3);
            this.gbAddRosterComposition.Controls.Add(this.dataGridView2);
            this.gbAddRosterComposition.Controls.Add(this.dataGridView1);
            this.gbAddRosterComposition.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddRosterComposition.Location = new System.Drawing.Point(26, 115);
            this.gbAddRosterComposition.Name = "gbAddRosterComposition";
            this.gbAddRosterComposition.Size = new System.Drawing.Size(1053, 611);
            this.gbAddRosterComposition.TabIndex = 1;
            this.gbAddRosterComposition.TabStop = false;
            this.gbAddRosterComposition.Text = "Composition";
            // 
            // lblAddRosterTitle
            // 
            this.lblAddRosterTitle.AutoSize = true;
            this.lblAddRosterTitle.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRosterTitle.Location = new System.Drawing.Point(485, 306);
            this.lblAddRosterTitle.Name = "lblAddRosterTitle";
            this.lblAddRosterTitle.Size = new System.Drawing.Size(91, 35);
            this.lblAddRosterTitle.TabIndex = 9;
            this.lblAddRosterTitle.Text = "Roster";
            // 
            // lblAddRosterListTitle
            // 
            this.lblAddRosterListTitle.AutoSize = true;
            this.lblAddRosterListTitle.Location = new System.Drawing.Point(349, 36);
            this.lblAddRosterListTitle.Name = "lblAddRosterListTitle";
            this.lblAddRosterListTitle.Size = new System.Drawing.Size(345, 35);
            this.lblAddRosterListTitle.TabIndex = 8;
            this.lblAddRosterListTitle.Text = "Liste des membres de guilde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "TOTAL : 0";
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
            // dataGridView4
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerName,
            this.playerGrade,
            this.Column4,
            this.Column5,
            this.GuildMemberRole,
            this.playerDetails});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView4.Location = new System.Drawing.Point(158, 81);
            this.dataGridView4.Name = "dataGridView4";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(725, 200);
            this.dataGridView4.TabIndex = 3;
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
            // dataGridView3
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView3.Location = new System.Drawing.Point(738, 393);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(288, 150);
            this.dataGridView3.TabIndex = 2;
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
            this.dataGridViewTextBoxColumn6.HeaderText = "X";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(392, 393);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(288, 150);
            this.dataGridView2.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.HeaderText = "X";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // gbAddRosterInformations
            // 
            this.gbAddRosterInformations.Controls.Add(this.tbAddRosterName);
            this.gbAddRosterInformations.Controls.Add(this.lblAddRosterName);
            this.gbAddRosterInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddRosterInformations.Location = new System.Drawing.Point(26, 12);
            this.gbAddRosterInformations.Name = "gbAddRosterInformations";
            this.gbAddRosterInformations.Size = new System.Drawing.Size(1066, 97);
            this.gbAddRosterInformations.TabIndex = 0;
            this.gbAddRosterInformations.TabStop = false;
            this.gbAddRosterInformations.Text = "Informations du roster";
            // 
            // tbAddRosterName
            // 
            this.tbAddRosterName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddRosterName.Location = new System.Drawing.Point(223, 45);
            this.tbAddRosterName.Name = "tbAddRosterName";
            this.tbAddRosterName.Size = new System.Drawing.Size(190, 33);
            this.tbAddRosterName.TabIndex = 1;
            // 
            // lblAddRosterName
            // 
            this.lblAddRosterName.AutoSize = true;
            this.lblAddRosterName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRosterName.Location = new System.Drawing.Point(153, 45);
            this.lblAddRosterName.Name = "lblAddRosterName";
            this.lblAddRosterName.Size = new System.Drawing.Size(64, 26);
            this.lblAddRosterName.TabIndex = 0;
            this.lblAddRosterName.Text = "Nom :";
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
            // 
            // frmAddRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1125, 783);
            this.Controls.Add(this.btnAddRosterClose);
            this.Controls.Add(this.btnAddRosterSave);
            this.Controls.Add(this.gbAddRosterComposition);
            this.Controls.Add(this.gbAddRosterInformations);
            this.Name = "frmAddRoster";
            this.Text = "frmAddRoster";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbAddRosterComposition.ResumeLayout(false);
            this.gbAddRosterComposition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbAddRosterInformations.ResumeLayout(false);
            this.gbAddRosterInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbAddRosterComposition;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblAddRaidNumberDps;
        private System.Windows.Forms.Label lblAddRaidNumberHeal;
        private System.Windows.Forms.Label lblAddRaidNumberTank;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuildMemberRole;
        private System.Windows.Forms.DataGridViewButtonColumn playerDetails;
        private System.Windows.Forms.GroupBox gbAddRosterInformations;
        private System.Windows.Forms.TextBox tbAddRosterName;
        private System.Windows.Forms.Label lblAddRosterName;
        private System.Windows.Forms.Button btnAddRosterSave;
        private System.Windows.Forms.Button btnAddRosterClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.Label lblAddRosterTitle;
        private System.Windows.Forms.Label lblAddRosterListTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn3;
    }
}