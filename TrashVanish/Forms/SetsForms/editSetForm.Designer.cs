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
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.targetPathTextBox = new System.Windows.Forms.TextBox();
            this.deleteExtensionFromListButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.updateSetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addExtensionToSetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.extensionsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.setNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(221, 220);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(75, 23);
            this.selectFolderButton.TabIndex = 30;
            this.selectFolderButton.Text = "Обзор";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Сохранить в...";
            // 
            // targetPathTextBox
            // 
            this.targetPathTextBox.Location = new System.Drawing.Point(11, 222);
            this.targetPathTextBox.Name = "targetPathTextBox";
            this.targetPathTextBox.Size = new System.Drawing.Size(204, 20);
            this.targetPathTextBox.TabIndex = 28;
            // 
            // deleteExtensionFromListButton
            // 
            this.deleteExtensionFromListButton.Location = new System.Drawing.Point(221, 125);
            this.deleteExtensionFromListButton.Name = "deleteExtensionFromListButton";
            this.deleteExtensionFromListButton.Size = new System.Drawing.Size(75, 23);
            this.deleteExtensionFromListButton.TabIndex = 27;
            this.deleteExtensionFromListButton.Text = "Удалить";
            this.deleteExtensionFromListButton.UseVisualStyleBackColor = true;
            this.deleteExtensionFromListButton.Click += new System.EventHandler(this.deleteExtensionFromListButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(-5, 256);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(318, 23);
            this.messageLabel.TabIndex = 26;
            this.messageLabel.Text = "Message";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLabel.Visible = false;
            // 
            // updateSetButton
            // 
            this.updateSetButton.Location = new System.Drawing.Point(89, 282);
            this.updateSetButton.Name = "updateSetButton";
            this.updateSetButton.Size = new System.Drawing.Size(131, 23);
            this.updateSetButton.TabIndex = 25;
            this.updateSetButton.Text = "Сохранить изменения";
            this.updateSetButton.UseVisualStyleBackColor = true;
            this.updateSetButton.Click += new System.EventHandler(this.updateSetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Расширения в наборе";
            // 
            // addExtensionToSetButton
            // 
            this.addExtensionToSetButton.Location = new System.Drawing.Point(221, 72);
            this.addExtensionToSetButton.Name = "addExtensionToSetButton";
            this.addExtensionToSetButton.Size = new System.Drawing.Size(75, 23);
            this.addExtensionToSetButton.TabIndex = 23;
            this.addExtensionToSetButton.Text = "Добавить";
            this.addExtensionToSetButton.UseVisualStyleBackColor = true;
            this.addExtensionToSetButton.Click += new System.EventHandler(this.addExtensionToSetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Расширение";
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.Location = new System.Drawing.Point(11, 73);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(204, 20);
            this.extensionTextBox.TabIndex = 21;
            // 
            // extensionsList
            // 
            this.extensionsList.FormattingEnabled = true;
            this.extensionsList.Location = new System.Drawing.Point(11, 125);
            this.extensionsList.Name = "extensionsList";
            this.extensionsList.Size = new System.Drawing.Size(204, 69);
            this.extensionsList.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Название набора";
            // 
            // setNameTextBox
            // 
            this.setNameTextBox.Location = new System.Drawing.Point(11, 29);
            this.setNameTextBox.Name = "setNameTextBox";
            this.setNameTextBox.Size = new System.Drawing.Size(285, 20);
            this.setNameTextBox.TabIndex = 18;
            // 
            // editSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 317);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.targetPathTextBox);
            this.Controls.Add(this.deleteExtensionFromListButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.updateSetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addExtensionToSetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.extensionTextBox);
            this.Controls.Add(this.extensionsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "editSetForm";
            this.Text = "TrashVanish - Редактировать набор";
            this.Load += new System.EventHandler(this.editSetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox targetPathTextBox;
        private System.Windows.Forms.Button deleteExtensionFromListButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button updateSetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addExtensionToSetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.ListBox extensionsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox setNameTextBox;
    }
}