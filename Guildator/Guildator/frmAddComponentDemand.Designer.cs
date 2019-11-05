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
            this.gbAddComponentDemand = new System.Windows.Forms.GroupBox();
            this.nudAddComponentDemandQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbAddComponentDemandeName = new System.Windows.Forms.ListBox();
            this.lblAddComponentDemandQuantity = new System.Windows.Forms.Label();
            this.lblAddComponentDemandName = new System.Windows.Forms.Label();
            this.btnAddComponentDemandClose = new System.Windows.Forms.Button();
            this.btnAddComponentDemandSave = new System.Windows.Forms.Button();
            this.gbAddComponentDemand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddComponentDemandQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddComponentDemand
            // 
            this.gbAddComponentDemand.Controls.Add(this.nudAddComponentDemandQuantity);
            this.gbAddComponentDemand.Controls.Add(this.lbAddComponentDemandeName);
            this.gbAddComponentDemand.Controls.Add(this.lblAddComponentDemandQuantity);
            this.gbAddComponentDemand.Controls.Add(this.lblAddComponentDemandName);
            this.gbAddComponentDemand.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddComponentDemand.Location = new System.Drawing.Point(12, 12);
            this.gbAddComponentDemand.Name = "gbAddComponentDemand";
            this.gbAddComponentDemand.Size = new System.Drawing.Size(488, 199);
            this.gbAddComponentDemand.TabIndex = 0;
            this.gbAddComponentDemand.TabStop = false;
            this.gbAddComponentDemand.Text = "Demander un composant";
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
            // lblAddComponentDemandQuantity
            // 
            this.lblAddComponentDemandQuantity.AutoSize = true;
            this.lblAddComponentDemandQuantity.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddComponentDemandQuantity.Location = new System.Drawing.Point(42, 126);
            this.lblAddComponentDemandQuantity.Name = "lblAddComponentDemandQuantity";
            this.lblAddComponentDemandQuantity.Size = new System.Drawing.Size(101, 26);
            this.lblAddComponentDemandQuantity.TabIndex = 1;
            this.lblAddComponentDemandQuantity.Text = "Quantité :";
            // 
            // lblAddComponentDemandName
            // 
            this.lblAddComponentDemandName.AutoSize = true;
            this.lblAddComponentDemandName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddComponentDemandName.Location = new System.Drawing.Point(42, 59);
            this.lblAddComponentDemandName.Name = "lblAddComponentDemandName";
            this.lblAddComponentDemandName.Size = new System.Drawing.Size(64, 26);
            this.lblAddComponentDemandName.TabIndex = 0;
            this.lblAddComponentDemandName.Text = "Nom :";
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
            this.Controls.Add(this.gbAddComponentDemand);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAddComponentDemand";
            this.Text = "frmAddComponentDemand";
            this.Load += new System.EventHandler(this.frmAddComponentDemand_Load);
            this.gbAddComponentDemand.ResumeLayout(false);
            this.gbAddComponentDemand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddComponentDemandQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddComponentDemand;
        private System.Windows.Forms.Label lblAddComponentDemandName;
        private System.Windows.Forms.Button btnAddComponentDemandClose;
        private System.Windows.Forms.Button btnAddComponentDemandSave;
        private System.Windows.Forms.NumericUpDown nudAddComponentDemandQuantity;
        private System.Windows.Forms.ListBox lbAddComponentDemandeName;
        private System.Windows.Forms.Label lblAddComponentDemandQuantity;
    }
}