using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashVanish.Forms
{
    public partial class globalSettingsForm : Form
    {
        public globalSettingsForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.appicon;
        }

        private void rulesSettings_Click(object sender, EventArgs e)
        {
            Form rs = Application.OpenForms["RulesSettings"];
            if (rs != null)
            {
                rs.Activate();
                return;
            }
            else
            {
                RulesSettings rulesSettingForm = new RulesSettings();
                rulesSettingForm.Show();
            }
        }

        private void clearLogCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.clearLog = clearLogCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void overwriteFiles_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.overWriteFiles = overwriteFiles.Checked;
            Properties.Settings.Default.Save();
        }

        private void deleteFlag_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.deleteAfterCopy = deleteFlag.Checked;
            Properties.Settings.Default.Save();
        }

        private void globalSettingsForm_Load(object sender, EventArgs e)
        {
            loadCheckboxSettings();
        }

        private void loadCheckboxSettings()
        {
            clearLogCheckbox.Checked = Properties.Settings.Default.clearLog;
            overwriteFiles.Checked = Properties.Settings.Default.overWriteFiles;
            deleteFlag.Checked = Properties.Settings.Default.deleteAfterCopy;
        }

        private void extensionSetSettingsButton_Click(object sender, EventArgs e)
        {
            Form eSS = Application.OpenForms["ExtensionsSetSettings"];
            if (eSS != null)
            {
                eSS.Activate();
                return;
            }
            else
            {
                ExtensionsSetSettings extensionsSetSettings = new ExtensionsSetSettings();
                extensionsSetSettings.Show();
            }
        }
    }
}