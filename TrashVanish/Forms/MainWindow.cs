using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using TrashVanish.Classes;
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
            resourceManager = currentCulture.GlobalResourseManager;
        }

        private ResourceManager resourceManager;
        private List<RuleModel> rules = new List<RuleModel>();
        private List<SetModel> sets = new List<SetModel>();
        private readonly string cwd = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DBConnection.CheckDB();
            logRichTextBox.SelectionColor = Color.Cyan;
            logRichTextBox.AppendText("[" + DateTime.Now + "]" + " - " + resourceManager.GetString("AppIsLoaded") + "\r\n");
            logRichTextBox.SelectionColor = logRichTextBox.ForeColor;
        }

        private void MainTask_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.clearLog)
            {
                logRichTextBox.Text = "";
            }

            rules = DBConnection.LoadRules();
            sets = DBConnection.LoadSets();
            Worker worker = new Worker(logRichTextBox);
            worker.RunVanisher(cwd, rules, sets, Properties.Settings.Default.deleteAfterCopy, Properties.Settings.Default.overWriteFiles);
        }

        private void GlobalSettings_Click(object sender, EventArgs e)
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

        private void ClearLogItem_Click(object sender, EventArgs e)
        {
            logRichTextBox.Text = "";
        }
    }
}