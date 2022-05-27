namespace artifact_manager2.GUI
{
    partial class AdminPanel
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
            this.ManageUsersButton = new System.Windows.Forms.Button();
            this.AddRoleButton = new System.Windows.Forms.Button();
            this.ManageRolesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageUsersButton
            // 
            this.ManageUsersButton.Location = new System.Drawing.Point(71, 27);
            this.ManageUsersButton.Name = "ManageUsersButton";
            this.ManageUsersButton.Size = new System.Drawing.Size(101, 23);
            this.ManageUsersButton.TabIndex = 0;
            this.ManageUsersButton.Text = "Manage Users";
            this.ManageUsersButton.UseVisualStyleBackColor = true;
            this.ManageUsersButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AddRoleButton
            // 
            this.AddRoleButton.Location = new System.Drawing.Point(71, 81);
            this.AddRoleButton.Name = "AddRoleButton";
            this.AddRoleButton.Size = new System.Drawing.Size(101, 23);
            this.AddRoleButton.TabIndex = 1;
            this.AddRoleButton.Text = "Manage Roles";
            this.AddRoleButton.UseVisualStyleBackColor = true;
            this.AddRoleButton.Click += new System.EventHandler(this.AddRoleButton_Click);
            // 
            // ManageRolesButton
            // 
            this.ManageRolesButton.Location = new System.Drawing.Point(71, 137);
            this.ManageRolesButton.Name = "ManageRolesButton";
            this.ManageRolesButton.Size = new System.Drawing.Size(101, 23);
            this.ManageRolesButton.TabIndex = 2;
            this.ManageRolesButton.Text = "Assign Roles";
            this.ManageRolesButton.UseVisualStyleBackColor = true;
            this.ManageRolesButton.Click += new System.EventHandler(this.ManageRolesButton_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 207);
            this.Controls.Add(this.ManageRolesButton);
            this.Controls.Add(this.AddRoleButton);
            this.Controls.Add(this.ManageUsersButton);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageUsersButton;
        private System.Windows.Forms.Button AddRoleButton;
        private System.Windows.Forms.Button ManageRolesButton;
    }
}