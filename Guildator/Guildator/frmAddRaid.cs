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
    public partial class frmAddRaid : Form
    {
        public frmAddRaid()
        {
            InitializeComponent();
        }



        //Lors du choix du roster, la dgvAddRaidParticipantsList doit être mise à jour avec les membres du roster
        //Si case cbAddRaidGuildMasterOk est cochée, adapter la dgv


        private void dgvAddRaidParticipantsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Supprimer le joueur du raid et le notifier
        }

        private void btnAddRaidAddPlayer_Click(object sender, EventArgs e)
        {
            //Envoyer la liste actuelle des participants
            frmAddPlayerToRaid frmAddPlayerToRaid = new frmAddPlayerToRaid();
            frmAddPlayerToRaid.ShowDialog();
        }

        private void btnAddRaidClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddRaidSave_Click(object sender, EventArgs e)
        {
            //Enregistrement du raid dans bdd
            this.Dispose();
        }
    }
}
