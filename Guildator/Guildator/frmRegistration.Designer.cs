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
            this.btnRegistrationConfirmation = new System.Windows.Forms.Button();
            this.lblkRegistrationConnexion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblRegistrationAccountInformations
            // 
            this.lblRegistrationAccountInformations.AutoSize = true;
            this.lblRegistrationAccountInformations.Location = new System.Drawing.Point(87, 48);
            this.lblRegistrationAccountInformations.Name = "lblRegistrationAccountInformations";
            this.lblRegistrationAccountInformations.Size = new System.Drawing.Size(217, 17);
            this.lblRegistrationAccountInformations.TabIndex = 0;
            this.lblRegistrationAccountInformations.Text = "Informations du compte Guildator";
            // 
            // lblRegistrationEmail
            // 
            this.lblRegistrationEmail.AutoSize = true;
            this.lblRegistrationEmail.Location = new System.Drawing.Point(52, 122);
            this.lblRegistrationEmail.Name = "lblRegistrationEmail";
            this.lblRegistrationEmail.Size = new System.Drawing.Size(97, 17);
            this.lblRegistrationEmail.TabIndex = 1;
            this.lblRegistrationEmail.Text = "Adresse mail :";
            // 
            // lblRegistrationPassword
            // 
            this.lblRegistrationPassword.AutoSize = true;
            this.lblRegistrationPassword.Location = new System.Drawing.Point(52, 164);
            this.lblRegistrationPassword.Name = "lblRegistrationPassword";
            this.lblRegistrationPassword.Size = new System.Drawing.Size(101, 17);
            this.lblRegistrationPassword.TabIndex = 2;
            this.lblRegistrationPassword.Text = "Mot de passe :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 4;
            // 
            // lblRegistrationCharacterTitle
            // 
            this.lblRegistrationCharacterTitle.AutoSize = true;
            this.lblRegistrationCharacterTitle.Location = new System.Drawing.Point(87, 240);
            this.lblRegistrationCharacterTitle.Name = "lblRegistrationCharacterTitle";
            this.lblRegistrationCharacterTitle.Size = new System.Drawing.Size(185, 17);
            this.lblRegistrationCharacterTitle.TabIndex = 5;
            this.lblRegistrationCharacterTitle.Text = "Informations du personnage";
            // 
            // lblRegistrationFaction
            // 
            this.lblRegistrationFaction.AutoSize = true;
            this.lblRegistrationFaction.Location = new System.Drawing.Point(52, 361);
            this.lblRegistrationFaction.Name = "lblRegistrationFaction";
            this.lblRegistrationFaction.Size = new System.Drawing.Size(62, 17);
            this.lblRegistrationFaction.TabIndex = 6;
            this.lblRegistrationFaction.Text = "Faction :";
            // 
            // rbRegistrationAlliance
            // 
            this.rbRegistrationAlliance.AutoSize = true;
            this.rbRegistrationAlliance.Location = new System.Drawing.Point(158, 357);
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
            this.rbRegistrationHorde.Location = new System.Drawing.Point(242, 357);
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
            this.lblRegistrationRace.Location = new System.Drawing.Point(52, 426);
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
            this.listBox1.Location = new System.Drawing.Point(158, 426);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 20);
            this.listBox1.TabIndex = 10;
            // 
            // lblRegistrationClass
            // 
            this.lblRegistrationClass.AutoSize = true;
            this.lblRegistrationClass.Location = new System.Drawing.Point(52, 481);
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
            this.listBox2.Location = new System.Drawing.Point(158, 481);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(175, 20);
            this.listBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 298);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 22);
            this.textBox3.TabIndex = 13;
            // 
            // lblRegistrationCharacterName
            // 
            this.lblRegistrationCharacterName.AutoSize = true;
            this.lblRegistrationCharacterName.Location = new System.Drawing.Point(52, 301);
            this.lblRegistrationCharacterName.Name = "lblRegistrationCharacterName";
            this.lblRegistrationCharacterName.Size = new System.Drawing.Size(45, 17);
            this.lblRegistrationCharacterName.TabIndex = 14;
            this.lblRegistrationCharacterName.Text = "Nom :";
            // 
            // btnRegistrationConfirmation
            // 
            this.btnRegistrationConfirmation.Location = new System.Drawing.Point(133, 547);
            this.btnRegistrationConfirmation.Name = "btnRegistrationConfirmation";
            this.btnRegistrationConfirmation.Size = new System.Drawing.Size(86, 27);
            this.btnRegistrationConfirmation.TabIndex = 15;
            this.btnRegistrationConfirmation.Text = "S\'inscrire";
            this.btnRegistrationConfirmation.UseVisualStyleBackColor = true;
            // 
            // lblkRegistrationConnexion
            // 
            this.lblkRegistrationConnexion.AutoSize = true;
            this.lblkRegistrationConnexion.Location = new System.Drawing.Point(42, 613);
            this.lblkRegistrationConnexion.Name = "lblkRegistrationConnexion";
            this.lblkRegistrationConnexion.Size = new System.Drawing.Size(320, 17);
            this.lblkRegistrationConnexion.TabIndex = 16;
            this.lblkRegistrationConnexion.TabStop = true;
            this.lblkRegistrationConnexion.Text = "Déjà un compte ? Cliquez ici pour vous connecter";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 700);
            this.Controls.Add(this.lblkRegistrationConnexion);
            this.Controls.Add(this.btnRegistrationConfirmation);
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
        private System.Windows.Forms.Button btnRegistrationConfirmation;
        private System.Windows.Forms.LinkLabel lblkRegistrationConnexion;
    }
}