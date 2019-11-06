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
    public partial class frmGuildSearch : Form
    {
        public frmGuildSearch()
        {
            InitializeComponent();
        }

        private void btnGuildSearchAction_Click(object sender, EventArgs e)
        {
            //Adapter la dgvGuildSearch
            //Si nom de guilde trouvé -> textbox en vert
        }

        private void btnGuildSearchBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuildSearchSave_Click(object sender, EventArgs e)
        {
            if (checkGuildName()) {
                //faire la demande pour rejoindre la guilde concernée
                frmGuildWaiting frmGuildWaiting = new frmGuildWaiting();
                frmGuildWaiting.Show();
                this.Dispose();
            }

        }

        private Boolean checkGuildName() {
            if (tbGuildSearchName.Text.Equals("")) {
                lblGuildSearchGuildNameError.Text = "Merci d'entrer un nom de guilde";
                return false;
            }
            return true;
        }
    }
}
