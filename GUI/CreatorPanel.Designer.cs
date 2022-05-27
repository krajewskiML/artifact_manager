namespace artifact_manager2.GUI
{
    partial class CreatorPanel
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
            this.NewChangesLabel = new System.Windows.Forms.Label();
            this.RecentlyUpdatedListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StrongestCharactersListBox = new System.Windows.Forms.ListBox();
            this.CreateClassButon = new System.Windows.Forms.Button();
            this.CreateEntityButton = new System.Windows.Forms.Button();
            this.EditClassButton = new System.Windows.Forms.Button();
            this.EditEntityButton = new System.Windows.Forms.Button();
            this.DeleteClassButton = new System.Windows.Forms.Button();
            this.DeleteEntityButton = new System.Windows.Forms.Button();
            this.BrowseArtifactsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewChangesLabel
            // 
            this.NewChangesLabel.AutoSize = true;
            this.NewChangesLabel.Location = new System.Drawing.Point(43, 30);
            this.NewChangesLabel.Name = "NewChangesLabel";
            this.NewChangesLabel.Size = new System.Drawing.Size(126, 13);
            this.NewChangesLabel.TabIndex = 0;
            this.NewChangesLabel.Text = "Recently added/updated";
            // 
            // RecentlyUpdatedListBox
            // 
            this.RecentlyUpdatedListBox.FormattingEnabled = true;
            this.RecentlyUpdatedListBox.Location = new System.Drawing.Point(46, 64);
            this.RecentlyUpdatedListBox.Name = "RecentlyUpdatedListBox";
            this.RecentlyUpdatedListBox.Size = new System.Drawing.Size(382, 160);
            this.RecentlyUpdatedListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Strongest characters";
            // 
            // StrongestCharactersListBox
            // 
            this.StrongestCharactersListBox.FormattingEnabled = true;
            this.StrongestCharactersListBox.Location = new System.Drawing.Point(46, 266);
            this.StrongestCharactersListBox.Name = "StrongestCharactersListBox";
            this.StrongestCharactersListBox.Size = new System.Drawing.Size(382, 160);
            this.StrongestCharactersListBox.TabIndex = 3;
            // 
            // CreateClassButon
            // 
            this.CreateClassButon.AllowDrop = true;
            this.CreateClassButon.Enabled = false;
            this.CreateClassButon.Location = new System.Drawing.Point(451, 64);
            this.CreateClassButon.Name = "CreateClassButon";
            this.CreateClassButon.Size = new System.Drawing.Size(99, 52);
            this.CreateClassButon.TabIndex = 4;
            this.CreateClassButon.Text = "Create Class";
            this.CreateClassButon.UseVisualStyleBackColor = true;
            this.CreateClassButon.Click += new System.EventHandler(this.CreateClassButon_Click);
            // 
            // CreateEntityButton
            // 
            this.CreateEntityButton.Enabled = false;
            this.CreateEntityButton.Location = new System.Drawing.Point(608, 63);
            this.CreateEntityButton.Name = "CreateEntityButton";
            this.CreateEntityButton.Size = new System.Drawing.Size(99, 53);
            this.CreateEntityButton.TabIndex = 5;
            this.CreateEntityButton.Text = "Create Artifact";
            this.CreateEntityButton.UseVisualStyleBackColor = true;
            this.CreateEntityButton.Click += new System.EventHandler(this.CreateEntityButton_Click);
            // 
            // EditClassButton
            // 
            this.EditClassButton.Enabled = false;
            this.EditClassButton.Location = new System.Drawing.Point(451, 172);
            this.EditClassButton.Name = "EditClassButton";
            this.EditClassButton.Size = new System.Drawing.Size(99, 52);
            this.EditClassButton.TabIndex = 6;
            this.EditClassButton.Text = "Edit Class";
            this.EditClassButton.UseVisualStyleBackColor = true;
            this.EditClassButton.Click += new System.EventHandler(this.EditClassButton_Click);
            // 
            // EditEntityButton
            // 
            this.EditEntityButton.Enabled = false;
            this.EditEntityButton.Location = new System.Drawing.Point(608, 172);
            this.EditEntityButton.Name = "EditEntityButton";
            this.EditEntityButton.Size = new System.Drawing.Size(99, 52);
            this.EditEntityButton.TabIndex = 7;
            this.EditEntityButton.Text = "Edit Artifact";
            this.EditEntityButton.UseVisualStyleBackColor = true;
            this.EditEntityButton.Click += new System.EventHandler(this.EditEntityButton_Click);
            // 
            // DeleteClassButton
            // 
            this.DeleteClassButton.Enabled = false;
            this.DeleteClassButton.Location = new System.Drawing.Point(451, 266);
            this.DeleteClassButton.Name = "DeleteClassButton";
            this.DeleteClassButton.Size = new System.Drawing.Size(99, 52);
            this.DeleteClassButton.TabIndex = 8;
            this.DeleteClassButton.Text = "Delete Class";
            this.DeleteClassButton.UseVisualStyleBackColor = true;
            this.DeleteClassButton.Click += new System.EventHandler(this.DeleteClassButton_Click);
            // 
            // DeleteEntityButton
            // 
            this.DeleteEntityButton.Enabled = false;
            this.DeleteEntityButton.Location = new System.Drawing.Point(608, 266);
            this.DeleteEntityButton.Name = "DeleteEntityButton";
            this.DeleteEntityButton.Size = new System.Drawing.Size(99, 52);
            this.DeleteEntityButton.TabIndex = 9;
            this.DeleteEntityButton.Text = "Delete Artifact";
            this.DeleteEntityButton.UseVisualStyleBackColor = true;
            this.DeleteEntityButton.Click += new System.EventHandler(this.DeleteEntityButton_Click);
            // 
            // BrowseArtifactsButton
            // 
            this.BrowseArtifactsButton.Location = new System.Drawing.Point(451, 364);
            this.BrowseArtifactsButton.Name = "BrowseArtifactsButton";
            this.BrowseArtifactsButton.Size = new System.Drawing.Size(256, 61);
            this.BrowseArtifactsButton.TabIndex = 10;
            this.BrowseArtifactsButton.Text = "Browse Artifacts";
            this.BrowseArtifactsButton.UseVisualStyleBackColor = true;
            this.BrowseArtifactsButton.Click += new System.EventHandler(this.BrowseArtifactsButton_Click);
            // 
            // CreatorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrowseArtifactsButton);
            this.Controls.Add(this.DeleteEntityButton);
            this.Controls.Add(this.DeleteClassButton);
            this.Controls.Add(this.EditEntityButton);
            this.Controls.Add(this.EditClassButton);
            this.Controls.Add(this.CreateEntityButton);
            this.Controls.Add(this.CreateClassButon);
            this.Controls.Add(this.StrongestCharactersListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecentlyUpdatedListBox);
            this.Controls.Add(this.NewChangesLabel);
            this.Name = "CreatorPanel";
            this.Text = "CreatorPanel";
            this.Load += new System.EventHandler(this.CreatorPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewChangesLabel;
        private System.Windows.Forms.ListBox RecentlyUpdatedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StrongestCharactersListBox;
        private System.Windows.Forms.Button CreateClassButon;
        private System.Windows.Forms.Button CreateEntityButton;
        private System.Windows.Forms.Button EditClassButton;
        private System.Windows.Forms.Button EditEntityButton;
        private System.Windows.Forms.Button DeleteClassButton;
        private System.Windows.Forms.Button DeleteEntityButton;
        private System.Windows.Forms.Button BrowseArtifactsButton;
    }
}