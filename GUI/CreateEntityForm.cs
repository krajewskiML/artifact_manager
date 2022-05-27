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
    public partial class CreateEntityForm : Form
    {
        public CreateEntityForm()
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

        private void loadAttributesSetter(string classname)
        {
            var attributes = ClassController.getClassesDescription(classname);
            AttributesLayoutPanel.Controls.Clear();
            AttributesLayoutPanel.AutoSize = true;
            AttributesLayoutPanel.RowCount = 2;
            AttributesLayoutPanel.ColumnCount = attributes.Count;
            float widthPercent = 100 / attributes.Count;
            float heigthPercent = 100 / 2;
            for(int i = 0; i < AttributesLayoutPanel.ColumnCount; i++)
            {
                AttributesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, widthPercent));
            }
            for (int i = 0; i < AttributesLayoutPanel.RowCount; i++)
            {
                AttributesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, heigthPercent));
            }
            // fill labels
            for(int i =0; i < AttributesLayoutPanel.ColumnCount; i++)
            {
                Label attributeLabel = new Label() { Text = attributes[i].Name};
                AttributesLayoutPanel.Controls.Add(attributeLabel, i, 0);
            }
            //fill textboxes
            for (int i = 0; i < AttributesLayoutPanel.ColumnCount; i++)
            {
                switch (attributes[i].TypeOfAttribute)
                {
                    case "String":
                        TextBox textBox = new TextBox();
                        AttributesLayoutPanel.Controls.Add(textBox, i, 1);
                        break;
                    case "Integer":
                        NumericUpDown numericUpDown = new NumericUpDown() {};
                        AttributesLayoutPanel.Controls.Add(numericUpDown, i, 1);
                        break;
                    case "Float":
                        NumericUpDown numericUpDownFloat = new NumericUpDown() { DecimalPlaces = 2};
                        AttributesLayoutPanel.Controls.Add(numericUpDownFloat, i, 1);
                        break;
                }     
            }
        }

        private bool validateValues()
        {
            for(int column = 0; column < AttributesLayoutPanel.ColumnCount; column++)
            {
                var control = AttributesLayoutPanel.GetControlFromPosition(column, 1);

                if (control.Text == "")
                {
                    return false;
                }

                
            }
            return true;
        }

        private void ClassPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var classname = ClassPickerComboBox.SelectedItem as string;
            loadAttributesSetter(classname);
        }

        private void CancelButon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Dictionary<string, string> getProperties()
        {
            var map = new Dictionary<string, string>();
            for(int column = 0; column < AttributesLayoutPanel.ColumnCount; column++)
            {
                var label = AttributesLayoutPanel.GetControlFromPosition(column, 0);
                var key = label.Text;
                var control = AttributesLayoutPanel.GetControlFromPosition(column, 1);
                if(control is TextBox)
                {
                    map.Add(key, control.Text.ToString());

                }
                if(control is NumericUpDown)
                {
                    map.Add(key, control.Text);
                }
            }
            return map;
        }

        private void AddEntityButton_Click(object sender, EventArgs e)
        {
            if(AttributesLayoutPanel.Controls.Count > 0)
            {
                if (validateValues())
                {
                    var classname = ClassPickerComboBox.SelectedItem as string;
                    var properties = getProperties();
                    EntityController.AddRecord(classname, properties);
                    MessageBox.Show(
                        "Entity has been added!",
                        "Entity added",
                        MessageBoxButtons.OK
                        );
                    resetAttributes();
                }
                else
                {
                    MessageBox.Show(
                        "Not all values have been properly provided",
                        "Wrong values",
                        MessageBoxButtons.OK
                        );
                }
            }
            else
            {
                MessageBox.Show(
                        "Class has not been choosen",
                        "No class",
                        MessageBoxButtons.OK
                        );
            }
            
        }

        private void resetAttributes()
        {
            for (int column = 0; column < AttributesLayoutPanel.ColumnCount; column++)
            {
                var label = AttributesLayoutPanel.GetControlFromPosition(column, 0);
                var key = label.Text;
                var control = AttributesLayoutPanel.GetControlFromPosition(column, 1);
                if (control is TextBox)
                {
                    control.Text = "";

                }
                if (control is NumericUpDown)
                {
                    control.Text = "";
                }
            }
        }
    }
}
