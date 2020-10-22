using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrashVanish.Classes;

namespace TrashVanish.Forms.SetsForms
{
    public partial class editSetForm : Form
    {
        private ResourceManager resourceManager;
        private SetModel setToEdit;
        private DataGridView rulesGrid;

        public editSetForm(SetModel set, DataGridView dgv)
        {
            InitializeComponent();
            setToEdit = set;
            rulesGrid = dgv;
            this.Icon = Properties.Resources.appicon;
            resourceManager = new ResourceManager("TrashVanish.lang_" + System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName, Assembly.GetExecutingAssembly());
        }

        private void editSetForm_Load(object sender, EventArgs e)
        {
            setNameTextBox.Text = setToEdit.setName;
            foreach (KeyValuePair<string, string> entry in getExtensionsAndIncludes())
            {
                extensionsList.Rows.Add(entry.Key, entry.Value);
            }
            targetPathTextBox.Text = setToEdit.targetPath;
            isCaseSensetiveCheckBox.Checked = setToEdit.isCaseSensetive == 1 ? true : false;
        }

        private Dictionary<string, string> getExtensionsAndIncludes()
        {
            Dictionary<string, string> extensionsAndIncludes = new Dictionary<string, string>();
            foreach (setExtensionModel ext in setToEdit.extensions)
            {
                extensionsAndIncludes.Add(ext.extension, ext.includes);
            }
            return extensionsAndIncludes;
        }

        private void addExtToList()
        {
            string extension = extensionTextBox.Text.Trim();
            string includes = includesTextBox.Text.Trim();
            if (extensionTextBox.Text == "")
            {
                messageLabelFunc(resourceManager.GetString("extIsInvalid"), Color.DarkOrange);
                return;
            }
            if (extension[0] != '.')
            {
                extension = '.' + extension;
            }
            if (!extValidate(extension))
            {
                return;
            }
            extensionTextBox.Text = "";
            includesTextBox.Text = "";
            extensionsList.Rows.Add(extension, includes);
        }

        private void messageLabelFunc(string message, Color color)
        {
            messageLabel.Visible = true;
            messageLabel.ForeColor = color;
            messageLabel.Text = message;
            var timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += (s, e) =>
            {
                messageLabel.Hide();
                timer.Stop();
            };
            timer.Start();
        }

        private bool extValidate(string extension)
        {
            if (extension.Substring(1).Length == 0)
            {
                messageLabelFunc(resourceManager.GetString("extIsInvalid"), Color.DarkOrange);
                return false;
            }
            foreach (char l in extension.Substring(1))
            {
                if (!(l >= 65 && l <= 90) && !(l >= 97 && l <= 122))
                {
                    messageLabelFunc(resourceManager.GetString("extIsInvalid"), Color.DarkOrange);
                    return false;
                }
            }
            return true;
        }

        private bool pathValidate(string path)
        {
            try
            {
                Path.GetFullPath(path);
            }
            catch
            {
                messageLabelFunc(resourceManager.GetString("pathIsInvalid"), Color.DarkOrange);
                return false;
            }
            if (!Path.IsPathRooted(path))
            {
                messageLabelFunc(resourceManager.GetString("relPathesAreForbidden"), Color.DarkOrange);
                return false;
            }
            return true;
        }

        private void updateSetButton_Click(object sender, EventArgs e)
        {
            //string id = rulesGrid.CurrentRow.Cells[0].Value.ToString();
            string id = setToEdit.setID;
            int isCaseSensetive = isCaseSensetiveCheckBox.Checked ? 1 : 0;
            if (setNameTextBox.Text == "" || extensionsList.Rows.Count == 0 || targetPathTextBox.Text == "")
            {
                messageLabelFunc(resourceManager.GetString("ReqFieldsAreEmpty"), Color.DarkOrange);
                return;
            }
            if (!pathValidate(targetPathTextBox.Text))
            {
                return;
            }
            string setName = setNameTextBox.Text;
            Dictionary<string, string> setExtensionsAndIncludes = new Dictionary<string, string>();
            foreach (DataGridViewRow listItem in extensionsList.Rows)
            {
                setExtensionsAndIncludes.Add(listItem.Cells[0].Value.ToString(), listItem.Cells[1].Value.ToString());
            }
            string targetPath = targetPathTextBox.Text;
            DBConnection.DeleteSet(id);
            DBConnection.AddSet(setName, setExtensionsAndIncludes, targetPath, isCaseSensetive);
            //DBConnection.UpdateSet(id, setName, setExtensions, targetPath);
            setNameTextBox.Text = "";
            extensionTextBox.Text = "";
            extensionsList.Rows.Clear();
            GridUpdater gridUpdater = new GridUpdater(rulesGrid);
            gridUpdater.UpdateExtensionsSets();
            messageLabelFunc(resourceManager.GetString("setAddedSuccessfully"), Color.Lime);
            Close();
        }

        private void addExtensionToSetButton_Click_1(object sender, EventArgs e)
        {
            addExtToList();
        }

        private void deleteExtensionFromListButton_Click_1(object sender, EventArgs e)
        {
            int selectedrow;
            try
            {
                selectedrow = extensionsList.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                // Mo rules in grid yet
                return;
            }
            extensionsList.Rows.RemoveAt(selectedrow);
        }

        private void extensionTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addExtToList();
            }
        }

        private void selectFolderButton_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                targetPathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}