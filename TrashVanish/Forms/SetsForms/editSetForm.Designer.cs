namespace TrashVanish.Forms.SetsForms
{
    partial class editSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editSetForm));
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.targetPathTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.addSetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.setNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.includesTextBox = new System.Windows.Forms.TextBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addExtensionToSetButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.extensionsList = new System.Windows.Forms.DataGridView();
            this.isCaseSensetiveCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteExtensionFromListButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.extColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.includesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extensionsList)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            resources.ApplyResources(this.selectFolderButton, "selectFolderButton");
            this.selectFolderButton.Name = "selectFolderButton";
            this.toolTip1.SetToolTip(this.selectFolderButton, resources.GetString("selectFolderButton.ToolTip"));
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click_1);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // targetPathTextBox
            // 
            resources.ApplyResources(this.targetPathTextBox, "targetPathTextBox");
            this.targetPathTextBox.Name = "targetPathTextBox";
            this.toolTip1.SetToolTip(this.targetPathTextBox, resources.GetString("targetPathTextBox.ToolTip"));
            // 
            // messageLabel
            // 
            resources.ApplyResources(this.messageLabel, "messageLabel");
            this.messageLabel.Name = "messageLabel";
            this.toolTip1.SetToolTip(this.messageLabel, resources.GetString("messageLabel.ToolTip"));
            // 
            // addSetButton
            // 
            resources.ApplyResources(this.addSetButton, "addSetButton");
            this.addSetButton.Name = "addSetButton";
            this.toolTip1.SetToolTip(this.addSetButton, resources.GetString("addSetButton.ToolTip"));
            this.addSetButton.UseVisualStyleBackColor = true;
            this.addSetButton.Click += new System.EventHandler(this.updateSetButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // setNameTextBox
            // 
            resources.ApplyResources(this.setNameTextBox, "setNameTextBox");
            this.setNameTextBox.Name = "setNameTextBox";
            this.toolTip1.SetToolTip(this.setNameTextBox, resources.GetString("setNameTextBox.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.includesTextBox);
            this.groupBox1.Controls.Add(this.extensionTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addExtensionToSetButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // includesTextBox
            // 
            resources.ApplyResources(this.includesTextBox, "includesTextBox");
            this.includesTextBox.Name = "includesTextBox";
            this.toolTip1.SetToolTip(this.includesTextBox, resources.GetString("includesTextBox.ToolTip"));
            // 
            // extensionTextBox
            // 
            resources.ApplyResources(this.extensionTextBox, "extensionTextBox");
            this.extensionTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.extensionTextBox.Name = "extensionTextBox";
            this.toolTip1.SetToolTip(this.extensionTextBox, resources.GetString("extensionTextBox.ToolTip"));
            this.extensionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.extensionTextBox_KeyPress_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // addExtensionToSetButton
            // 
            resources.ApplyResources(this.addExtensionToSetButton, "addExtensionToSetButton");
            this.addExtensionToSetButton.Name = "addExtensionToSetButton";
            this.toolTip1.SetToolTip(this.addExtensionToSetButton, resources.GetString("addExtensionToSetButton.ToolTip"));
            this.addExtensionToSetButton.UseVisualStyleBackColor = true;
            this.addExtensionToSetButton.Click += new System.EventHandler(this.addExtensionToSetButton_Click_1);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.extensionsList);
            this.groupBox2.Controls.Add(this.isCaseSensetiveCheckBox);
            this.groupBox2.Controls.Add(this.deleteExtensionFromListButton);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // extensionsList
            // 
            resources.ApplyResources(this.extensionsList, "extensionsList");
            this.extensionsList.AllowUserToAddRows = false;
            this.extensionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extensionsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.extColumn,
            this.includesColumn});
            this.extensionsList.Name = "extensionsList";
            this.extensionsList.RowHeadersVisible = false;
            this.extensionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.extensionsList, resources.GetString("extensionsList.ToolTip"));
            // 
            // isCaseSensetiveCheckBox
            // 
            resources.ApplyResources(this.isCaseSensetiveCheckBox, "isCaseSensetiveCheckBox");
            this.isCaseSensetiveCheckBox.Name = "isCaseSensetiveCheckBox";
            this.toolTip1.SetToolTip(this.isCaseSensetiveCheckBox, resources.GetString("isCaseSensetiveCheckBox.ToolTip"));
            this.isCaseSensetiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteExtensionFromListButton
            // 
            resources.ApplyResources(this.deleteExtensionFromListButton, "deleteExtensionFromListButton");
            this.deleteExtensionFromListButton.Name = "deleteExtensionFromListButton";
            this.toolTip1.SetToolTip(this.deleteExtensionFromListButton, resources.GetString("deleteExtensionFromListButton.ToolTip"));
            this.deleteExtensionFromListButton.UseVisualStyleBackColor = true;
            this.deleteExtensionFromListButton.Click += new System.EventHandler(this.deleteExtensionFromListButton_Click_1);
            // 
            // extColumn
            // 
            this.extColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.extColumn, "extColumn");
            this.extColumn.Name = "extColumn";
            this.extColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // includesColumn
            // 
            this.includesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.includesColumn, "includesColumn");
            this.includesColumn.Name = "includesColumn";
            this.includesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // editSetForm
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
            this.Name = "editSetForm";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.editSetForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extensionsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox targetPathTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button addSetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox setNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox includesTextBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addExtensionToSetButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView extensionsList;
        private System.Windows.Forms.CheckBox isCaseSensetiveCheckBox;
        private System.Windows.Forms.Button deleteExtensionFromListButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn extColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn includesColumn;
    }
}