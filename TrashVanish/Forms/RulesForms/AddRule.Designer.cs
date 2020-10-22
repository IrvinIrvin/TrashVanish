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
            this.ExtensionTextBox = new System.Windows.Forms.TextBox();
            this.isCaseSensetiveCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // includesTextBox
            // 
            resources.ApplyResources(this.includesTextBox, "includesTextBox");
            this.includesTextBox.Name = "includesTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // pathTextBox
            // 
            resources.ApplyResources(this.pathTextBox, "pathTextBox");
            this.pathTextBox.Name = "pathTextBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // browseFolders
            // 
            resources.ApplyResources(this.browseFolders, "browseFolders");
            this.browseFolders.Name = "browseFolders";
            this.browseFolders.UseVisualStyleBackColor = true;
            this.browseFolders.Click += new System.EventHandler(this.browseFolders_Click);
            // 
            // AddRuleButton
            // 
            resources.ApplyResources(this.AddRuleButton, "AddRuleButton");
            this.AddRuleButton.Name = "AddRuleButton";
            this.AddRuleButton.UseVisualStyleBackColor = true;
            this.AddRuleButton.Click += new System.EventHandler(this.AddRuleButton_Click);
            // 
            // browseFilesButton
            // 
            resources.ApplyResources(this.browseFilesButton, "browseFilesButton");
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            this.browseFilesButton.Click += new System.EventHandler(this.browseFilesButton_Click);
            // 
            // messageLabel
            // 
            resources.ApplyResources(this.messageLabel, "messageLabel");
            this.messageLabel.Name = "messageLabel";
            // 
            // ExtensionTextBox
            // 
            resources.ApplyResources(this.ExtensionTextBox, "ExtensionTextBox");
            this.ExtensionTextBox.Name = "ExtensionTextBox";
            // 
            // isCaseSensetiveCheckBox
            // 
            resources.ApplyResources(this.isCaseSensetiveCheckBox, "isCaseSensetiveCheckBox");
            this.isCaseSensetiveCheckBox.Checked = true;
            this.isCaseSensetiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isCaseSensetiveCheckBox.Name = "isCaseSensetiveCheckBox";
            this.isCaseSensetiveCheckBox.UseVisualStyleBackColor = true;
            this.isCaseSensetiveCheckBox.CheckedChanged += new System.EventHandler(this.isCaseSensetive_CheckedChanged);
            // 
            // AddRule
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.isCaseSensetiveCheckBox);
            this.Controls.Add(this.ExtensionTextBox);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddRule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox ExtensionTextBox;
        private System.Windows.Forms.CheckBox isCaseSensetiveCheckBox;
    }
}