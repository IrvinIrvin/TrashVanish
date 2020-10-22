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
            this.editRule = new System.Windows.Forms.Button();
            this.addRuleButton = new System.Windows.Forms.Button();
            this.deleteRule = new System.Windows.Forms.Button();
            this.updateRulesButton = new System.Windows.Forms.Button();
            this.rulesGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameIncludes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCaseSensetive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SavePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetsSettingsTab = new System.Windows.Forms.TabPage();
            this.updateGridButton = new System.Windows.Forms.Button();
            this.deleteSetButton = new System.Windows.Forms.Button();
            this.editSetButton = new System.Windows.Forms.Button();
            this.addSetButton = new System.Windows.Forms.Button();
            this.extensionsSetGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rulesAndSetsTabControl.SuspendLayout();
            this.RulesSettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).BeginInit();
            this.SetsSettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extensionsSetGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clearLogCheckbox
            // 
            this.clearLogCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.overwriteFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.rulesAndSetsTabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.RulesSettingsTab.Controls.Add(this.editRule);
            this.RulesSettingsTab.Controls.Add(this.addRuleButton);
            this.RulesSettingsTab.Controls.Add(this.deleteRule);
            this.RulesSettingsTab.Controls.Add(this.updateRulesButton);
            this.RulesSettingsTab.Controls.Add(this.rulesGrid);
            this.RulesSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.RulesSettingsTab.Name = "RulesSettingsTab";
            this.RulesSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.RulesSettingsTab.Size = new System.Drawing.Size(597, 239);
            this.RulesSettingsTab.TabIndex = 0;
            this.RulesSettingsTab.Text = "Правила";
            this.RulesSettingsTab.UseVisualStyleBackColor = true;
            // 
            // editRule
            // 
            this.editRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editRule.Location = new System.Drawing.Point(468, 94);
            this.editRule.Name = "editRule";
            this.editRule.Size = new System.Drawing.Size(123, 23);
            this.editRule.TabIndex = 9;
            this.editRule.Text = "Редактировать";
            this.editRule.UseVisualStyleBackColor = true;
            this.editRule.Click += new System.EventHandler(this.editRule_Click);
            // 
            // addRuleButton
            // 
            this.addRuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRuleButton.Location = new System.Drawing.Point(468, 55);
            this.addRuleButton.Name = "addRuleButton";
            this.addRuleButton.Size = new System.Drawing.Size(123, 23);
            this.addRuleButton.TabIndex = 8;
            this.addRuleButton.Text = "Добавить правило";
            this.addRuleButton.UseVisualStyleBackColor = true;
            this.addRuleButton.Click += new System.EventHandler(this.addRuleButton_Click);
            // 
            // deleteRule
            // 
            this.deleteRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteRule.Location = new System.Drawing.Point(468, 135);
            this.deleteRule.Name = "deleteRule";
            this.deleteRule.Size = new System.Drawing.Size(123, 23);
            this.deleteRule.TabIndex = 7;
            this.deleteRule.Text = "Удалить";
            this.deleteRule.UseVisualStyleBackColor = true;
            this.deleteRule.Click += new System.EventHandler(this.deleteRule_Click);
            // 
            // updateRulesButton
            // 
            this.updateRulesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateRulesButton.Location = new System.Drawing.Point(468, 16);
            this.updateRulesButton.Name = "updateRulesButton";
            this.updateRulesButton.Size = new System.Drawing.Size(123, 23);
            this.updateRulesButton.TabIndex = 6;
            this.updateRulesButton.Text = "Обновить";
            this.updateRulesButton.UseVisualStyleBackColor = true;
            this.updateRulesButton.Click += new System.EventHandler(this.updateRulesButton_Click);
            // 
            // rulesGrid
            // 
            this.rulesGrid.AllowUserToAddRows = false;
            this.rulesGrid.AllowUserToDeleteRows = false;
            this.rulesGrid.AllowUserToResizeRows = false;
            this.rulesGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FileExtension,
            this.NameIncludes,
            this.isCaseSensetive,
            this.SavePath});
            this.rulesGrid.Location = new System.Drawing.Point(6, 16);
            this.rulesGrid.MultiSelect = false;
            this.rulesGrid.Name = "rulesGrid";
            this.rulesGrid.ReadOnly = true;
            this.rulesGrid.RowHeadersVisible = false;
            this.rulesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.rulesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rulesGrid.Size = new System.Drawing.Size(448, 203);
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
            this.FileExtension.HeaderText = "Расширение";
            this.FileExtension.MinimumWidth = 50;
            this.FileExtension.Name = "FileExtension";
            this.FileExtension.ReadOnly = true;
            this.FileExtension.Width = 95;
            // 
            // NameIncludes
            // 
            this.NameIncludes.HeaderText = "Имя файла содержит";
            this.NameIncludes.MinimumWidth = 50;
            this.NameIncludes.Name = "NameIncludes";
            this.NameIncludes.ReadOnly = true;
            this.NameIncludes.Width = 129;
            // 
            // isCaseSensetive
            // 
            this.isCaseSensetive.HeaderText = "Учитывать регистр";
            this.isCaseSensetive.Name = "isCaseSensetive";
            this.isCaseSensetive.ReadOnly = true;
            // 
            // SavePath
            // 
            this.SavePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SavePath.HeaderText = "Путь";
            this.SavePath.Name = "SavePath";
            this.SavePath.ReadOnly = true;
            // 
            // SetsSettingsTab
            // 
            this.SetsSettingsTab.Controls.Add(this.updateGridButton);
            this.SetsSettingsTab.Controls.Add(this.deleteSetButton);
            this.SetsSettingsTab.Controls.Add(this.editSetButton);
            this.SetsSettingsTab.Controls.Add(this.addSetButton);
            this.SetsSettingsTab.Controls.Add(this.extensionsSetGrid);
            this.SetsSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SetsSettingsTab.Name = "SetsSettingsTab";
            this.SetsSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SetsSettingsTab.Size = new System.Drawing.Size(597, 239);
            this.SetsSettingsTab.TabIndex = 1;
            this.SetsSettingsTab.Text = "Наборы";
            this.SetsSettingsTab.UseVisualStyleBackColor = true;
            // 
            // updateGridButton
            // 
            this.updateGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateGridButton.Location = new System.Drawing.Point(463, 16);
            this.updateGridButton.Name = "updateGridButton";
            this.updateGridButton.Size = new System.Drawing.Size(128, 23);
            this.updateGridButton.TabIndex = 9;
            this.updateGridButton.Text = "Обновить";
            this.updateGridButton.UseVisualStyleBackColor = true;
            this.updateGridButton.Click += new System.EventHandler(this.updateGridButton_Click);
            // 
            // deleteSetButton
            // 
            this.deleteSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSetButton.Location = new System.Drawing.Point(463, 132);
            this.deleteSetButton.Name = "deleteSetButton";
            this.deleteSetButton.Size = new System.Drawing.Size(128, 23);
            this.deleteSetButton.TabIndex = 8;
            this.deleteSetButton.Text = "Удалить набор";
            this.deleteSetButton.UseVisualStyleBackColor = true;
            this.deleteSetButton.Click += new System.EventHandler(this.deleteSetButton_Click);
            // 
            // editSetButton
            // 
            this.editSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSetButton.Location = new System.Drawing.Point(463, 93);
            this.editSetButton.Name = "editSetButton";
            this.editSetButton.Size = new System.Drawing.Size(128, 23);
            this.editSetButton.TabIndex = 7;
            this.editSetButton.Text = "Редактировать";
            this.editSetButton.UseVisualStyleBackColor = true;
            this.editSetButton.Click += new System.EventHandler(this.editSetButton_Click);
            // 
            // addSetButton
            // 
            this.addSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSetButton.Location = new System.Drawing.Point(463, 54);
            this.addSetButton.Name = "addSetButton";
            this.addSetButton.Size = new System.Drawing.Size(128, 23);
            this.addSetButton.TabIndex = 6;
            this.addSetButton.Text = "Добавить набор";
            this.addSetButton.UseVisualStyleBackColor = true;
            this.addSetButton.Click += new System.EventHandler(this.addSetButton_Click);
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
            this.extensionsSetGrid.Location = new System.Drawing.Point(6, 16);
            this.extensionsSetGrid.MultiSelect = false;
            this.extensionsSetGrid.Name = "extensionsSetGrid";
            this.extensionsSetGrid.ReadOnly = true;
            this.extensionsSetGrid.RowHeadersVisible = false;
            this.extensionsSetGrid.Size = new System.Drawing.Size(448, 203);
            this.extensionsSetGrid.TabIndex = 5;
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
            this.SetName.HeaderText = "Имя набора";
            this.SetName.MinimumWidth = 50;
            this.SetName.Name = "SetName";
            this.SetName.ReadOnly = true;
            this.SetName.Width = 93;
            // 
            // Extensions
            // 
            this.Extensions.HeaderText = "Расширения";
            this.Extensions.MinimumWidth = 50;
            this.Extensions.Name = "Extensions";
            this.Extensions.ReadOnly = true;
            this.Extensions.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Учитывать регистр";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // targetPath
            // 
            this.targetPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.targetPath.HeaderText = "Путь";
            this.targetPath.Name = "targetPath";
            this.targetPath.ReadOnly = true;
            this.targetPath.Width = 56;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "globalSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrashVanish - Настройки";
            this.Load += new System.EventHandler(this.globalSettingsForm_Load);
            this.rulesAndSetsTabControl.ResumeLayout(false);
            this.RulesSettingsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).EndInit();
            this.SetsSettingsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.extensionsSetGrid)).EndInit();
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
        private System.Windows.Forms.Button editRule;
        private System.Windows.Forms.Button addRuleButton;
        private System.Windows.Forms.Button deleteRule;
        private System.Windows.Forms.Button updateRulesButton;
        private System.Windows.Forms.DataGridView rulesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameIncludes;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCaseSensetive;
        private System.Windows.Forms.DataGridViewTextBoxColumn SavePath;
        private System.Windows.Forms.Button updateGridButton;
        private System.Windows.Forms.Button deleteSetButton;
        private System.Windows.Forms.Button editSetButton;
        private System.Windows.Forms.Button addSetButton;
        private System.Windows.Forms.DataGridView extensionsSetGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetPath;
    }
}