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

        private void addRule_Click(object sender, EventArgs e)
        {
            AddRule addRuleForm = new AddRule();
            addRuleForm.Show();
        }

        private void rulesSettings_Click(object sender, EventArgs e)
        {
            RulesSettings rulesSettingForm = new RulesSettings();
            rulesSettingForm.Show();
        }
    }
}
