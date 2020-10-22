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

namespace TrashVanish.Forms.RulesForms
{
    public partial class editRuleForm : Form
    {
        private ResourceManager resourceManager;
        private DataGridView rulesGrid;

        public editRuleForm(DataGridView dataGridView)
        {
            //rulesGrid.CurrentRow.Cells[i].Value.ToString();
            InitializeComponent();
            rulesGrid = dataGridView;
            this.Icon = Properties.Resources.appicon;
            resourceManager = new ResourceManager("TrashVanish.lang_" + System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName, Assembly.GetExecutingAssembly());
        }

        private void editRuleForm_Load(object sender, EventArgs e)
        {
            ExtensionTextBox.Text = rulesGrid.CurrentRow.Cells[1].Value.ToString();
            includesTextBox.Text = rulesGrid.CurrentRow.Cells[2].Value.ToString();
            //pathTextBox.Text = rulesGrid.CurrentRow.Cells[3].Value.ToString();
            caseSensetive.Checked = Convert.ToInt32(rulesGrid.CurrentRow.Cells[3].Value.ToString()) == 1 ? true : false;
            pathTextBox.Text = rulesGrid.CurrentRow.Cells[4].Value.ToString();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            string id = rulesGrid.CurrentRow.Cells[0].Value.ToString();
            string includes = includesTextBox.Text.Trim();
            string path = pathTextBox.Text.Trim();
            string extension = ExtensionTextBox.Text.Trim();
            int isCaseSensetive = caseSensetive.Checked ? 1 : 0;

            if (extension == "" || path == "")
            {
                messageLabelFunc(resourceManager.GetString("ReqFieldsAreEmpty"), Color.DarkOrange);
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

            if (DBConnection.IsRuleExist(extension, includes, isCaseSensetive))
            {
                messageLabelFunc(string.Format(resourceManager.GetString("ruleForExtAlreadyExist"), extension), Color.DarkOrange);
                return;
            }
            RuleModel rule = new RuleModel { ruleExtension = extension, ruleIncludes = includes, rulePath = path, ruleIsCaseSensetive = isCaseSensetive };
            DBConnection.DeleteRule(id);
            DBConnection.AddRule(rule);
            messageLabelFunc(string.Format(resourceManager.GetString("ruleUpdatedSuccessfully"), extension), Color.Lime);
            ExtensionTextBox.Text = "";
            includesTextBox.Text = "";
            pathTextBox.Text = "";
            GridUpdater gu = new GridUpdater(rulesGrid);
            gu.UpdateRules();
            Close();
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
    }
}