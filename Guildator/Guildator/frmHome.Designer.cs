namespace Guildator
{
    partial class frmHome
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblHomeRaidDateSelection = new System.Windows.Forms.Label();
            this.lblHomeRaidList = new System.Windows.Forms.Label();
            this.tcHomeGuildInfomations.SuspendLayout();
            this.tpHomeGuildRaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcHomeGuildInfomations
            // 
            this.tcHomeGuildInfomations.AccessibleName = "";
            this.tcHomeGuildInfomations.Controls.Add(this.tpHomeGuildMembers);
            this.tcHomeGuildInfomations.Controls.Add(this.tpHomeGuildEvents);
            this.tcHomeGuildInfomations.Controls.Add(this.tpHomeGuildRaid);
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
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(12, 50);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblHomeRaidDateSelection
            // 
            this.lblHomeRaidDateSelection.AutoSize = true;
            this.lblHomeRaidDateSelection.Location = new System.Drawing.Point(38, 21);
            this.lblHomeRaidDateSelection.Name = "lblHomeRaidDateSelection";
            this.lblHomeRaidDateSelection.Size = new System.Drawing.Size(335, 17);
            this.lblHomeRaidDateSelection.TabIndex = 2;
            this.lblHomeRaidDateSelection.Text = "Sélectionner une date pour afficher les raids prévus";
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
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 666);
            this.Controls.Add(this.tcHomeGuildInfomations);
            this.Name = "frmHome";
            this.Text = "Tableau de bord";
            this.tcHomeGuildInfomations.ResumeLayout(false);
            this.tpHomeGuildRaid.ResumeLayout(false);
            this.tpHomeGuildRaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}