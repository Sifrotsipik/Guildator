namespace Guildator
{
    partial class frmProfilPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfilPlayer));
            this.gbProfilPlayerAccountIntomations = new System.Windows.Forms.GroupBox();
            this.tbProfilPlayerPassword = new System.Windows.Forms.TextBox();
            this.lblProfilPlayerPasswordTitle = new System.Windows.Forms.Label();
            this.tbProfilPlayerEmail = new System.Windows.Forms.TextBox();
            this.lblProfilPlayerEmailTitle = new System.Windows.Forms.Label();
            this.gbProfilPlayerCharacterInformations = new System.Windows.Forms.GroupBox();
            this.btnProfilPlayerAccountDelete = new System.Windows.Forms.Button();
            this.rbProfilPlayerDps = new System.Windows.Forms.RadioButton();
            this.rbProfilPlayerHeal = new System.Windows.Forms.RadioButton();
            this.rbProfilPlayerTank = new System.Windows.Forms.RadioButton();
            this.lblProfilPlayerCharacterNameTitle = new System.Windows.Forms.Label();
            this.tbProfilPlayerCharacterName = new System.Windows.Forms.TextBox();
            this.lblProfilPlayerFactionTitle = new System.Windows.Forms.Label();
            this.rbProfilPlayerAlliance = new System.Windows.Forms.RadioButton();
            this.rbProfilPlayerHorde = new System.Windows.Forms.RadioButton();
            this.lblProfilPlayerRaceTitle = new System.Windows.Forms.Label();
            this.lbProfilPlayerRace = new System.Windows.Forms.ListBox();
            this.lblProfilPlayerRoleTitle = new System.Windows.Forms.Label();
            this.lblProfilPlayerClassTitle = new System.Windows.Forms.Label();
            this.lbProfilPlayerClass = new System.Windows.Forms.ListBox();
            this.btnProfilPlayerSave = new System.Windows.Forms.Button();
            this.btnProfilPlayerClose = new System.Windows.Forms.Button();
            this.gbProfilPlayerGuildInformations = new System.Windows.Forms.GroupBox();
            this.lblProfilPlayerGrade = new System.Windows.Forms.Label();
            this.lblProfilPlayerGradeTitle = new System.Windows.Forms.Label();
            this.lblProfilPlayerGuildName = new System.Windows.Forms.Label();
            this.btnProfilPlayerGuildQuit = new System.Windows.Forms.Button();
            this.lblProfilPlayerGuildNameTitle = new System.Windows.Forms.Label();
            this.gbProfilPlayerAccountIntomations.SuspendLayout();
            this.gbProfilPlayerCharacterInformations.SuspendLayout();
            this.gbProfilPlayerGuildInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProfilPlayerAccountIntomations
            // 
            this.gbProfilPlayerAccountIntomations.Controls.Add(this.tbProfilPlayerPassword);
            this.gbProfilPlayerAccountIntomations.Controls.Add(this.lblProfilPlayerPasswordTitle);
            this.gbProfilPlayerAccountIntomations.Controls.Add(this.tbProfilPlayerEmail);
            this.gbProfilPlayerAccountIntomations.Controls.Add(this.lblProfilPlayerEmailTitle);
            this.gbProfilPlayerAccountIntomations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProfilPlayerAccountIntomations.Location = new System.Drawing.Point(24, 13);
            this.gbProfilPlayerAccountIntomations.Name = "gbProfilPlayerAccountIntomations";
            this.gbProfilPlayerAccountIntomations.Size = new System.Drawing.Size(435, 160);
            this.gbProfilPlayerAccountIntomations.TabIndex = 0;
            this.gbProfilPlayerAccountIntomations.TabStop = false;
            this.gbProfilPlayerAccountIntomations.Text = "Informations du compte";
            // 
            // tbProfilPlayerPassword
            // 
            this.tbProfilPlayerPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfilPlayerPassword.Location = new System.Drawing.Point(183, 104);
            this.tbProfilPlayerPassword.Name = "tbProfilPlayerPassword";
            this.tbProfilPlayerPassword.Size = new System.Drawing.Size(228, 33);
            this.tbProfilPlayerPassword.TabIndex = 3;
            this.tbProfilPlayerPassword.Text = "************";
            // 
            // lblProfilPlayerPasswordTitle
            // 
            this.lblProfilPlayerPasswordTitle.AutoSize = true;
            this.lblProfilPlayerPasswordTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPlayerPasswordTitle.Location = new System.Drawing.Point(36, 107);
            this.lblProfilPlayerPasswordTitle.Name = "lblProfilPlayerPasswordTitle";
            this.lblProfilPlayerPasswordTitle.Size = new System.Drawing.Size(146, 26);
            this.lblProfilPlayerPasswordTitle.TabIndex = 2;
            this.lblProfilPlayerPasswordTitle.Text = "Mot de passe : ";
            // 
            // tbProfilPlayerEmail
            // 
            this.tbProfilPlayerEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfilPlayerEmail.Location = new System.Drawing.Point(183, 58);
            this.tbProfilPlayerEmail.Name = "tbProfilPlayerEmail";
            this.tbProfilPlayerEmail.Size = new System.Drawing.Size(228, 33);
            this.tbProfilPlayerEmail.TabIndex = 1;
            this.tbProfilPlayerEmail.Text = "player@exemple.ch";
            this.tbProfilPlayerEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblProfilPlayerEmailTitle
            // 
            this.lblProfilPlayerEmailTitle.AutoSize = true;
            this.lblProfilPlayerEmailTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPlayerEmailTitle.Location = new System.Drawing.Point(32, 58);
            this.lblProfilPlayerEmailTitle.Name = "lblProfilPlayerEmailTitle";
            this.lblProfilPlayerEmailTitle.Size = new System.Drawing.Size(145, 26);
            this.lblProfilPlayerEmailTitle.TabIndex = 0;
            this.lblProfilPlayerEmailTitle.Text = "Adresse email :";
            // 
            // gbProfilPlayerCharacterInformations
            // 
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.btnProfilPlayerAccountDelete);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.rbProfilPlayerDps);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.rbProfilPlayerHeal);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.rbProfilPlayerTank);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.lblProfilPlayerCharacterNameTitle);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.tbProfilPlayerCharacterName);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.lblProfilPlayerFactionTitle);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.rbProfilPlayerAlliance);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.rbProfilPlayerHorde);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.lblProfilPlayerRaceTitle);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.lbProfilPlayerRace);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.lblProfilPlayerRoleTitle);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.lblProfilPlayerClassTitle);
            this.gbProfilPlayerCharacterInformations.Controls.Add(this.lbProfilPlayerClass);
            this.gbProfilPlayerCharacterInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProfilPlayerCharacterInformations.Location = new System.Drawing.Point(24, 179);
            this.gbProfilPlayerCharacterInformations.Name = "gbProfilPlayerCharacterInformations";
            this.gbProfilPlayerCharacterInformations.Size = new System.Drawing.Size(435, 368);
            this.gbProfilPlayerCharacterInformations.TabIndex = 1;
            this.gbProfilPlayerCharacterInformations.TabStop = false;
            this.gbProfilPlayerCharacterInformations.Text = "Informations du personnage";
            // 
            // btnProfilPlayerAccountDelete
            // 
            this.btnProfilPlayerAccountDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfilPlayerAccountDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilPlayerAccountDelete.ForeColor = System.Drawing.Color.Red;
            this.btnProfilPlayerAccountDelete.Location = new System.Drawing.Point(187, 313);
            this.btnProfilPlayerAccountDelete.Name = "btnProfilPlayerAccountDelete";
            this.btnProfilPlayerAccountDelete.Size = new System.Drawing.Size(215, 34);
            this.btnProfilPlayerAccountDelete.TabIndex = 37;
            this.btnProfilPlayerAccountDelete.Text = "Supprimer le compte";
            this.btnProfilPlayerAccountDelete.UseVisualStyleBackColor = false;
            this.btnProfilPlayerAccountDelete.Click += new System.EventHandler(this.btnProfilPlayerAccountDelete_Click);
            // 
            // rbProfilPlayerDps
            // 
            this.rbProfilPlayerDps.AutoSize = true;
            this.rbProfilPlayerDps.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProfilPlayerDps.Location = new System.Drawing.Point(309, 268);
            this.rbProfilPlayerDps.Name = "rbProfilPlayerDps";
            this.rbProfilPlayerDps.Size = new System.Drawing.Size(70, 30);
            this.rbProfilPlayerDps.TabIndex = 36;
            this.rbProfilPlayerDps.TabStop = true;
            this.rbProfilPlayerDps.Text = "DPS";
            this.rbProfilPlayerDps.UseVisualStyleBackColor = true;
            // 
            // rbProfilPlayerHeal
            // 
            this.rbProfilPlayerHeal.AutoSize = true;
            this.rbProfilPlayerHeal.Checked = true;
            this.rbProfilPlayerHeal.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProfilPlayerHeal.Location = new System.Drawing.Point(220, 268);
            this.rbProfilPlayerHeal.Name = "rbProfilPlayerHeal";
            this.rbProfilPlayerHeal.Size = new System.Drawing.Size(83, 30);
            this.rbProfilPlayerHeal.TabIndex = 35;
            this.rbProfilPlayerHeal.TabStop = true;
            this.rbProfilPlayerHeal.Text = "HEAL";
            this.rbProfilPlayerHeal.UseVisualStyleBackColor = true;
            // 
            // rbProfilPlayerTank
            // 
            this.rbProfilPlayerTank.AutoSize = true;
            this.rbProfilPlayerTank.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProfilPlayerTank.Location = new System.Drawing.Point(128, 268);
            this.rbProfilPlayerTank.Name = "rbProfilPlayerTank";
            this.rbProfilPlayerTank.Size = new System.Drawing.Size(86, 30);
            this.rbProfilPlayerTank.TabIndex = 34;
            this.rbProfilPlayerTank.TabStop = true;
            this.rbProfilPlayerTank.Text = "TANK";
            this.rbProfilPlayerTank.UseVisualStyleBackColor = true;
            // 
            // lblProfilPlayerCharacterNameTitle
            // 
            this.lblProfilPlayerCharacterNameTitle.AutoSize = true;
            this.lblProfilPlayerCharacterNameTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPlayerCharacterNameTitle.Location = new System.Drawing.Point(32, 50);
            this.lblProfilPlayerCharacterNameTitle.Name = "lblProfilPlayerCharacterNameTitle";
            this.lblProfilPlayerCharacterNameTitle.Size = new System.Drawing.Size(64, 26);
            this.lblProfilPlayerCharacterNameTitle.TabIndex = 32;
            this.lblProfilPlayerCharacterNameTitle.Text = "Nom :";
            // 
            // tbProfilPlayerCharacterName
            // 
            this.tbProfilPlayerCharacterName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfilPlayerCharacterName.Location = new System.Drawing.Point(187, 47);
            this.tbProfilPlayerCharacterName.Name = "tbProfilPlayerCharacterName";
            this.tbProfilPlayerCharacterName.Size = new System.Drawing.Size(200, 33);
            this.tbProfilPlayerCharacterName.TabIndex = 31;
            this.tbProfilPlayerCharacterName.Text = "NomDePersonnage";
            // 
            // lblProfilPlayerFactionTitle
            // 
            this.lblProfilPlayerFactionTitle.AutoSize = true;
            this.lblProfilPlayerFactionTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPlayerFactionTitle.Location = new System.Drawing.Point(32, 95);
            this.lblProfilPlayerFactionTitle.Name = "lblProfilPlayerFactionTitle";
            this.lblProfilPlayerFactionTitle.Size = new System.Drawing.Size(88, 26);
            this.lblProfilPlayerFactionTitle.TabIndex = 24;
            this.lblProfilPlayerFactionTitle.Text = "Faction :";
            // 
            // rbProfilPlayerAlliance
            // 
            this.rbProfilPlayerAlliance.AutoSize = true;
            this.rbProfilPlayerAlliance.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProfilPlayerAlliance.Location = new System.Drawing.Point(152, 95);
            this.rbProfilPlayerAlliance.Name = "rbProfilPlayerAlliance";
            this.rbProfilPlayerAlliance.Size = new System.Drawing.Size(100, 30);
            this.rbProfilPlayerAlliance.TabIndex = 25;
            this.rbProfilPlayerAlliance.Text = "Alliance";
            this.rbProfilPlayerAlliance.UseVisualStyleBackColor = true;
            // 
            // rbProfilPlayerHorde
            // 
            this.rbProfilPlayerHorde.AutoSize = true;
            this.rbProfilPlayerHorde.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProfilPlayerHorde.Location = new System.Drawing.Point(258, 95);
            this.rbProfilPlayerHorde.Name = "rbProfilPlayerHorde";
            this.rbProfilPlayerHorde.Size = new System.Drawing.Size(88, 30);
            this.rbProfilPlayerHorde.TabIndex = 26;
            this.rbProfilPlayerHorde.TabStop = true;
            this.rbProfilPlayerHorde.Text = "Horde";
            this.rbProfilPlayerHorde.UseVisualStyleBackColor = true;
            // 
            // lblProfilPlayerRaceTitle
            // 
            this.lblProfilPlayerRaceTitle.AutoSize = true;
            this.lblProfilPlayerRaceTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPlayerRaceTitle.Location = new System.Drawing.Point(32, 141);
            this.lblProfilPlayerRaceTitle.Name = "lblProfilPlayerRaceTitle";
            this.lblProfilPlayerRaceTitle.Size = new System.Drawing.Size(66, 26);
            this.lblProfilPlayerRaceTitle.TabIndex = 27;
            this.lblProfilPlayerRaceTitle.Text = "Race :";
            // 
            // lbProfilPlayerRace
            // 
            this.lbProfilPlayerRace.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfilPlayerRace.FormattingEnabled = true;
            this.lbProfilPlayerRace.ItemHeight = 24;
            this.lbProfilPlayerRace.Items.AddRange(new object[] {
            "Nain",
            "Elfe de la nuit",
            "Gnome",
            "Humain"});
            this.lbProfilPlayerRace.Location = new System.Drawing.Point(152, 141);
            this.lbProfilPlayerRace.Name = "lbProfilPlayerRace";
            this.lbProfilPlayerRace.Size = new System.Drawing.Size(224, 28);
            this.lbProfilPlayerRace.TabIndex = 28;
            // 
            // lblProfilPlayerRoleTitle
            // 
            this.lblProfilPlayerRoleTitle.AutoSize = true;
            this.lblProfilPlayerRoleTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPlayerRoleTitle.Location = new System.Drawing.Point(32, 268);
            this.lblProfilPlayerRoleTitle.Name = "lblProfilPlayerRoleTitle";
            this.lblProfilPlayerRoleTitle.Size = new System.Drawing.Size(61, 26);
            this.lblProfilPlayerRoleTitle.TabIndex = 33;
            this.lblProfilPlayerRoleTitle.Text = "Rôle :";
            // 
            // lblProfilPlayerClassTitle
            // 
            this.lblProfilPlayerClassTitle.AutoSize = true;
            this.lblProfilPlayerClassTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPlayerClassTitle.Location = new System.Drawing.Point(32, 201);
            this.lblProfilPlayerClassTitle.Name = "lblProfilPlayerClassTitle";
            this.lblProfilPlayerClassTitle.Size = new System.Drawing.Size(84, 26);
            this.lblProfilPlayerClassTitle.TabIndex = 29;
            this.lblProfilPlayerClassTitle.Text = "Classe : ";
            // 
            // lbProfilPlayerClass
            // 
            this.lbProfilPlayerClass.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfilPlayerClass.FormattingEnabled = true;
            this.lbProfilPlayerClass.ItemHeight = 24;
            this.lbProfilPlayerClass.Items.AddRange(new object[] {
            "Prêtre",
            "Chasseur",
            "Voleur",
            "Démoniste",
            "Guerrier",
            "Paladin",
            "Chaman",
            "Druide",
            "Mage"});
            this.lbProfilPlayerClass.Location = new System.Drawing.Point(152, 201);
            this.lbProfilPlayerClass.Name = "lbProfilPlayerClass";
            this.lbProfilPlayerClass.Size = new System.Drawing.Size(224, 28);
            this.lbProfilPlayerClass.TabIndex = 30;
            // 
            // btnProfilPlayerSave
            // 
            this.btnProfilPlayerSave.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilPlayerSave.Location = new System.Drawing.Point(332, 724);
            this.btnProfilPlayerSave.Name = "btnProfilPlayerSave";
            this.btnProfilPlayerSave.Size = new System.Drawing.Size(126, 35);
            this.btnProfilPlayerSave.TabIndex = 9;
            this.btnProfilPlayerSave.Text = "Enregistrer";
            this.btnProfilPlayerSave.UseVisualStyleBackColor = true;
            this.btnProfilPlayerSave.Click += new System.EventHandler(this.btnProfilPlayerSave_Click);
            // 
            // btnProfilPlayerClose
            // 
            this.btnProfilPlayerClose.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilPlayerClose.Location = new System.Drawing.Point(24, 724);
            this.btnProfilPlayerClose.Name = "btnProfilPlayerClose";
            this.btnProfilPlayerClose.Size = new System.Drawing.Size(92, 35);
            this.btnProfilPlayerClose.TabIndex = 8;
            this.btnProfilPlayerClose.Text = "Fermer";
            this.btnProfilPlayerClose.UseVisualStyleBackColor = true;
            this.btnProfilPlayerClose.Click += new System.EventHandler(this.btnProfilPlayerClose_Click);
            // 
            // gbProfilPlayerGuildInformations
            // 
            this.gbProfilPlayerGuildInformations.Controls.Add(this.lblProfilPlayerGrade);
            this.gbProfilPlayerGuildInformations.Controls.Add(this.lblProfilPlayerGradeTitle);
            this.gbProfilPlayerGuildInformations.Controls.Add(this.lblProfilPlayerGuildName);
            this.gbProfilPlayerGuildInformations.Controls.Add(this.btnProfilPlayerGuildQuit);
            this.gbProfilPlayerGuildInformations.Controls.Add(this.lblProfilPlayerGuildNameTitle);
            this.gbProfilPlayerGuildInformations.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProfilPlayerGuildInformations.Location = new System.Drawing.Point(24, 553);
            this.gbProfilPlayerGuildInformations.Name = "gbProfilPlayerGuildInformations";
            this.gbProfilPlayerGuildInformations.Size = new System.Drawing.Size(435, 165);
            this.gbProfilPlayerGuildInformations.TabIndex = 7;
            this.gbProfilPlayerGuildInformations.TabStop = false;
            this.gbProfilPlayerGuildInformations.Text = "Informations de Guilde";
            // 
            // lblProfilPlayerGrade
            // 
            this.lblProfilPlayerGrade.AutoSize = true;
            this.lblProfilPlayerGrade.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPlayerGrade.Location = new System.Drawing.Point(137, 64);
            this.lblProfilPlayerGrade.Name = "lblProfilPlayerGrade";
            this.lblProfilPlayerGrade.Size = new System.Drawing.Size(81, 26);
            this.lblProfilPlayerGrade.TabIndex = 5;
            this.lblProfilPlayerGrade.Text = "Vétéran";
            // 
            // lblProfilPlayerGradeTitle
            // 
            this.lblProfilPlayerGradeTitle.AutoSize = true;
            this.lblProfilPlayerGradeTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPlayerGradeTitle.Location = new System.Drawing.Point(46, 65);
            this.lblProfilPlayerGradeTitle.Name = "lblProfilPlayerGradeTitle";
            this.lblProfilPlayerGradeTitle.Size = new System.Drawing.Size(77, 26);
            this.lblProfilPlayerGradeTitle.TabIndex = 4;
            this.lblProfilPlayerGradeTitle.Text = "Grade :";
            // 
            // lblProfilPlayerGuildName
            // 
            this.lblProfilPlayerGuildName.AutoSize = true;
            this.lblProfilPlayerGuildName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPlayerGuildName.Location = new System.Drawing.Point(137, 36);
            this.lblProfilPlayerGuildName.Name = "lblProfilPlayerGuildName";
            this.lblProfilPlayerGuildName.Size = new System.Drawing.Size(137, 28);
            this.lblProfilPlayerGuildName.TabIndex = 3;
            this.lblProfilPlayerGuildName.Text = "NomDeGuilde";
            // 
            // btnProfilPlayerGuildQuit
            // 
            this.btnProfilPlayerGuildQuit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfilPlayerGuildQuit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilPlayerGuildQuit.ForeColor = System.Drawing.Color.Red;
            this.btnProfilPlayerGuildQuit.Location = new System.Drawing.Point(220, 106);
            this.btnProfilPlayerGuildQuit.Name = "btnProfilPlayerGuildQuit";
            this.btnProfilPlayerGuildQuit.Size = new System.Drawing.Size(182, 34);
            this.btnProfilPlayerGuildQuit.TabIndex = 2;
            this.btnProfilPlayerGuildQuit.Text = "Quitter la guilde";
            this.btnProfilPlayerGuildQuit.UseVisualStyleBackColor = false;
            this.btnProfilPlayerGuildQuit.Click += new System.EventHandler(this.btnProfilPlayerGuildQuit_Click);
            // 
            // lblProfilPlayerGuildNameTitle
            // 
            this.lblProfilPlayerGuildNameTitle.AutoSize = true;
            this.lblProfilPlayerGuildNameTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPlayerGuildNameTitle.Location = new System.Drawing.Point(46, 39);
            this.lblProfilPlayerGuildNameTitle.Name = "lblProfilPlayerGuildNameTitle";
            this.lblProfilPlayerGuildNameTitle.Size = new System.Drawing.Size(64, 26);
            this.lblProfilPlayerGuildNameTitle.TabIndex = 0;
            this.lblProfilPlayerGuildNameTitle.Text = "Nom :";
            // 
            // frmProfilPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 779);
            this.Controls.Add(this.btnProfilPlayerSave);
            this.Controls.Add(this.btnProfilPlayerClose);
            this.Controls.Add(this.gbProfilPlayerGuildInformations);
            this.Controls.Add(this.gbProfilPlayerCharacterInformations);
            this.Controls.Add(this.gbProfilPlayerAccountIntomations);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProfilPlayer";
            this.Text = "Page de profil";
            this.Load += new System.EventHandler(this.frmProfilPlayer_Load);
            this.gbProfilPlayerAccountIntomations.ResumeLayout(false);
            this.gbProfilPlayerAccountIntomations.PerformLayout();
            this.gbProfilPlayerCharacterInformations.ResumeLayout(false);
            this.gbProfilPlayerCharacterInformations.PerformLayout();
            this.gbProfilPlayerGuildInformations.ResumeLayout(false);
            this.gbProfilPlayerGuildInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProfilPlayerAccountIntomations;
        private System.Windows.Forms.Label lblProfilPlayerEmailTitle;
        private System.Windows.Forms.TextBox tbProfilPlayerPassword;
        private System.Windows.Forms.Label lblProfilPlayerPasswordTitle;
        private System.Windows.Forms.TextBox tbProfilPlayerEmail;
        private System.Windows.Forms.GroupBox gbProfilPlayerCharacterInformations;
        private System.Windows.Forms.Label lblProfilPlayerCharacterNameTitle;
        private System.Windows.Forms.TextBox tbProfilPlayerCharacterName;
        private System.Windows.Forms.Label lblProfilPlayerFactionTitle;
        private System.Windows.Forms.RadioButton rbProfilPlayerAlliance;
        private System.Windows.Forms.RadioButton rbProfilPlayerHorde;
        private System.Windows.Forms.Label lblProfilPlayerRaceTitle;
        private System.Windows.Forms.ListBox lbProfilPlayerRace;
        private System.Windows.Forms.Label lblProfilPlayerRoleTitle;
        private System.Windows.Forms.Label lblProfilPlayerClassTitle;
        private System.Windows.Forms.ListBox lbProfilPlayerClass;
        private System.Windows.Forms.RadioButton rbProfilPlayerDps;
        private System.Windows.Forms.RadioButton rbProfilPlayerHeal;
        private System.Windows.Forms.RadioButton rbProfilPlayerTank;
        private System.Windows.Forms.Button btnProfilPlayerSave;
        private System.Windows.Forms.Button btnProfilPlayerClose;
        private System.Windows.Forms.GroupBox gbProfilPlayerGuildInformations;
        private System.Windows.Forms.Label lblProfilPlayerGuildName;
        private System.Windows.Forms.Button btnProfilPlayerGuildQuit;
        private System.Windows.Forms.Label lblProfilPlayerGuildNameTitle;
        private System.Windows.Forms.Label lblProfilPlayerGrade;
        private System.Windows.Forms.Label lblProfilPlayerGradeTitle;
        private System.Windows.Forms.Button btnProfilPlayerAccountDelete;
    }
}