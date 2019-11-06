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
    public partial class frmComponentDemandDetails : Form
    {
        public frmComponentDemandDetails()
        {
            InitializeComponent();
        }

        private void frmComponentDemandDetails_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnComponentDemandDetailsClose;
        }

        private void btnComponentDemandDetailsClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnComponentDemandDetailsDelete_Click(object sender, EventArgs e)
        {
            //Supprimer la demande de composant
        }
    }
}
