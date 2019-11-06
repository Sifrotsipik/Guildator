namespace Guildator
{
    partial class frmGuildSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuildSearch));
            this.lblGuildSearchName = new System.Windows.Forms.Label();
            this.tbGuildSearchName = new System.Windows.Forms.TextBox();
            this.btnGuildSearchAction = new System.Windows.Forms.Button();
            this.btnGuildSearchBack = new System.Windows.Forms.Button();
            this.btnGuildSearchSave = new System.Windows.Forms.Button();
            this.gbGuildSearchSearch = new System.Windows.Forms.GroupBox();
            this.gbGuildSearchInformations = new System.Windows.Forms.GroupBox();
            this.dgvGuildSearchList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGuildSearchGuildNameError = new System.Windows.Forms.Label();
            this.gbGuildSearchSearch.SuspendLayout();
            this.gbGuildSearchInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuildSearchList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuildSearchName
            // 
            this.lblGuildSearchName.AutoSize = true;
            this.lblGuildSearchName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuildSearchName.Location = new System.Drawing.Point(33, 57);
            this.lblGuildSearchName.Name = "lblGuildSearchName";
            this.lblGuildSearchName.Size = new System.Drawing.Size(64, 26);
            this.lblGuildSearchName.TabIndex = 2;
            this.lblGuildSearchName.Text = "Nom :";
            // 
            // tbGuildSearchName
            // 
            this.tbGuildSearchName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuildSearchName.Location = new System.Drawing.Point(103, 54);
            this.tbGuildSearchName.Name = "tbGuildSearchName";
            this.tbGuildSearchName.Size = new System.Drawing.Size(258, 33);
            this.tbGuildSearchName.TabIndex = 3;
            // 
            // btnGuildSearchAction
            // 
            this.btnGuildSearchAction.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuildSearchAction.Location = new System.Drawing.Point(230, 105);
            this.btnGuildSearchAction.Name = "btnGuildSearchAction";
            this.btnGuildSearchAction.Size = new System.Drawing.Size(131, 34);
            this.btnGuildSearchAction.TabIndex = 4;
            this.btnGuildSearchAction.Text = "Recherche";
            this.btnGuildSearchAction.UseVisualStyleBackColor = true;
            this.btnGuildSearchAction.Click += new System.EventHandler(this.btnGuildSearchAction_Click);
            // 
            // btnGuildSearchBack
            // 
            this.btnGuildSearchBack.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuildSearchBack.Location = new System.Drawing.Point(12, 426);
            this.btnGuildSearchBack.Name = "btnGuildSearchBack";
            this.btnGuildSearchBack.Size = new System.Drawing.Size(97, 37);
            this.btnGuildSearchBack.TabIndex = 5;
            this.btnGuildSearchBack.Text = "Quitter";
            this.btnGuildSearchBack.UseVisualStyleBackColor = true;
            this.btnGuildSearchBack.Click += new System.EventHandler(this.btnGuildSearchBack_Click);
            // 
            // btnGuildSearchSave
            // 
            this.btnGuildSearchSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuildSearchSave.Location = new System.Drawing.Point(250, 426);
            this.btnGuildSearchSave.Name = "btnGuildSearchSave";
            this.btnGuildSearchSave.Size = new System.Drawing.Size(207, 37);
            this.btnGuildSearchSave.TabIndex = 8;
            this.btnGuildSearchSave.Text = "Demander à rejoindre";
            this.btnGuildSearchSave.UseVisualStyleBackColor = true;
            this.btnGuildSearchSave.Click += new System.EventHandler(this.btnGuildSearchSave_Click);
            // 
            // gbGuildSearchSearch
            // 
            this.gbGuildSearchSearch.Controls.Add(this.lblGuildSearchGuildNameError);
            this.gbGuildSearchSearch.Controls.Add(this.tbGuildSearchName);
            this.gbGuildSearchSearch.Controls.Add(this.btnGuildSearchAction);
            this.gbGuildSearchSearch.Controls.Add(this.lblGuildSearchName);
            this.gbGuildSearchSearch.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGuildSearchSearch.Location = new System.Drawing.Point(12, 12);
            this.gbGuildSearchSearch.Name = "gbGuildSearchSearch";
            this.gbGuildSearchSearch.Size = new System.Drawing.Size(445, 179);
            this.gbGuildSearchSearch.TabIndex = 10;
            this.gbGuildSearchSearch.TabStop = false;
            this.gbGuildSearchSearch.Text = "Rechercher une guilde";
            // 
            // gbGuildSearchInformations
            // 
            this.gbGuildSearchInformations.Controls.Add(this.dgvGuildSearchList);
            this.gbGuildSearchInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGuildSearchInformations.Location = new System.Drawing.Point(12, 206);
            this.gbGuildSearchInformations.Name = "gbGuildSearchInformations";
            this.gbGuildSearchInformations.Size = new System.Drawing.Size(445, 214);
            this.gbGuildSearchInformations.TabIndex = 11;
            this.gbGuildSearchInformations.TabStop = false;
            this.gbGuildSearchInformations.Text = "Liste des Guildes";
            // 
            // dgvGuildSearchList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuildSearchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuildSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuildSearchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGuildSearchList.Location = new System.Drawing.Point(6, 39);
            this.dgvGuildSearchList.Name = "dgvGuildSearchList";
            this.dgvGuildSearchList.RowHeadersVisible = false;
            this.dgvGuildSearchList.RowHeadersWidth = 51;
            this.dgvGuildSearchList.RowTemplate.Height = 24;
            this.dgvGuildSearchList.Size = new System.Drawing.Size(419, 150);
            this.dgvGuildSearchList.TabIndex = 0;
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
            this.Column2.HeaderText = "Membres";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Maître de guilde";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // lblGuildSearchGuildNameError
            // 
            this.lblGuildSearchGuildNameError.AutoSize = true;
            this.lblGuildSearchGuildNameError.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuildSearchGuildNameError.ForeColor = System.Drawing.Color.Red;
            this.lblGuildSearchGuildNameError.Location = new System.Drawing.Point(103, 142);
            this.lblGuildSearchGuildNameError.Name = "lblGuildSearchGuildNameError";
            this.lblGuildSearchGuildNameError.Size = new System.Drawing.Size(0, 24);
            this.lblGuildSearchGuildNameError.TabIndex = 5;
            // 
            // frmGuildSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 489);
            this.Controls.Add(this.gbGuildSearchInformations);
            this.Controls.Add(this.gbGuildSearchSearch);
            this.Controls.Add(this.btnGuildSearchSave);
            this.Controls.Add(this.btnGuildSearchBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuildSearch";
            this.Text = "Page de recherche de guilde";
            this.gbGuildSearchSearch.ResumeLayout(false);
            this.gbGuildSearchSearch.PerformLayout();
            this.gbGuildSearchInformations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuildSearchList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGuildSearchName;
        private System.Windows.Forms.TextBox tbGuildSearchName;
        private System.Windows.Forms.Button btnGuildSearchAction;
        private System.Windows.Forms.Button btnGuildSearchBack;
        private System.Windows.Forms.Button btnGuildSearchSave;
        private System.Windows.Forms.GroupBox gbGuildSearchSearch;
        private System.Windows.Forms.GroupBox gbGuildSearchInformations;
        private System.Windows.Forms.DataGridView dgvGuildSearchList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblGuildSearchGuildNameError;
    }
}