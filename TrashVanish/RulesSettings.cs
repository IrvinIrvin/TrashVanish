using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrashVanish
{
    public partial class RulesSettings : Form
    {
        public RulesSettings()
        {
            InitializeComponent();
        }

        private List<RuleModel> rules = new List<RuleModel>();

        private void RulesSettings_Load(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void updateGrid()
        {
            GridUpdater gu = new GridUpdater(this.rulesGrid);
            gu.UpdateGrid();
            //rulesGrid.Rows.Clear();
            //rules = DBConnection.LoadRules();
            //foreach (RuleModel rule in rules)
            //{
            //    rulesGrid.Rows.Add(rule.ruleID, rule.ruleExtension, rule.ruleRegister, rule.ruleIncludes, rule.rulePath);
            //}
        }

        private void updateRulesButton_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void deleteRule_Click(object sender, EventArgs e)
        {
            int selectedrow = rulesGrid.CurrentCell.RowIndex;
            int columnbydefault = 0;
            // Удаление по id
            DBConnection.DeleteRule(rulesGrid.Rows[selectedrow].Cells[columnbydefault].Value.ToString());
            updateGrid();
        }

        // Кнопка добавить правило, но мне ее лень переименовывать
        private void button1_Click(object sender, EventArgs e)
        {
            AddRule addRuleForm = new AddRule();
            addRuleForm.Show();
            updateGrid();
        }
    }
}