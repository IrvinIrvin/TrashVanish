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

namespace TrashVanish.Forms.RulesForms
{
    public partial class editRuleForm : Form
    {
        public editRuleForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.appicon;
        }

        private DataGridView rulesGrid;

        public editRuleForm(DataGridView dataGridView)
        {
            //rulesGrid.CurrentRow.Cells[i].Value.ToString();
            InitializeComponent();
            rulesGrid = dataGridView;
            this.Icon = Properties.Resources.appicon;
        }

        private void editRuleForm_Load(object sender, EventArgs e)
        {
            ExtensionTextBox.Text = rulesGrid.CurrentRow.Cells[1].Value.ToString();
            includesTextBox.Text = rulesGrid.CurrentRow.Cells[2].Value.ToString();
            pathTextBox.Text = rulesGrid.CurrentRow.Cells[3].Value.ToString();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            string id = rulesGrid.CurrentRow.Cells[0].Value.ToString();
            string includes = includesTextBox.Text.Trim();
            string path = pathTextBox.Text.Trim();
            string extension = ExtensionTextBox.Text.Trim();
            if (extension == "" || path == "")
            {
                messageLabelFunc("Обязательные поля не заполнены", Color.DarkOrange);
                return;
            }
            if (extension[0] != '.')
            {
                extension = '.' + extension;
            }
            if (!extValidate(extension) || !pathValidate(path))
            {
                return;
            }

            if (DBConnection.isRuleExist(extension, includes))
            {
                messageLabelFunc("Правило для \"" + extension + "\" уже существует", Color.DarkOrange);
                return;
            }
            RuleModel rule = new RuleModel { ruleExtension = extension, ruleIncludes = includes, rulePath = path };
            //DBConnection.UpdateRule(id, rule);
            DBConnection.DeleteRule(id);
            DBConnection.AddRule(rule);
            messageLabelFunc("Правило для \"" + extension + "\" обновленно", Color.Lime);
            ExtensionTextBox.Text = "";
            includesTextBox.Text = "";
            pathTextBox.Text = "";
            GridUpdater gu = new GridUpdater(rulesGrid);
            gu.UpdateRules();
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
    }
}