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
            this.lblRegistrationAccountInformations = new System.Windows.Forms.Label();
            this.lblRegistrationEmail = new System.Windows.Forms.Label();
            this.lblRegistrationPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblRegistrationCharacterTitle = new System.Windows.Forms.Label();
            this.lblRegistrationFaction = new System.Windows.Forms.Label();
            this.rbRegistrationAlliance = new System.Windows.Forms.RadioButton();
            this.rbRegistrationHorde = new System.Windows.Forms.RadioButton();
            this.lblRegistrationRace = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblRegistrationClass = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblRegistrationCharacterName = new System.Windows.Forms.Label();
            this.btnRegistrationNext = new System.Windows.Forms.Button();
            this.lblkRegistrationConnexion = new System.Windows.Forms.LinkLabel();
            this.lblRegistrationRole = new System.Windows.Forms.Label();
            this.cbRegistrationTank = new System.Windows.Forms.CheckBox();
            this.cbRegistrationDps = new System.Windows.Forms.CheckBox();
            this.cbRegistrationHeal = new System.Windows.Forms.CheckBox();
            this.btnRegistrationBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegistrationAccountInformations
            // 
            this.lblRegistrationAccountInformations.AutoSize = true;
            this.lblRegistrationAccountInformations.Location = new System.Drawing.Point(87, 28);
            this.lblRegistrationAccountInformations.Name = "lblRegistrationAccountInformations";
            this.lblRegistrationAccountInformations.Size = new System.Drawing.Size(217, 17);
            this.lblRegistrationAccountInformations.TabIndex = 0;
            this.lblRegistrationAccountInformations.Text = "Informations du compte Guildator";
            // 
            // lblRegistrationEmail
            // 
            this.lblRegistrationEmail.AutoSize = true;
            this.lblRegistrationEmail.Location = new System.Drawing.Point(52, 68);
            this.lblRegistrationEmail.Name = "lblRegistrationEmail";
            this.lblRegistrationEmail.Size = new System.Drawing.Size(97, 17);
            this.lblRegistrationEmail.TabIndex = 1;
            this.lblRegistrationEmail.Text = "Adresse mail :";
            // 
            // lblRegistrationPassword
            // 
            this.lblRegistrationPassword.AutoSize = true;
            this.lblRegistrationPassword.Location = new System.Drawing.Point(52, 133);
            this.lblRegistrationPassword.Name = "lblRegistrationPassword";
            this.lblRegistrationPassword.Size = new System.Drawing.Size(101, 17);
            this.lblRegistrationPassword.TabIndex = 2;
            this.lblRegistrationPassword.Text = "Mot de passe :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 4;
            // 
            // lblRegistrationCharacterTitle
            // 
            this.lblRegistrationCharacterTitle.AutoSize = true;
            this.lblRegistrationCharacterTitle.Location = new System.Drawing.Point(87, 192);
            this.lblRegistrationCharacterTitle.Name = "lblRegistrationCharacterTitle";
            this.lblRegistrationCharacterTitle.Size = new System.Drawing.Size(185, 17);
            this.lblRegistrationCharacterTitle.TabIndex = 5;
            this.lblRegistrationCharacterTitle.Text = "Informations du personnage";
            // 
            // lblRegistrationFaction
            // 
            this.lblRegistrationFaction.AutoSize = true;
            this.lblRegistrationFaction.Location = new System.Drawing.Point(52, 295);
            this.lblRegistrationFaction.Name = "lblRegistrationFaction";
            this.lblRegistrationFaction.Size = new System.Drawing.Size(62, 17);
            this.lblRegistrationFaction.TabIndex = 6;
            this.lblRegistrationFaction.Text = "Faction :";
            // 
            // rbRegistrationAlliance
            // 
            this.rbRegistrationAlliance.AutoSize = true;
            this.rbRegistrationAlliance.Location = new System.Drawing.Point(158, 295);
            this.rbRegistrationAlliance.Name = "rbRegistrationAlliance";
            this.rbRegistrationAlliance.Size = new System.Drawing.Size(78, 21);
            this.rbRegistrationAlliance.TabIndex = 7;
            this.rbRegistrationAlliance.TabStop = true;
            this.rbRegistrationAlliance.Text = "Alliance";
            this.rbRegistrationAlliance.UseVisualStyleBackColor = true;
            // 
            // rbRegistrationHorde
            // 
            this.rbRegistrationHorde.AutoSize = true;
            this.rbRegistrationHorde.Location = new System.Drawing.Point(242, 295);
            this.rbRegistrationHorde.Name = "rbRegistrationHorde";
            this.rbRegistrationHorde.Size = new System.Drawing.Size(68, 21);
            this.rbRegistrationHorde.TabIndex = 8;
            this.rbRegistrationHorde.TabStop = true;
            this.rbRegistrationHorde.Text = "Horde";
            this.rbRegistrationHorde.UseVisualStyleBackColor = true;
            // 
            // lblRegistrationRace
            // 
            this.lblRegistrationRace.AutoSize = true;
            this.lblRegistrationRace.Location = new System.Drawing.Point(52, 349);
            this.lblRegistrationRace.Name = "lblRegistrationRace";
            this.lblRegistrationRace.Size = new System.Drawing.Size(49, 17);
            this.lblRegistrationRace.TabIndex = 9;
            this.lblRegistrationRace.Text = "Race :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Sélectionnez une race",
            "Elfe de la nuit",
            "Gnome",
            "Humain",
            "Nain"});
            this.listBox1.Location = new System.Drawing.Point(158, 349);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 20);
            this.listBox1.TabIndex = 10;
            // 
            // lblRegistrationClass
            // 
            this.lblRegistrationClass.AutoSize = true;
            this.lblRegistrationClass.Location = new System.Drawing.Point(52, 403);
            this.lblRegistrationClass.Name = "lblRegistrationClass";
            this.lblRegistrationClass.Size = new System.Drawing.Size(62, 17);
            this.lblRegistrationClass.TabIndex = 11;
            this.lblRegistrationClass.Text = "Classe : ";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
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
            this.listBox2.Location = new System.Drawing.Point(158, 403);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(175, 20);
            this.listBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 22);
            this.textBox3.TabIndex = 13;
            // 
            // lblRegistrationCharacterName
            // 
            this.lblRegistrationCharacterName.AutoSize = true;
            this.lblRegistrationCharacterName.Location = new System.Drawing.Point(52, 241);
            this.lblRegistrationCharacterName.Name = "lblRegistrationCharacterName";
            this.lblRegistrationCharacterName.Size = new System.Drawing.Size(45, 17);
            this.lblRegistrationCharacterName.TabIndex = 14;
            this.lblRegistrationCharacterName.Text = "Nom :";
            // 
            // btnRegistrationNext
            // 
            this.btnRegistrationNext.Location = new System.Drawing.Point(242, 593);
            this.btnRegistrationNext.Name = "btnRegistrationNext";
            this.btnRegistrationNext.Size = new System.Drawing.Size(84, 27);
            this.btnRegistrationNext.TabIndex = 15;
            this.btnRegistrationNext.Text = "Suivant";
            this.btnRegistrationNext.UseVisualStyleBackColor = true;
            // 
            // lblkRegistrationConnexion
            // 
            this.lblkRegistrationConnexion.AutoSize = true;
            this.lblkRegistrationConnexion.Location = new System.Drawing.Point(41, 645);
            this.lblkRegistrationConnexion.Name = "lblkRegistrationConnexion";
            this.lblkRegistrationConnexion.Size = new System.Drawing.Size(320, 17);
            this.lblkRegistrationConnexion.TabIndex = 16;
            this.lblkRegistrationConnexion.TabStop = true;
            this.lblkRegistrationConnexion.Text = "Déjà un compte ? Cliquez ici pour vous connecter";
            // 
            // lblRegistrationRole
            // 
            this.lblRegistrationRole.AutoSize = true;
            this.lblRegistrationRole.Location = new System.Drawing.Point(52, 465);
            this.lblRegistrationRole.Name = "lblRegistrationRole";
            this.lblRegistrationRole.Size = new System.Drawing.Size(45, 17);
            this.lblRegistrationRole.TabIndex = 17;
            this.lblRegistrationRole.Text = "Rôle :";
            // 
            // cbRegistrationTank
            // 
            this.cbRegistrationTank.AutoSize = true;
            this.cbRegistrationTank.Location = new System.Drawing.Point(158, 465);
            this.cbRegistrationTank.Name = "cbRegistrationTank";
            this.cbRegistrationTank.Size = new System.Drawing.Size(67, 21);
            this.cbRegistrationTank.TabIndex = 18;
            this.cbRegistrationTank.Text = "TANK";
            this.cbRegistrationTank.UseVisualStyleBackColor = true;
            // 
            // cbRegistrationDps
            // 
            this.cbRegistrationDps.AutoSize = true;
            this.cbRegistrationDps.Location = new System.Drawing.Point(300, 465);
            this.cbRegistrationDps.Name = "cbRegistrationDps";
            this.cbRegistrationDps.Size = new System.Drawing.Size(58, 21);
            this.cbRegistrationDps.TabIndex = 19;
            this.cbRegistrationDps.Text = "DPS";
            this.cbRegistrationDps.UseVisualStyleBackColor = true;
            // 
            // cbRegistrationHeal
            // 
            this.cbRegistrationHeal.AutoSize = true;
            this.cbRegistrationHeal.Location = new System.Drawing.Point(228, 465);
            this.cbRegistrationHeal.Name = "cbRegistrationHeal";
            this.cbRegistrationHeal.Size = new System.Drawing.Size(66, 21);
            this.cbRegistrationHeal.TabIndex = 20;
            this.cbRegistrationHeal.Text = "HEAL";
            this.cbRegistrationHeal.UseVisualStyleBackColor = true;
            // 
            // btnRegistrationBack
            // 
            this.btnRegistrationBack.Location = new System.Drawing.Point(90, 593);
            this.btnRegistrationBack.Name = "btnRegistrationBack";
            this.btnRegistrationBack.Size = new System.Drawing.Size(82, 27);
            this.btnRegistrationBack.TabIndex = 21;
            this.btnRegistrationBack.Text = "Retour";
            this.btnRegistrationBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrationBack);
            this.Controls.Add(this.cbRegistrationHeal);
            this.Controls.Add(this.cbRegistrationDps);
            this.Controls.Add(this.cbRegistrationTank);
            this.Controls.Add(this.lblRegistrationRole);
            this.Controls.Add(this.lblkRegistrationConnexion);
            this.Controls.Add(this.btnRegistrationNext);
            this.Controls.Add(this.lblRegistrationCharacterName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblRegistrationClass);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblRegistrationRace);
            this.Controls.Add(this.rbRegistrationHorde);
            this.Controls.Add(this.rbRegistrationAlliance);
            this.Controls.Add(this.lblRegistrationFaction);
            this.Controls.Add(this.lblRegistrationCharacterTitle);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRegistrationPassword);
            this.Controls.Add(this.lblRegistrationEmail);
            this.Controls.Add(this.lblRegistrationAccountInformations);
            this.Name = "frmRegistration";
            this.Text = "Page d\'inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrationAccountInformations;
        private System.Windows.Forms.Label lblRegistrationEmail;
        private System.Windows.Forms.Label lblRegistrationPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblRegistrationCharacterTitle;
        private System.Windows.Forms.Label lblRegistrationFaction;
        private System.Windows.Forms.RadioButton rbRegistrationAlliance;
        private System.Windows.Forms.RadioButton rbRegistrationHorde;
        private System.Windows.Forms.Label lblRegistrationRace;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblRegistrationClass;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblRegistrationCharacterName;
        private System.Windows.Forms.Button btnRegistrationNext;
        private System.Windows.Forms.LinkLabel lblkRegistrationConnexion;
        private System.Windows.Forms.Label lblRegistrationRole;
        private System.Windows.Forms.CheckBox cbRegistrationTank;
        private System.Windows.Forms.CheckBox cbRegistrationDps;
        private System.Windows.Forms.CheckBox cbRegistrationHeal;
        private System.Windows.Forms.Button btnRegistrationBack;
        private System.Windows.Forms.Label label1;
    }
}