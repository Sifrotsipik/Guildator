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
    public partial class frmRaidDetails : Form
    {
        public frmRaidDetails()
        {
            InitializeComponent();
        }



        private void dgvRaidDetailsParticipantsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Supprimer l'invitation au raid et notifier le joueur

        }

        private void btnRaidDetailsAddMember_Click(object sender, EventArgs e)
        {
            //Envoyer la liste des participants actuelle à frmAddPlayerToRaid
            frmAddPlayerToRaid frmAddPlayerToRaid = new frmAddPlayerToRaid();
            frmAddPlayerToRaid.ShowDialog();
        }

        private void btnRaidDetailsClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRaidDetailsSave_Click(object sender, EventArgs e)
        {
            //Sauvegarder les modifications du raid
        }
    }
}
