namespace artifact_manager2.GUI
{
    partial class DeleteClassForm
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
            this.ClassToDeleteLabel = new System.Windows.Forms.Label();
            this.PickClassComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassToDeleteLabel
            // 
            this.ClassToDeleteLabel.AutoSize = true;
            this.ClassToDeleteLabel.Location = new System.Drawing.Point(13, 13);
            this.ClassToDeleteLabel.Name = "ClassToDeleteLabel";
            this.ClassToDeleteLabel.Size = new System.Drawing.Size(32, 13);
            this.ClassToDeleteLabel.TabIndex = 0;
            this.ClassToDeleteLabel.Text = "Class";
            // 
            // PickClassComboBox
            // 
            this.PickClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PickClassComboBox.FormattingEnabled = true;
            this.PickClassComboBox.Location = new System.Drawing.Point(90, 13);
            this.PickClassComboBox.Name = "PickClassComboBox";
            this.PickClassComboBox.Size = new System.Drawing.Size(171, 21);
            this.PickClassComboBox.TabIndex = 1;
            this.PickClassComboBox.SelectedIndexChanged += new System.EventHandler(this.PickClassComboBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(16, 86);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(176, 85);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 161);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PickClassComboBox);
            this.Controls.Add(this.ClassToDeleteLabel);
            this.Name = "DeleteClassForm";
            this.Text = "DeleteClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClassToDeleteLabel;
        private System.Windows.Forms.ComboBox PickClassComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}