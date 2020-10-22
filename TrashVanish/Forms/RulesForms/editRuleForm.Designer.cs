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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editRuleForm));
            this.messageLabel = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.browseFolders = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.includesTextBox = new System.Windows.Forms.TextBox();
            this.caseSensetive = new System.Windows.Forms.CheckBox();
            this.browseFilesButton = new System.Windows.Forms.Button();
            this.ExtensionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            resources.ApplyResources(this.messageLabel, "messageLabel");
            this.messageLabel.Name = "messageLabel";
            // 
            // saveChangesButton
            // 
            resources.ApplyResources(this.saveChangesButton, "saveChangesButton");
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // browseFolders
            // 
            resources.ApplyResources(this.browseFolders, "browseFolders");
            this.browseFolders.Name = "browseFolders";
            this.browseFolders.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pathTextBox
            // 
            resources.ApplyResources(this.pathTextBox, "pathTextBox");
            this.pathTextBox.Name = "pathTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // includesTextBox
            // 
            resources.ApplyResources(this.includesTextBox, "includesTextBox");
            this.includesTextBox.Name = "includesTextBox";
            // 
            // caseSensetive
            // 
            resources.ApplyResources(this.caseSensetive, "caseSensetive");
            this.caseSensetive.Name = "caseSensetive";
            this.caseSensetive.UseVisualStyleBackColor = true;
            // 
            // browseFilesButton
            // 
            resources.ApplyResources(this.browseFilesButton, "browseFilesButton");
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            // 
            // ExtensionTextBox
            // 
            resources.ApplyResources(this.ExtensionTextBox, "ExtensionTextBox");
            this.ExtensionTextBox.Name = "ExtensionTextBox";
            // 
            // editRuleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExtensionTextBox);
            this.Controls.Add(this.caseSensetive);
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
            this.Load += new System.EventHandler(this.editRuleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button browseFolders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox includesTextBox;
        private System.Windows.Forms.CheckBox caseSensetive;
        private System.Windows.Forms.Button browseFilesButton;
        private System.Windows.Forms.TextBox ExtensionTextBox;
    }
}