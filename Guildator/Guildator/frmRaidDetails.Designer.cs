namespace Guildator
{
    partial class frmRaidDetails
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidParticipantsNumber = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidParticipantsTitle = new System.Windows.Forms.Label();
            this.lblHomeGuildMasterRaidDateTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRaidDetailsClose = new System.Windows.Forms.Button();
            this.lblRaidDetailsRaidName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.Roster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rôle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invitation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Roster,
            this.Nom,
            this.Classe,
            this.Rôle,
            this.Invitation,
            this.Delete});
            this.dataGridView2.Location = new System.Drawing.Point(6, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(571, 255);
            this.dataGridView2.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.lblRaidDetailsRaidName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblHomeGuildMasterRaidParticipantsNumber);
            this.groupBox1.Controls.Add(this.lblHomeGuildMasterRaidParticipantsTitle);
            this.groupBox1.Controls.Add(this.lblHomeGuildMasterRaidDateTitle);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 276);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations du raid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 26);
            this.label7.TabIndex = 45;
            this.label7.Text = "0/14";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 26);
            this.label6.TabIndex = 44;
            this.label6.Text = "0/4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = "0/2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 26);
            this.label5.TabIndex = 42;
            this.label5.Text = "DPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 41;
            this.label4.Text = "HEAL";
            // 
            // fd
            // 
            this.fd.AutoSize = true;
            this.fd.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fd.Location = new System.Drawing.Point(155, 215);
            this.fd.Name = "fd";
            this.fd.Size = new System.Drawing.Size(65, 26);
            this.fd.TabIndex = 40;
            this.fd.Text = "TANK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "En attente :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 38;
            this.label1.Text = "Invités : ";
            // 
            // lblHomeGuildMasterRaidParticipantsNumber
            // 
            this.lblHomeGuildMasterRaidParticipantsNumber.AutoSize = true;
            this.lblHomeGuildMasterRaidParticipantsNumber.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeGuildMasterRaidParticipantsNumber.Location = new System.Drawing.Point(229, 70);
            this.lblHomeGuildMasterRaidParticipantsNumber.Name = "lblHomeGuildMasterRaidParticipantsNumber";
            this.lblHomeGuildMasterRaidParticipantsNumber.Size = new System.Drawing.Size(0, 26);
            this.lblHomeGuildMasterRaidParticipantsNumber.TabIndex = 37;
            // 
            // lblHomeGuildMasterRaidParticipantsTitle
            // 
            this.lblHomeGuildMasterRaidParticipantsTitle.AutoSize = true;
            this.lblHomeGuildMasterRaidParticipantsTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeGuildMasterRaidParticipantsTitle.Location = new System.Drawing.Point(25, 145);
            this.lblHomeGuildMasterRaidParticipantsTitle.Name = "lblHomeGuildMasterRaidParticipantsTitle";
            this.lblHomeGuildMasterRaidParticipantsTitle.Size = new System.Drawing.Size(126, 26);
            this.lblHomeGuildMasterRaidParticipantsTitle.TabIndex = 36;
            this.lblHomeGuildMasterRaidParticipantsTitle.Text = "Participants :";
            // 
            // lblHomeGuildMasterRaidDateTitle
            // 
            this.lblHomeGuildMasterRaidDateTitle.AutoSize = true;
            this.lblHomeGuildMasterRaidDateTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeGuildMasterRaidDateTitle.Location = new System.Drawing.Point(25, 78);
            this.lblHomeGuildMasterRaidDateTitle.Name = "lblHomeGuildMasterRaidDateTitle";
            this.lblHomeGuildMasterRaidDateTitle.Size = new System.Drawing.Size(133, 26);
            this.lblHomeGuildMasterRaidDateTitle.TabIndex = 34;
            this.lblHomeGuildMasterRaidDateTitle.Text = "Date du raid :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 333);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des participants";
            // 
            // btnRaidDetailsClose
            // 
            this.btnRaidDetailsClose.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaidDetailsClose.Location = new System.Drawing.Point(12, 632);
            this.btnRaidDetailsClose.Name = "btnRaidDetailsClose";
            this.btnRaidDetailsClose.Size = new System.Drawing.Size(89, 32);
            this.btnRaidDetailsClose.TabIndex = 36;
            this.btnRaidDetailsClose.Text = "Fermer";
            this.btnRaidDetailsClose.UseVisualStyleBackColor = true;
            // 
            // lblRaidDetailsRaidName
            // 
            this.lblRaidDetailsRaidName.AutoSize = true;
            this.lblRaidDetailsRaidName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaidDetailsRaidName.Location = new System.Drawing.Point(25, 44);
            this.lblRaidDetailsRaidName.Name = "lblRaidDetailsRaidName";
            this.lblRaidDetailsRaidName.Size = new System.Drawing.Size(64, 26);
            this.lblRaidDetailsRaidName.TabIndex = 46;
            this.lblRaidDetailsRaidName.Text = "Nom :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(476, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 37;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "Onyxia",
            "Coeur du Magma",
            "Repaire de l\'Aile Noire"});
            this.listBox1.Location = new System.Drawing.Point(171, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 28);
            this.listBox1.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 31);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(397, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 31);
            this.button2.TabIndex = 21;
            this.button2.Text = "Ajouter un membre";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Roster
            // 
            this.Roster.HeaderText = "Roster";
            this.Roster.MinimumWidth = 6;
            this.Roster.Name = "Roster";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 110;
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
            // Invitation
            // 
            this.Invitation.HeaderText = "Invitation";
            this.Invitation.MinimumWidth = 6;
            this.Invitation.Name = "Invitation";
            this.Invitation.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "X";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 125;
            // 
            // frmRaidDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 676);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRaidDetailsClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRaidDetails";
            this.Text = "frmRaidDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHomeGuildMasterRaidParticipantsNumber;
        private System.Windows.Forms.Label lblHomeGuildMasterRaidParticipantsTitle;
        private System.Windows.Forms.Label lblHomeGuildMasterRaidDateTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRaidDetailsClose;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblRaidDetailsRaidName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rôle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invitation;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}