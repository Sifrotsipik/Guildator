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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Membres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaîtreDeGuilde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGuildSearchSearch = new System.Windows.Forms.GroupBox();
            this.gbGuildSearchInformations = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbGuildSearchSearch.SuspendLayout();
            this.gbGuildSearchInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGuildSearchName
            // 
            this.lblGuildSearchName.AutoSize = true;
            this.lblGuildSearchName.Location = new System.Drawing.Point(43, 35);
            this.lblGuildSearchName.Name = "lblGuildSearchName";
            this.lblGuildSearchName.Size = new System.Drawing.Size(122, 17);
            this.lblGuildSearchName.TabIndex = 2;
            this.lblGuildSearchName.Text = "Nom de la guilde :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 3;
            // 
            // btnGuildSearchAction
            // 
            this.btnGuildSearchAction.Location = new System.Drawing.Point(263, 63);
            this.btnGuildSearchAction.Name = "btnGuildSearchAction";
            this.btnGuildSearchAction.Size = new System.Drawing.Size(91, 23);
            this.btnGuildSearchAction.TabIndex = 4;
            this.btnGuildSearchAction.Text = "Recherche";
            this.btnGuildSearchAction.UseVisualStyleBackColor = true;
            // 
            // btnGuildSearchBack
            // 
            this.btnGuildSearchBack.Location = new System.Drawing.Point(12, 286);
            this.btnGuildSearchBack.Name = "btnGuildSearchBack";
            this.btnGuildSearchBack.Size = new System.Drawing.Size(75, 29);
            this.btnGuildSearchBack.TabIndex = 5;
            this.btnGuildSearchBack.Text = "Retour";
            this.btnGuildSearchBack.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Rejoindre";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Membres,
            this.MaîtreDeGuilde});
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 81);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // Membres
            // 
            this.Membres.HeaderText = "Membres";
            this.Membres.MinimumWidth = 6;
            this.Membres.Name = "Membres";
            this.Membres.Width = 125;
            // 
            // MaîtreDeGuilde
            // 
            this.MaîtreDeGuilde.HeaderText = "Maître de guilde";
            this.MaîtreDeGuilde.MinimumWidth = 6;
            this.MaîtreDeGuilde.Name = "MaîtreDeGuilde";
            this.MaîtreDeGuilde.Width = 125;
            // 
            // gbGuildSearchSearch
            // 
            this.gbGuildSearchSearch.Controls.Add(this.textBox1);
            this.gbGuildSearchSearch.Controls.Add(this.btnGuildSearchAction);
            this.gbGuildSearchSearch.Controls.Add(this.lblGuildSearchName);
            this.gbGuildSearchSearch.Location = new System.Drawing.Point(12, 12);
            this.gbGuildSearchSearch.Name = "gbGuildSearchSearch";
            this.gbGuildSearchSearch.Size = new System.Drawing.Size(445, 99);
            this.gbGuildSearchSearch.TabIndex = 10;
            this.gbGuildSearchSearch.TabStop = false;
            this.gbGuildSearchSearch.Text = "Rechercher une guilde";
            // 
            // gbGuildSearchInformations
            // 
            this.gbGuildSearchInformations.Controls.Add(this.dataGridView1);
            this.gbGuildSearchInformations.Location = new System.Drawing.Point(12, 117);
            this.gbGuildSearchInformations.Name = "gbGuildSearchInformations";
            this.gbGuildSearchInformations.Size = new System.Drawing.Size(445, 139);
            this.gbGuildSearchInformations.TabIndex = 11;
            this.gbGuildSearchInformations.TabStop = false;
            this.gbGuildSearchInformations.Text = "groupBox2";
            // 
            // frmGuildSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 355);
            this.Controls.Add(this.gbGuildSearchInformations);
            this.Controls.Add(this.gbGuildSearchSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuildSearchBack);
            this.Name = "frmGuildSearch";
            this.Text = "Recherche de guilde";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbGuildSearchSearch.ResumeLayout(false);
            this.gbGuildSearchSearch.PerformLayout();
            this.gbGuildSearchInformations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGuildSearchName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuildSearchAction;
        private System.Windows.Forms.Button btnGuildSearchBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membres;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaîtreDeGuilde;
        private System.Windows.Forms.GroupBox gbGuildSearchSearch;
        private System.Windows.Forms.GroupBox gbGuildSearchInformations;
    }
}