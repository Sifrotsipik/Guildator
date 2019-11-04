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
            this.lblGuildSearchName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGuildSearchAction = new System.Windows.Forms.Button();
            this.btnGuildSearchBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbGuildSearchSearch = new System.Windows.Forms.GroupBox();
            this.gbGuildSearchInformations = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGuildSearchSearch.SuspendLayout();
            this.gbGuildSearchInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 33);
            this.textBox1.TabIndex = 3;
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
            // 
            // btnGuildSearchBack
            // 
            this.btnGuildSearchBack.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuildSearchBack.Location = new System.Drawing.Point(12, 426);
            this.btnGuildSearchBack.Name = "btnGuildSearchBack";
            this.btnGuildSearchBack.Size = new System.Drawing.Size(97, 37);
            this.btnGuildSearchBack.TabIndex = 5;
            this.btnGuildSearchBack.Text = "Fermer";
            this.btnGuildSearchBack.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Demander à rejoindre";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbGuildSearchSearch
            // 
            this.gbGuildSearchSearch.Controls.Add(this.textBox1);
            this.gbGuildSearchSearch.Controls.Add(this.btnGuildSearchAction);
            this.gbGuildSearchSearch.Controls.Add(this.lblGuildSearchName);
            this.gbGuildSearchSearch.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGuildSearchSearch.Location = new System.Drawing.Point(12, 12);
            this.gbGuildSearchSearch.Name = "gbGuildSearchSearch";
            this.gbGuildSearchSearch.Size = new System.Drawing.Size(445, 159);
            this.gbGuildSearchSearch.TabIndex = 10;
            this.gbGuildSearchSearch.TabStop = false;
            this.gbGuildSearchSearch.Text = "Rechercher une guilde";
            // 
            // gbGuildSearchInformations
            // 
            this.gbGuildSearchInformations.Controls.Add(this.dataGridView1);
            this.gbGuildSearchInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGuildSearchInformations.Location = new System.Drawing.Point(12, 177);
            this.gbGuildSearchInformations.Name = "gbGuildSearchInformations";
            this.gbGuildSearchInformations.Size = new System.Drawing.Size(445, 243);
            this.gbGuildSearchInformations.TabIndex = 11;
            this.gbGuildSearchInformations.TabStop = false;
            this.gbGuildSearchInformations.Text = "Liste des Guildes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(6, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(419, 150);
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
            // frmGuildSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 489);
            this.Controls.Add(this.gbGuildSearchInformations);
            this.Controls.Add(this.gbGuildSearchSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuildSearchBack);
            this.Name = "frmGuildSearch";
            this.Text = "Recherche de guilde";
            this.gbGuildSearchSearch.ResumeLayout(false);
            this.gbGuildSearchSearch.PerformLayout();
            this.gbGuildSearchInformations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGuildSearchName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuildSearchAction;
        private System.Windows.Forms.Button btnGuildSearchBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbGuildSearchSearch;
        private System.Windows.Forms.GroupBox gbGuildSearchInformations;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}