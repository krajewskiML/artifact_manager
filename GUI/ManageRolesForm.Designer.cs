namespace artifact_manager2.GUI
{
    partial class ManageRolesForm
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
            this.RolesLabel = new System.Windows.Forms.Label();
            this.RolesListBox = new System.Windows.Forms.ListBox();
            this.DeleteRoleButton = new System.Windows.Forms.Button();
            this.RolePropertiesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewRoleNameTextBox = new System.Windows.Forms.TextBox();
            this.NewRoleNameLabel = new System.Windows.Forms.Label();
            this.AddNewRoleButton = new System.Windows.Forms.Button();
            this.EditRoleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RolesLabel
            // 
            this.RolesLabel.AutoSize = true;
            this.RolesLabel.Location = new System.Drawing.Point(34, 27);
            this.RolesLabel.Name = "RolesLabel";
            this.RolesLabel.Size = new System.Drawing.Size(34, 13);
            this.RolesLabel.TabIndex = 0;
            this.RolesLabel.Text = "Roles";
            // 
            // RolesListBox
            // 
            this.RolesListBox.FormattingEnabled = true;
            this.RolesListBox.Location = new System.Drawing.Point(37, 62);
            this.RolesListBox.Name = "RolesListBox";
            this.RolesListBox.Size = new System.Drawing.Size(120, 160);
            this.RolesListBox.TabIndex = 1;
            this.RolesListBox.SelectedIndexChanged += new System.EventHandler(this.RolesListBox_SelectedIndexChanged);
            // 
            // DeleteRoleButton
            // 
            this.DeleteRoleButton.Location = new System.Drawing.Point(37, 263);
            this.DeleteRoleButton.Name = "DeleteRoleButton";
            this.DeleteRoleButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteRoleButton.TabIndex = 2;
            this.DeleteRoleButton.Text = "Delete role";
            this.DeleteRoleButton.UseVisualStyleBackColor = true;
            this.DeleteRoleButton.Click += new System.EventHandler(this.DeleteRoleButton_Click);
            // 
            // RolePropertiesCheckedListBox
            // 
            this.RolePropertiesCheckedListBox.FormattingEnabled = true;
            this.RolePropertiesCheckedListBox.Items.AddRange(new object[] {
            "IsAdmin",
            "CanAddClasses",
            "CanUpdateClasses",
            "CanDeleteClasses",
            "CanAddRecords",
            "CanUpdateRecords",
            "CanDeleteRecords"});
            this.RolePropertiesCheckedListBox.Location = new System.Drawing.Point(244, 62);
            this.RolePropertiesCheckedListBox.Name = "RolePropertiesCheckedListBox";
            this.RolePropertiesCheckedListBox.Size = new System.Drawing.Size(120, 154);
            this.RolePropertiesCheckedListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "New role";
            // 
            // NewRoleNameTextBox
            // 
            this.NewRoleNameTextBox.Location = new System.Drawing.Point(244, 266);
            this.NewRoleNameTextBox.Name = "NewRoleNameTextBox";
            this.NewRoleNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.NewRoleNameTextBox.TabIndex = 5;
            this.NewRoleNameTextBox.TextChanged += new System.EventHandler(this.NewRoleNameTextBox_TextChanged);
            // 
            // NewRoleNameLabel
            // 
            this.NewRoleNameLabel.AutoSize = true;
            this.NewRoleNameLabel.Location = new System.Drawing.Point(247, 247);
            this.NewRoleNameLabel.Name = "NewRoleNameLabel";
            this.NewRoleNameLabel.Size = new System.Drawing.Size(78, 13);
            this.NewRoleNameLabel.TabIndex = 6;
            this.NewRoleNameLabel.Text = "New role name";
            // 
            // AddNewRoleButton
            // 
            this.AddNewRoleButton.Enabled = false;
            this.AddNewRoleButton.Location = new System.Drawing.Point(244, 320);
            this.AddNewRoleButton.Name = "AddNewRoleButton";
            this.AddNewRoleButton.Size = new System.Drawing.Size(120, 23);
            this.AddNewRoleButton.TabIndex = 7;
            this.AddNewRoleButton.Text = "Add role";
            this.AddNewRoleButton.UseVisualStyleBackColor = true;
            this.AddNewRoleButton.Click += new System.EventHandler(this.AddNewRoleButton_Click);
            // 
            // EditRoleButton
            // 
            this.EditRoleButton.Location = new System.Drawing.Point(37, 319);
            this.EditRoleButton.Name = "EditRoleButton";
            this.EditRoleButton.Size = new System.Drawing.Size(120, 23);
            this.EditRoleButton.TabIndex = 8;
            this.EditRoleButton.Text = "Edit role";
            this.EditRoleButton.UseVisualStyleBackColor = true;
            this.EditRoleButton.Click += new System.EventHandler(this.EditRoleButton_Click);
            // 
            // ManageRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.EditRoleButton);
            this.Controls.Add(this.AddNewRoleButton);
            this.Controls.Add(this.NewRoleNameLabel);
            this.Controls.Add(this.NewRoleNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RolePropertiesCheckedListBox);
            this.Controls.Add(this.DeleteRoleButton);
            this.Controls.Add(this.RolesListBox);
            this.Controls.Add(this.RolesLabel);
            this.Name = "ManageRolesForm";
            this.Text = "ManageRolesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RolesLabel;
        private System.Windows.Forms.ListBox RolesListBox;
        private System.Windows.Forms.Button DeleteRoleButton;
        private System.Windows.Forms.CheckedListBox RolePropertiesCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewRoleNameTextBox;
        private System.Windows.Forms.Label NewRoleNameLabel;
        private System.Windows.Forms.Button AddNewRoleButton;
        private System.Windows.Forms.Button EditRoleButton;
    }
}