using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TrashVanish
{
    public delegate void UpdateLogger();

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<RuleModel> rules = new List<RuleModel>();
        private string cwd = @"C:\Users\" + Environment.UserName + @"\Desktop";
        private bool deleteFile = true, owFiles = true, clearLog = false;

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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var box = logRTB;
            DBConnection.CheckDB();
            loadCheckboxSettings();
            box.SelectionColor = Color.Cyan;
            box.AppendText("[" + DateTime.Now + "]" + " - " + "Программа загружена" + "\r\n");
            box.SelectionColor = box.ForeColor;
        }

        private void loadCheckboxSettings()
        {
            checkBox1.Checked = Properties.Settings.Default.clearLog;
            overwriteFiles.Checked = Properties.Settings.Default.overWriteFiles;
            deleteFlag.Checked = Properties.Settings.Default.deleteAfterCopy;
        }

        private void mainTask_Click(object sender, EventArgs e)
        {
            if (clearLog)
            {
                logRTB.Text = "";
            }

            rules = DBConnection.LoadRules();
            Worker worker = new Worker(this);
            worker.RunVanisher(cwd, rules, deleteFile, owFiles);
        }

        private void deleteFlag_CheckedChanged(object sender, EventArgs e)
        {
            deleteFile = deleteFlag.Checked;
            Properties.Settings.Default.deleteAfterCopy = deleteFlag.Checked;
            Properties.Settings.Default.Save();
        }

        // clear log checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            clearLog = checkBox1.Checked;
            Properties.Settings.Default.clearLog = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void overwriteFiles_CheckedChanged(object sender, EventArgs e)
        {
            owFiles = overwriteFiles.Checked;
            Properties.Settings.Default.overWriteFiles = overwriteFiles.Checked;
            Properties.Settings.Default.Save();
        }
    }
}