using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashVanish
{
    internal class GridUpdater
    {
        private static DataGridView rulesGrid;

        public GridUpdater()
        {
            // To init class in non grid window
        }

        public GridUpdater(DataGridView dgv)
        {
            rulesGrid = dgv;
        }

        /// <summary>
        /// Reloads rules from database
        /// </summary>
        public void UpdateGrid()
        {
            rulesGrid.Rows.Clear();
            List<RuleModel> rules = DBConnection.LoadRules();
            foreach (RuleModel rule in rules)
            {
                rulesGrid.Rows.Add(rule.ruleID, rule.ruleExtension, rule.ruleIncludes, rule.rulePath);
            }
        }
    }
}