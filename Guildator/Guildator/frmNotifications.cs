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
    public partial class frmNotifications : Form
    {
        public frmNotifications()
        {
            InitializeComponent();
        }

        private void btnNotificationsClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvNotificationsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Retirer la notification de la liste
        }

        private void frmNotifications_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnNotificationsClose;
        }
    }
}
