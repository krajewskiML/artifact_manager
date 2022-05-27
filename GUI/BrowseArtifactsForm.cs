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
    public partial class BrowseArtifactsForm : Form
    {
        public BrowseArtifactsForm()
        {
            InitializeComponent();
            InitializeClassPicker();
        }

        private void InitializeClassPicker()
        {
            var classNames = ClassController.getClassesName();
            ClassPickerComboBox.Items.Clear();
            foreach (var className in classNames)
            {
                    ClassPickerComboBox.Items.Add(className);

            }

            ClassPickerComboBox.SelectedIndex = -1;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClassPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pickedClass = ClassPickerComboBox.SelectedItem.ToString();
            var allRepresentants = EntityController.GetFullRepresentatives(pickedClass);
            ArtifactsListBox.Items.Clear();
            foreach (var representant in allRepresentants)
            {
                ArtifactsListBox.Items.Add(representant);
            }
        }
    }
}
