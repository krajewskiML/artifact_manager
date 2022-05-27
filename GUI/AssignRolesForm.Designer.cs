namespace artifact_manager2.GUI
{
    partial class AssignRolesForm
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
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersListBox
            // 
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.Location = new System.Drawing.Point(12, 27);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(165, 212);
            this.UsersListBox.TabIndex = 0;
            this.UsersListBox.SelectedIndexChanged += new System.EventHandler(this.UsersListBox_SelectedIndexChanged);
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Location = new System.Drawing.Point(13, 11);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(34, 13);
            this.UsersLabel.TabIndex = 1;
            this.UsersLabel.Text = "Users";
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(12, 264);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(165, 23);
            this.EditUserButton.TabIndex = 2;
            this.EditUserButton.Text = "Edit user";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // AssignRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 324);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.UsersListBox);
            this.Name = "AssignRolesForm";
            this.Text = "AssignRolesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.Button EditUserButton;
    }
}