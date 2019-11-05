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
    public partial class frmAddGuild : Form
    {
        public frmAddGuild()
        {
            InitializeComponent();
        }

        private void frmAddGuild_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAddGuildSave;
        }

        private void btnAddGuildClose_Click(object sender, EventArgs e)
        {
            //L'utilisateur ne peut pas revenir sur la création du compte et personnage. Ceux-ci sont deja enregistrés. Il doit se reconnecter.
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
