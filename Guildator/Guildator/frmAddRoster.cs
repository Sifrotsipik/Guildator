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
    public partial class frmAddRoster : Form
    {
        public frmAddRoster()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRosterSave_Click(object sender, EventArgs e)
        {
            if (checkRosterName()) {
                //Créer le Roster dans la bdd
                this.Dispose();
            }

        }

        private Boolean checkRosterName() {
            if (tbAddRosterName.Text.Equals(""))
            {
                lblAddRosterNameError.Text = "Veuillez saisir un nom de roster";
                return false;
            }
            //Si listes vides -> erreur
            //Si nom de roster deja utilisé -> message
            return true;
        }

        private void btnAddRosterClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
