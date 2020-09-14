using System;
using System.Windows.Forms;

namespace TrashVanish
{
    public partial class RulesSettings : Form
    {
        public RulesSettings()
        {
            InitializeComponent();
        }

        private void RulesSettings_Load(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void updateGrid()
        {
            GridUpdater gu = new GridUpdater(this.rulesGrid);
            gu.UpdateRules();
        }

        private void updateRulesButton_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void deleteRule_Click(object sender, EventArgs e)
        {
            int selectedrow;
            try
            {
                selectedrow = rulesGrid.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                // Mo rules in grid yet
                return;
            }
            int columnbydefault = 0; // column with id (invisible)
            DBConnection.DeleteRule(rulesGrid.Rows[selectedrow].Cells[columnbydefault].Value.ToString());
            updateGrid();
        }

        private void addRuleButton_Click(object sender, EventArgs e)
        {
            Form ar = Application.OpenForms["AddRule"];
            if (ar != null)
            {
                ar.Activate();
                return;
            }
            else
            {
                AddRule addRuleForm = new AddRule();
                addRuleForm.ShowDialog();
            }
            updateGrid();
        }
    }
}