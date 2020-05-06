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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesSettings));
            this.rulesGrid = new System.Windows.Forms.DataGridView();
            this.FileExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameIncludes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SavePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateRulesButton = new System.Windows.Forms.Button();
            this.deleteRule = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // rulesGrid
            // 
            this.rulesGrid.AllowUserToAddRows = false;
            this.rulesGrid.AllowUserToDeleteRows = false;
            this.rulesGrid.AllowUserToResizeRows = false;
            this.rulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.rulesGrid.Size = new System.Drawing.Size(358, 150);
            this.rulesGrid.TabIndex = 0;
            // 
            // FileExtension
            // 
            this.FileExtension.HeaderText = "Расширение";
            this.FileExtension.Name = "FileExtension";
            this.FileExtension.ReadOnly = true;
            this.FileExtension.Width = 95;
            // 
            // NameIncludes
            // 
            this.NameIncludes.HeaderText = "Имя файла содержит";
            this.NameIncludes.Name = "NameIncludes";
            this.NameIncludes.ReadOnly = true;
            // 
            // SavePath
            // 
            this.SavePath.HeaderText = "Путь";
            this.SavePath.Name = "SavePath";
            this.SavePath.ReadOnly = true;
            this.SavePath.Width = 200;
            // 
            // updateRulesButton
            // 
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
            this.deleteRule.Location = new System.Drawing.Point(376, 91);
            this.deleteRule.Name = "deleteRule";
            this.deleteRule.Size = new System.Drawing.Size(123, 23);
            this.deleteRule.TabIndex = 2;
            this.deleteRule.Text = "Удалить";
            this.deleteRule.UseVisualStyleBackColor = true;
            this.deleteRule.Click += new System.EventHandler(this.deleteRule_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить правило";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RulesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteRule);
            this.Controls.Add(this.updateRulesButton);
            this.Controls.Add(this.rulesGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RulesSettings";
            this.Text = "TrashVanisher - Настройка правил";
            this.Load += new System.EventHandler(this.RulesSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rulesGrid;
        private System.Windows.Forms.Button updateRulesButton;
        private System.Windows.Forms.Button deleteRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameIncludes;
        private System.Windows.Forms.DataGridViewTextBoxColumn SavePath;
        private System.Windows.Forms.Button button1;
    }
}