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
            this.lblGuildWaitingTitle1 = new System.Windows.Forms.Label();
            this.btnGuildWaitingClose = new System.Windows.Forms.Button();
            this.lblGuildWaitingTitle2 = new System.Windows.Forms.Label();
            this.gbGuildWaitingInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGuildWaitingInformations
            // 
            this.gbGuildWaitingInformations.Controls.Add(this.lblGuildWaitingTitle2);
            this.gbGuildWaitingInformations.Controls.Add(this.lblGuildWaitingTitle1);
            this.gbGuildWaitingInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGuildWaitingInformations.Location = new System.Drawing.Point(12, 12);
            this.gbGuildWaitingInformations.Name = "gbGuildWaitingInformations";
            this.gbGuildWaitingInformations.Size = new System.Drawing.Size(595, 232);
            this.gbGuildWaitingInformations.TabIndex = 0;
            this.gbGuildWaitingInformations.TabStop = false;
            this.gbGuildWaitingInformations.Text = "En attente d\'une guilde";
            // 
            // lblGuildWaitingTitle1
            // 
            this.lblGuildWaitingTitle1.AutoSize = true;
            this.lblGuildWaitingTitle1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuildWaitingTitle1.Location = new System.Drawing.Point(51, 72);
            this.lblGuildWaitingTitle1.Name = "lblGuildWaitingTitle1";
            this.lblGuildWaitingTitle1.Size = new System.Drawing.Size(472, 33);
            this.lblGuildWaitingTitle1.TabIndex = 0;
            this.lblGuildWaitingTitle1.Text = "Votre demande est en cours de validation";
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
            // lblGuildWaitingTitle2
            // 
            this.lblGuildWaitingTitle2.AutoSize = true;
            this.lblGuildWaitingTitle2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuildWaitingTitle2.Location = new System.Drawing.Point(51, 130);
            this.lblGuildWaitingTitle2.Name = "lblGuildWaitingTitle2";
            this.lblGuildWaitingTitle2.Size = new System.Drawing.Size(480, 33);
            this.lblGuildWaitingTitle2.TabIndex = 1;
            this.lblGuildWaitingTitle2.Text = "Merci de contacter votre Maître de guilde";
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
        private System.Windows.Forms.Label lblGuildWaitingTitle1;
        private System.Windows.Forms.Button btnGuildWaitingClose;
        private System.Windows.Forms.Label lblGuildWaitingTitle2;
    }
}