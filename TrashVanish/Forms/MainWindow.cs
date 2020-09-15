using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TrashVanish.Forms;

namespace TrashVanish
{
    public delegate void UpdateLogger();

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.appicon;
        }

        private List<RuleModel> rules = new List<RuleModel>();
        private string cwd = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DBConnection.CheckDB();
            logRichTextBox.SelectionColor = Color.Cyan;
            logRichTextBox.AppendText("[" + DateTime.Now + "]" + " - " + "Программа загружена" + "\r\n");
            logRichTextBox.SelectionColor = logRichTextBox.ForeColor;
        }

        private void mainTask_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.clearLog)
            {
                logRichTextBox.Text = "";
            }

            rules = DBConnection.LoadRules();
            Worker worker = new Worker(this);
            worker.RunVanisher(cwd, rules, Properties.Settings.Default.deleteAfterCopy, Properties.Settings.Default.overWriteFiles);
        }

        private void globalSettings_Click(object sender, EventArgs e)
        {
            Form gSF = Application.OpenForms["globalSettingsForm"];
            if (gSF != null)
            {
                gSF.Activate();
                return;
            }
            else
            {
                globalSettingsForm globalSettingsForm = new globalSettingsForm();
                globalSettingsForm.Show();
            }
        }
    }
}