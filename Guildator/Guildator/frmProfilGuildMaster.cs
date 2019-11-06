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
    public partial class frmProfilGuildMaster : Form
    {
        public frmProfilGuildMaster()
        {
            InitializeComponent();
        }

        private void btnProfilGuildMasterAccountDelete_Click(object sender, EventArgs e)
        {
            //Demande de validation du choix
            //Suppression de la guilde
            //Suppression du compte
        }

        private void btnProfilGuildMasterGuildDelete_Click(object sender, EventArgs e)
        {
            //Exclure les membres
            //Suppression de la guilde
        }

        private void btnProfilGuildMasterClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProfilGuildMasterSave_Click(object sender, EventArgs e)
        {
            //Si changements -> modifier l'objet
            this.Dispose();
        }

        private void frmProfilGuildMaster_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnProfilGuildMasterSave;
        }
    }
}
