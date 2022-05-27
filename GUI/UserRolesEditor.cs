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
    public partial class UserRolesEditor : Form
    {
        public Dictionary<string, bool> initialOptions { get; set; }
        public Dictionary<string, bool> finalOptions { get; set; }
        public UserRolesEditor(string username, Dictionary<string, bool> initialProperties)
        {
            InitializeComponent();
            InitializeCheckbox(initialProperties);

            UsersPermissionsLabel.Text = $"{username}'s permissions";

            initialOptions = new Dictionary<string, bool>();
            foreach (var property in initialProperties)
            {
                initialOptions.Add(property.Key, property.Value);
            }
        }

        private void InitializeCheckbox(Dictionary<string, bool> initialProperties)
        {
            foreach(var property in initialProperties)
            {
                PermissionListBox.Items.Add(property.Key, property.Value);
            }
        }

        private Dictionary<string, bool> CheckBoxToMap()
        {
            var newRolesDict = new Dictionary<string, bool>();
            for(int i = 0; i < PermissionListBox.Items.Count; ++i)
            {
                newRolesDict[PermissionListBox.Items[i].ToString()] = PermissionListBox.GetItemChecked(i);
            }
            return newRolesDict;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PermissionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentState = CheckBoxToMap();
            if (!currentState.Equals(initialOptions))
            {
                OKButton.Enabled = true;
            }
            else
            {
                OKButton.Enabled = false;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.finalOptions = CheckBoxToMap();
            this.Close();
        }
    }
}
