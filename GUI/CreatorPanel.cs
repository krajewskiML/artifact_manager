using artifact_manager2.Database.EnhancedModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using artifact_manager2.Controllers;

namespace artifact_manager2.GUI
{
    public partial class CreatorPanel : Form
    {
        public CreatorPanel(FullUser user)
        {
            InitializeComponent();
            setPermissions(user);
        }

        private void refresh()
        {
            LoadStrongestCharacters();
            LoadLatest();
        }

        private void setPermissions(FullUser user)
        {
            CreateClassButon.Enabled = user.allPerrmissions.CanAddClasses;
            CreateEntityButton.Enabled = user.allPerrmissions.CanAddRecords;
            EditClassButton.Enabled = user.allPerrmissions.CanUpdateClasses;
            EditEntityButton.Enabled = user.allPerrmissions.CanUpdateRecords;
            DeleteClassButton.Enabled = user.allPerrmissions.CanDeleteClasses;
            DeleteEntityButton.Enabled = user.allPerrmissions.CanDeleteRecords;
        }

        private void CreateClassButon_Click(object sender, EventArgs e)
        {
            CreateClassForm createClassForm = new CreateClassForm();
            createClassForm.ShowDialog();
            refresh();
        }

        private void CreateEntityButton_Click(object sender, EventArgs e)
        {
            CreateEntityForm createEntityForm = new CreateEntityForm();
            createEntityForm.ShowDialog();
            refresh();
        }

        private void EditClassButton_Click(object sender, EventArgs e)
        {
            EditClassForm editClassForm = new EditClassForm();
            editClassForm.ShowDialog();
            refresh();
        }

        private void EditEntityButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteClassButton_Click(object sender, EventArgs e)
        {
            DeleteClassForm createClassForm = new DeleteClassForm();
            createClassForm.ShowDialog();
            refresh();
        }

        private void DeleteEntityButton_Click(object sender, EventArgs e)
        {
            DeleteEntityForm deleteEntityForm = new DeleteEntityForm();
            deleteEntityForm.ShowDialog();
            refresh();
        }

        private void CreatorPanel_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void LoadStrongestCharacters()
        {
            StrongestCharactersListBox.Items.Clear();
            var strongestCharacters = EntityController.GetStrongestRepresentatives();
            foreach(var character in strongestCharacters)
            {
                StrongestCharactersListBox.Items.Add(character.toShowOnBoard());
            }
        }

        private void LoadLatest()
        {
            RecentlyUpdatedListBox.Items.Clear();
            var latestArtifacts = EntityController.GetLatestRepresetatives();
            foreach (var artifact in latestArtifacts)
            {
                RecentlyUpdatedListBox.Items.Add(artifact);
            }
        }

        private void BrowseArtifactsButton_Click(object sender, EventArgs e)
        {
            BrowseArtifactsForm browseArtifactsForm = new BrowseArtifactsForm();
            browseArtifactsForm.ShowDialog();
        }
    }
}
