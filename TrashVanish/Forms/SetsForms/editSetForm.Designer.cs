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
            this.selectFolderButton.Location = new System.Drawing.Point(222, 326);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(133, 23);
            this.selectFolderButton.TabIndex = 29;
            this.selectFolderButton.Text = "Обзор";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Сохранить в...";
            // 
            // targetPathTextBox
            // 
            this.targetPathTextBox.Location = new System.Drawing.Point(12, 328);
            this.targetPathTextBox.Name = "targetPathTextBox";
            this.targetPathTextBox.Size = new System.Drawing.Size(204, 20);
            this.targetPathTextBox.TabIndex = 27;
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(-3, 352);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(372, 23);
            this.messageLabel.TabIndex = 26;
            this.messageLabel.Text = "Message";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLabel.Visible = false;
            // 
            // addSetButton
            // 
            this.addSetButton.Location = new System.Drawing.Point(116, 378);
            this.addSetButton.Name = "addSetButton";
            this.addSetButton.Size = new System.Drawing.Size(134, 23);
            this.addSetButton.TabIndex = 25;
            this.addSetButton.Text = "Редактировать набор";
            this.addSetButton.UseVisualStyleBackColor = true;
            this.addSetButton.Click += new System.EventHandler(this.updateSetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Название набора";
            // 
            // setNameTextBox
            // 
            this.setNameTextBox.Location = new System.Drawing.Point(12, 29);
            this.setNameTextBox.Name = "setNameTextBox";
            this.setNameTextBox.Size = new System.Drawing.Size(343, 20);
            this.setNameTextBox.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.includesTextBox);
            this.groupBox1.Controls.Add(this.extensionTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addExtensionToSetButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 128);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Файл содержит...";
            // 
            // includesTextBox
            // 
            this.includesTextBox.Location = new System.Drawing.Point(6, 71);
            this.includesTextBox.Name = "includesTextBox";
            this.includesTextBox.Size = new System.Drawing.Size(332, 20);
            this.includesTextBox.TabIndex = 19;
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.extensionTextBox.Location = new System.Drawing.Point(6, 32);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(332, 20);
            this.extensionTextBox.TabIndex = 3;
            this.extensionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.extensionTextBox_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Расширение";
            // 
            // addExtensionToSetButton
            // 
            this.addExtensionToSetButton.Location = new System.Drawing.Point(121, 97);
            this.addExtensionToSetButton.Name = "addExtensionToSetButton";
            this.addExtensionToSetButton.Size = new System.Drawing.Size(103, 23);
            this.addExtensionToSetButton.TabIndex = 5;
            this.addExtensionToSetButton.Text = "Добавить";
            this.addExtensionToSetButton.UseVisualStyleBackColor = true;
            this.addExtensionToSetButton.Click += new System.EventHandler(this.addExtensionToSetButton_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.extensionsList);
            this.groupBox2.Controls.Add(this.isCaseSensetiveCheckBox);
            this.groupBox2.Controls.Add(this.deleteExtensionFromListButton);
            this.groupBox2.Location = new System.Drawing.Point(11, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 116);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расширения в наборе";
            // 
            // extensionsList
            // 
            this.extensionsList.AllowUserToAddRows = false;
            this.extensionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extensionsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.extColumn,
            this.includesColumn});
            this.extensionsList.Location = new System.Drawing.Point(7, 19);
            this.extensionsList.Name = "extensionsList";
            this.extensionsList.RowHeadersVisible = false;
            this.extensionsList.Size = new System.Drawing.Size(204, 91);
            this.extensionsList.TabIndex = 19;
            // 
            // isCaseSensetiveCheckBox
            // 
            this.isCaseSensetiveCheckBox.AutoSize = true;
            this.isCaseSensetiveCheckBox.Location = new System.Drawing.Point(217, 83);
            this.isCaseSensetiveCheckBox.Name = "isCaseSensetiveCheckBox";
            this.isCaseSensetiveCheckBox.Size = new System.Drawing.Size(124, 17);
            this.isCaseSensetiveCheckBox.TabIndex = 18;
            this.isCaseSensetiveCheckBox.Text = "Учитывать регистр";
            this.toolTip1.SetToolTip(this.isCaseSensetiveCheckBox, "Регистр будет учитываться для всех расширений в наборе");
            this.isCaseSensetiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteExtensionFromListButton
            // 
            this.deleteExtensionFromListButton.Location = new System.Drawing.Point(217, 19);
            this.deleteExtensionFromListButton.Name = "deleteExtensionFromListButton";
            this.deleteExtensionFromListButton.Size = new System.Drawing.Size(121, 23);
            this.deleteExtensionFromListButton.TabIndex = 14;
            this.deleteExtensionFromListButton.Text = "Удалить";
            this.deleteExtensionFromListButton.UseVisualStyleBackColor = true;
            this.deleteExtensionFromListButton.Click += new System.EventHandler(this.deleteExtensionFromListButton_Click_1);
            // 
            // extColumn
            // 
            this.extColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.extColumn.HeaderText = "Расширение";
            this.extColumn.Name = "extColumn";
            this.extColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.extColumn.Width = 95;
            // 
            // includesColumn
            // 
            this.includesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.includesColumn.HeaderText = "Содержит";
            this.includesColumn.Name = "includesColumn";
            this.includesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.includesColumn.Width = 82;
            // 
            // editSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 413);
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
            this.Text = "TrashVanish - Редактировать набор";
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