namespace TrashVanish
{
    partial class RulesSettings
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
            this.rulesGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameIncludes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SavePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateRulesButton = new System.Windows.Forms.Button();
            this.deleteRule = new System.Windows.Forms.Button();
            this.addRuleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).BeginInit();
            this.SuspendLayout();
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
            this.SavePath});
            this.rulesGrid.Location = new System.Drawing.Point(12, 12);
            this.rulesGrid.MultiSelect = false;
            this.rulesGrid.Name = "rulesGrid";
            this.rulesGrid.ReadOnly = true;
            this.rulesGrid.RowHeadersVisible = false;
            this.rulesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.rulesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rulesGrid.Size = new System.Drawing.Size(358, 165);
            this.rulesGrid.TabIndex = 0;
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
            this.FileExtension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileExtension.HeaderText = "Расширение";
            this.FileExtension.Name = "FileExtension";
            this.FileExtension.ReadOnly = true;
            this.FileExtension.Width = 95;
            // 
            // NameIncludes
            // 
            this.NameIncludes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameIncludes.HeaderText = "Имя файла содержит";
            this.NameIncludes.Name = "NameIncludes";
            this.NameIncludes.ReadOnly = true;
            this.NameIncludes.Width = 129;
            // 
            // SavePath
            // 
            this.SavePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SavePath.HeaderText = "Путь";
            this.SavePath.Name = "SavePath";
            this.SavePath.ReadOnly = true;
            // 
            // updateRulesButton
            // 
            this.updateRulesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateRulesButton.Location = new System.Drawing.Point(376, 12);
            this.updateRulesButton.Name = "updateRulesButton";
            this.updateRulesButton.Size = new System.Drawing.Size(123, 23);
            this.updateRulesButton.TabIndex = 1;
            this.updateRulesButton.Text = "Обновить";
            this.updateRulesButton.UseVisualStyleBackColor = true;
            this.updateRulesButton.Click += new System.EventHandler(this.updateRulesButton_Click);
            // 
            // deleteRule
            // 
            this.deleteRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteRule.Location = new System.Drawing.Point(376, 91);
            this.deleteRule.Name = "deleteRule";
            this.deleteRule.Size = new System.Drawing.Size(123, 23);
            this.deleteRule.TabIndex = 2;
            this.deleteRule.Text = "Удалить";
            this.deleteRule.UseVisualStyleBackColor = true;
            this.deleteRule.Click += new System.EventHandler(this.deleteRule_Click);
            // 
            // addRuleButton
            // 
            this.addRuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRuleButton.Location = new System.Drawing.Point(376, 51);
            this.addRuleButton.Name = "addRuleButton";
            this.addRuleButton.Size = new System.Drawing.Size(123, 23);
            this.addRuleButton.TabIndex = 3;
            this.addRuleButton.Text = "Добавить правило";
            this.addRuleButton.UseVisualStyleBackColor = true;
            this.addRuleButton.Click += new System.EventHandler(this.addRuleButton_Click);
            // 
            // RulesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 189);
            this.Controls.Add(this.addRuleButton);
            this.Controls.Add(this.deleteRule);
            this.Controls.Add(this.updateRulesButton);
            this.Controls.Add(this.rulesGrid);
            this.MinimumSize = new System.Drawing.Size(527, 228);
            this.Name = "RulesSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrashVanisher - Настройка правил";
            this.Load += new System.EventHandler(this.RulesSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rulesGrid;
        private System.Windows.Forms.Button updateRulesButton;
        private System.Windows.Forms.Button deleteRule;
        private System.Windows.Forms.Button addRuleButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameIncludes;
        private System.Windows.Forms.DataGridViewTextBoxColumn SavePath;
    }
}