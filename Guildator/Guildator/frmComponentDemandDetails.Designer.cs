namespace Guildator
{
    partial class frmComponentDemandDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentDemandDetails));
            this.gbComponentDemandDetailsInformations = new System.Windows.Forms.GroupBox();
            this.btnComponentDemandDetailsDelete = new System.Windows.Forms.Button();
            this.lblComponentDemandDetailsQuantity = new System.Windows.Forms.Label();
            this.lblComponentDemandDetailsTotalQuantityTitle = new System.Windows.Forms.Label();
            this.dgvComponentDemandDetailsList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComponentDemandDetailsDonatorsList = new System.Windows.Forms.Label();
            this.lblComponentDemandDetailsQuantityLeft = new System.Windows.Forms.Label();
            this.lblComponentDemandDetailsName = new System.Windows.Forms.Label();
            this.lblComponentDemandDetailsQuantityLeftTitle = new System.Windows.Forms.Label();
            this.lblComponentDemandDetailsNameTitle = new System.Windows.Forms.Label();
            this.btnComponentDemandDetailsClose = new System.Windows.Forms.Button();
            this.gbComponentDemandDetailsInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentDemandDetailsList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbComponentDemandDetailsInformations
            // 
            this.gbComponentDemandDetailsInformations.Controls.Add(this.btnComponentDemandDetailsDelete);
            this.gbComponentDemandDetailsInformations.Controls.Add(this.lblComponentDemandDetailsQuantity);
            this.gbComponentDemandDetailsInformations.Controls.Add(this.lblComponentDemandDetailsTotalQuantityTitle);
            this.gbComponentDemandDetailsInformations.Controls.Add(this.dgvComponentDemandDetailsList);
            this.gbComponentDemandDetailsInformations.Controls.Add(this.lblComponentDemandDetailsDonatorsList);
            this.gbComponentDemandDetailsInformations.Controls.Add(this.lblComponentDemandDetailsQuantityLeft);
            this.gbComponentDemandDetailsInformations.Controls.Add(this.lblComponentDemandDetailsName);
            this.gbComponentDemandDetailsInformations.Controls.Add(this.lblComponentDemandDetailsQuantityLeftTitle);
            this.gbComponentDemandDetailsInformations.Controls.Add(this.lblComponentDemandDetailsNameTitle);
            this.gbComponentDemandDetailsInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComponentDemandDetailsInformations.Location = new System.Drawing.Point(13, 13);
            this.gbComponentDemandDetailsInformations.Name = "gbComponentDemandDetailsInformations";
            this.gbComponentDemandDetailsInformations.Size = new System.Drawing.Size(470, 706);
            this.gbComponentDemandDetailsInformations.TabIndex = 0;
            this.gbComponentDemandDetailsInformations.TabStop = false;
            this.gbComponentDemandDetailsInformations.Text = "Informations sur votre demande";
            // 
            // btnComponentDemandDetailsDelete
            // 
            this.btnComponentDemandDetailsDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComponentDemandDetailsDelete.ForeColor = System.Drawing.Color.Red;
            this.btnComponentDemandDetailsDelete.Location = new System.Drawing.Point(196, 638);
            this.btnComponentDemandDetailsDelete.Name = "btnComponentDemandDetailsDelete";
            this.btnComponentDemandDetailsDelete.Size = new System.Drawing.Size(245, 37);
            this.btnComponentDemandDetailsDelete.TabIndex = 9;
            this.btnComponentDemandDetailsDelete.Text = "Supprimer la demande";
            this.btnComponentDemandDetailsDelete.UseVisualStyleBackColor = true;
            this.btnComponentDemandDetailsDelete.Click += new System.EventHandler(this.btnComponentDemandDetailsDelete_Click);
            // 
            // lblComponentDemandDetailsQuantity
            // 
            this.lblComponentDemandDetailsQuantity.AutoSize = true;
            this.lblComponentDemandDetailsQuantity.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentDemandDetailsQuantity.Location = new System.Drawing.Point(280, 121);
            this.lblComponentDemandDetailsQuantity.Name = "lblComponentDemandDetailsQuantity";
            this.lblComponentDemandDetailsQuantity.Size = new System.Drawing.Size(45, 26);
            this.lblComponentDemandDetailsQuantity.TabIndex = 8;
            this.lblComponentDemandDetailsQuantity.Text = "100";
            // 
            // lblComponentDemandDetailsTotalQuantityTitle
            // 
            this.lblComponentDemandDetailsTotalQuantityTitle.AutoSize = true;
            this.lblComponentDemandDetailsTotalQuantityTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentDemandDetailsTotalQuantityTitle.Location = new System.Drawing.Point(49, 121);
            this.lblComponentDemandDetailsTotalQuantityTitle.Name = "lblComponentDemandDetailsTotalQuantityTitle";
            this.lblComponentDemandDetailsTotalQuantityTitle.Size = new System.Drawing.Size(164, 26);
            this.lblComponentDemandDetailsTotalQuantityTitle.TabIndex = 7;
            this.lblComponentDemandDetailsTotalQuantityTitle.Text = "Quantité totale : ";
            // 
            // dgvComponentDemandDetailsList
            // 
            this.dgvComponentDemandDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentDemandDetailsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvComponentDemandDetailsList.Location = new System.Drawing.Point(54, 276);
            this.dgvComponentDemandDetailsList.Name = "dgvComponentDemandDetailsList";
            this.dgvComponentDemandDetailsList.RowHeadersVisible = false;
            this.dgvComponentDemandDetailsList.RowHeadersWidth = 51;
            this.dgvComponentDemandDetailsList.RowTemplate.Height = 24;
            this.dgvComponentDemandDetailsList.Size = new System.Drawing.Size(262, 318);
            this.dgvComponentDemandDetailsList.TabIndex = 6;
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
            this.Column2.HeaderText = "Quantité";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // lblComponentDemandDetailsDonatorsList
            // 
            this.lblComponentDemandDetailsDonatorsList.AutoSize = true;
            this.lblComponentDemandDetailsDonatorsList.Location = new System.Drawing.Point(63, 238);
            this.lblComponentDemandDetailsDonatorsList.Name = "lblComponentDemandDetailsDonatorsList";
            this.lblComponentDemandDetailsDonatorsList.Size = new System.Drawing.Size(243, 35);
            this.lblComponentDemandDetailsDonatorsList.TabIndex = 5;
            this.lblComponentDemandDetailsDonatorsList.Text = "Liste des donateurs";
            // 
            // lblComponentDemandDetailsQuantityLeft
            // 
            this.lblComponentDemandDetailsQuantityLeft.AutoSize = true;
            this.lblComponentDemandDetailsQuantityLeft.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentDemandDetailsQuantityLeft.Location = new System.Drawing.Point(280, 174);
            this.lblComponentDemandDetailsQuantityLeft.Name = "lblComponentDemandDetailsQuantityLeft";
            this.lblComponentDemandDetailsQuantityLeft.Size = new System.Drawing.Size(36, 26);
            this.lblComponentDemandDetailsQuantityLeft.TabIndex = 4;
            this.lblComponentDemandDetailsQuantityLeft.Text = "20";
            // 
            // lblComponentDemandDetailsName
            // 
            this.lblComponentDemandDetailsName.AutoSize = true;
            this.lblComponentDemandDetailsName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentDemandDetailsName.Location = new System.Drawing.Point(280, 68);
            this.lblComponentDemandDetailsName.Name = "lblComponentDemandDetailsName";
            this.lblComponentDemandDetailsName.Size = new System.Drawing.Size(161, 26);
            this.lblComponentDemandDetailsName.TabIndex = 3;
            this.lblComponentDemandDetailsName.Text = "Minerai de cuivre";
            // 
            // lblComponentDemandDetailsQuantityLeftTitle
            // 
            this.lblComponentDemandDetailsQuantityLeftTitle.AutoSize = true;
            this.lblComponentDemandDetailsQuantityLeftTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentDemandDetailsQuantityLeftTitle.Location = new System.Drawing.Point(49, 174);
            this.lblComponentDemandDetailsQuantityLeftTitle.Name = "lblComponentDemandDetailsQuantityLeftTitle";
            this.lblComponentDemandDetailsQuantityLeftTitle.Size = new System.Drawing.Size(187, 26);
            this.lblComponentDemandDetailsQuantityLeftTitle.TabIndex = 2;
            this.lblComponentDemandDetailsQuantityLeftTitle.Text = "Quantité restante : ";
            // 
            // lblComponentDemandDetailsNameTitle
            // 
            this.lblComponentDemandDetailsNameTitle.AutoSize = true;
            this.lblComponentDemandDetailsNameTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentDemandDetailsNameTitle.Location = new System.Drawing.Point(49, 68);
            this.lblComponentDemandDetailsNameTitle.Name = "lblComponentDemandDetailsNameTitle";
            this.lblComponentDemandDetailsNameTitle.Size = new System.Drawing.Size(195, 26);
            this.lblComponentDemandDetailsNameTitle.TabIndex = 0;
            this.lblComponentDemandDetailsNameTitle.Text = "Nom du composant : ";
            // 
            // btnComponentDemandDetailsClose
            // 
            this.btnComponentDemandDetailsClose.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComponentDemandDetailsClose.Location = new System.Drawing.Point(392, 725);
            this.btnComponentDemandDetailsClose.Name = "btnComponentDemandDetailsClose";
            this.btnComponentDemandDetailsClose.Size = new System.Drawing.Size(91, 32);
            this.btnComponentDemandDetailsClose.TabIndex = 1;
            this.btnComponentDemandDetailsClose.Text = "Fermer";
            this.btnComponentDemandDetailsClose.UseVisualStyleBackColor = true;
            this.btnComponentDemandDetailsClose.Click += new System.EventHandler(this.btnComponentDemandDetailsClose_Click);
            // 
            // frmComponentDemandDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 772);
            this.Controls.Add(this.btnComponentDemandDetailsClose);
            this.Controls.Add(this.gbComponentDemandDetailsInformations);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmComponentDemandDetails";
            this.Text = "Page de demande de composant détailée";
            this.Load += new System.EventHandler(this.frmComponentDemandDetails_Load);
            this.gbComponentDemandDetailsInformations.ResumeLayout(false);
            this.gbComponentDemandDetailsInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentDemandDetailsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbComponentDemandDetailsInformations;
        private System.Windows.Forms.Label lblComponentDemandDetailsDonatorsList;
        private System.Windows.Forms.Label lblComponentDemandDetailsQuantityLeft;
        private System.Windows.Forms.Label lblComponentDemandDetailsName;
        private System.Windows.Forms.Label lblComponentDemandDetailsQuantityLeftTitle;
        private System.Windows.Forms.Label lblComponentDemandDetailsNameTitle;
        private System.Windows.Forms.Button btnComponentDemandDetailsDelete;
        private System.Windows.Forms.Label lblComponentDemandDetailsQuantity;
        private System.Windows.Forms.Label lblComponentDemandDetailsTotalQuantityTitle;
        private System.Windows.Forms.DataGridView dgvComponentDemandDetailsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnComponentDemandDetailsClose;
    }
}