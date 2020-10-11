using System;
using System.Windows.Forms;
using TrashVanish.Forms.RulesForms;

namespace TrashVanish
{
    public partial class RulesSettings : Form
    {
        public RulesSettings()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.appicon;
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
            if (!rulesAreExist())
            {
                return;
            }
            int selectedrow = rulesGrid.CurrentCell.RowIndex; ;
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
                AddRule addRuleForm = new AddRule(rulesGrid);
                addRuleForm.ShowDialog();
            }
            updateGrid();
        }

        private void editRule_Click(object sender, EventArgs e)
        {
            if (!rulesAreExist())
            {
                return;
            }
            Form er = Application.OpenForms["editRule"];
            if (er != null)
            {
                er.Activate();
                return;
            }
            else
            {
                editRuleForm editRuleForm = new editRuleForm(rulesGrid);
                editRuleForm.ShowDialog();
            }
            updateGrid();
        }

        private bool rulesAreExist()
        {
            int selectedrow;
            try
            {
                selectedrow = rulesGrid.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                // No rules in grid yet
                return false;
            }
            return true;
        }
    }
}