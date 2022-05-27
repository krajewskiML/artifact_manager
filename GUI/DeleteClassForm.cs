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
    public partial class DeleteClassForm : Form
    {
        public DeleteClassForm()
        {
            InitializeComponent();
            InitializeClassPicker();
        }

        private void InitializeClassPicker()
        {
            var classNames = ClassController.getClassesName();
            PickClassComboBox.Items.Clear();
            foreach (var className in classNames)
            {
                if (className != ClassController.CHARACTER_BASE_CLASS)
                {
                    PickClassComboBox.Items.Add(className);
                }
                
            }
            
            PickClassComboBox.SelectedIndex = -1;
        }

        private void PickClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PickClassComboBox.SelectedIndex == -1 || PickClassComboBox.Items.Count ==0)
            {
                DeleteButton.Enabled = false;
            }
            else
            {
                DeleteButton.Enabled = true;
            }
        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var classToDelete = PickClassComboBox.SelectedItem.ToString();
            ClassController.deleteClass(classToDelete);
            InitializeClassPicker();
        }
    }
}
