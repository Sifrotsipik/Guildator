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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void lblkRegistrationConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnRegistrationNext_Click(object sender, EventArgs e)
        {
            //Créer les objets Compte et Personnage

            if (checkRegistration()) {
                //Les champs sont remplis
                if (cbRegistrationGuildMaster.Checked == true)
                {
                    frmAddGuild frmAddGuild = new frmAddGuild();
                    frmAddGuild.Show();
                    this.Hide();
                }
                else
                {
                    frmGuildSearch frmGuildSearch = new frmGuildSearch();
                    frmGuildSearch.Show();
                    this.Hide();
                }
            }


        }

        private Boolean checkRegistration() {

            //Compte
            if (tbRegistrationEmail.Text.Equals("") || tbRegistrationPassword.Text.Equals(""))
            {
                lblRegistrationAccountError.Text = "Veuillez entrer une adresse mail et un mot de passe";
                return false;
            }
            //Personnage
            if (tbRegistrationCharacterName.Text.Equals("")) {
                lblRegistrationCharacterError.Text = "Veuillez entrer un nom de personnage";
                return false;
            }
            return true;
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegistrationNext;
        }

        private void btnRegistrationBack_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}
