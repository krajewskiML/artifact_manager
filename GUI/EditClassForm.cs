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
    public partial class EditClassForm : Form
    {
        public EditClassForm()
        {
            InitializeComponent();
            InitializeBaseClassPicker();
        }

        private void InitializeBaseClassPicker()
        {
            var classNames = ClassController.getClassesName();
            ClassPickerComboBox.Items.Clear();
            foreach (var className in classNames)
            {
                if (className != ClassController.CHARACTER_BASE_CLASS)
                {
                    ClassPickerComboBox.Items.Add(className);
                }
            }
            ClassPickerComboBox.SelectedIndex = 0;
        }

        private void DeleteAttributeButton_Click(object sender, EventArgs e)
        {
            var pickedClass = ClassPickerComboBox.SelectedItem.ToString();
            var picckedAttribute = AttributesListBox.SelectedItem.ToString().Split('\t')[0];
            ClassController.removeAttribute(pickedClass, picckedAttribute);
            AttributesListBox.Items.Remove(AttributesListBox.SelectedItem);
            AttributesListBox.SelectedIndex = -1;
        }

        private void ClassPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pickedBaseClass = ClassPickerComboBox.SelectedItem;
            AttributesListBox.Items.Clear();
            var attributesOfBaseClass = ClassController.getSpecificClassesDescription(pickedBaseClass.ToString());
            var idOfBaseClass = ClassController.getClassId(pickedBaseClass.ToString());
            foreach (var attribute in attributesOfBaseClass)
            {
                AttributesListBox.Items.Add(ClassController.AttributeToString(attribute));
            }
            //newClass.setSuperClassAttributes(idOfBaseClass, attributesOfBaseClass);
        }

        private List<string> getCurrentAttributeNames()
        {
            var list = new List<string>();
            foreach (var attribute in AttributesListBox.Items)
            {
                list.Add(attribute.ToString().Split('\t')[0]);
            }
            return list;
        }

        private void AttributesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AttributesListBox.SelectedIndex > -1)
            {
                DeleteAttributeButton.Enabled = true;
                if(NewNameTextBox.Text.Length > 0)
                {
                    RenameButton.Enabled = true;
                }
                
            }
            else
            {
                RenameButton.Enabled = false;
                DeleteAttributeButton.Enabled = false;
            }
        }

        private void NewNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NewNameTextBox.Text.Length > 0 && !getCurrentAttributeNames().Contains((NewNameTextBox.Text.ToString())))
            {
                if (AttributesListBox.SelectedIndex > -1)
                {
                    RenameButton.Enabled = true;
                }
                else
                {
                    RenameButton.Enabled = false;
                }

            }
            else
            {
                RenameButton.Enabled = false;
            }
        }

        public bool IsFloatOrInt(string value)
        {
            int intValue;
            float floatValue;
            return Int32.TryParse(value, out intValue) || float.TryParse(value, out floatValue);
        }

        private bool canAddNewAttribute()
        {
            var pickedType = TypeOfAttributeComboBox.SelectedItem;
            if (pickedType == null)
            {
                return false;
            }
            var defaultValue = DefaultValueTextBox.Text.ToString();
            if (defaultValue.Length == 0)
            {
                return false;
            }
            if (AttributeNameTextBox.Text.Length == 0)
            {
                return false;
            }
            var attrName = AttributeNameTextBox.Text.ToString();
            var currentNames = new List<string>();
            //checking if deault value is valid
            if(pickedType.ToString() == "String")
            {
                return true;
            }
            if(pickedType.ToString() == "Float")
            {
                return IsFloatOrInt(defaultValue);
            }
            int smth;
            return Int32.TryParse(defaultValue, out smth);
        }

        private void AttributeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (canAddNewAttribute())
            {
                AddAttributeButton.Enabled = true;
            }
            else
            {
                AddAttributeButton.Enabled = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            var newName = NewNameTextBox.Text.ToString().Replace(' ', '_');
            var pickedClass = ClassPickerComboBox.SelectedItem.ToString();
            var oldName = AttributesListBox.SelectedItem.ToString().Split('\t')[0];
            ClassController.renameAttribute(pickedClass, oldName, newName);
            AttributesListBox.Items.Clear();
            var attributesOfBaseClass = ClassController.getSpecificClassesDescription(pickedClass);
            var idOfBaseClass = ClassController.getClassId(pickedClass);
            foreach (var attribute in attributesOfBaseClass)
            {
                AttributesListBox.Items.Add(ClassController.AttributeToString(attribute));
            }
            AttributesListBox.SelectedIndex = -1;
            NewNameTextBox.Text = "";
        }

        private void DefaultValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (canAddNewAttribute())
            {
                AddAttributeButton.Enabled = true;
            }
            else
            {
                AddAttributeButton.Enabled = false;
            }
        }

        private void AddAttributeButton_Click(object sender, EventArgs e)
        {
            var attrName = AttributeNameTextBox.Text.ToString();
            var pickedType = TypeOfAttributeComboBox.SelectedItem.ToString();
            var defaultValue = DefaultValueTextBox.Text.ToString();
            var pickedClass = ClassPickerComboBox.SelectedItem.ToString();
            ClassController.addAttributeToClass(pickedClass, attrName, pickedType, defaultValue);
            MessageBox.Show(
                $"You have added attribute {attrName}",
                "Attribute Added",
                MessageBoxButtons.OK
                );
            AttributeNameTextBox.Text = "";
            TypeOfAttributeComboBox.SelectedIndex = -1;
            DefaultValueTextBox.Text = "";
            AttributesListBox.Items.Clear();
            var attributesOfBaseClass = ClassController.getSpecificClassesDescription(pickedClass);
            var idOfBaseClass = ClassController.getClassId(pickedClass);
            foreach (var attribute in attributesOfBaseClass)
            {
                AttributesListBox.Items.Add(ClassController.AttributeToString(attribute));
            }
        }
    }
}
