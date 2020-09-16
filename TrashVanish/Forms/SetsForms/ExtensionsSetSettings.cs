using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrashVanish.Forms.SetsForms;

namespace TrashVanish
{
    public partial class ExtensionsSetSettings : Form
    {
        public ExtensionsSetSettings()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.appicon;
        }

        private void addSetButton_Click(object sender, EventArgs e)
        {
            Form AES = Application.OpenForms["AddExtensionSet"];
            if (AES != null)
            {
                AES.Activate();
                return;
            }
            else
            {
                AddExtensionSet addExtensionSet = new AddExtensionSet(extensionsSetGrid);
                addExtensionSet.ShowDialog();
            }
        }

        private void editSetButton_Click(object sender, EventArgs e)
        {
            // Открыть форму с правкой набора
        }

        private void deleteSetButton_Click(object sender, EventArgs e)
        {
            // Удалить набор
            int selectedrow;
            try
            {
                selectedrow = extensionsSetGrid.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                // Mo rules in grid yet
                return;
            }
            int columnbydefault = 0; // column with id (invisible)
            DBConnection.DeleteSet(extensionsSetGrid.Rows[selectedrow].Cells[columnbydefault].Value.ToString());
            updateGrid();
        }

        private void updateGridButton_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void updateGrid()
        {
            GridUpdater gu = new GridUpdater(extensionsSetGrid);
            gu.UpdateExtensionsSets();
        }

        private void ExtensionsSetSettings_Load(object sender, EventArgs e)
        {
            updateGrid();
        }
    }
}