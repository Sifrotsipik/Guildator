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
            if (tbLoginIdentifiant.Text == "guildmaster")
            {
                frmHomeGuildMaster frmHomeGuildMaster = new frmHomeGuildMaster();
                frmHomeGuildMaster.Show();
                this.Hide();
            }
            else if (tbLoginIdentifiant.Text == "user")
            {
                frmHomePlayer frmHomePlayer = new frmHomePlayer();
                frmHomePlayer.Show();
                this.Hide();
            }
        }

    }
}
