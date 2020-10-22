namespace TrashVanish.Forms.SetsForms
{
    partial class AddExtensionSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExtensionSet));
            this.setNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addExtensionToSetButton = new System.Windows.Forms.Button();
            this.addSetButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.deleteExtensionFromListButton = new System.Windows.Forms.Button();
            this.targetPathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.isCaseSensetiveCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.includesTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.extensionsList = new System.Windows.Forms.DataGridView();
            this.extColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.includesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extensionsList)).BeginInit();
            this.SuspendLayout();
            // 
            // setNameTextBox
            // 
            resources.ApplyResources(this.setNameTextBox, "setNameTextBox");
            this.setNameTextBox.Name = "setNameTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.extensionTextBox, "extensionTextBox");
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.extensionTextBox_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // addExtensionToSetButton
            // 
            resources.ApplyResources(this.addExtensionToSetButton, "addExtensionToSetButton");
            this.addExtensionToSetButton.Name = "addExtensionToSetButton";
            this.addExtensionToSetButton.UseVisualStyleBackColor = true;
            this.addExtensionToSetButton.Click += new System.EventHandler(this.addExtensionToSetButton_Click);
            // 
            // addSetButton
            // 
            resources.ApplyResources(this.addSetButton, "addSetButton");
            this.addSetButton.Name = "addSetButton";
            this.addSetButton.UseVisualStyleBackColor = true;
            this.addSetButton.Click += new System.EventHandler(this.addSetButton_Click);
            // 
            // messageLabel
            // 
            resources.ApplyResources(this.messageLabel, "messageLabel");
            this.messageLabel.Name = "messageLabel";
            // 
            // deleteExtensionFromListButton
            // 
            resources.ApplyResources(this.deleteExtensionFromListButton, "deleteExtensionFromListButton");
            this.deleteExtensionFromListButton.Name = "deleteExtensionFromListButton";
            this.toolTip1.SetToolTip(this.deleteExtensionFromListButton, resources.GetString("deleteExtensionFromListButton.ToolTip"));
            this.deleteExtensionFromListButton.UseVisualStyleBackColor = true;
            this.deleteExtensionFromListButton.Click += new System.EventHandler(this.deleteExtensionFromListButton_Click);
            // 
            // targetPathTextBox
            // 
            resources.ApplyResources(this.targetPathTextBox, "targetPathTextBox");
            this.targetPathTextBox.Name = "targetPathTextBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // selectFolderButton
            // 
            resources.ApplyResources(this.selectFolderButton, "selectFolderButton");
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // isCaseSensetiveCheckBox
            // 
            resources.ApplyResources(this.isCaseSensetiveCheckBox, "isCaseSensetiveCheckBox");
            this.isCaseSensetiveCheckBox.Name = "isCaseSensetiveCheckBox";
            this.toolTip1.SetToolTip(this.isCaseSensetiveCheckBox, resources.GetString("isCaseSensetiveCheckBox.ToolTip"));
            this.isCaseSensetiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // includesTextBox
            // 
            resources.ApplyResources(this.includesTextBox, "includesTextBox");
            this.includesTextBox.Name = "includesTextBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.includesTextBox);
            this.groupBox1.Controls.Add(this.extensionTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addExtensionToSetButton);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.extensionsList);
            this.groupBox2.Controls.Add(this.isCaseSensetiveCheckBox);
            this.groupBox2.Controls.Add(this.deleteExtensionFromListButton);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // extensionsList
            // 
            this.extensionsList.AllowUserToAddRows = false;
            this.extensionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extensionsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.extColumn,
            this.includesColumn});
            resources.ApplyResources(this.extensionsList, "extensionsList");
            this.extensionsList.Name = "extensionsList";
            this.extensionsList.RowHeadersVisible = false;
            this.extensionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // extColumn
            // 
            this.extColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.extColumn, "extColumn");
            this.extColumn.Name = "extColumn";
            this.extColumn.ReadOnly = true;
            this.extColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // includesColumn
            // 
            this.includesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.includesColumn, "includesColumn");
            this.includesColumn.Name = "includesColumn";
            this.includesColumn.ReadOnly = true;
            this.includesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AddExtensionSet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.targetPathTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.addSetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setNameTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddExtensionSet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extensionsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox setNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addExtensionToSetButton;
        private System.Windows.Forms.Button addSetButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button deleteExtensionFromListButton;
        private System.Windows.Forms.TextBox targetPathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.CheckBox isCaseSensetiveCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox includesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView extensionsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn extColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn includesColumn;
    }
}