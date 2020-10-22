using System;
using System.Windows.Forms;
using TrashVanish.Classes;
using TrashVanish.Forms.RulesForms;
using TrashVanish.Forms.SetsForms;

namespace TrashVanish.Forms
{
    public partial class globalSettingsForm : Form
    {
        public globalSettingsForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.appicon;
        }

        private GridUpdater rulesUpdater;
        private GridUpdater setsUpdater;

        private void ClearLogCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.clearLog = clearLogCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void OverwriteFiles_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.overWriteFiles = overwriteFiles.Checked;
            Properties.Settings.Default.Save();
        }

        private void DeleteFlag_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.deleteAfterCopy = deleteFlag.Checked;
            Properties.Settings.Default.Save();
        }

        private void GlobalSettingsForm_Load(object sender, EventArgs e)
        {
            LoadCheckboxSettings();
            rulesUpdater = new GridUpdater(rulesGrid);
            setsUpdater = new GridUpdater(extensionsSetGrid);

            rulesUpdater.UpdateRules();
            setsUpdater.UpdateExtensionsSets();
        }

        private void LoadCheckboxSettings()
        {
            clearLogCheckbox.Checked = Properties.Settings.Default.clearLog;
            overwriteFiles.Checked = Properties.Settings.Default.overWriteFiles;
            deleteFlag.Checked = Properties.Settings.Default.deleteAfterCopy;
        }

        private void RulesAndSetsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rulesAndSetsTabControl.SelectedTab == rulesAndSetsTabControl.TabPages["RulesSettingsTab"])
            {
                rulesUpdater.UpdateRules();
            }
            else
            {
                setsUpdater.UpdateExtensionsSets();
            }
        }

        private bool RulesAreExist()
        {
            int selectedrow;
            try
            {
                selectedrow = rulesGrid.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                // No rules in grid yet
                return false;
            }
            return true;
        }

        // RULES CONTEXT MENU
        private void UpdateGridItem_Click(object sender, EventArgs e)
        {
            rulesUpdater.UpdateRules();
        }

        private void AddRuleItem_Click(object sender, EventArgs e)
        {
            Form ar = Application.OpenForms["AddRule"];
            if (ar != null)
            {
                ar.Activate();
                return;
            }
            else
            {
                AddRule addRuleForm = new AddRule(rulesGrid);
                addRuleForm.ShowDialog();
            }
            rulesUpdater.UpdateRules();
        }

        private void EditRuleItem_Click(object sender, EventArgs e)
        {
            if (!RulesAreExist())
            {
                return;
            }
            Form er = Application.OpenForms["editRule"];
            if (er != null)
            {
                er.Activate();
                return;
            }
            else
            {
                //editRuleForm editRuleForm = new editRuleForm(rulesGrid);
                editRuleForm erf = new editRuleForm(rulesGrid);
                erf.ShowDialog();
            }
            rulesUpdater.UpdateRules();
        }

        private void DeleteRuleItem_Click(object sender, EventArgs e)
        {
            if (!RulesAreExist())
            {
                return;
            }
            int selectedrow = rulesGrid.CurrentCell.RowIndex; ;
            int columnbydefault = 0; // column with id (invisible)
            DBConnection.DeleteRule(rulesGrid.Rows[selectedrow].Cells[columnbydefault].Value.ToString());
            rulesUpdater.UpdateRules();
        }

        // SETS CONTEXT MENU

        private void UpdateSetGridItem_Click(object sender, EventArgs e)
        {
            setsUpdater.UpdateExtensionsSets();
        }

        private void AddSetItem_Click(object sender, EventArgs e)
        {
            Form AES = Application.OpenForms["AddExtensionSet"];
            if (AES != null)
            {
                AES.Activate();
                return;
            }
            else
            {
                AddExtensionSet addExtensionSet = new AddExtensionSet(extensionsSetGrid);
                addExtensionSet.ShowDialog();
            }
        }

        private void EditSetItem_Click(object sender, EventArgs e)
        {
            Form esf = Application.OpenForms["editSetForm"];
            if (esf != null)
            {
                esf.Activate();
                return;
            }
            else
            {
                int selectedrow;
                try
                {
                    selectedrow = extensionsSetGrid.CurrentCell.RowIndex;
                }
                catch (NullReferenceException)
                {
                    // Mo rules in grid yet
                    return;
                }
                int columnbydefault = 0; // column with id (invisible)
                SetModel setToEdit = DBConnection.LoadSetByID(extensionsSetGrid.Rows[selectedrow].Cells[columnbydefault].Value.ToString());
                editSetForm editSetForm = new editSetForm(setToEdit, extensionsSetGrid);
                editSetForm.Show();
            }
        }

        private void DeleteSetItem_Click(object sender, EventArgs e)
        {
            // Удалить набор
            int selectedrow;
            try
            {
                selectedrow = extensionsSetGrid.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                // Mo rules in grid yet
                return;
            }
            int columnbydefault = 0; // column with id (invisible)
            DBConnection.DeleteSet(extensionsSetGrid.Rows[selectedrow].Cells[columnbydefault].Value.ToString());
            setsUpdater.UpdateExtensionsSets();
        }
    }
}