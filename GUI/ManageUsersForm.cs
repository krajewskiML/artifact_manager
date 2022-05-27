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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
            InitializeUsersList();
        }

        private void InitializeUsersList()
        {
            UsersList.Items.Clear();
            var users = LoginController.getAllUsers();
            foreach (var user in users)
            {
                UsersList.Items.Add(user.UserName);
            }
        }

        private void NewPasswordButton_Click(object sender, EventArgs e)
        {
            var username = UsersList.Items[UsersList.SelectedIndex].ToString();
            var newPassword = NewPasswordTextBox.Text.ToString();
            LoginController.updatePassword(username, newPassword);
            MessageBox.Show(
                $"user with login: '{username}' has new password: '{newPassword}'",
                "Password updated",
                MessageBoxButtons.OK
            );
            NewPasswordTextBox.Text = "";
        }

        private void NewPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.Text.ToString().Length > 0 && UsersList.SelectedIndex >= 0)
            {
                NewPasswordButton.Enabled = true;
            }
            else
            {
                NewPasswordButton.Enabled = false;
            }
        }

        private void UsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(UsersList.SelectedIndex >= 0)
            {
                DeleteUserButton.Enabled = true;
            }
            else
            {
                DeleteUserButton.Enabled = false;
            }
        }

        private void NewUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NewUsernameTextBox.Text.ToString().Length > 0 && NewUserPasswordTextBox.Text.ToString().Length > 0)
            {
                AddUserButton.Enabled = true;
            }
            else
            {
                AddUserButton.Enabled = false;
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var login = NewUsernameTextBox.Text.ToString();
            var password = NewUserPasswordTextBox.Text.ToString();
            if (LoginController.checkIfUserExists(login))
            {
                MessageBox.Show(
                    $"user with login: '{login}' already exists!",
                    "Wrong login",
                    MessageBoxButtons.OK
                );
            }
            else
            {
                LoginController.addUser(login, password);
                MessageBox.Show(
                    $"user with login: '{login}' and password: '{password}' has been created",
                    "User created",
                    MessageBoxButtons.OK
                    );
                InitializeUsersList();
            }

            NewUsernameTextBox.Text = "";
            NewUserPasswordTextBox.Text = "";
        }

        private void NewUserPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NewUsernameTextBox.Text.ToString().Length > 0 && NewUserPasswordTextBox.Text.ToString().Length > 0)
            {
                AddUserButton.Enabled = true;
            }
            else
            {
                AddUserButton.Enabled = false;
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            var username = UsersList.Items[UsersList.SelectedIndex].ToString();
            LoginController.deleteUser(username);
            MessageBox.Show(
                $"user with login: '{username}' has been deleted",
                "User deleted",
                MessageBoxButtons.OK
            );
            InitializeUsersList();
        }
    }
}
