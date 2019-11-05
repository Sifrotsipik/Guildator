namespace Guildator
{
    partial class frmGuildWaiting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuildWaiting));
            this.gbGuildWaitingInformations = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuildWaitingClose = new System.Windows.Forms.Button();
            this.gbGuildWaitingInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGuildWaitingInformations
            // 
            this.gbGuildWaitingInformations.Controls.Add(this.label1);
            this.gbGuildWaitingInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGuildWaitingInformations.Location = new System.Drawing.Point(12, 12);
            this.gbGuildWaitingInformations.Name = "gbGuildWaitingInformations";
            this.gbGuildWaitingInformations.Size = new System.Drawing.Size(595, 232);
            this.gbGuildWaitingInformations.TabIndex = 0;
            this.gbGuildWaitingInformations.TabStop = false;
            this.gbGuildWaitingInformations.Text = "En attente d\'une guilde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre demande est en cours de validation";
            // 
            // btnGuildWaitingClose
            // 
            this.btnGuildWaitingClose.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuildWaitingClose.Location = new System.Drawing.Point(242, 259);
            this.btnGuildWaitingClose.Name = "btnGuildWaitingClose";
            this.btnGuildWaitingClose.Size = new System.Drawing.Size(99, 39);
            this.btnGuildWaitingClose.TabIndex = 1;
            this.btnGuildWaitingClose.Text = "Quitter";
            this.btnGuildWaitingClose.UseVisualStyleBackColor = true;
            this.btnGuildWaitingClose.Click += new System.EventHandler(this.btnGuildWaitingClose_Click);
            // 
            // frmGuildWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 337);
            this.Controls.Add(this.btnGuildWaitingClose);
            this.Controls.Add(this.gbGuildWaitingInformations);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuildWaiting";
            this.Text = "Page d\'attente de Guilde";
            this.gbGuildWaitingInformations.ResumeLayout(false);
            this.gbGuildWaitingInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGuildWaitingInformations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuildWaitingClose;
    }
}