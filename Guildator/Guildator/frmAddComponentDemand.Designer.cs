namespace Guildator
{
    partial class frmAddComponentDemand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddComponentDemand));
            this.gbAddComponentDemandInformations = new System.Windows.Forms.GroupBox();
            this.nudAddComponentDemandQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbAddComponentDemandeName = new System.Windows.Forms.ListBox();
            this.lblAddComponentDemandQuantityTitle = new System.Windows.Forms.Label();
            this.lblAddComponentDemandNameTitle = new System.Windows.Forms.Label();
            this.btnAddComponentDemandClose = new System.Windows.Forms.Button();
            this.btnAddComponentDemandSave = new System.Windows.Forms.Button();
            this.gbAddComponentDemandInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddComponentDemandQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddComponentDemandInformations
            // 
            this.gbAddComponentDemandInformations.Controls.Add(this.nudAddComponentDemandQuantity);
            this.gbAddComponentDemandInformations.Controls.Add(this.lbAddComponentDemandeName);
            this.gbAddComponentDemandInformations.Controls.Add(this.lblAddComponentDemandQuantityTitle);
            this.gbAddComponentDemandInformations.Controls.Add(this.lblAddComponentDemandNameTitle);
            this.gbAddComponentDemandInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddComponentDemandInformations.Location = new System.Drawing.Point(12, 12);
            this.gbAddComponentDemandInformations.Name = "gbAddComponentDemandInformations";
            this.gbAddComponentDemandInformations.Size = new System.Drawing.Size(488, 199);
            this.gbAddComponentDemandInformations.TabIndex = 0;
            this.gbAddComponentDemandInformations.TabStop = false;
            this.gbAddComponentDemandInformations.Text = "Demander un composant";
            // 
            // nudAddComponentDemandQuantity
            // 
            this.nudAddComponentDemandQuantity.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAddComponentDemandQuantity.Location = new System.Drawing.Point(149, 126);
            this.nudAddComponentDemandQuantity.Name = "nudAddComponentDemandQuantity";
            this.nudAddComponentDemandQuantity.Size = new System.Drawing.Size(120, 33);
            this.nudAddComponentDemandQuantity.TabIndex = 3;
            // 
            // lbAddComponentDemandeName
            // 
            this.lbAddComponentDemandeName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddComponentDemandeName.FormattingEnabled = true;
            this.lbAddComponentDemandeName.ItemHeight = 24;
            this.lbAddComponentDemandeName.Items.AddRange(new object[] {
            "Sélectionnez un composant",
            "Minerai de cuivre",
            "Minerai d\'argent",
            "Minerai d\'or",
            "Barre de cuivre",
            "Barre d\'argent",
            "Barre d\'or",
            ""});
            this.lbAddComponentDemandeName.Location = new System.Drawing.Point(123, 59);
            this.lbAddComponentDemandeName.Name = "lbAddComponentDemandeName";
            this.lbAddComponentDemandeName.Size = new System.Drawing.Size(332, 28);
            this.lbAddComponentDemandeName.TabIndex = 2;
            // 
            // lblAddComponentDemandQuantityTitle
            // 
            this.lblAddComponentDemandQuantityTitle.AutoSize = true;
            this.lblAddComponentDemandQuantityTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddComponentDemandQuantityTitle.Location = new System.Drawing.Point(42, 126);
            this.lblAddComponentDemandQuantityTitle.Name = "lblAddComponentDemandQuantityTitle";
            this.lblAddComponentDemandQuantityTitle.Size = new System.Drawing.Size(101, 26);
            this.lblAddComponentDemandQuantityTitle.TabIndex = 1;
            this.lblAddComponentDemandQuantityTitle.Text = "Quantité :";
            // 
            // lblAddComponentDemandNameTitle
            // 
            this.lblAddComponentDemandNameTitle.AutoSize = true;
            this.lblAddComponentDemandNameTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddComponentDemandNameTitle.Location = new System.Drawing.Point(42, 59);
            this.lblAddComponentDemandNameTitle.Name = "lblAddComponentDemandNameTitle";
            this.lblAddComponentDemandNameTitle.Size = new System.Drawing.Size(64, 26);
            this.lblAddComponentDemandNameTitle.TabIndex = 0;
            this.lblAddComponentDemandNameTitle.Text = "Nom :";
            // 
            // btnAddComponentDemandClose
            // 
            this.btnAddComponentDemandClose.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponentDemandClose.Location = new System.Drawing.Point(12, 217);
            this.btnAddComponentDemandClose.Name = "btnAddComponentDemandClose";
            this.btnAddComponentDemandClose.Size = new System.Drawing.Size(90, 36);
            this.btnAddComponentDemandClose.TabIndex = 1;
            this.btnAddComponentDemandClose.Text = "Fermer";
            this.btnAddComponentDemandClose.UseVisualStyleBackColor = true;
            this.btnAddComponentDemandClose.Click += new System.EventHandler(this.btnAddComponentDemandClose_Click);
            // 
            // btnAddComponentDemandSave
            // 
            this.btnAddComponentDemandSave.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponentDemandSave.Location = new System.Drawing.Point(374, 217);
            this.btnAddComponentDemandSave.Name = "btnAddComponentDemandSave";
            this.btnAddComponentDemandSave.Size = new System.Drawing.Size(126, 36);
            this.btnAddComponentDemandSave.TabIndex = 2;
            this.btnAddComponentDemandSave.Text = "Enregistrer";
            this.btnAddComponentDemandSave.UseVisualStyleBackColor = true;
            this.btnAddComponentDemandSave.Click += new System.EventHandler(this.btnAddComponentDemandSave_Click);
            // 
            // frmAddComponentDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 271);
            this.Controls.Add(this.btnAddComponentDemandSave);
            this.Controls.Add(this.btnAddComponentDemandClose);
            this.Controls.Add(this.gbAddComponentDemandInformations);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddComponentDemand";
            this.Text = "Page de demande de composants";
            this.Load += new System.EventHandler(this.frmAddComponentDemand_Load);
            this.gbAddComponentDemandInformations.ResumeLayout(false);
            this.gbAddComponentDemandInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddComponentDemandQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddComponentDemandInformations;
        private System.Windows.Forms.Label lblAddComponentDemandNameTitle;
        private System.Windows.Forms.Button btnAddComponentDemandClose;
        private System.Windows.Forms.Button btnAddComponentDemandSave;
        private System.Windows.Forms.NumericUpDown nudAddComponentDemandQuantity;
        private System.Windows.Forms.ListBox lbAddComponentDemandeName;
        private System.Windows.Forms.Label lblAddComponentDemandQuantityTitle;
    }
}