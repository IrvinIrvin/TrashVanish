namespace TrashVanish.Forms
{
    partial class globalSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(globalSettingsForm));
            this.clearLogCheckbox = new System.Windows.Forms.CheckBox();
            this.overwriteFiles = new System.Windows.Forms.CheckBox();
            this.deleteFlag = new System.Windows.Forms.CheckBox();
            this.checkboxesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.rulesAndSetsTabControl = new System.Windows.Forms.TabControl();
            this.RulesSettingsTab = new System.Windows.Forms.TabPage();
            this.rulesGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruleRowControlMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editRuleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRuleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameIncludes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCaseSensetive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SavePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruleGridControlsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateGridItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRuleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetsSettingsTab = new System.Windows.Forms.TabPage();
            this.extensionsSetGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setRowControlMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSetItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSetItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Extensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setGridControlStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateSetGridItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSetItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesAndSetsTabControl.SuspendLayout();
            this.RulesSettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).BeginInit();
            this.ruleRowControlMenuStrip.SuspendLayout();
            this.ruleGridControlsStrip.SuspendLayout();
            this.SetsSettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extensionsSetGrid)).BeginInit();
            this.setRowControlMenuStrip.SuspendLayout();
            this.setGridControlStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearLogCheckbox
            // 
            resources.ApplyResources(this.clearLogCheckbox, "clearLogCheckbox");
            this.clearLogCheckbox.Name = "clearLogCheckbox";
            this.checkboxesToolTip.SetToolTip(this.clearLogCheckbox, resources.GetString("clearLogCheckbox.ToolTip"));
            this.clearLogCheckbox.UseVisualStyleBackColor = true;
            this.clearLogCheckbox.CheckedChanged += new System.EventHandler(this.ClearLogCheckbox_CheckedChanged);
            // 
            // overwriteFiles
            // 
            resources.ApplyResources(this.overwriteFiles, "overwriteFiles");
            this.overwriteFiles.Checked = true;
            this.overwriteFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteFiles.Name = "overwriteFiles";
            this.checkboxesToolTip.SetToolTip(this.overwriteFiles, resources.GetString("overwriteFiles.ToolTip"));
            this.overwriteFiles.UseVisualStyleBackColor = true;
            this.overwriteFiles.CheckedChanged += new System.EventHandler(this.OverwriteFiles_CheckedChanged);
            // 
            // deleteFlag
            // 
            resources.ApplyResources(this.deleteFlag, "deleteFlag");
            this.deleteFlag.Checked = true;
            this.deleteFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteFlag.Name = "deleteFlag";
            this.checkboxesToolTip.SetToolTip(this.deleteFlag, resources.GetString("deleteFlag.ToolTip"));
            this.deleteFlag.UseVisualStyleBackColor = true;
            this.deleteFlag.CheckedChanged += new System.EventHandler(this.DeleteFlag_CheckedChanged);
            // 
            // rulesAndSetsTabControl
            // 
            resources.ApplyResources(this.rulesAndSetsTabControl, "rulesAndSetsTabControl");
            this.rulesAndSetsTabControl.Controls.Add(this.RulesSettingsTab);
            this.rulesAndSetsTabControl.Controls.Add(this.SetsSettingsTab);
            this.rulesAndSetsTabControl.Name = "rulesAndSetsTabControl";
            this.rulesAndSetsTabControl.SelectedIndex = 0;
            this.checkboxesToolTip.SetToolTip(this.rulesAndSetsTabControl, resources.GetString("rulesAndSetsTabControl.ToolTip"));
            this.rulesAndSetsTabControl.SelectedIndexChanged += new System.EventHandler(this.RulesAndSetsTabControl_SelectedIndexChanged);
            // 
            // RulesSettingsTab
            // 
            resources.ApplyResources(this.RulesSettingsTab, "RulesSettingsTab");
            this.RulesSettingsTab.Controls.Add(this.rulesGrid);
            this.RulesSettingsTab.Name = "RulesSettingsTab";
            this.checkboxesToolTip.SetToolTip(this.RulesSettingsTab, resources.GetString("RulesSettingsTab.ToolTip"));
            this.RulesSettingsTab.UseVisualStyleBackColor = true;
            // 
            // rulesGrid
            // 
            resources.ApplyResources(this.rulesGrid, "rulesGrid");
            this.rulesGrid.AllowUserToAddRows = false;
            this.rulesGrid.AllowUserToDeleteRows = false;
            this.rulesGrid.AllowUserToResizeRows = false;
            this.rulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FileExtension,
            this.NameIncludes,
            this.isCaseSensetive,
            this.SavePath});
            this.rulesGrid.ContextMenuStrip = this.ruleGridControlsStrip;
            this.rulesGrid.MultiSelect = false;
            this.rulesGrid.Name = "rulesGrid";
            this.rulesGrid.ReadOnly = true;
            this.rulesGrid.RowHeadersVisible = false;
            this.rulesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.rulesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkboxesToolTip.SetToolTip(this.rulesGrid, resources.GetString("rulesGrid.ToolTip"));
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // FileExtension
            // 
            this.FileExtension.ContextMenuStrip = this.ruleRowControlMenuStrip;
            resources.ApplyResources(this.FileExtension, "FileExtension");
            this.FileExtension.Name = "FileExtension";
            this.FileExtension.ReadOnly = true;
            // 
            // ruleRowControlMenuStrip
            // 
            resources.ApplyResources(this.ruleRowControlMenuStrip, "ruleRowControlMenuStrip");
            this.ruleRowControlMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRuleItem,
            this.deleteRuleItem});
            this.ruleRowControlMenuStrip.Name = "ruleControlsStrip";
            this.checkboxesToolTip.SetToolTip(this.ruleRowControlMenuStrip, resources.GetString("ruleRowControlMenuStrip.ToolTip"));
            // 
            // editRuleItem
            // 
            resources.ApplyResources(this.editRuleItem, "editRuleItem");
            this.editRuleItem.Name = "editRuleItem";
            this.editRuleItem.Click += new System.EventHandler(this.EditRuleItem_Click);
            // 
            // deleteRuleItem
            // 
            resources.ApplyResources(this.deleteRuleItem, "deleteRuleItem");
            this.deleteRuleItem.Name = "deleteRuleItem";
            this.deleteRuleItem.Click += new System.EventHandler(this.DeleteRuleItem_Click);
            // 
            // NameIncludes
            // 
            this.NameIncludes.ContextMenuStrip = this.ruleRowControlMenuStrip;
            resources.ApplyResources(this.NameIncludes, "NameIncludes");
            this.NameIncludes.Name = "NameIncludes";
            this.NameIncludes.ReadOnly = true;
            // 
            // isCaseSensetive
            // 
            this.isCaseSensetive.ContextMenuStrip = this.ruleRowControlMenuStrip;
            resources.ApplyResources(this.isCaseSensetive, "isCaseSensetive");
            this.isCaseSensetive.Name = "isCaseSensetive";
            this.isCaseSensetive.ReadOnly = true;
            // 
            // SavePath
            // 
            this.SavePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SavePath.ContextMenuStrip = this.ruleRowControlMenuStrip;
            resources.ApplyResources(this.SavePath, "SavePath");
            this.SavePath.Name = "SavePath";
            this.SavePath.ReadOnly = true;
            // 
            // ruleGridControlsStrip
            // 
            resources.ApplyResources(this.ruleGridControlsStrip, "ruleGridControlsStrip");
            this.ruleGridControlsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateGridItem,
            this.AddRuleItem});
            this.ruleGridControlsStrip.Name = "ruleControlsStrip";
            this.checkboxesToolTip.SetToolTip(this.ruleGridControlsStrip, resources.GetString("ruleGridControlsStrip.ToolTip"));
            // 
            // UpdateGridItem
            // 
            resources.ApplyResources(this.UpdateGridItem, "UpdateGridItem");
            this.UpdateGridItem.Name = "UpdateGridItem";
            this.UpdateGridItem.Click += new System.EventHandler(this.UpdateGridItem_Click);
            // 
            // AddRuleItem
            // 
            resources.ApplyResources(this.AddRuleItem, "AddRuleItem");
            this.AddRuleItem.Name = "AddRuleItem";
            this.AddRuleItem.Click += new System.EventHandler(this.AddRuleItem_Click);
            // 
            // SetsSettingsTab
            // 
            resources.ApplyResources(this.SetsSettingsTab, "SetsSettingsTab");
            this.SetsSettingsTab.Controls.Add(this.extensionsSetGrid);
            this.SetsSettingsTab.Name = "SetsSettingsTab";
            this.checkboxesToolTip.SetToolTip(this.SetsSettingsTab, resources.GetString("SetsSettingsTab.ToolTip"));
            this.SetsSettingsTab.UseVisualStyleBackColor = true;
            // 
            // extensionsSetGrid
            // 
            resources.ApplyResources(this.extensionsSetGrid, "extensionsSetGrid");
            this.extensionsSetGrid.AllowUserToAddRows = false;
            this.extensionsSetGrid.AllowUserToDeleteRows = false;
            this.extensionsSetGrid.AllowUserToResizeRows = false;
            this.extensionsSetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.extensionsSetGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.SetName,
            this.Extensions,
            this.dataGridViewTextBoxColumn2,
            this.targetPath});
            this.extensionsSetGrid.ContextMenuStrip = this.setGridControlStrip;
            this.extensionsSetGrid.MultiSelect = false;
            this.extensionsSetGrid.Name = "extensionsSetGrid";
            this.extensionsSetGrid.ReadOnly = true;
            this.extensionsSetGrid.RowHeadersVisible = false;
            this.extensionsSetGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkboxesToolTip.SetToolTip(this.extensionsSetGrid, resources.GetString("extensionsSetGrid.ToolTip"));
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // SetName
            // 
            this.SetName.ContextMenuStrip = this.setRowControlMenuStrip;
            resources.ApplyResources(this.SetName, "SetName");
            this.SetName.Name = "SetName";
            this.SetName.ReadOnly = true;
            // 
            // setRowControlMenuStrip
            // 
            resources.ApplyResources(this.setRowControlMenuStrip, "setRowControlMenuStrip");
            this.setRowControlMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSetItem,
            this.deleteSetItem});
            this.setRowControlMenuStrip.Name = "ruleControlsStrip";
            this.checkboxesToolTip.SetToolTip(this.setRowControlMenuStrip, resources.GetString("setRowControlMenuStrip.ToolTip"));
            // 
            // editSetItem
            // 
            resources.ApplyResources(this.editSetItem, "editSetItem");
            this.editSetItem.Name = "editSetItem";
            this.editSetItem.Click += new System.EventHandler(this.EditSetItem_Click);
            // 
            // deleteSetItem
            // 
            resources.ApplyResources(this.deleteSetItem, "deleteSetItem");
            this.deleteSetItem.Name = "deleteSetItem";
            this.deleteSetItem.Click += new System.EventHandler(this.DeleteSetItem_Click);
            // 
            // Extensions
            // 
            this.Extensions.ContextMenuStrip = this.setRowControlMenuStrip;
            resources.ApplyResources(this.Extensions, "Extensions");
            this.Extensions.Name = "Extensions";
            this.Extensions.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.ContextMenuStrip = this.setRowControlMenuStrip;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // targetPath
            // 
            this.targetPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.targetPath.ContextMenuStrip = this.setRowControlMenuStrip;
            resources.ApplyResources(this.targetPath, "targetPath");
            this.targetPath.Name = "targetPath";
            this.targetPath.ReadOnly = true;
            // 
            // setGridControlStrip
            // 
            resources.ApplyResources(this.setGridControlStrip, "setGridControlStrip");
            this.setGridControlStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSetGridItem,
            this.addSetItem});
            this.setGridControlStrip.Name = "ruleControlsStrip";
            this.checkboxesToolTip.SetToolTip(this.setGridControlStrip, resources.GetString("setGridControlStrip.ToolTip"));
            // 
            // updateSetGridItem
            // 
            resources.ApplyResources(this.updateSetGridItem, "updateSetGridItem");
            this.updateSetGridItem.Name = "updateSetGridItem";
            this.updateSetGridItem.Click += new System.EventHandler(this.UpdateSetGridItem_Click);
            // 
            // addSetItem
            // 
            resources.ApplyResources(this.addSetItem, "addSetItem");
            this.addSetItem.Name = "addSetItem";
            this.addSetItem.Click += new System.EventHandler(this.AddSetItem_Click);
            // 
            // globalSettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rulesAndSetsTabControl);
            this.Controls.Add(this.clearLogCheckbox);
            this.Controls.Add(this.overwriteFiles);
            this.Controls.Add(this.deleteFlag);
            this.Name = "globalSettingsForm";
            this.checkboxesToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.GlobalSettingsForm_Load);
            this.rulesAndSetsTabControl.ResumeLayout(false);
            this.RulesSettingsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).EndInit();
            this.ruleRowControlMenuStrip.ResumeLayout(false);
            this.ruleGridControlsStrip.ResumeLayout(false);
            this.SetsSettingsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.extensionsSetGrid)).EndInit();
            this.setRowControlMenuStrip.ResumeLayout(false);
            this.setGridControlStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox clearLogCheckbox;
        private System.Windows.Forms.CheckBox overwriteFiles;
        private System.Windows.Forms.CheckBox deleteFlag;
        private System.Windows.Forms.ToolTip checkboxesToolTip;
        private System.Windows.Forms.TabControl rulesAndSetsTabControl;
        private System.Windows.Forms.TabPage RulesSettingsTab;
        private System.Windows.Forms.TabPage SetsSettingsTab;
        private System.Windows.Forms.DataGridView rulesGrid;
        private System.Windows.Forms.DataGridView extensionsSetGrid;
        private System.Windows.Forms.ContextMenuStrip ruleGridControlsStrip;
        private System.Windows.Forms.ToolStripMenuItem UpdateGridItem;
        private System.Windows.Forms.ToolStripMenuItem AddRuleItem;
        private System.Windows.Forms.ContextMenuStrip ruleRowControlMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editRuleItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRuleItem;
        private System.Windows.Forms.ContextMenuStrip setGridControlStrip;
        private System.Windows.Forms.ToolStripMenuItem updateSetGridItem;
        private System.Windows.Forms.ToolStripMenuItem addSetItem;
        private System.Windows.Forms.ContextMenuStrip setRowControlMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editSetItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSetItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameIncludes;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCaseSensetive;
        private System.Windows.Forms.DataGridViewTextBoxColumn SavePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetPath;
    }
}