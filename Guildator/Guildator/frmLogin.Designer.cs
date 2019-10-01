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
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.btnLoginConnexion = new System.Windows.Forms.Button();
            this.lblkLoginRegistration = new System.Windows.Forms.LinkLabel();
            this.tbLoginIdentifiant = new System.Windows.Forms.TextBox();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Location = new System.Drawing.Point(95, 122);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(105, 17);
            this.lblLoginEmail.TabIndex = 0;
            this.lblLoginEmail.Text = "Adresse email :";
            // 
            // btnLoginConnexion
            // 
            this.btnLoginConnexion.Location = new System.Drawing.Point(153, 272);
            this.btnLoginConnexion.Name = "btnLoginConnexion";
            this.btnLoginConnexion.Size = new System.Drawing.Size(104, 26);
            this.btnLoginConnexion.TabIndex = 1;
            this.btnLoginConnexion.Text = "Connexion";
            this.btnLoginConnexion.UseVisualStyleBackColor = true;
            // 
            // lblkLoginRegistration
            // 
            this.lblkLoginRegistration.AutoSize = true;
            this.lblkLoginRegistration.Location = new System.Drawing.Point(105, 338);
            this.lblkLoginRegistration.Name = "lblkLoginRegistration";
            this.lblkLoginRegistration.Size = new System.Drawing.Size(218, 17);
            this.lblkLoginRegistration.TabIndex = 2;
            this.lblkLoginRegistration.TabStop = true;
            this.lblkLoginRegistration.Text = "Pas de compte ? Incrivez-vous ici";
            // 
            // tbLoginIdentifiant
            // 
            this.tbLoginIdentifiant.Location = new System.Drawing.Point(223, 119);
            this.tbLoginIdentifiant.Name = "tbLoginIdentifiant";
            this.tbLoginIdentifiant.Size = new System.Drawing.Size(100, 22);
            this.tbLoginIdentifiant.TabIndex = 3;
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(223, 177);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.Size = new System.Drawing.Size(100, 22);
            this.tbLoginPassword.TabIndex = 4;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(71, 177);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(101, 17);
            this.lblLoginPassword.TabIndex = 5;
            this.lblLoginPassword.Text = "Mot de passe :";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Location = new System.Drawing.Point(105, 52);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(207, 17);
            this.lblLoginTitle.TabIndex = 6;
            this.lblLoginTitle.Text = "Connectez vous à votre compte";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 466);
            this.Controls.Add(this.lblLoginTitle);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.tbLoginIdentifiant);
            this.Controls.Add(this.lblkLoginRegistration);
            this.Controls.Add(this.btnLoginConnexion);
            this.Controls.Add(this.lblLoginEmail);
            this.Name = "frmLogin";
            this.Text = "Page de connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.Button btnLoginConnexion;
        private System.Windows.Forms.LinkLabel lblkLoginRegistration;
        private System.Windows.Forms.TextBox tbLoginIdentifiant;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginTitle;
    }
}

