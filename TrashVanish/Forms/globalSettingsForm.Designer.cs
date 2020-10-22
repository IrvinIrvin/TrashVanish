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
            this.setRowControlMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSetItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSetItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGridControlStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateSetGridItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSetItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.clearLogCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearLogCheckbox.AutoSize = true;
            this.clearLogCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearLogCheckbox.Location = new System.Drawing.Point(12, 294);
            this.clearLogCheckbox.Name = "clearLogCheckbox";
            this.clearLogCheckbox.Size = new System.Drawing.Size(91, 17);
            this.clearLogCheckbox.TabIndex = 9;
            this.clearLogCheckbox.Text = "Очищать лог";
            this.checkboxesToolTip.SetToolTip(this.clearLogCheckbox, "Очистить лог перед выполнением задания");
            this.clearLogCheckbox.UseVisualStyleBackColor = true;
            this.clearLogCheckbox.CheckedChanged += new System.EventHandler(this.clearLogCheckbox_CheckedChanged);
            // 
            // overwriteFiles
            // 
            this.overwriteFiles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.overwriteFiles.Checked = true;
            this.overwriteFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteFiles.Location = new System.Drawing.Point(246, 282);
            this.overwriteFiles.Name = "overwriteFiles";
            this.overwriteFiles.Size = new System.Drawing.Size(114, 40);
            this.overwriteFiles.TabIndex = 8;
            this.overwriteFiles.Text = "Перезаписывать файлы";
            this.checkboxesToolTip.SetToolTip(this.overwriteFiles, "Перезаписывать уже существующие файлы в случае конфликта (если не отмечено, файл " +
        "не будет скопирован)");
            this.overwriteFiles.UseVisualStyleBackColor = true;
            this.overwriteFiles.CheckedChanged += new System.EventHandler(this.overwriteFiles_CheckedChanged);
            // 
            // deleteFlag
            // 
            this.deleteFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFlag.Checked = true;
            this.deleteFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteFlag.Location = new System.Drawing.Point(503, 275);
            this.deleteFlag.Name = "deleteFlag";
            this.deleteFlag.Size = new System.Drawing.Size(114, 55);
            this.deleteFlag.TabIndex = 7;
            this.deleteFlag.Text = "Удалять после копирования";
            this.checkboxesToolTip.SetToolTip(this.deleteFlag, "Удалить файл после копирования");
            this.deleteFlag.UseVisualStyleBackColor = true;
            this.deleteFlag.CheckedChanged += new System.EventHandler(this.deleteFlag_CheckedChanged);
            // 
            // rulesAndSetsTabControl
            // 
            this.rulesAndSetsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesAndSetsTabControl.Controls.Add(this.RulesSettingsTab);
            this.rulesAndSetsTabControl.Controls.Add(this.SetsSettingsTab);
            this.rulesAndSetsTabControl.Location = new System.Drawing.Point(12, 8);
            this.rulesAndSetsTabControl.Name = "rulesAndSetsTabControl";
            this.rulesAndSetsTabControl.SelectedIndex = 0;
            this.rulesAndSetsTabControl.Size = new System.Drawing.Size(605, 265);
            this.rulesAndSetsTabControl.TabIndex = 10;
            this.rulesAndSetsTabControl.SelectedIndexChanged += new System.EventHandler(this.rulesAndSetsTabControl_SelectedIndexChanged);
            // 
            // RulesSettingsTab
            // 
            this.RulesSettingsTab.Controls.Add(this.rulesGrid);
            this.RulesSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.RulesSettingsTab.Name = "RulesSettingsTab";
            this.RulesSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.RulesSettingsTab.Size = new System.Drawing.Size(597, 239);
            this.RulesSettingsTab.TabIndex = 0;
            this.RulesSettingsTab.Text = "Правила";
            this.RulesSettingsTab.UseVisualStyleBackColor = true;
            // 
            // rulesGrid
            // 
            this.rulesGrid.AllowUserToAddRows = false;
            this.rulesGrid.AllowUserToDeleteRows = false;
            this.rulesGrid.AllowUserToResizeRows = false;
            this.rulesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FileExtension,
            this.NameIncludes,
            this.isCaseSensetive,
            this.SavePath});
            this.rulesGrid.ContextMenuStrip = this.ruleGridControlsStrip;
            this.rulesGrid.Location = new System.Drawing.Point(6, 16);
            this.rulesGrid.MultiSelect = false;
            this.rulesGrid.Name = "rulesGrid";
            this.rulesGrid.ReadOnly = true;
            this.rulesGrid.RowHeadersVisible = false;
            this.rulesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.rulesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rulesGrid.Size = new System.Drawing.Size(585, 203);
            this.rulesGrid.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // FileExtension
            // 
            this.FileExtension.ContextMenuStrip = this.ruleRowControlMenuStrip;
            this.FileExtension.HeaderText = "Расширение";
            this.FileExtension.MinimumWidth = 50;
            this.FileExtension.Name = "FileExtension";
            this.FileExtension.ReadOnly = true;
            this.FileExtension.Width = 95;
            // 
            // ruleRowControlMenuStrip
            // 
            this.ruleRowControlMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRuleItem,
            this.deleteRuleItem});
            this.ruleRowControlMenuStrip.Name = "ruleControlsStrip";
            this.ruleRowControlMenuStrip.Size = new System.Drawing.Size(155, 48);
            // 
            // editRuleItem
            // 
            this.editRuleItem.Name = "editRuleItem";
            this.editRuleItem.Size = new System.Drawing.Size(154, 22);
            this.editRuleItem.Text = "Редактировать";
            this.editRuleItem.Click += new System.EventHandler(this.editRuleItem_Click);
            // 
            // deleteRuleItem
            // 
            this.deleteRuleItem.Name = "deleteRuleItem";
            this.deleteRuleItem.Size = new System.Drawing.Size(154, 22);
            this.deleteRuleItem.Text = "Удалить";
            this.deleteRuleItem.Click += new System.EventHandler(this.deleteRuleItem_Click);
            // 
            // NameIncludes
            // 
            this.NameIncludes.ContextMenuStrip = this.ruleRowControlMenuStrip;
            this.NameIncludes.HeaderText = "Имя файла содержит";
            this.NameIncludes.MinimumWidth = 50;
            this.NameIncludes.Name = "NameIncludes";
            this.NameIncludes.ReadOnly = true;
            this.NameIncludes.Width = 129;
            // 
            // isCaseSensetive
            // 
            this.isCaseSensetive.ContextMenuStrip = this.ruleRowControlMenuStrip;
            this.isCaseSensetive.HeaderText = "Учитывать регистр";
            this.isCaseSensetive.Name = "isCaseSensetive";
            this.isCaseSensetive.ReadOnly = true;
            // 
            // SavePath
            // 
            this.SavePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SavePath.ContextMenuStrip = this.ruleRowControlMenuStrip;
            this.SavePath.HeaderText = "Путь";
            this.SavePath.Name = "SavePath";
            this.SavePath.ReadOnly = true;
            // 
            // ruleGridControlsStrip
            // 
            this.ruleGridControlsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateGridItem,
            this.AddRuleItem});
            this.ruleGridControlsStrip.Name = "ruleControlsStrip";
            this.ruleGridControlsStrip.Size = new System.Drawing.Size(177, 48);
            // 
            // UpdateGridItem
            // 
            this.UpdateGridItem.Name = "UpdateGridItem";
            this.UpdateGridItem.Size = new System.Drawing.Size(176, 22);
            this.UpdateGridItem.Text = "Обновить";
            this.UpdateGridItem.Click += new System.EventHandler(this.UpdateGridItem_Click);
            // 
            // AddRuleItem
            // 
            this.AddRuleItem.Name = "AddRuleItem";
            this.AddRuleItem.Size = new System.Drawing.Size(176, 22);
            this.AddRuleItem.Text = "Добавить правило";
            this.AddRuleItem.Click += new System.EventHandler(this.AddRuleItem_Click);
            // 
            // SetsSettingsTab
            // 
            this.SetsSettingsTab.Controls.Add(this.extensionsSetGrid);
            this.SetsSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SetsSettingsTab.Name = "SetsSettingsTab";
            this.SetsSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SetsSettingsTab.Size = new System.Drawing.Size(597, 239);
            this.SetsSettingsTab.TabIndex = 1;
            this.SetsSettingsTab.Text = "Наборы";
            this.SetsSettingsTab.UseVisualStyleBackColor = true;
            // 
            // extensionsSetGrid
            // 
            this.extensionsSetGrid.AllowUserToAddRows = false;
            this.extensionsSetGrid.AllowUserToDeleteRows = false;
            this.extensionsSetGrid.AllowUserToResizeRows = false;
            this.extensionsSetGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extensionsSetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.extensionsSetGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.SetName,
            this.Extensions,
            this.dataGridViewTextBoxColumn2,
            this.targetPath});
            this.extensionsSetGrid.ContextMenuStrip = this.setGridControlStrip;
            this.extensionsSetGrid.Location = new System.Drawing.Point(6, 16);
            this.extensionsSetGrid.MultiSelect = false;
            this.extensionsSetGrid.Name = "extensionsSetGrid";
            this.extensionsSetGrid.ReadOnly = true;
            this.extensionsSetGrid.RowHeadersVisible = false;
            this.extensionsSetGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.extensionsSetGrid.Size = new System.Drawing.Size(585, 203);
            this.extensionsSetGrid.TabIndex = 5;
            // 
            // setRowControlMenuStrip
            // 
            this.setRowControlMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSetItem,
            this.deleteSetItem});
            this.setRowControlMenuStrip.Name = "ruleControlsStrip";
            this.setRowControlMenuStrip.Size = new System.Drawing.Size(155, 48);
            // 
            // editSetItem
            // 
            this.editSetItem.Name = "editSetItem";
            this.editSetItem.Size = new System.Drawing.Size(154, 22);
            this.editSetItem.Text = "Редактировать";
            this.editSetItem.Click += new System.EventHandler(this.editSetItem_Click);
            // 
            // deleteSetItem
            // 
            this.deleteSetItem.Name = "deleteSetItem";
            this.deleteSetItem.Size = new System.Drawing.Size(154, 22);
            this.deleteSetItem.Text = "Удалить";
            this.deleteSetItem.Click += new System.EventHandler(this.deleteSetItem_Click);
            // 
            // setGridControlStrip
            // 
            this.setGridControlStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSetGridItem,
            this.addSetItem});
            this.setGridControlStrip.Name = "ruleControlsStrip";
            this.setGridControlStrip.Size = new System.Drawing.Size(164, 48);
            // 
            // updateSetGridItem
            // 
            this.updateSetGridItem.Name = "updateSetGridItem";
            this.updateSetGridItem.Size = new System.Drawing.Size(163, 22);
            this.updateSetGridItem.Text = "Обновить";
            this.updateSetGridItem.Click += new System.EventHandler(this.updateSetGridItem_Click);
            // 
            // addSetItem
            // 
            this.addSetItem.Name = "addSetItem";
            this.addSetItem.Size = new System.Drawing.Size(163, 22);
            this.addSetItem.Text = "Добавить набор";
            this.addSetItem.Click += new System.EventHandler(this.addSetItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // SetName
            // 
            this.SetName.ContextMenuStrip = this.setRowControlMenuStrip;
            this.SetName.HeaderText = "Имя набора";
            this.SetName.MinimumWidth = 50;
            this.SetName.Name = "SetName";
            this.SetName.ReadOnly = true;
            this.SetName.Width = 93;
            // 
            // Extensions
            // 
            this.Extensions.ContextMenuStrip = this.setRowControlMenuStrip;
            this.Extensions.HeaderText = "Расширения";
            this.Extensions.MinimumWidth = 50;
            this.Extensions.Name = "Extensions";
            this.Extensions.ReadOnly = true;
            this.Extensions.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.ContextMenuStrip = this.setRowControlMenuStrip;
            this.dataGridViewTextBoxColumn2.HeaderText = "Учитывать регистр";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // targetPath
            // 
            this.targetPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.targetPath.ContextMenuStrip = this.setRowControlMenuStrip;
            this.targetPath.HeaderText = "Путь";
            this.targetPath.Name = "targetPath";
            this.targetPath.ReadOnly = true;
            // 
            // globalSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 334);
            this.Controls.Add(this.rulesAndSetsTabControl);
            this.Controls.Add(this.clearLogCheckbox);
            this.Controls.Add(this.overwriteFiles);
            this.Controls.Add(this.deleteFlag);
            this.MinimumSize = new System.Drawing.Size(645, 373);
            this.Name = "globalSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrashVanish - Настройки";
            this.Load += new System.EventHandler(this.globalSettingsForm_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameIncludes;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCaseSensetive;
        private System.Windows.Forms.DataGridViewTextBoxColumn SavePath;
        private System.Windows.Forms.ContextMenuStrip setGridControlStrip;
        private System.Windows.Forms.ToolStripMenuItem updateSetGridItem;
        private System.Windows.Forms.ToolStripMenuItem addSetItem;
        private System.Windows.Forms.ContextMenuStrip setRowControlMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editSetItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSetItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetPath;
    }
}