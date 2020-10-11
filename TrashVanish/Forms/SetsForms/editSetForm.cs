using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashVanish.Forms.SetsForms
{
    public partial class editSetForm : Form
    {
        public editSetForm()
        {
            InitializeComponent();
        }

        private DataGridView rulesGrid;

        public editSetForm(DataGridView dataGridView)
        {
            InitializeComponent();
            rulesGrid = dataGridView;
            this.Icon = Properties.Resources.appicon;
        }

        private void editSetForm_Load(object sender, EventArgs e)
        {
            setNameTextBox.Text = rulesGrid.CurrentRow.Cells[1].Value.ToString();
            foreach (string ext in getSplittedExtensions())
            {
                if (ext.Trim() != "")
                {
                    extensionsList.Items.Add(ext.Trim());
                }
            }
            targetPathTextBox.Text = rulesGrid.CurrentRow.Cells[3].Value.ToString();
        }

        private string[] getSplittedExtensions()
        {
            return rulesGrid.CurrentRow.Cells[2].Value.ToString().Split(';');
        }

        private void addExtensionToSetButton_Click(object sender, EventArgs e)
        {
            addExtToList();
        }

        private void addExtToList()
        {
            string extension = extensionTextBox.Text;
            if (extensionTextBox.Text == "")
            {
                messageLabelFunc("Расширение не может быть пустым", Color.DarkOrange);
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
            extensionsList.Items.Add(extension);
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
                messageLabelFunc("Расширение не корректно", Color.DarkOrange);
                return false;
            }
            foreach (char l in extension.Substring(1))
            {
                if (!(l >= 65 && l <= 90) && !(l >= 97 && l <= 122))
                {
                    messageLabelFunc("Расширение не корректно", Color.DarkOrange);
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
                messageLabelFunc("Путь не корректен", Color.DarkOrange);
                return false;
            }
            if (!Path.IsPathRooted(path))
            {
                messageLabelFunc("Относительные пути запрещены", Color.DarkOrange);
                return false;
            }
            return true;
        }

        private void deleteExtensionFromListButton_Click(object sender, EventArgs e)
        {
            extensionsList.Items.Remove(extensionsList.SelectedItem);
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                targetPathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void updateSetButton_Click(object sender, EventArgs e)
        {
            string id = rulesGrid.CurrentRow.Cells[0].Value.ToString();
            if (setNameTextBox.Text == "" || extensionsList.Items.Count == 0 || targetPathTextBox.Text == "")
            {
                messageLabelFunc("Не заполнены необходимые данные", Color.DarkOrange);
                return;
            }
            if (!pathValidate(targetPathTextBox.Text))
            {
                return;
            }
            string setName = setNameTextBox.Text;
            List<string> setExtensions = new List<string>();
            foreach (string listItem in extensionsList.Items)
            {
                setExtensions.Add(listItem.ToString());
            }
            string targetPath = targetPathTextBox.Text;
            //DBConnection.AddSet(setName, setExtensions, targetPath);
            DBConnection.DeleteSet(id);
            DBConnection.AddSet(setName, setExtensions, targetPath);
            //DBConnection.UpdateSet(id, setName, setExtensions, targetPath);
            setNameTextBox.Text = "";
            extensionTextBox.Text = "";
            extensionsList.Items.Clear();
            GridUpdater gridUpdater = new GridUpdater(rulesGrid);
            gridUpdater.UpdateExtensionsSets();
            messageLabelFunc("Набор был успешно обновлен", Color.Lime);
        }

        private void extensionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addExtToList();
            }
        }
    }
}