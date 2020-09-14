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
    public partial class ExtensionsSet : Form
    {
        public ExtensionsSet()
        {
            InitializeComponent();
        }

        private void addSetButton_Click(object sender, EventArgs e)
        {
            // Открыть форму с добавлением набора
        }

        private void editSetButton_Click(object sender, EventArgs e)
        {
            // Открыть форму с правкой набора
        }

        private void deleteSetButton_Click(object sender, EventArgs e)
        {
            // Удалить набор
        }

        private void updateGridButton_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void updateGrid()
        {
            GridUpdater gu = new GridUpdater(this.extensionsSetGrid);
            gu.UpdateExtensionsSets();
        }
    }
}