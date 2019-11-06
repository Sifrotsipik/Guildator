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
    public partial class frmHomePlayer : Form
    {
        public frmHomePlayer()
        {
            InitializeComponent();
        }

        private void btnHomePlayerComponentDemand_Click(object sender, EventArgs e)
        {
            frmAddComponentDemand frmAddComponentDemand = new frmAddComponentDemand();
            frmAddComponentDemand.ShowDialog();
        }

        private void lblkHomePlayerNotifications_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNotifications frmNotifications = new frmNotifications();
            frmNotifications.ShowDialog();
        }

        private void lblkHomePlayerProfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProfilPlayer frmProfilPlayer = new frmProfilPlayer();
            frmProfilPlayer.ShowDialog();
        }
    }
}
