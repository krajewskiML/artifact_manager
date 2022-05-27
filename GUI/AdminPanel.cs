using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artifact_manager2.GUI
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm();
            manageUsersForm.ShowDialog();
        }

        private void AddRoleButton_Click(object sender, EventArgs e)
        {
            ManageRolesForm manageRolesForm = new ManageRolesForm();
            manageRolesForm.ShowDialog();
        }

        private void ManageRolesButton_Click(object sender, EventArgs e)
        {
            AssignRolesForm assignRolesForm = new AssignRolesForm();
            assignRolesForm.ShowDialog();
        }
    }
}
