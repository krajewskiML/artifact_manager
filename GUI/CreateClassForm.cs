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
    public partial class CreateClassForm : Form
    {
        private const string NONE_BASE_CLASS = "None";
        private NewClassContainer newClass;
        public CreateClassForm()
        {
            InitializeComponent();
            newClass = new NewClassContainer();
            InitializeBaseClassPicker();
        }

        private void InitializeBaseClassPicker()
        {
            var classNames = ClassController.getClassesName();
            BaseClassComboBox.Items.Clear();
            BaseClassComboBox.Items.Add(NONE_BASE_CLASS);
            foreach (var className in classNames)
            {
                BaseClassComboBox.Items.Add(className);
            }
            BaseClassComboBox.SelectedIndex = 0;
        }

        private void BaseClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pickedBaseClass = BaseClassComboBox.SelectedItem;
            BaseClassAttributesListBox.Items.Clear();
            var attributesOfBaseClass = ClassController.getClassesDescription(pickedBaseClass.ToString());
            var idOfBaseClass = ClassController.getClassId(pickedBaseClass.ToString());
            foreach (var attribute in attributesOfBaseClass)
            {
                BaseClassAttributesListBox.Items.Add(ClassController.AttributeToString(attribute));
            }
            newClass.setSuperClassAttributes(idOfBaseClass, attributesOfBaseClass);
        }

        private void AttributeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AttributeNameTextBox.Text.ToString().Length > 0 && TypeOfAttributeComboBox.SelectedIndex != -1)
            {
                AddAttributeButton.Enabled = true;
            }
            else
            {
                AddAttributeButton.Enabled = false;
            }
        }

        private void TypeOfAttributeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AttributeNameTextBox.Text.ToString().Length > 0 && TypeOfAttributeComboBox.SelectedIndex != -1)
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
            var attributeName = AttributeNameTextBox.Text.ToString();
            var attributeType = TypeOfAttributeComboBox.SelectedItem.ToString();
            if (!newClass.isNameValid(attributeName))
            {
                MessageBox.Show(
                   $"name od attribute: '{attributeName}' is already taken!",
                   "Wrong attributeName",
                   MessageBoxButtons.OK
                   );
            }
            else
            {
                newClass.addAttribute(attributeName, attributeType);
                NewClassAttributesListBox.Items.Add(attributeName + '\t' + attributeType);
                AttributeNameTextBox.Text = "";
                TypeOfAttributeComboBox.SelectedIndex = -1;
            }
        }

        private void DeleteAttributeButton_Click(object sender, EventArgs e)
        {
            var attributeToDelete = NewClassAttributesListBox.SelectedItem;
            var attributeName = attributeToDelete.ToString().Split('\t')[0];
            newClass.deleteAttribute(attributeName);
            NewClassAttributesListBox.Items.Remove(attributeToDelete);
            NewClassAttributesListBox.SelectedIndex = -1;
        }

        private void NewClassAttributesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NewClassAttributesListBox.SelectedIndex != -1)
            {
                DeleteAttributeButton.Enabled = true;
            }
            else
            {
                DeleteAttributeButton.Enabled = false;
            }
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            ClassController.addClass(newClass);
            newClass = new NewClassContainer();
            cleanFields();
            InitializeBaseClassPicker();
        }

        private void cleanFields()
        {
            NameOfClassTextBox.Text = "";
            BaseClassComboBox.SelectedIndex = 0;
            BaseClassAttributesListBox.Items.Clear();
            NewClassAttributesListBox.Items.Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameOfClassTextBox_TextChanged(object sender, EventArgs e)
        {
            var currentClassName = NameOfClassTextBox.Text.ToString();

            if (currentClassName.Length > 0)
            {
                if (ClassController.isClassNameTaken(currentClassName))
                {
                    NameOfClassTextBox.BackColor = Color.Red;
                    AddClassButton.Enabled = false;
                }
                else
                {
                    NameOfClassTextBox.BackColor = Color.LightGreen;
                    AddClassButton.Enabled = true;
                    newClass.setName(currentClassName);
                }
            }
            else
            {
                AddClassButton.Enabled = false;
                NameOfClassTextBox.BackColor = Color.White;
            }
        }


    }
}
