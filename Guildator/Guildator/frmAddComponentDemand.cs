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
    public partial class frmAddComponentDemand : Form
    {
        public frmAddComponentDemand()
        {
            InitializeComponent();
        }

        private void frmAddComponentDemand_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAddComponentDemandSave;
        }

        private void btnAddComponentDemandSave_Click(object sender, EventArgs e)
        {
            //if (lbAddComponentDemandeName.Text == "Sélectionnez un composant")
            //{
            //    lblAddComponentDemandNameTitle.ForeColor = Color.Red;
            //}
            if (nudAddComponentDemandQuantity.Value <= 0)
            {
                lblAddComponentDemandQuantityTitle.ForeColor = Color.Red;
            }
            else {
                //Créer l'objet ComponentDemand
                this.Dispose();
            }
        }

        private void btnAddComponentDemandClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
