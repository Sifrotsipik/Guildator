namespace Guildator
{
    partial class frmNotifications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotifications));
            this.gbNotificationsInformations = new System.Windows.Forms.GroupBox();
            this.dgvNotificationsList = new System.Windows.Forms.DataGridView();
            this.btnNotificationsClose = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbNotificationsInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificationsList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNotificationsInformations
            // 
            this.gbNotificationsInformations.Controls.Add(this.dgvNotificationsList);
            this.gbNotificationsInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNotificationsInformations.Location = new System.Drawing.Point(12, 12);
            this.gbNotificationsInformations.Name = "gbNotificationsInformations";
            this.gbNotificationsInformations.Size = new System.Drawing.Size(445, 569);
            this.gbNotificationsInformations.TabIndex = 0;
            this.gbNotificationsInformations.TabStop = false;
            this.gbNotificationsInformations.Text = "Liste des notifications";
            // 
            // dgvNotificationsList
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotificationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotificationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificationsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvNotificationsList.Location = new System.Drawing.Point(17, 54);
            this.dgvNotificationsList.Name = "dgvNotificationsList";
            this.dgvNotificationsList.ReadOnly = true;
            this.dgvNotificationsList.RowHeadersVisible = false;
            this.dgvNotificationsList.RowHeadersWidth = 51;
            this.dgvNotificationsList.RowTemplate.Height = 24;
            this.dgvNotificationsList.Size = new System.Drawing.Size(404, 165);
            this.dgvNotificationsList.TabIndex = 0;
            this.dgvNotificationsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotificationsList_CellContentClick);
            // 
            // btnNotificationsClose
            // 
            this.btnNotificationsClose.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificationsClose.Location = new System.Drawing.Point(363, 587);
            this.btnNotificationsClose.Name = "btnNotificationsClose";
            this.btnNotificationsClose.Size = new System.Drawing.Size(94, 38);
            this.btnNotificationsClose.TabIndex = 1;
            this.btnNotificationsClose.Text = "Fermer";
            this.btnNotificationsClose.UseVisualStyleBackColor = true;
            this.btnNotificationsClose.Click += new System.EventHandler(this.btnNotificationsClose_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Type";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Retirer";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 125;
            // 
            // frmNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 637);
            this.Controls.Add(this.btnNotificationsClose);
            this.Controls.Add(this.gbNotificationsInformations);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNotifications";
            this.Text = "Page de notifications";
            this.Load += new System.EventHandler(this.frmNotifications_Load);
            this.gbNotificationsInformations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificationsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNotificationsInformations;
        private System.Windows.Forms.DataGridView dgvNotificationsList;
        private System.Windows.Forms.Button btnNotificationsClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}