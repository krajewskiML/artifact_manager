namespace artifact_manager2.GUI
{
    partial class EditClassForm
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
            this.ClassLabel = new System.Windows.Forms.Label();
            this.ClassPickerComboBox = new System.Windows.Forms.ComboBox();
            this.UniqueAttributesLabel = new System.Windows.Forms.Label();
            this.AttributesListBox = new System.Windows.Forms.ListBox();
            this.DeleteAttributeButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.NewNameTextBox = new System.Windows.Forms.TextBox();
            this.NewAttributeNameLabel = new System.Windows.Forms.Label();
            this.AddAttributeButton = new System.Windows.Forms.Button();
            this.AttributeTypeLabel = new System.Windows.Forms.Label();
            this.TypeOfAttributeComboBox = new System.Windows.Forms.ComboBox();
            this.AttributeNameTextBox = new System.Windows.Forms.TextBox();
            this.AttributeNameLabel = new System.Windows.Forms.Label();
            this.DefaultValueLabel = new System.Windows.Forms.Label();
            this.DefaultValueTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(13, 13);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(32, 13);
            this.ClassLabel.TabIndex = 0;
            this.ClassLabel.Text = "Class";
            // 
            // ClassPickerComboBox
            // 
            this.ClassPickerComboBox.FormattingEnabled = true;
            this.ClassPickerComboBox.Location = new System.Drawing.Point(123, 10);
            this.ClassPickerComboBox.Name = "ClassPickerComboBox";
            this.ClassPickerComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassPickerComboBox.TabIndex = 1;
            this.ClassPickerComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassPickerComboBox_SelectedIndexChanged);
            // 
            // UniqueAttributesLabel
            // 
            this.UniqueAttributesLabel.AutoSize = true;
            this.UniqueAttributesLabel.Location = new System.Drawing.Point(13, 61);
            this.UniqueAttributesLabel.Name = "UniqueAttributesLabel";
            this.UniqueAttributesLabel.Size = new System.Drawing.Size(88, 13);
            this.UniqueAttributesLabel.TabIndex = 2;
            this.UniqueAttributesLabel.Text = "Unique Attributes";
            // 
            // AttributesListBox
            // 
            this.AttributesListBox.FormattingEnabled = true;
            this.AttributesListBox.Location = new System.Drawing.Point(123, 61);
            this.AttributesListBox.Name = "AttributesListBox";
            this.AttributesListBox.Size = new System.Drawing.Size(120, 121);
            this.AttributesListBox.TabIndex = 3;
            this.AttributesListBox.SelectedIndexChanged += new System.EventHandler(this.AttributesListBox_SelectedIndexChanged);
            // 
            // DeleteAttributeButton
            // 
            this.DeleteAttributeButton.Enabled = false;
            this.DeleteAttributeButton.Location = new System.Drawing.Point(124, 221);
            this.DeleteAttributeButton.Name = "DeleteAttributeButton";
            this.DeleteAttributeButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteAttributeButton.TabIndex = 4;
            this.DeleteAttributeButton.Text = "Delete";
            this.DeleteAttributeButton.UseVisualStyleBackColor = true;
            this.DeleteAttributeButton.Click += new System.EventHandler(this.DeleteAttributeButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Enabled = false;
            this.RenameButton.Location = new System.Drawing.Point(123, 329);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(121, 23);
            this.RenameButton.TabIndex = 5;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // NewNameTextBox
            // 
            this.NewNameTextBox.Location = new System.Drawing.Point(123, 278);
            this.NewNameTextBox.Name = "NewNameTextBox";
            this.NewNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.NewNameTextBox.TabIndex = 6;
            this.NewNameTextBox.TextChanged += new System.EventHandler(this.NewNameTextBox_TextChanged);
            // 
            // NewAttributeNameLabel
            // 
            this.NewAttributeNameLabel.AutoSize = true;
            this.NewAttributeNameLabel.Location = new System.Drawing.Point(16, 284);
            this.NewAttributeNameLabel.Name = "NewAttributeNameLabel";
            this.NewAttributeNameLabel.Size = new System.Drawing.Size(102, 13);
            this.NewAttributeNameLabel.TabIndex = 7;
            this.NewAttributeNameLabel.Text = "New Attribute Name";
            // 
            // AddAttributeButton
            // 
            this.AddAttributeButton.Enabled = false;
            this.AddAttributeButton.Location = new System.Drawing.Point(387, 141);
            this.AddAttributeButton.Name = "AddAttributeButton";
            this.AddAttributeButton.Size = new System.Drawing.Size(121, 23);
            this.AddAttributeButton.TabIndex = 18;
            this.AddAttributeButton.Text = "Add Attribute";
            this.AddAttributeButton.UseVisualStyleBackColor = true;
            this.AddAttributeButton.Click += new System.EventHandler(this.AddAttributeButton_Click);
            // 
            // AttributeTypeLabel
            // 
            this.AttributeTypeLabel.AutoSize = true;
            this.AttributeTypeLabel.Location = new System.Drawing.Point(274, 51);
            this.AttributeTypeLabel.Name = "AttributeTypeLabel";
            this.AttributeTypeLabel.Size = new System.Drawing.Size(73, 13);
            this.AttributeTypeLabel.TabIndex = 17;
            this.AttributeTypeLabel.Text = "Attribute Type";
            // 
            // TypeOfAttributeComboBox
            // 
            this.TypeOfAttributeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeOfAttributeComboBox.FormattingEnabled = true;
            this.TypeOfAttributeComboBox.Items.AddRange(new object[] {
            "Integer",
            "Float",
            "String"});
            this.TypeOfAttributeComboBox.Location = new System.Drawing.Point(387, 51);
            this.TypeOfAttributeComboBox.Name = "TypeOfAttributeComboBox";
            this.TypeOfAttributeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeOfAttributeComboBox.TabIndex = 16;
            // 
            // AttributeNameTextBox
            // 
            this.AttributeNameTextBox.Location = new System.Drawing.Point(388, 13);
            this.AttributeNameTextBox.Name = "AttributeNameTextBox";
            this.AttributeNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.AttributeNameTextBox.TabIndex = 15;
            this.AttributeNameTextBox.TextChanged += new System.EventHandler(this.AttributeNameTextBox_TextChanged);
            // 
            // AttributeNameLabel
            // 
            this.AttributeNameLabel.AutoSize = true;
            this.AttributeNameLabel.Location = new System.Drawing.Point(274, 13);
            this.AttributeNameLabel.Name = "AttributeNameLabel";
            this.AttributeNameLabel.Size = new System.Drawing.Size(77, 13);
            this.AttributeNameLabel.TabIndex = 14;
            this.AttributeNameLabel.Text = "Attribute Name";
            // 
            // DefaultValueLabel
            // 
            this.DefaultValueLabel.AutoSize = true;
            this.DefaultValueLabel.Location = new System.Drawing.Point(277, 91);
            this.DefaultValueLabel.Name = "DefaultValueLabel";
            this.DefaultValueLabel.Size = new System.Drawing.Size(71, 13);
            this.DefaultValueLabel.TabIndex = 19;
            this.DefaultValueLabel.Text = "Default Value";
            // 
            // DefaultValueTextBox
            // 
            this.DefaultValueTextBox.Location = new System.Drawing.Point(387, 91);
            this.DefaultValueTextBox.Name = "DefaultValueTextBox";
            this.DefaultValueTextBox.Size = new System.Drawing.Size(121, 20);
            this.DefaultValueTextBox.TabIndex = 20;
            this.DefaultValueTextBox.TextChanged += new System.EventHandler(this.DefaultValueTextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(388, 220);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 23);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 372);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DefaultValueTextBox);
            this.Controls.Add(this.DefaultValueLabel);
            this.Controls.Add(this.AddAttributeButton);
            this.Controls.Add(this.AttributeTypeLabel);
            this.Controls.Add(this.TypeOfAttributeComboBox);
            this.Controls.Add(this.AttributeNameTextBox);
            this.Controls.Add(this.AttributeNameLabel);
            this.Controls.Add(this.NewAttributeNameLabel);
            this.Controls.Add(this.NewNameTextBox);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.DeleteAttributeButton);
            this.Controls.Add(this.AttributesListBox);
            this.Controls.Add(this.UniqueAttributesLabel);
            this.Controls.Add(this.ClassPickerComboBox);
            this.Controls.Add(this.ClassLabel);
            this.Name = "EditClassForm";
            this.Text = "EditClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.ComboBox ClassPickerComboBox;
        private System.Windows.Forms.Label UniqueAttributesLabel;
        private System.Windows.Forms.ListBox AttributesListBox;
        private System.Windows.Forms.Button DeleteAttributeButton;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.TextBox NewNameTextBox;
        private System.Windows.Forms.Label NewAttributeNameLabel;
        private System.Windows.Forms.Button AddAttributeButton;
        private System.Windows.Forms.Label AttributeTypeLabel;
        private System.Windows.Forms.ComboBox TypeOfAttributeComboBox;
        private System.Windows.Forms.TextBox AttributeNameTextBox;
        private System.Windows.Forms.Label AttributeNameLabel;
        private System.Windows.Forms.Label DefaultValueLabel;
        private System.Windows.Forms.TextBox DefaultValueTextBox;
        private System.Windows.Forms.Button CancelButton;
    }
}