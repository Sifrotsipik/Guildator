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
    public partial class frmHomeGuildMaster : Form
    {
        public frmHomeGuildMaster()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRaidDetails frmRaidDetails = new frmRaidDetails();
            frmRaidDetails.ShowDialog();
        }

        private void gbHomeGuildMasterGuildMembersList_Enter(object sender, EventArgs e)
        {

        }

        private void lblHomeGuildMasterRoster_Click(object sender, EventArgs e)
        {

        }

        private void frmHomeGuildMaster_Load(object sender, EventArgs e)
        {

        }

        private void btnHomeGuildMasterAddRaid_Click(object sender, EventArgs e)
        {
            frmAddRaid frmAddRaid = new frmAddRaid();
            frmAddRaid.ShowDialog();
        }

        private void btnHomeGuildMasterAddRoster_Click(object sender, EventArgs e)
        {
            frmAddRoster frmAddRoster = new frmAddRoster();
            frmAddRoster.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblkHomeGuildMasterProfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                        
        }

        private void lblkHomeGuildMasterNotifications_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNotifications frmNotifications = new frmNotifications();
            frmNotifications.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddComponentDemand frmAddComponentDemand = new frmAddComponentDemand();
            frmAddComponentDemand.ShowDialog();
        }


        private void dgvHomeGuildMasterMembersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPlayerDetails frmPlayerDetails = new frmPlayerDetails();
            frmPlayerDetails.ShowDialog();
        }

        private void dgvHomeGuildMasterRostersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRosterDetails frmRosterDetails = new frmRosterDetails();
            frmRosterDetails.ShowDialog();
        }
    }
}
