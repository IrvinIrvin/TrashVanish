namespace TrashVanish
{
    partial class AddRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRule));
            this.ExtensionTextBox = new System.Windows.Forms.TextBox();
            this.includesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.browseFolders = new System.Windows.Forms.Button();
            this.AddRuleButton = new System.Windows.Forms.Button();
            this.browseFilesButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExtensionTextBox
            // 
            this.ExtensionTextBox.Location = new System.Drawing.Point(12, 28);
            this.ExtensionTextBox.Name = "ExtensionTextBox";
            this.ExtensionTextBox.Size = new System.Drawing.Size(203, 20);
            this.ExtensionTextBox.TabIndex = 0;
            // 
            // includesTextBox
            // 
            this.includesTextBox.Location = new System.Drawing.Point(12, 82);
            this.includesTextBox.Name = "includesTextBox";
            this.includesTextBox.Size = new System.Drawing.Size(203, 20);
            this.includesTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Расширение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название файла содержит...";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 133);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(203, 20);
            this.pathTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сохранить в...";
            // 
            // browseFolders
            // 
            this.browseFolders.Location = new System.Drawing.Point(221, 131);
            this.browseFolders.Name = "browseFolders";
            this.browseFolders.Size = new System.Drawing.Size(75, 23);
            this.browseFolders.TabIndex = 9;
            this.browseFolders.Text = "Обзор";
            this.browseFolders.UseVisualStyleBackColor = true;
            this.browseFolders.Click += new System.EventHandler(this.browseFolders_Click);
            // 
            // AddRuleButton
            // 
            this.AddRuleButton.Location = new System.Drawing.Point(103, 196);
            this.AddRuleButton.Name = "AddRuleButton";
            this.AddRuleButton.Size = new System.Drawing.Size(114, 23);
            this.AddRuleButton.TabIndex = 10;
            this.AddRuleButton.Text = "Добавить правило";
            this.AddRuleButton.UseVisualStyleBackColor = true;
            this.AddRuleButton.Click += new System.EventHandler(this.AddRuleButton_Click);
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Location = new System.Drawing.Point(221, 26);
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.Size = new System.Drawing.Size(75, 23);
            this.browseFilesButton.TabIndex = 11;
            this.browseFilesButton.Text = "Обзор";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            this.browseFilesButton.Click += new System.EventHandler(this.browseFilesButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(0, 167);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(318, 23);
            this.messageLabel.TabIndex = 12;
            this.messageLabel.Text = "Message";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLabel.Visible = false;
            // 
            // AddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 231);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.browseFilesButton);
            this.Controls.Add(this.AddRuleButton);
            this.Controls.Add(this.browseFolders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.includesTextBox);
            this.Controls.Add(this.ExtensionTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrashVanisher - Добавить правило";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExtensionTextBox;
        private System.Windows.Forms.TextBox includesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button browseFolders;
        private System.Windows.Forms.Button AddRuleButton;
        private System.Windows.Forms.Button browseFilesButton;
        private System.Windows.Forms.Label messageLabel;
    }
}