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
            updateGrid();
        }
        private void updateGrid()
        {
            rulesGrid.Rows.Clear();
            rules = DBConnection.LoadRules();
            foreach (RuleModel rule in rules)
            {
                rulesGrid.Rows.Add(rule.ruleExtension, rule.ruleIncludes, rule.rulePath);
            }
        }
        private void updateRulesButton_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void deleteRule_Click(object sender, EventArgs e)
        {
            int selectedrow = rulesGrid.CurrentCell.RowIndex;
            int columnbydefault = 0;
            //MessageBox.Show("Selected row: " + rulesGrid.CurrentCell.RowIndex + " value is " + rulesGrid.Rows[selectedrow].Cells[columnbydefault].Value.ToString());
            DBConnection.DeleteRule(rulesGrid.Rows[selectedrow].Cells[columnbydefault].Value.ToString());
            updateGrid();
        }
    }
}
