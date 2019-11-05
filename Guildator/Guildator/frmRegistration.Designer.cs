namespace Guildator
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.lblRegistrationEmail = new System.Windows.Forms.Label();
            this.lblRegistrationPassword = new System.Windows.Forms.Label();
            this.tbRegistrationEmail = new System.Windows.Forms.TextBox();
            this.tbRegistrationPassword = new System.Windows.Forms.TextBox();
            this.lblRegistrationCharacterFaction = new System.Windows.Forms.Label();
            this.rbRegistrationAlliance = new System.Windows.Forms.RadioButton();
            this.rbRegistrationHorde = new System.Windows.Forms.RadioButton();
            this.lblRegistrationCharacterRace = new System.Windows.Forms.Label();
            this.lbRegistrationCharacterRace = new System.Windows.Forms.ListBox();
            this.lblRegistrationCharacterClass = new System.Windows.Forms.Label();
            this.lbRegistrationCharacterClass = new System.Windows.Forms.ListBox();
            this.tbRegistrationCharacterName = new System.Windows.Forms.TextBox();
            this.lblRegistrationCharacterName = new System.Windows.Forms.Label();
            this.btnRegistrationNext = new System.Windows.Forms.Button();
            this.lblkRegistrationConnexion = new System.Windows.Forms.LinkLabel();
            this.lblRegistrationCharacterRole = new System.Windows.Forms.Label();
            this.btnRegistrationBack = new System.Windows.Forms.Button();
            this.gbRegistrationAccountInformations = new System.Windows.Forms.GroupBox();
            this.lblRegistrationAccountError = new System.Windows.Forms.Label();
            this.gbRegistrationPlayerInformations = new System.Windows.Forms.GroupBox();
            this.lblRegistrationCharacterError = new System.Windows.Forms.Label();
            this.rbRegistrationCharacterRoleDps = new System.Windows.Forms.RadioButton();
            this.rbRegistrationCharacterRoleHeal = new System.Windows.Forms.RadioButton();
            this.rbRegistrationCharacterRoleTank = new System.Windows.Forms.RadioButton();
            this.cbRegistrationGuildMaster = new System.Windows.Forms.CheckBox();
            this.gbRegistrationAccountInformations.SuspendLayout();
            this.gbRegistrationPlayerInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistrationEmail
            // 
            this.lblRegistrationEmail.AutoSize = true;
            this.lblRegistrationEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationEmail.Location = new System.Drawing.Point(42, 59);
            this.lblRegistrationEmail.Name = "lblRegistrationEmail";
            this.lblRegistrationEmail.Size = new System.Drawing.Size(135, 26);
            this.lblRegistrationEmail.TabIndex = 1;
            this.lblRegistrationEmail.Text = "Adresse mail :";
            // 
            // lblRegistrationPassword
            // 
            this.lblRegistrationPassword.AutoSize = true;
            this.lblRegistrationPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationPassword.Location = new System.Drawing.Point(42, 133);
            this.lblRegistrationPassword.Name = "lblRegistrationPassword";
            this.lblRegistrationPassword.Size = new System.Drawing.Size(140, 26);
            this.lblRegistrationPassword.TabIndex = 2;
            this.lblRegistrationPassword.Text = "Mot de passe :";
            // 
            // tbRegistrationEmail
            // 
            this.tbRegistrationEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegistrationEmail.Location = new System.Drawing.Point(197, 59);
            this.tbRegistrationEmail.Name = "tbRegistrationEmail";
            this.tbRegistrationEmail.Size = new System.Drawing.Size(200, 33);
            this.tbRegistrationEmail.TabIndex = 1;
            // 
            // tbRegistrationPassword
            // 
            this.tbRegistrationPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegistrationPassword.Location = new System.Drawing.Point(197, 133);
            this.tbRegistrationPassword.Name = "tbRegistrationPassword";
            this.tbRegistrationPassword.PasswordChar = '*';
            this.tbRegistrationPassword.Size = new System.Drawing.Size(200, 33);
            this.tbRegistrationPassword.TabIndex = 2;
            // 
            // lblRegistrationCharacterFaction
            // 
            this.lblRegistrationCharacterFaction.AutoSize = true;
            this.lblRegistrationCharacterFaction.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationCharacterFaction.Location = new System.Drawing.Point(42, 134);
            this.lblRegistrationCharacterFaction.Name = "lblRegistrationCharacterFaction";
            this.lblRegistrationCharacterFaction.Size = new System.Drawing.Size(88, 26);
            this.lblRegistrationCharacterFaction.TabIndex = 6;
            this.lblRegistrationCharacterFaction.Text = "Faction :";
            // 
            // rbRegistrationAlliance
            // 
            this.rbRegistrationAlliance.AutoSize = true;
            this.rbRegistrationAlliance.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegistrationAlliance.Location = new System.Drawing.Point(162, 134);
            this.rbRegistrationAlliance.Name = "rbRegistrationAlliance";
            this.rbRegistrationAlliance.Size = new System.Drawing.Size(100, 30);
            this.rbRegistrationAlliance.TabIndex = 7;
            this.rbRegistrationAlliance.TabStop = true;
            this.rbRegistrationAlliance.Text = "Alliance";
            this.rbRegistrationAlliance.UseVisualStyleBackColor = true;
            // 
            // rbRegistrationHorde
            // 
            this.rbRegistrationHorde.AutoSize = true;
            this.rbRegistrationHorde.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegistrationHorde.Location = new System.Drawing.Point(268, 134);
            this.rbRegistrationHorde.Name = "rbRegistrationHorde";
            this.rbRegistrationHorde.Size = new System.Drawing.Size(88, 30);
            this.rbRegistrationHorde.TabIndex = 8;
            this.rbRegistrationHorde.TabStop = true;
            this.rbRegistrationHorde.Text = "Horde";
            this.rbRegistrationHorde.UseVisualStyleBackColor = true;
            // 
            // lblRegistrationCharacterRace
            // 
            this.lblRegistrationCharacterRace.AutoSize = true;
            this.lblRegistrationCharacterRace.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationCharacterRace.Location = new System.Drawing.Point(42, 205);
            this.lblRegistrationCharacterRace.Name = "lblRegistrationCharacterRace";
            this.lblRegistrationCharacterRace.Size = new System.Drawing.Size(66, 26);
            this.lblRegistrationCharacterRace.TabIndex = 9;
            this.lblRegistrationCharacterRace.Text = "Race :";
            // 
            // lbRegistrationCharacterRace
            // 
            this.lbRegistrationCharacterRace.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistrationCharacterRace.FormattingEnabled = true;
            this.lbRegistrationCharacterRace.ItemHeight = 24;
            this.lbRegistrationCharacterRace.Items.AddRange(new object[] {
            "Sélectionnez une race",
            "Elfe de la nuit",
            "Gnome",
            "Humain",
            "Nain"});
            this.lbRegistrationCharacterRace.Location = new System.Drawing.Point(162, 205);
            this.lbRegistrationCharacterRace.Name = "lbRegistrationCharacterRace";
            this.lbRegistrationCharacterRace.Size = new System.Drawing.Size(224, 28);
            this.lbRegistrationCharacterRace.TabIndex = 10;
            // 
            // lblRegistrationCharacterClass
            // 
            this.lblRegistrationCharacterClass.AutoSize = true;
            this.lblRegistrationCharacterClass.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationCharacterClass.Location = new System.Drawing.Point(42, 274);
            this.lblRegistrationCharacterClass.Name = "lblRegistrationCharacterClass";
            this.lblRegistrationCharacterClass.Size = new System.Drawing.Size(84, 26);
            this.lblRegistrationCharacterClass.TabIndex = 11;
            this.lblRegistrationCharacterClass.Text = "Classe : ";
            // 
            // lbRegistrationCharacterClass
            // 
            this.lbRegistrationCharacterClass.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistrationCharacterClass.FormattingEnabled = true;
            this.lbRegistrationCharacterClass.ItemHeight = 24;
            this.lbRegistrationCharacterClass.Items.AddRange(new object[] {
            "Sélectionnez une classe",
            "Chasseur",
            "Voleur",
            "Démoniste",
            "Guerrier",
            "Paladin",
            "Chaman",
            "Druide",
            "Mage",
            "Prêtre"});
            this.lbRegistrationCharacterClass.Location = new System.Drawing.Point(162, 274);
            this.lbRegistrationCharacterClass.Name = "lbRegistrationCharacterClass";
            this.lbRegistrationCharacterClass.Size = new System.Drawing.Size(224, 28);
            this.lbRegistrationCharacterClass.TabIndex = 12;
            // 
            // tbRegistrationCharacterName
            // 
            this.tbRegistrationCharacterName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegistrationCharacterName.Location = new System.Drawing.Point(197, 67);
            this.tbRegistrationCharacterName.Name = "tbRegistrationCharacterName";
            this.tbRegistrationCharacterName.Size = new System.Drawing.Size(200, 33);
            this.tbRegistrationCharacterName.TabIndex = 3;
            // 
            // lblRegistrationCharacterName
            // 
            this.lblRegistrationCharacterName.AutoSize = true;
            this.lblRegistrationCharacterName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationCharacterName.Location = new System.Drawing.Point(42, 70);
            this.lblRegistrationCharacterName.Name = "lblRegistrationCharacterName";
            this.lblRegistrationCharacterName.Size = new System.Drawing.Size(64, 26);
            this.lblRegistrationCharacterName.TabIndex = 14;
            this.lblRegistrationCharacterName.Text = "Nom :";
            // 
            // btnRegistrationNext
            // 
            this.btnRegistrationNext.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrationNext.Location = new System.Drawing.Point(382, 747);
            this.btnRegistrationNext.Name = "btnRegistrationNext";
            this.btnRegistrationNext.Size = new System.Drawing.Size(120, 33);
            this.btnRegistrationNext.TabIndex = 15;
            this.btnRegistrationNext.Text = "Suivant";
            this.btnRegistrationNext.UseVisualStyleBackColor = true;
            this.btnRegistrationNext.Click += new System.EventHandler(this.btnRegistrationNext_Click);
            // 
            // lblkRegistrationConnexion
            // 
            this.lblkRegistrationConnexion.AutoSize = true;
            this.lblkRegistrationConnexion.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkRegistrationConnexion.Location = new System.Drawing.Point(52, 794);
            this.lblkRegistrationConnexion.Name = "lblkRegistrationConnexion";
            this.lblkRegistrationConnexion.Size = new System.Drawing.Size(438, 26);
            this.lblkRegistrationConnexion.TabIndex = 16;
            this.lblkRegistrationConnexion.TabStop = true;
            this.lblkRegistrationConnexion.Text = "Déjà un compte ? Cliquez ici pour vous connecter";
            this.lblkRegistrationConnexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkRegistrationConnexion_LinkClicked);
            // 
            // lblRegistrationCharacterRole
            // 
            this.lblRegistrationCharacterRole.AutoSize = true;
            this.lblRegistrationCharacterRole.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationCharacterRole.Location = new System.Drawing.Point(42, 336);
            this.lblRegistrationCharacterRole.Name = "lblRegistrationCharacterRole";
            this.lblRegistrationCharacterRole.Size = new System.Drawing.Size(61, 26);
            this.lblRegistrationCharacterRole.TabIndex = 17;
            this.lblRegistrationCharacterRole.Text = "Rôle :";
            // 
            // btnRegistrationBack
            // 
            this.btnRegistrationBack.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrationBack.Location = new System.Drawing.Point(35, 747);
            this.btnRegistrationBack.Name = "btnRegistrationBack";
            this.btnRegistrationBack.Size = new System.Drawing.Size(120, 33);
            this.btnRegistrationBack.TabIndex = 21;
            this.btnRegistrationBack.Text = "Retour";
            this.btnRegistrationBack.UseVisualStyleBackColor = true;
            this.btnRegistrationBack.Click += new System.EventHandler(this.btnRegistrationBack_Click);
            // 
            // gbRegistrationAccountInformations
            // 
            this.gbRegistrationAccountInformations.Controls.Add(this.lblRegistrationAccountError);
            this.gbRegistrationAccountInformations.Controls.Add(this.lblRegistrationEmail);
            this.gbRegistrationAccountInformations.Controls.Add(this.lblRegistrationPassword);
            this.gbRegistrationAccountInformations.Controls.Add(this.tbRegistrationEmail);
            this.gbRegistrationAccountInformations.Controls.Add(this.tbRegistrationPassword);
            this.gbRegistrationAccountInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrationAccountInformations.Location = new System.Drawing.Point(35, 35);
            this.gbRegistrationAccountInformations.Name = "gbRegistrationAccountInformations";
            this.gbRegistrationAccountInformations.Size = new System.Drawing.Size(467, 213);
            this.gbRegistrationAccountInformations.TabIndex = 23;
            this.gbRegistrationAccountInformations.TabStop = false;
            this.gbRegistrationAccountInformations.Text = "Informations du compte";
            // 
            // lblRegistrationAccountError
            // 
            this.lblRegistrationAccountError.AutoSize = true;
            this.lblRegistrationAccountError.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationAccountError.ForeColor = System.Drawing.Color.Red;
            this.lblRegistrationAccountError.Location = new System.Drawing.Point(47, 190);
            this.lblRegistrationAccountError.Name = "lblRegistrationAccountError";
            this.lblRegistrationAccountError.Size = new System.Drawing.Size(0, 19);
            this.lblRegistrationAccountError.TabIndex = 3;
            // 
            // gbRegistrationPlayerInformations
            // 
            this.gbRegistrationPlayerInformations.Controls.Add(this.lblRegistrationCharacterError);
            this.gbRegistrationPlayerInformations.Controls.Add(this.rbRegistrationCharacterRoleDps);
            this.gbRegistrationPlayerInformations.Controls.Add(this.rbRegistrationCharacterRoleHeal);
            this.gbRegistrationPlayerInformations.Controls.Add(this.rbRegistrationCharacterRoleTank);
            this.gbRegistrationPlayerInformations.Controls.Add(this.cbRegistrationGuildMaster);
            this.gbRegistrationPlayerInformations.Controls.Add(this.lblRegistrationCharacterName);
            this.gbRegistrationPlayerInformations.Controls.Add(this.tbRegistrationCharacterName);
            this.gbRegistrationPlayerInformations.Controls.Add(this.lblRegistrationCharacterFaction);
            this.gbRegistrationPlayerInformations.Controls.Add(this.rbRegistrationAlliance);
            this.gbRegistrationPlayerInformations.Controls.Add(this.rbRegistrationHorde);
            this.gbRegistrationPlayerInformations.Controls.Add(this.lblRegistrationCharacterRace);
            this.gbRegistrationPlayerInformations.Controls.Add(this.lbRegistrationCharacterRace);
            this.gbRegistrationPlayerInformations.Controls.Add(this.lblRegistrationCharacterRole);
            this.gbRegistrationPlayerInformations.Controls.Add(this.lblRegistrationCharacterClass);
            this.gbRegistrationPlayerInformations.Controls.Add(this.lbRegistrationCharacterClass);
            this.gbRegistrationPlayerInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrationPlayerInformations.Location = new System.Drawing.Point(35, 263);
            this.gbRegistrationPlayerInformations.Name = "gbRegistrationPlayerInformations";
            this.gbRegistrationPlayerInformations.Size = new System.Drawing.Size(467, 478);
            this.gbRegistrationPlayerInformations.TabIndex = 24;
            this.gbRegistrationPlayerInformations.TabStop = false;
            this.gbRegistrationPlayerInformations.Text = "Informations du personnage";
            // 
            // lblRegistrationCharacterError
            // 
            this.lblRegistrationCharacterError.AutoSize = true;
            this.lblRegistrationCharacterError.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationCharacterError.ForeColor = System.Drawing.Color.Red;
            this.lblRegistrationCharacterError.Location = new System.Drawing.Point(47, 428);
            this.lblRegistrationCharacterError.Name = "lblRegistrationCharacterError";
            this.lblRegistrationCharacterError.Size = new System.Drawing.Size(0, 19);
            this.lblRegistrationCharacterError.TabIndex = 27;
            // 
            // rbRegistrationCharacterRoleDps
            // 
            this.rbRegistrationCharacterRoleDps.AutoSize = true;
            this.rbRegistrationCharacterRoleDps.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegistrationCharacterRoleDps.Location = new System.Drawing.Point(316, 336);
            this.rbRegistrationCharacterRoleDps.Name = "rbRegistrationCharacterRoleDps";
            this.rbRegistrationCharacterRoleDps.Size = new System.Drawing.Size(70, 30);
            this.rbRegistrationCharacterRoleDps.TabIndex = 26;
            this.rbRegistrationCharacterRoleDps.TabStop = true;
            this.rbRegistrationCharacterRoleDps.Text = "DPS";
            this.rbRegistrationCharacterRoleDps.UseVisualStyleBackColor = true;
            // 
            // rbRegistrationCharacterRoleHeal
            // 
            this.rbRegistrationCharacterRoleHeal.AutoSize = true;
            this.rbRegistrationCharacterRoleHeal.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegistrationCharacterRoleHeal.Location = new System.Drawing.Point(227, 336);
            this.rbRegistrationCharacterRoleHeal.Name = "rbRegistrationCharacterRoleHeal";
            this.rbRegistrationCharacterRoleHeal.Size = new System.Drawing.Size(83, 30);
            this.rbRegistrationCharacterRoleHeal.TabIndex = 25;
            this.rbRegistrationCharacterRoleHeal.TabStop = true;
            this.rbRegistrationCharacterRoleHeal.Text = "HEAL";
            this.rbRegistrationCharacterRoleHeal.UseVisualStyleBackColor = true;
            // 
            // rbRegistrationCharacterRoleTank
            // 
            this.rbRegistrationCharacterRoleTank.AutoSize = true;
            this.rbRegistrationCharacterRoleTank.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegistrationCharacterRoleTank.Location = new System.Drawing.Point(135, 336);
            this.rbRegistrationCharacterRoleTank.Name = "rbRegistrationCharacterRoleTank";
            this.rbRegistrationCharacterRoleTank.Size = new System.Drawing.Size(86, 30);
            this.rbRegistrationCharacterRoleTank.TabIndex = 24;
            this.rbRegistrationCharacterRoleTank.TabStop = true;
            this.rbRegistrationCharacterRoleTank.Text = "TANK";
            this.rbRegistrationCharacterRoleTank.UseVisualStyleBackColor = true;
            // 
            // cbRegistrationGuildMaster
            // 
            this.cbRegistrationGuildMaster.AutoSize = true;
            this.cbRegistrationGuildMaster.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbRegistrationGuildMaster.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRegistrationGuildMaster.Location = new System.Drawing.Point(63, 389);
            this.cbRegistrationGuildMaster.Name = "cbRegistrationGuildMaster";
            this.cbRegistrationGuildMaster.Size = new System.Drawing.Size(309, 32);
            this.cbRegistrationGuildMaster.TabIndex = 23;
            this.cbRegistrationGuildMaster.Text = "* Je suis Maître d\'une guilde ";
            this.cbRegistrationGuildMaster.UseVisualStyleBackColor = true;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 841);
            this.Controls.Add(this.gbRegistrationPlayerInformations);
            this.Controls.Add(this.gbRegistrationAccountInformations);
            this.Controls.Add(this.btnRegistrationBack);
            this.Controls.Add(this.lblkRegistrationConnexion);
            this.Controls.Add(this.btnRegistrationNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistration";
            this.Text = "Page d\'inscription";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.gbRegistrationAccountInformations.ResumeLayout(false);
            this.gbRegistrationAccountInformations.PerformLayout();
            this.gbRegistrationPlayerInformations.ResumeLayout(false);
            this.gbRegistrationPlayerInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegistrationEmail;
        private System.Windows.Forms.Label lblRegistrationPassword;
        private System.Windows.Forms.TextBox tbRegistrationEmail;
        private System.Windows.Forms.TextBox tbRegistrationPassword;
        private System.Windows.Forms.Label lblRegistrationCharacterFaction;
        private System.Windows.Forms.RadioButton rbRegistrationAlliance;
        private System.Windows.Forms.RadioButton rbRegistrationHorde;
        private System.Windows.Forms.Label lblRegistrationCharacterRace;
        private System.Windows.Forms.ListBox lbRegistrationCharacterRace;
        private System.Windows.Forms.Label lblRegistrationCharacterClass;
        private System.Windows.Forms.ListBox lbRegistrationCharacterClass;
        private System.Windows.Forms.TextBox tbRegistrationCharacterName;
        private System.Windows.Forms.Label lblRegistrationCharacterName;
        private System.Windows.Forms.Button btnRegistrationNext;
        private System.Windows.Forms.LinkLabel lblkRegistrationConnexion;
        private System.Windows.Forms.Label lblRegistrationCharacterRole;
        private System.Windows.Forms.Button btnRegistrationBack;
        private System.Windows.Forms.GroupBox gbRegistrationAccountInformations;
        private System.Windows.Forms.GroupBox gbRegistrationPlayerInformations;
        private System.Windows.Forms.RadioButton rbRegistrationCharacterRoleDps;
        private System.Windows.Forms.RadioButton rbRegistrationCharacterRoleHeal;
        private System.Windows.Forms.RadioButton rbRegistrationCharacterRoleTank;
        private System.Windows.Forms.Label lblRegistrationAccountError;
        private System.Windows.Forms.Label lblRegistrationCharacterError;
        private System.Windows.Forms.CheckBox cbRegistrationGuildMaster;
    }
}