namespace artifact_manager2.GUI
{
    partial class CreateEntityForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClassPickerComboBox = new System.Windows.Forms.ComboBox();
            this.AttributesLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AttributesLabel = new System.Windows.Forms.Label();
            this.CancelButon = new System.Windows.Forms.Button();
            this.AddEntityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // ClassPickerComboBox
            // 
            this.ClassPickerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassPickerComboBox.FormattingEnabled = true;
            this.ClassPickerComboBox.Location = new System.Drawing.Point(87, 13);
            this.ClassPickerComboBox.Name = "ClassPickerComboBox";
            this.ClassPickerComboBox.Size = new System.Drawing.Size(240, 21);
            this.ClassPickerComboBox.TabIndex = 1;
            this.ClassPickerComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassPickerComboBox_SelectedIndexChanged);
            // 
            // AttributesLayoutPanel
            // 
            this.AttributesLayoutPanel.ColumnCount = 2;
            this.AttributesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttributesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttributesLayoutPanel.Location = new System.Drawing.Point(87, 60);
            this.AttributesLayoutPanel.Name = "AttributesLayoutPanel";
            this.AttributesLayoutPanel.RowCount = 2;
            this.AttributesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttributesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttributesLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.AttributesLayoutPanel.TabIndex = 2;
            // 
            // AttributesLabel
            // 
            this.AttributesLabel.AutoSize = true;
            this.AttributesLabel.Location = new System.Drawing.Point(16, 60);
            this.AttributesLabel.Name = "AttributesLabel";
            this.AttributesLabel.Size = new System.Drawing.Size(51, 13);
            this.AttributesLabel.TabIndex = 3;
            this.AttributesLabel.Text = "Attributes";
            // 
            // CancelButon
            // 
            this.CancelButon.Location = new System.Drawing.Point(87, 212);
            this.CancelButon.Name = "CancelButon";
            this.CancelButon.Size = new System.Drawing.Size(75, 23);
            this.CancelButon.TabIndex = 4;
            this.CancelButon.Text = "Cancel";
            this.CancelButon.UseVisualStyleBackColor = true;
            this.CancelButon.Click += new System.EventHandler(this.CancelButon_Click);
            // 
            // AddEntityButton
            // 
            this.AddEntityButton.Location = new System.Drawing.Point(211, 211);
            this.AddEntityButton.Name = "AddEntityButton";
            this.AddEntityButton.Size = new System.Drawing.Size(75, 23);
            this.AddEntityButton.TabIndex = 5;
            this.AddEntityButton.Text = "Add Entity";
            this.AddEntityButton.UseVisualStyleBackColor = true;
            this.AddEntityButton.Click += new System.EventHandler(this.AddEntityButton_Click);
            // 
            // CreateEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddEntityButton);
            this.Controls.Add(this.CancelButon);
            this.Controls.Add(this.AttributesLabel);
            this.Controls.Add(this.AttributesLayoutPanel);
            this.Controls.Add(this.ClassPickerComboBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateEntityForm";
            this.Text = "CreateEntityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClassPickerComboBox;
        private System.Windows.Forms.TableLayoutPanel AttributesLayoutPanel;
        private System.Windows.Forms.Label AttributesLabel;
        private System.Windows.Forms.Button CancelButon;
        private System.Windows.Forms.Button AddEntityButton;
    }
}