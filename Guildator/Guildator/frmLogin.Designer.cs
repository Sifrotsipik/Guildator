namespace Guildator
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblLoginEmailTitle = new System.Windows.Forms.Label();
            this.btnLoginConnexion = new System.Windows.Forms.Button();
            this.lblkLoginRegistration = new System.Windows.Forms.LinkLabel();
            this.tbLoginEmail = new System.Windows.Forms.TextBox();
            this.lblLoginPasswordTitle = new System.Windows.Forms.Label();
            this.gbLoginInformations = new System.Windows.Forms.GroupBox();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.gbLoginInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginEmailTitle
            // 
            this.lblLoginEmailTitle.AutoSize = true;
            this.lblLoginEmailTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEmailTitle.Location = new System.Drawing.Point(44, 103);
            this.lblLoginEmailTitle.Name = "lblLoginEmailTitle";
            this.lblLoginEmailTitle.Size = new System.Drawing.Size(145, 26);
            this.lblLoginEmailTitle.TabIndex = 0;
            this.lblLoginEmailTitle.Text = "Adresse email :";
            // 
            // btnLoginConnexion
            // 
            this.btnLoginConnexion.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginConnexion.Location = new System.Drawing.Point(177, 394);
            this.btnLoginConnexion.Name = "btnLoginConnexion";
            this.btnLoginConnexion.Size = new System.Drawing.Size(120, 35);
            this.btnLoginConnexion.TabIndex = 1;
            this.btnLoginConnexion.Text = "Connexion";
            this.btnLoginConnexion.UseVisualStyleBackColor = true;
            this.btnLoginConnexion.Click += new System.EventHandler(this.btnLoginConnexion_Click);
            // 
            // lblkLoginRegistration
            // 
            this.lblkLoginRegistration.AutoSize = true;
            this.lblkLoginRegistration.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkLoginRegistration.Location = new System.Drawing.Point(99, 482);
            this.lblkLoginRegistration.Name = "lblkLoginRegistration";
            this.lblkLoginRegistration.Size = new System.Drawing.Size(302, 26);
            this.lblkLoginRegistration.TabIndex = 2;
            this.lblkLoginRegistration.TabStop = true;
            this.lblkLoginRegistration.Text = "Pas de compte ? Incrivez-vous ici";
            this.lblkLoginRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkLoginRegistration_LinkClicked);
            // 
            // tbLoginEmail
            // 
            this.tbLoginEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginEmail.Location = new System.Drawing.Point(209, 103);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(200, 33);
            this.tbLoginEmail.TabIndex = 1;
            // 
            // lblLoginPasswordTitle
            // 
            this.lblLoginPasswordTitle.AutoSize = true;
            this.lblLoginPasswordTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPasswordTitle.Location = new System.Drawing.Point(44, 207);
            this.lblLoginPasswordTitle.Name = "lblLoginPasswordTitle";
            this.lblLoginPasswordTitle.Size = new System.Drawing.Size(140, 26);
            this.lblLoginPasswordTitle.TabIndex = 5;
            this.lblLoginPasswordTitle.Text = "Mot de passe :";
            // 
            // gbLoginInformations
            // 
            this.gbLoginInformations.Controls.Add(this.lblLoginError);
            this.gbLoginInformations.Controls.Add(this.tbLoginPassword);
            this.gbLoginInformations.Controls.Add(this.lblLoginEmailTitle);
            this.gbLoginInformations.Controls.Add(this.lblLoginPasswordTitle);
            this.gbLoginInformations.Controls.Add(this.tbLoginEmail);
            this.gbLoginInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoginInformations.Location = new System.Drawing.Point(27, 49);
            this.gbLoginInformations.Name = "gbLoginInformations";
            this.gbLoginInformations.Size = new System.Drawing.Size(455, 307);
            this.gbLoginInformations.TabIndex = 7;
            this.gbLoginInformations.TabStop = false;
            this.gbLoginInformations.Text = "Connectez-vous à votre compte";
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
            this.lblLoginError.Location = new System.Drawing.Point(44, 260);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(0, 19);
            this.lblLoginError.TabIndex = 6;
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginPassword.Location = new System.Drawing.Point(209, 207);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(200, 33);
            this.tbLoginPassword.TabIndex = 2;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 573);
            this.Controls.Add(this.gbLoginInformations);
            this.Controls.Add(this.lblkLoginRegistration);
            this.Controls.Add(this.btnLoginConnexion);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "Page de connexion";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.gbLoginInformations.ResumeLayout(false);
            this.gbLoginInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginEmailTitle;
        private System.Windows.Forms.Button btnLoginConnexion;
        private System.Windows.Forms.LinkLabel lblkLoginRegistration;
        private System.Windows.Forms.TextBox tbLoginEmail;
        private System.Windows.Forms.Label lblLoginPasswordTitle;
        private System.Windows.Forms.GroupBox gbLoginInformations;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.Label lblLoginError;
    }
}

