using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artifact_manager2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if(LoginTextBox.Text.ToString().Length >0 && PasswordTextBox.Text.ToString().Length > 0)
            {
                LoginButton.Enabled = true;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.ToString().Length > 0 && PasswordTextBox.Text.ToString().Length > 0)
            {
                LoginButton.Enabled = true;
            }
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
