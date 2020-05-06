using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrashVanish
{
    public partial class AddRule : Form
    {
        public AddRule()
        {
            InitializeComponent();
        }

        private string path, extension, includes;

        private void browseFilesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                extension = Path.GetExtension(openFileDialog.FileName);
                ExtensionTextBox.Text = extension;
            }
        }

        private void AddRuleButton_Click(object sender, EventArgs e)
        {
            includes = includesTextBox.Text;
            path = pathTextBox.Text;
            extension = ExtensionTextBox.Text;
            if (DBConnection.isRuleExist(extension))
            {
                MessageBox.Show("Правило для этого расширения уже создано");
                return;
            }
            extension = ExtensionTextBox.Text;
            if (extension == "" || path == "")
            {
                MessageBox.Show("Обязательные поля не заполнены");
                return;
            }
            RuleModel rule = new RuleModel { ruleExtension = extension, ruleIncludes = includes, rulePath = path };
            DBConnection.AddRule(rule);
            ExtensionTextBox.Text = "";
            includesTextBox.Text = "";
            pathTextBox.Text = "";
        }

        private void browseFolders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
                pathTextBox.Text = path;
            }
        }
    }
}