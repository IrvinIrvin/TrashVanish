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
        private static DataGridView dataGrid;

        public GridUpdater()
        {
            // To init class in non grid window
        }

        public GridUpdater(DataGridView dataGrid)
        {
            GridUpdater.dataGrid = dataGrid;
        }

        /// <summary>
        /// Reloads rules from database
        /// </summary>
        public void UpdateRules()
        {
            dataGrid.Rows.Clear();
            List<RuleModel> rules = DBConnection.LoadRules();
            foreach (RuleModel rule in rules)
            {
                dataGrid.Rows.Add(rule.ruleID, rule.ruleExtension, rule.ruleIncludes, rule.rulePath);
            }
        }

        /// <summary>
        /// Reloads extension sets from database
        /// </summary>
        public void UpdateExtensionsSets()
        {
            dataGrid.Rows.Clear();
            // Здесь будет список с наборами расширений
        }
    }
}