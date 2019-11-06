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
    public partial class frmPlayerDetails : Form
    {
        public frmPlayerDetails()
        {
            InitializeComponent();
        }

        private void btnPlayerDetailsSave_Click(object sender, EventArgs e)
        {
            //Si changement de grade -> enregistrer le changement dans la bdd
            this.Dispose();
        }

        private void btnPlayerDetailsClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
