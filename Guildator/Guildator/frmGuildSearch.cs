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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuildSearchAction_Click(object sender, EventArgs e)
        {
            //Adapter la dgvGuildSearch
        }

        private void btnGuildSearchBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuildSearchSave_Click(object sender, EventArgs e)
        {
            //faire la demande pour rejoindre la guilde concernée
            frmGuildWaiting frmGuildWaiting = new frmGuildWaiting();
            frmGuildWaiting.Show();
            this.Hide();
        }
    }
}
