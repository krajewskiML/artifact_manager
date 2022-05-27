namespace artifact_manager2.GUI
{
    partial class CreateClassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BaseClassComboBox = new System.Windows.Forms.ComboBox();
            this.BaseClassPickerLabel = new System.Windows.Forms.Label();
            this.BaseClassAttributesLabel = new System.Windows.Forms.Label();
            this.BaseClassAttributesListBox = new System.Windows.Forms.ListBox();
            this.NameOfClassLabel = new System.Windows.Forms.Label();
            this.NameOfClassTextBox = new System.Windows.Forms.TextBox();
            this.NewClassAttributesListBox = new System.Windows.Forms.ListBox();
            this.NewAttributeLabel = new System.Windows.Forms.Label();
            this.AttributeNameLabel = new System.Windows.Forms.Label();
            this.AttributeNameTextBox = new System.Windows.Forms.TextBox();
            this.TypeOfAttributeComboBox = new System.Windows.Forms.ComboBox();
            this.AttributeTypeLabel = new System.Windows.Forms.Label();
            this.DeleteAttributeButton = new System.Windows.Forms.Button();
            this.AddAttributeButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddClassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BaseClassComboBox
            // 
            this.BaseClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaseClassComboBox.FormattingEnabled = true;
            this.BaseClassComboBox.Location = new System.Drawing.Point(143, 69);
            this.BaseClassComboBox.Name = "BaseClassComboBox";
            this.BaseClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.BaseClassComboBox.TabIndex = 0;
            this.BaseClassComboBox.SelectedIndexChanged += new System.EventHandler(this.BaseClassComboBox_SelectedIndexChanged);
            // 
            // BaseClassPickerLabel
            // 
            this.BaseClassPickerLabel.AutoSize = true;
            this.BaseClassPickerLabel.Location = new System.Drawing.Point(13, 72);
            this.BaseClassPickerLabel.Name = "BaseClassPickerLabel";
            this.BaseClassPickerLabel.Size = new System.Drawing.Size(107, 13);
            this.BaseClassPickerLabel.TabIndex = 1;
            this.BaseClassPickerLabel.Text = "Base Class (Optional)";
            // 
            // BaseClassAttributesLabel
            // 
            this.BaseClassAttributesLabel.AutoSize = true;
            this.BaseClassAttributesLabel.Location = new System.Drawing.Point(13, 108);
            this.BaseClassAttributesLabel.Name = "BaseClassAttributesLabel";
            this.BaseClassAttributesLabel.Size = new System.Drawing.Size(113, 13);
            this.BaseClassAttributesLabel.TabIndex = 2;
            this.BaseClassAttributesLabel.Text = "Base Class\'s Attributes";
            // 
            // BaseClassAttributesListBox
            // 
            this.BaseClassAttributesListBox.Enabled = false;
            this.BaseClassAttributesListBox.FormattingEnabled = true;
            this.BaseClassAttributesListBox.Location = new System.Drawing.Point(143, 108);
            this.BaseClassAttributesListBox.Name = "BaseClassAttributesListBox";
            this.BaseClassAttributesListBox.Size = new System.Drawing.Size(120, 160);
            this.BaseClassAttributesListBox.TabIndex = 3;
            // 
            // NameOfClassLabel
            // 
            this.NameOfClassLabel.AutoSize = true;
            this.NameOfClassLabel.Location = new System.Drawing.Point(13, 31);
            this.NameOfClassLabel.Name = "NameOfClassLabel";
            this.NameOfClassLabel.Size = new System.Drawing.Size(75, 13);
            this.NameOfClassLabel.TabIndex = 4;
            this.NameOfClassLabel.Text = "Name of Class";
            // 
            // NameOfClassTextBox
            // 
            this.NameOfClassTextBox.Location = new System.Drawing.Point(143, 31);
            this.NameOfClassTextBox.Name = "NameOfClassTextBox";
            this.NameOfClassTextBox.Size = new System.Drawing.Size(121, 20);
            this.NameOfClassTextBox.TabIndex = 5;
            this.NameOfClassTextBox.TextChanged += new System.EventHandler(this.NameOfClassTextBox_TextChanged);
            // 
            // NewClassAttributesListBox
            // 
            this.NewClassAttributesListBox.FormattingEnabled = true;
            this.NewClassAttributesListBox.Location = new System.Drawing.Point(422, 108);
            this.NewClassAttributesListBox.Name = "NewClassAttributesListBox";
            this.NewClassAttributesListBox.Size = new System.Drawing.Size(120, 160);
            this.NewClassAttributesListBox.TabIndex = 6;
            this.NewClassAttributesListBox.SelectedIndexChanged += new System.EventHandler(this.NewClassAttributesListBox_SelectedIndexChanged);
            // 
            // NewAttributeLabel
            // 
            this.NewAttributeLabel.AutoSize = true;
            this.NewAttributeLabel.Location = new System.Drawing.Point(305, 108);
            this.NewAttributeLabel.Name = "NewAttributeLabel";
            this.NewAttributeLabel.Size = new System.Drawing.Size(111, 13);
            this.NewAttributeLabel.TabIndex = 7;
            this.NewAttributeLabel.Text = "New Class\'s Attributes";
            // 
            // AttributeNameLabel
            // 
            this.AttributeNameLabel.AutoSize = true;
            this.AttributeNameLabel.Location = new System.Drawing.Point(308, 31);
            this.AttributeNameLabel.Name = "AttributeNameLabel";
            this.AttributeNameLabel.Size = new System.Drawing.Size(77, 13);
            this.AttributeNameLabel.TabIndex = 8;
            this.AttributeNameLabel.Text = "Attribute Name";
            // 
            // AttributeNameTextBox
            // 
            this.AttributeNameTextBox.Location = new System.Drawing.Point(422, 31);
            this.AttributeNameTextBox.Name = "AttributeNameTextBox";
            this.AttributeNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.AttributeNameTextBox.TabIndex = 9;
            this.AttributeNameTextBox.TextChanged += new System.EventHandler(this.AttributeNameTextBox_TextChanged);
            // 
            // TypeOfAttributeComboBox
            // 
            this.TypeOfAttributeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeOfAttributeComboBox.FormattingEnabled = true;
            this.TypeOfAttributeComboBox.Items.AddRange(new object[] {
            "Integer",
            "Float",
            "String"});
            this.TypeOfAttributeComboBox.Location = new System.Drawing.Point(421, 69);
            this.TypeOfAttributeComboBox.Name = "TypeOfAttributeComboBox";
            this.TypeOfAttributeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeOfAttributeComboBox.TabIndex = 10;
            this.TypeOfAttributeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeOfAttributeComboBox_SelectedIndexChanged);
            // 
            // AttributeTypeLabel
            // 
            this.AttributeTypeLabel.AutoSize = true;
            this.AttributeTypeLabel.Location = new System.Drawing.Point(308, 69);
            this.AttributeTypeLabel.Name = "AttributeTypeLabel";
            this.AttributeTypeLabel.Size = new System.Drawing.Size(73, 13);
            this.AttributeTypeLabel.TabIndex = 11;
            this.AttributeTypeLabel.Text = "Attribute Type";
            // 
            // DeleteAttributeButton
            // 
            this.DeleteAttributeButton.Enabled = false;
            this.DeleteAttributeButton.Location = new System.Drawing.Point(576, 108);
            this.DeleteAttributeButton.Name = "DeleteAttributeButton";
            this.DeleteAttributeButton.Size = new System.Drawing.Size(121, 23);
            this.DeleteAttributeButton.TabIndex = 12;
            this.DeleteAttributeButton.Text = "Delete Attribute";
            this.DeleteAttributeButton.UseVisualStyleBackColor = true;
            this.DeleteAttributeButton.Click += new System.EventHandler(this.DeleteAttributeButton_Click);
            // 
            // AddAttributeButton
            // 
            this.AddAttributeButton.Enabled = false;
            this.AddAttributeButton.Location = new System.Drawing.Point(576, 31);
            this.AddAttributeButton.Name = "AddAttributeButton";
            this.AddAttributeButton.Size = new System.Drawing.Size(121, 23);
            this.AddAttributeButton.TabIndex = 13;
            this.AddAttributeButton.Text = "Add Attribute";
            this.AddAttributeButton.UseVisualStyleBackColor = true;
            this.AddAttributeButton.Click += new System.EventHandler(this.AddAttributeButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(143, 312);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddClassButton
            // 
            this.AddClassButton.Enabled = false;
            this.AddClassButton.Location = new System.Drawing.Point(422, 312);
            this.AddClassButton.Name = "AddClassButton";
            this.AddClassButton.Size = new System.Drawing.Size(120, 23);
            this.AddClassButton.TabIndex = 15;
            this.AddClassButton.Text = "Add Class";
            this.AddClassButton.UseVisualStyleBackColor = true;
            this.AddClassButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // CreateClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 389);
            this.Controls.Add(this.AddClassButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddAttributeButton);
            this.Controls.Add(this.DeleteAttributeButton);
            this.Controls.Add(this.AttributeTypeLabel);
            this.Controls.Add(this.TypeOfAttributeComboBox);
            this.Controls.Add(this.AttributeNameTextBox);
            this.Controls.Add(this.AttributeNameLabel);
            this.Controls.Add(this.NewAttributeLabel);
            this.Controls.Add(this.NewClassAttributesListBox);
            this.Controls.Add(this.NameOfClassTextBox);
            this.Controls.Add(this.NameOfClassLabel);
            this.Controls.Add(this.BaseClassAttributesListBox);
            this.Controls.Add(this.BaseClassAttributesLabel);
            this.Controls.Add(this.BaseClassPickerLabel);
            this.Controls.Add(this.BaseClassComboBox);
            this.Name = "CreateClassForm";
            this.Text = "CreateClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BaseClassComboBox;
        private System.Windows.Forms.Label BaseClassPickerLabel;
        private System.Windows.Forms.Label BaseClassAttributesLabel;
        private System.Windows.Forms.ListBox BaseClassAttributesListBox;
        private System.Windows.Forms.Label NameOfClassLabel;
        private System.Windows.Forms.TextBox NameOfClassTextBox;
        private System.Windows.Forms.ListBox NewClassAttributesListBox;
        private System.Windows.Forms.Label NewAttributeLabel;
        private System.Windows.Forms.Label AttributeNameLabel;
        private System.Windows.Forms.TextBox AttributeNameTextBox;
        private System.Windows.Forms.ComboBox TypeOfAttributeComboBox;
        private System.Windows.Forms.Label AttributeTypeLabel;
        private System.Windows.Forms.Button DeleteAttributeButton;
        private System.Windows.Forms.Button AddAttributeButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddClassButton;
    }
}