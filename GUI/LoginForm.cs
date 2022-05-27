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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            if (!LoginController.checkIfUserExists(login))
            {
                MessageBox.Show(
                    $"user with login: {login} does not exist!",
                    "Wrong login",
                    MessageBoxButtons.OK
                    );
                return;
            }
            if(!LoginController.checkIfPasswordIsmatching(login, password))
            {
                MessageBox.Show(
                    $"Wrong password!",
                    "Wrong password",
                    MessageBoxButtons.OK
                    );
                return;
            }
            var user = LoginController.retrieveUser(login);
            if (user.IsAdmin())
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.ShowDialog();
            }
            else
            {
                CreatorPanel creatorPanel = new CreatorPanel(user);
                creatorPanel.ShowDialog();
            }
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.ToString().Length > 0 && PasswordTextBox.Text.ToString().Length > 0)
            {
                LoginButton.Enabled = true;
            }
            else
            {
                LoginButton.Enabled = false;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.ToString().Length > 0 && PasswordTextBox.Text.ToString().Length > 0)
            {
                LoginButton.Enabled = true;
            }
            else
            {
                LoginButton.Enabled = false;
            }
        }
    }
}
