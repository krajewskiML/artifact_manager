namespace artifact_manager2.GUI
{
    partial class DeleteEntityForm
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
            this.EntitiesListBox = new System.Windows.Forms.ListBox();
            this.ClassPickerComboBox = new System.Windows.Forms.ComboBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.RepresentantsLabel = new System.Windows.Forms.Label();
            this.DeleteEntityButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntitiesListBox
            // 
            this.EntitiesListBox.FormattingEnabled = true;
            this.EntitiesListBox.Location = new System.Drawing.Point(118, 45);
            this.EntitiesListBox.Name = "EntitiesListBox";
            this.EntitiesListBox.Size = new System.Drawing.Size(474, 173);
            this.EntitiesListBox.TabIndex = 0;
            this.EntitiesListBox.SelectedIndexChanged += new System.EventHandler(this.EntitiesListBox_SelectedIndexChanged);
            // 
            // ClassPickerComboBox
            // 
            this.ClassPickerComboBox.FormattingEnabled = true;
            this.ClassPickerComboBox.Location = new System.Drawing.Point(119, 12);
            this.ClassPickerComboBox.Name = "ClassPickerComboBox";
            this.ClassPickerComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassPickerComboBox.TabIndex = 1;
            this.ClassPickerComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassPickerComboBox_SelectedIndexChanged);
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(13, 19);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(32, 13);
            this.ClassLabel.TabIndex = 2;
            this.ClassLabel.Text = "Class";
            // 
            // RepresentantsLabel
            // 
            this.RepresentantsLabel.AutoSize = true;
            this.RepresentantsLabel.Location = new System.Drawing.Point(16, 45);
            this.RepresentantsLabel.Name = "RepresentantsLabel";
            this.RepresentantsLabel.Size = new System.Drawing.Size(76, 13);
            this.RepresentantsLabel.TabIndex = 3;
            this.RepresentantsLabel.Text = "Representants";
            // 
            // DeleteEntityButton
            // 
            this.DeleteEntityButton.Enabled = false;
            this.DeleteEntityButton.Location = new System.Drawing.Point(119, 262);
            this.DeleteEntityButton.Name = "DeleteEntityButton";
            this.DeleteEntityButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteEntityButton.TabIndex = 4;
            this.DeleteEntityButton.Text = "Delete Entity";
            this.DeleteEntityButton.UseVisualStyleBackColor = true;
            this.DeleteEntityButton.Click += new System.EventHandler(this.DeleteEntityButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(516, 261);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteEntityButton);
            this.Controls.Add(this.RepresentantsLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.ClassPickerComboBox);
            this.Controls.Add(this.EntitiesListBox);
            this.Name = "DeleteEntityForm";
            this.Text = "DeleteEntityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EntitiesListBox;
        private System.Windows.Forms.ComboBox ClassPickerComboBox;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label RepresentantsLabel;
        private System.Windows.Forms.Button DeleteEntityButton;
        private System.Windows.Forms.Button CancelButton;
    }
}