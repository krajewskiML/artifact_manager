using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using artifact_manager2.Controllers;

namespace artifact_manager2.GUI
{
    public partial class AssignRolesForm : Form
    {
        public AssignRolesForm()
        {
            InitializeComponent();
            InitializeUsersList();
        }

        private void InitializeUsersList()
        {
            UsersListBox.Items.Clear();
            var users = LoginController.getAllUsers();
            foreach (var user in users)
            {
                UsersListBox.Items.Add(user.UserName);
            }
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedIndex >= 0)
            {
                EditUserButton.Enabled = true;
            }
            else
            {
                EditUserButton.Enabled = false;
            }
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            var user = UsersListBox.SelectedItem.ToString();

            using (UserRolesEditor editorForm = new UserRolesEditor(user, RoleController.usersRoles(user)))
            {
                var result = editorForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RoleController.updateUsersRoles(user, editorForm.finalOptions);
                }
            }
        }
    }
}
