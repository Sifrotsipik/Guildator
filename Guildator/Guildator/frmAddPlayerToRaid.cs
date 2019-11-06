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
    public partial class frmAddPlayerToRaid : Form
    {
        public frmAddPlayerToRaid()
        {
            InitializeComponent();
        }

        private void btnAddPlayerToRaidClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddPlayerToRaidSave_Click(object sender, EventArgs e)
        {
            //Sauvegarder l'ajout de membres au raid
            this.Dispose();
        }

        private void dgvAddPlayerToRaidMembersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ajouter le membre à la liste des participants
        }

        private void frmAddPlayerToRaid_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAddPlayerToRaidSave;
        }
    }
}
