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
using artifact_manager2.Database.EnhancedModels;

namespace artifact_manager2.GUI
{
    public partial class DeleteEntityForm : Form
    {
        public DeleteEntityForm()
        {
            InitializeComponent();
            InitializeClassPicker();
        }

        private void InitializeEntityPicker(string classname)
        {
            var entities = EntityController.GetFullRepresentatives(classname);
            EntitiesListBox.Items.Clear();  
            foreach (var entity in entities)
            {
                EntitiesListBox.Items.Add(entity);
            }
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

        private void ClassPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ClassPickerComboBox.SelectedIndex != -1)
            {
                var pickedClass = ClassPickerComboBox.SelectedItem.ToString();
                InitializeEntityPicker(pickedClass);
            }
        }

        private void EntitiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(EntitiesListBox.SelectedIndex != -1 && EntitiesListBox.Items.Count > 0)
            {
                DeleteEntityButton.Enabled = true;
            }
            else
            {
                DeleteEntityButton.Enabled = false;
            }
                
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteEntityButton_Click(object sender, EventArgs e)
        {
            var entity = EntitiesListBox.SelectedItem;
            EntityController.deleteEntity((FullRepresentative)entity);
            var pickedClass = ClassPickerComboBox.SelectedItem.ToString();
            InitializeEntityPicker(pickedClass);
            EntitiesListBox.SelectedIndex = -1;
            DeleteEntityButton.Enabled=false;
        }
    }
}
