namespace TrashVanish.Forms.RulesForms
{
    partial class editRuleForm
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
            this.ExtensionTextBox = new System.Windows.Forms.ComboBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.browseFilesButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.browseFolders = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.includesTextBox = new System.Windows.Forms.TextBox();
            this.caseSensetive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ExtensionTextBox
            // 
            this.ExtensionTextBox.FormattingEnabled = true;
            this.ExtensionTextBox.Items.AddRange(new object[] {
            "Добавить набор",
            "Изменить наборы"});
            this.ExtensionTextBox.Location = new System.Drawing.Point(11, 27);
            this.ExtensionTextBox.Name = "ExtensionTextBox";
            this.ExtensionTextBox.Size = new System.Drawing.Size(203, 21);
            this.ExtensionTextBox.TabIndex = 24;
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(-1, 165);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(318, 23);
            this.messageLabel.TabIndex = 23;
            this.messageLabel.Text = "Message";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLabel.Visible = false;
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Location = new System.Drawing.Point(220, 27);
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.Size = new System.Drawing.Size(75, 23);
            this.browseFilesButton.TabIndex = 22;
            this.browseFilesButton.Text = "Обзор";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(88, 191);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(141, 23);
            this.saveChangesButton.TabIndex = 21;
            this.saveChangesButton.Text = "Сохранить изменения";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // browseFolders
            // 
            this.browseFolders.Location = new System.Drawing.Point(220, 129);
            this.browseFolders.Name = "browseFolders";
            this.browseFolders.Size = new System.Drawing.Size(75, 23);
            this.browseFolders.TabIndex = 20;
            this.browseFolders.Text = "Обзор";
            this.browseFolders.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Сохранить в...";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(11, 131);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(203, 20);
            this.pathTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Название файла содержит...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Расширение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // includesTextBox
            // 
            this.includesTextBox.Location = new System.Drawing.Point(11, 80);
            this.includesTextBox.Name = "includesTextBox";
            this.includesTextBox.Size = new System.Drawing.Size(203, 20);
            this.includesTextBox.TabIndex = 14;
            // 
            // caseSensetive
            // 
            this.caseSensetive.AutoSize = true;
            this.caseSensetive.Location = new System.Drawing.Point(221, 80);
            this.caseSensetive.Name = "caseSensetive";
            this.caseSensetive.Size = new System.Drawing.Size(124, 17);
            this.caseSensetive.TabIndex = 25;
            this.caseSensetive.Text = "Учитывать регистр";
            this.caseSensetive.UseVisualStyleBackColor = true;
            // 
            // editRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 235);
            this.Controls.Add(this.caseSensetive);
            this.Controls.Add(this.ExtensionTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.browseFilesButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.browseFolders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.includesTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "editRuleForm";
            this.Text = "TrashVanisher - Редактировать правило";
            this.Load += new System.EventHandler(this.editRuleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ExtensionTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button browseFilesButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button browseFolders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox includesTextBox;
        private System.Windows.Forms.CheckBox caseSensetive;
    }
}