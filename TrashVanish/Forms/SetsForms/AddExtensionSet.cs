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
    public partial class AddExtensionSet : Form
    {
        public AddExtensionSet()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.appicon;
        }

        private DataGridView gridView;

        public AddExtensionSet(DataGridView dataGridView)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.appicon;
            gridView = dataGridView;
        }

        private void addExtensionToSetButton_Click(object sender, EventArgs e)
        {
            addExtToList();
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

        private void addSetButton_Click(object sender, EventArgs e)
        {
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
            DBConnection.AddSet(setName, setExtensions, targetPath);
            setNameTextBox.Text = "";
            extensionTextBox.Text = "";
            extensionsList.Items.Clear();
            GridUpdater gridUpdater = new GridUpdater(gridView);
            gridUpdater.UpdateExtensionsSets();
            messageLabelFunc("Набор был успешно добавлен", Color.Lime);
        }

        private void extensionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addExtToList();
            }
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

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                targetPathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}