using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guildator
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblkLoginRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.Show();
            this.Hide();
        }

        private void btnLoginConnexion_Click(object sender, EventArgs e)
        {
            if (checkLogin()) {
                //Si le joueur ou maitre de guilde n'ont pas de guilde (en cas de suppression de la guilde ou exit au mement de création de guilde), rediriger vers frmAddOrSearchGuild
                //Si le joueur est en attente de guilde rediriger vers frmGuildWaiting

                //Pour tests
                if (tbLoginIdentifiant.Text == "guild@master.ch")
                {
                    frmHomeGuildMaster frmHomeGuildMaster = new frmHomeGuildMaster();
                    frmHomeGuildMaster.Show();
                    this.Hide();
                }
                else if (tbLoginIdentifiant.Text == "user@exemple.com")
                {
                    frmHomePlayer frmHomePlayer = new frmHomePlayer();
                    frmHomePlayer.Show();
                    this.Hide();
                }
            }

        }

        private Boolean checkLogin() {
            if (tbLoginIdentifiant.Text.Equals(""))
            {
                lblLoginError.Text = "Veuillez entrer une adresse mail";
                return false;
            }
            else if (tbLoginPassword.Text.Equals("")) {
                lblLoginError.Text = "Veuillez entrer un mot de passe correct";
                return false;
            }
            else {
                //Controler la concordance du mot de passe et l'adresse du compte
                return true;
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLoginConnexion;
        }
    }
}
