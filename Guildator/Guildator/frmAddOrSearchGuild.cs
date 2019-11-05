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
            this.Hide();
        }

        private void btnAddOrSearchGuildSearch_Click(object sender, EventArgs e)
        {
            frmGuildSearch frmGuildSearch = new frmGuildSearch();
            frmGuildSearch.Show();
            this.Hide();
        }

        private void lblkHomeGuildMasterProfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
