namespace artifact_manager2.GUI
{
    partial class BrowseArtifactsForm
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
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ClassPickerComboBox = new System.Windows.Forms.ComboBox();
            this.ArtifactsLabel = new System.Windows.Forms.Label();
            this.ArtifactsListBox = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(13, 13);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category";
            // 
            // ClassPickerComboBox
            // 
            this.ClassPickerComboBox.FormattingEnabled = true;
            this.ClassPickerComboBox.Location = new System.Drawing.Point(102, 10);
            this.ClassPickerComboBox.Name = "ClassPickerComboBox";
            this.ClassPickerComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassPickerComboBox.TabIndex = 1;
            this.ClassPickerComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassPickerComboBox_SelectedIndexChanged);
            // 
            // ArtifactsLabel
            // 
            this.ArtifactsLabel.AutoSize = true;
            this.ArtifactsLabel.Location = new System.Drawing.Point(16, 60);
            this.ArtifactsLabel.Name = "ArtifactsLabel";
            this.ArtifactsLabel.Size = new System.Drawing.Size(45, 13);
            this.ArtifactsLabel.TabIndex = 2;
            this.ArtifactsLabel.Text = "Artifacts";
            // 
            // ArtifactsListBox
            // 
            this.ArtifactsListBox.Enabled = false;
            this.ArtifactsListBox.FormattingEnabled = true;
            this.ArtifactsListBox.Location = new System.Drawing.Point(102, 60);
            this.ArtifactsListBox.Name = "ArtifactsListBox";
            this.ArtifactsListBox.Size = new System.Drawing.Size(390, 212);
            this.ArtifactsListBox.TabIndex = 3;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(240, 286);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BrowseArtifactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 321);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ArtifactsListBox);
            this.Controls.Add(this.ArtifactsLabel);
            this.Controls.Add(this.ClassPickerComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Name = "BrowseArtifactsForm";
            this.Text = "BrowseArtifactsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox ClassPickerComboBox;
        private System.Windows.Forms.Label ArtifactsLabel;
        private System.Windows.Forms.ListBox ArtifactsListBox;
        private System.Windows.Forms.Button OKButton;
    }
}