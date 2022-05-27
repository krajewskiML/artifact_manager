namespace artifact_manager2.GUI
{
    partial class UserRolesEditor
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
            this.PermissionListBox = new System.Windows.Forms.CheckedListBox();
            this.UsersPermissionsLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PermissionListBox
            // 
            this.PermissionListBox.FormattingEnabled = true;
            this.PermissionListBox.Location = new System.Drawing.Point(13, 46);
            this.PermissionListBox.Name = "PermissionListBox";
            this.PermissionListBox.Size = new System.Drawing.Size(184, 154);
            this.PermissionListBox.TabIndex = 0;
            this.PermissionListBox.SelectedIndexChanged += new System.EventHandler(this.PermissionListBox_SelectedIndexChanged);
            // 
            // UsersPermissionsLabel
            // 
            this.UsersPermissionsLabel.AutoSize = true;
            this.UsersPermissionsLabel.Location = new System.Drawing.Point(13, 13);
            this.UsersPermissionsLabel.Name = "UsersPermissionsLabel";
            this.UsersPermissionsLabel.Size = new System.Drawing.Size(36, 13);
            this.UsersPermissionsLabel.TabIndex = 1;
            this.UsersPermissionsLabel.Text = "to_set";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(16, 272);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(122, 272);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // UserRolesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 336);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UsersPermissionsLabel);
            this.Controls.Add(this.PermissionListBox);
            this.Name = "UserRolesEditor";
            this.Text = "UserRolesEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox PermissionListBox;
        private System.Windows.Forms.Label UsersPermissionsLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}