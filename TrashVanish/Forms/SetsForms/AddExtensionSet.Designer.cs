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
            this.setNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.extensionsList = new System.Windows.Forms.ListBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addExtensionToSetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addSetButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.deleteExtensionFromListButton = new System.Windows.Forms.Button();
            this.targetPathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setNameTextBox
            // 
            this.setNameTextBox.Location = new System.Drawing.Point(12, 29);
            this.setNameTextBox.Name = "setNameTextBox";
            this.setNameTextBox.Size = new System.Drawing.Size(285, 20);
            this.setNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название набора";
            // 
            // extensionsList
            // 
            this.extensionsList.FormattingEnabled = true;
            this.extensionsList.Location = new System.Drawing.Point(12, 125);
            this.extensionsList.Name = "extensionsList";
            this.extensionsList.Size = new System.Drawing.Size(204, 69);
            this.extensionsList.TabIndex = 2;
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.Location = new System.Drawing.Point(12, 73);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(204, 20);
            this.extensionTextBox.TabIndex = 3;
            this.extensionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.extensionTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Расширение";
            // 
            // addExtensionToSetButton
            // 
            this.addExtensionToSetButton.Location = new System.Drawing.Point(222, 72);
            this.addExtensionToSetButton.Name = "addExtensionToSetButton";
            this.addExtensionToSetButton.Size = new System.Drawing.Size(75, 23);
            this.addExtensionToSetButton.TabIndex = 5;
            this.addExtensionToSetButton.Text = "Добавить";
            this.addExtensionToSetButton.UseVisualStyleBackColor = true;
            this.addExtensionToSetButton.Click += new System.EventHandler(this.addExtensionToSetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расширения в наборе";
            // 
            // addSetButton
            // 
            this.addSetButton.Location = new System.Drawing.Point(104, 282);
            this.addSetButton.Name = "addSetButton";
            this.addSetButton.Size = new System.Drawing.Size(103, 23);
            this.addSetButton.TabIndex = 7;
            this.addSetButton.Text = "Добавить набор";
            this.addSetButton.UseVisualStyleBackColor = true;
            this.addSetButton.Click += new System.EventHandler(this.addSetButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(-4, 256);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(318, 23);
            this.messageLabel.TabIndex = 13;
            this.messageLabel.Text = "Message";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLabel.Visible = false;
            // 
            // deleteExtensionFromListButton
            // 
            this.deleteExtensionFromListButton.Location = new System.Drawing.Point(222, 125);
            this.deleteExtensionFromListButton.Name = "deleteExtensionFromListButton";
            this.deleteExtensionFromListButton.Size = new System.Drawing.Size(75, 23);
            this.deleteExtensionFromListButton.TabIndex = 14;
            this.deleteExtensionFromListButton.Text = "Удалить";
            this.deleteExtensionFromListButton.UseVisualStyleBackColor = true;
            this.deleteExtensionFromListButton.Click += new System.EventHandler(this.deleteExtensionFromListButton_Click);
            // 
            // targetPathTextBox
            // 
            this.targetPathTextBox.Location = new System.Drawing.Point(12, 222);
            this.targetPathTextBox.Name = "targetPathTextBox";
            this.targetPathTextBox.Size = new System.Drawing.Size(204, 20);
            this.targetPathTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Сохранить в...";
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(222, 220);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(75, 23);
            this.selectFolderButton.TabIndex = 17;
            this.selectFolderButton.Text = "Обзор";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // AddExtensionSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 317);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.targetPathTextBox);
            this.Controls.Add(this.deleteExtensionFromListButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.addSetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addExtensionToSetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.extensionTextBox);
            this.Controls.Add(this.extensionsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddExtensionSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrashVanish - Добавить набор расширений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox setNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox extensionsList;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addExtensionToSetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addSetButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button deleteExtensionFromListButton;
        private System.Windows.Forms.TextBox targetPathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button selectFolderButton;
    }
}