using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashVanish
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<RuleModel> rules = new List<RuleModel>();
        private string cwd = @"C:\Users\" + Environment.UserName + @"\Desktop";
        private bool deleteFile = true, owFiles = true;

        private void rulesSettings_Click(object sender, EventArgs e)
        {
            RulesSettings rulesSettingForm = new RulesSettings();
            rulesSettingForm.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DBConnection.CheckDB();
        }

        private void mainTask_Click(object sender, EventArgs e)
        {
            rules = DBConnection.LoadRules();
            Worker.RunVanisher(cwd, rules, deleteFile, owFiles);
        }

        private void deleteFlag_CheckedChanged(object sender, EventArgs e)
        {
            deleteFile = deleteFlag.Checked;
        }

        private void overwriteFiles_CheckedChanged(object sender, EventArgs e)
        {
            owFiles = overwriteFiles.Checked;
        }
    }
}