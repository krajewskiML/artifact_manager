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
    public partial class RoleEdiorForm : Form
    {
        public Dictionary<string, bool> initialOptions { get; set; }
        public Dictionary<string, bool> finalOptions { get; set; }
        public RoleEdiorForm(Dictionary<string, bool> initialProperties)
        {
            InitializeComponent();
            InitializeCheckbox(initialProperties);
            initialOptions = new Dictionary<string, bool>();

            foreach (var property in initialProperties)
            {
                initialOptions.Add(property.Key, property.Value);
            }
        }

        private Dictionary<string, bool> CheckBoxToMap()
        {
            return new Dictionary<string, bool>()
                {
                    {"IsAdmin", PermissionsListBox.GetItemChecked(0)},
                    {"CanAddClasses", PermissionsListBox.GetItemChecked(1)},
                    {"CanUpdateClasses", PermissionsListBox.GetItemChecked(2)},
                    {"CanDeleteClasses", PermissionsListBox.GetItemChecked(3)},
                    {"CanAddRecords", PermissionsListBox.GetItemChecked(4)},
                    {"CanUpdateRecords", PermissionsListBox.GetItemChecked(5)},
                    {"CanDeleteRecords", PermissionsListBox.GetItemChecked(6)},
            };
        }

        private void InitializeCheckbox(Dictionary<string, bool> initialProperties)
        {
            PermissionsListBox.SetItemChecked(0, initialProperties["IsAdmin"]);
            PermissionsListBox.SetItemChecked(1, initialProperties["CanAddClasses"]);
            PermissionsListBox.SetItemChecked(2, initialProperties["CanUpdateClasses"]);
            PermissionsListBox.SetItemChecked(3, initialProperties["CanDeleteClasses"]);
            PermissionsListBox.SetItemChecked(4, initialProperties["CanAddRecords"]);
            PermissionsListBox.SetItemChecked(5, initialProperties["CanUpdateRecords"]);
            PermissionsListBox.SetItemChecked(6, initialProperties["CanDeleteRecords"]);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.finalOptions = CheckBoxToMap();
            this.Close();
        }

        private void PermissionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentState = CheckBoxToMap();
            if (!currentState.Equals(initialOptions)){
                OkButton.Enabled = true;
            }
            else
            {
                OkButton.Enabled = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
