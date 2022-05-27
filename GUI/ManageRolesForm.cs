using artifact_manager2.Controllers;
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
    public partial class ManageRolesForm : Form
    {
        public ManageRolesForm()
        {
            InitializeComponent();
            InitializeRolesList();
        }

        private void InitializeRolesList()
        {
            RolesListBox.Items.Clear();
            var roles = RoleController.getAllRoles();
            foreach (var role in roles)
            {
                RolesListBox.Items.Add(role.Name);
            }
        }

        private void NewRoleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NewRoleNameTextBox.Text.ToString().Length > 0)
            {
                AddNewRoleButton.Enabled = true;
            }
            else
            {
                AddNewRoleButton.Enabled = false;
            }
        }

        private Dictionary<string, bool> CheckBoxToMap()
        {
            return new Dictionary<string, bool>()
                {
                    {"IsAdmin", RolePropertiesCheckedListBox.GetItemChecked(0)},
                    {"CanAddClasses", RolePropertiesCheckedListBox.GetItemChecked(1)},
                    {"CanUpdateClasses", RolePropertiesCheckedListBox.GetItemChecked(2)},
                    {"CanDeleteClasses", RolePropertiesCheckedListBox.GetItemChecked(3)},
                    {"CanAddRecords", RolePropertiesCheckedListBox.GetItemChecked(4)},
                    {"CanUpdateRecords", RolePropertiesCheckedListBox.GetItemChecked(5)},
                    {"CanDeleteRecords", RolePropertiesCheckedListBox.GetItemChecked(6)},
            };
        }

        private void AddNewRoleButton_Click(object sender, EventArgs e)
        {
            var roleName = NewRoleNameTextBox.Text.ToString();
            if (RoleController.checkIfRoleExists(roleName))
            {
                MessageBox.Show(
                    $"Role with name: '{roleName}' already exists",
                    "Role already exists",
                    MessageBoxButtons.OK
                );
            }
            else
            {
                var permissions = CheckBoxToMap();
                RoleController.addRole(roleName, permissions);
                MessageBox.Show(
                    $"Role with name: '{roleName}' has been added",
                    "Role already exists",
                    MessageBoxButtons.OK
                );
                InitializeRolesList();
            }
            NewRoleNameTextBox.Text = "";
            for (int i = 0; i < RolePropertiesCheckedListBox.Items.Count; i++)
            {
                RolePropertiesCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void DeleteRoleButton_Click(object sender, EventArgs e)
        {
            var rolename = RolesListBox.SelectedItem.ToString();
            RoleController.deleteRole(rolename);
            MessageBox.Show(
                $"role: '{rolename}' has been deleted",
                "Role deleted",
                MessageBoxButtons.OK
            );
            InitializeRolesList();
        }

        private void RolesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RolesListBox.SelectedIndex >= 0)
            {
                DeleteRoleButton.Enabled = true;
                EditRoleButton.Enabled = true;
            }
            else
            {
                DeleteRoleButton.Enabled = false;
                EditRoleButton.Enabled = false;
            }
        }

        private void EditRoleButton_Click(object sender, EventArgs e)
        {
            var rolename = RolesListBox.SelectedItem.ToString();

            using(RoleEdiorForm editorForm = new RoleEdiorForm(RoleController.rolenameToDictionary(rolename)))
            {
                var result = editorForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RoleController.updateRole(rolename, editorForm.finalOptions);
                }
            }
        }
    }
}
