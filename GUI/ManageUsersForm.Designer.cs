namespace artifact_manager2.GUI
{
    partial class ManageUsersForm
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
            this.UsersList = new System.Windows.Forms.ListBox();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordButton = new System.Windows.Forms.Button();
            this.NewUsernameTextBox = new System.Windows.Forms.TextBox();
            this.NewUserLabel = new System.Windows.Forms.Label();
            this.NewUsernameLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.NewUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UpdatePasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsersList
            // 
            this.UsersList.FormattingEnabled = true;
            this.UsersList.Location = new System.Drawing.Point(37, 45);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(120, 186);
            this.UsersList.TabIndex = 0;
            this.UsersList.SelectedIndexChanged += new System.EventHandler(this.UsersList_SelectedIndexChanged);
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Location = new System.Drawing.Point(37, 13);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(34, 13);
            this.UsersLabel.TabIndex = 1;
            this.UsersLabel.Text = "Users";
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Enabled = false;
            this.DeleteUserButton.Location = new System.Drawing.Point(37, 258);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteUserButton.TabIndex = 2;
            this.DeleteUserButton.Text = "Delete user";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(37, 326);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(120, 20);
            this.NewPasswordTextBox.TabIndex = 3;
            this.NewPasswordTextBox.TextChanged += new System.EventHandler(this.NewPasswordTextBox_TextChanged);
            // 
            // NewPasswordButton
            // 
            this.NewPasswordButton.Enabled = false;
            this.NewPasswordButton.Location = new System.Drawing.Point(37, 363);
            this.NewPasswordButton.Name = "NewPasswordButton";
            this.NewPasswordButton.Size = new System.Drawing.Size(120, 23);
            this.NewPasswordButton.TabIndex = 4;
            this.NewPasswordButton.Text = "Change password";
            this.NewPasswordButton.UseVisualStyleBackColor = true;
            this.NewPasswordButton.Click += new System.EventHandler(this.NewPasswordButton_Click);
            // 
            // NewUsernameTextBox
            // 
            this.NewUsernameTextBox.Location = new System.Drawing.Point(321, 45);
            this.NewUsernameTextBox.Name = "NewUsernameTextBox";
            this.NewUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewUsernameTextBox.TabIndex = 5;
            this.NewUsernameTextBox.TextChanged += new System.EventHandler(this.NewUsernameTextBox_TextChanged);
            // 
            // NewUserLabel
            // 
            this.NewUserLabel.AutoSize = true;
            this.NewUserLabel.Location = new System.Drawing.Point(318, 13);
            this.NewUserLabel.Name = "NewUserLabel";
            this.NewUserLabel.Size = new System.Drawing.Size(54, 13);
            this.NewUserLabel.TabIndex = 6;
            this.NewUserLabel.Text = "New User";
            // 
            // NewUsernameLabel
            // 
            this.NewUsernameLabel.AutoSize = true;
            this.NewUsernameLabel.Location = new System.Drawing.Point(222, 51);
            this.NewUsernameLabel.Name = "NewUsernameLabel";
            this.NewUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.NewUsernameLabel.TabIndex = 7;
            this.NewUsernameLabel.Text = "Username";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(222, 107);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.NewPasswordLabel.TabIndex = 9;
            this.NewPasswordLabel.Text = "Password";
            // 
            // NewUserPasswordTextBox
            // 
            this.NewUserPasswordTextBox.Location = new System.Drawing.Point(321, 101);
            this.NewUserPasswordTextBox.Name = "NewUserPasswordTextBox";
            this.NewUserPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewUserPasswordTextBox.TabIndex = 8;
            this.NewUserPasswordTextBox.TextChanged += new System.EventHandler(this.NewUserPasswordTextBox_TextChanged);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Enabled = false;
            this.AddUserButton.Location = new System.Drawing.Point(321, 165);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(100, 23);
            this.AddUserButton.TabIndex = 10;
            this.AddUserButton.Text = "Add user";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UpdatePasswordLabel
            // 
            this.UpdatePasswordLabel.AutoSize = true;
            this.UpdatePasswordLabel.Location = new System.Drawing.Point(37, 307);
            this.UpdatePasswordLabel.Name = "UpdatePasswordLabel";
            this.UpdatePasswordLabel.Size = new System.Drawing.Size(77, 13);
            this.UpdatePasswordLabel.TabIndex = 11;
            this.UpdatePasswordLabel.Text = "New password";
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 424);
            this.Controls.Add(this.UpdatePasswordLabel);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.NewUserPasswordTextBox);
            this.Controls.Add(this.NewUsernameLabel);
            this.Controls.Add(this.NewUserLabel);
            this.Controls.Add(this.NewUsernameTextBox);
            this.Controls.Add(this.NewPasswordButton);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.UsersList);
            this.Name = "ManageUsersForm";
            this.Text = "ManageUsersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UsersList;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Button NewPasswordButton;
        private System.Windows.Forms.TextBox NewUsernameTextBox;
        private System.Windows.Forms.Label NewUserLabel;
        private System.Windows.Forms.Label NewUsernameLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox NewUserPasswordTextBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Label UpdatePasswordLabel;
    }
}