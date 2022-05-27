namespace artifact_manager2.GUI
{
    partial class RoleEdiorForm
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
            this.PermissionsListBox = new System.Windows.Forms.CheckedListBox();
            this.NewPermissionsLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PermissionsListBox
            // 
            this.PermissionsListBox.FormattingEnabled = true;
            this.PermissionsListBox.Items.AddRange(new object[] {
            "IsAdmin",
            "CanAddClasses",
            "CanUpdateClasses",
            "CanDeleteClasses",
            "CanAddRecords",
            "CanUpdateRecords",
            "CanDeleteRecords"});
            this.PermissionsListBox.Location = new System.Drawing.Point(38, 47);
            this.PermissionsListBox.Name = "PermissionsListBox";
            this.PermissionsListBox.Size = new System.Drawing.Size(134, 124);
            this.PermissionsListBox.TabIndex = 0;
            this.PermissionsListBox.SelectedIndexChanged += new System.EventHandler(this.PermissionsListBox_SelectedIndexChanged);
            // 
            // NewPermissionsLabel
            // 
            this.NewPermissionsLabel.AutoSize = true;
            this.NewPermissionsLabel.Location = new System.Drawing.Point(38, 13);
            this.NewPermissionsLabel.Name = "NewPermissionsLabel";
            this.NewPermissionsLabel.Size = new System.Drawing.Size(87, 13);
            this.NewPermissionsLabel.TabIndex = 1;
            this.NewPermissionsLabel.Text = "New Permissions";
            // 
            // OkButton
            // 
            this.OkButton.Enabled = false;
            this.OkButton.Location = new System.Drawing.Point(194, 225);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(38, 225);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RoleEdiorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 355);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NewPermissionsLabel);
            this.Controls.Add(this.PermissionsListBox);
            this.Name = "RoleEdiorForm";
            this.Text = "RoleEdiorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox PermissionsListBox;
        private System.Windows.Forms.Label NewPermissionsLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}