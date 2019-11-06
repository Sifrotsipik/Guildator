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
    public partial class frmAddOrSearchGuild : Form
    {
        public frmAddOrSearchGuild()
        {
            InitializeComponent();
        }



        private void btnAddOrSearchGuildAdd_Click(object sender, EventArgs e)
        {
            frmAddGuild frmAddGuild = new frmAddGuild();
            frmAddGuild.Show();
            this.Dispose();
        }

        private void btnAddOrSearchGuildSearch_Click(object sender, EventArgs e)
        {
            frmGuildSearch frmGuildSearch = new frmGuildSearch();
            frmGuildSearch.Show();
            this.Dispose();
        }

        private void lblkHomeGuildMasterProfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Renvoyer sur frmPlayerProfil sans guilde
        }

        private void btnAddOrSearchGuildExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblkAddOrSearchGuildNotifications_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNotifications frmNotifications = new frmNotifications();
            frmNotifications.ShowDialog();
        }

        private void frmAddOrSearchGuild_Load(object sender, EventArgs e)
        {

        }
    }
}
