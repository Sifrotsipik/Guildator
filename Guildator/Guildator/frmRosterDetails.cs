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
    public partial class frmRosterDetails : Form
    {
        public frmRosterDetails()
        {
            InitializeComponent();
        }

        private void frmRosterDetails_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnRosterDetailsSave;
        }

        private void btnRosterDetailsSave_Click(object sender, EventArgs e)
        {
            //Si modifications du roster -> update bdd
            this.Dispose();
        }

        private void btnRosterDetailsClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
