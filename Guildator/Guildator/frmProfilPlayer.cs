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
    public partial class frmProfilPlayer : Form
    {
        public frmProfilPlayer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProfilPlayerAccountDelete_Click(object sender, EventArgs e)
        {
            //Demande de validation du choix
            //Supprimer le personnage et le compte
            //Rediriger sur page de connexion/incription
        }

        private void btnProfilPlayerGuildQuit_Click(object sender, EventArgs e)
        {
            //Demande de validation du choix
            //Supprimer la guilde du joueur
            //Rediriger sur frmAddOrSearchGuild
        }

        private void frmProfilPlayer_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnProfilPlayerSave;
        }

        private void btnProfilPlayerClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProfilPlayerSave_Click(object sender, EventArgs e)
        {
            //Si changements -> modifier l'objet
            this.Dispose();
        }
    }
}
