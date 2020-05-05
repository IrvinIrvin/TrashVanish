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
    public partial class RulesSettings : Form
    {
        public RulesSettings()
        {
            InitializeComponent();
        }

        List<RuleModel> rules = new List<RuleModel>();
        private void RulesSettings_Load(object sender, EventArgs e)
        {

        }

        private void updateRulesButton_Click(object sender, EventArgs e)
        {
            rules = DBConnection.LoadRules();
            foreach (RuleModel rule in rules)
            {
                MessageBox.Show(rule.ruleExtension);
                rulesGrid.Rows.Add(rule.ruleExtension, rule.ruleIncludes, rule.rulePath);
            }
            MessageBox.Show("Table updated");
        }
    }
}
