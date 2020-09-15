namespace TrashVanish.Forms
{
    partial class globalSettingsForm
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
            this.rulesSettings = new System.Windows.Forms.Button();
            this.extensionSetSettingsButton = new System.Windows.Forms.Button();
            this.clearLogCheckbox = new System.Windows.Forms.CheckBox();
            this.overwriteFiles = new System.Windows.Forms.CheckBox();
            this.deleteFlag = new System.Windows.Forms.CheckBox();
            this.checkboxesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // rulesSettings
            // 
            this.rulesSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesSettings.Location = new System.Drawing.Point(46, 32);
            this.rulesSettings.Name = "rulesSettings";
            this.rulesSettings.Size = new System.Drawing.Size(115, 23);
            this.rulesSettings.TabIndex = 2;
            this.rulesSettings.Text = "Настроить правила";
            this.rulesSettings.UseVisualStyleBackColor = true;
            this.rulesSettings.Click += new System.EventHandler(this.rulesSettings_Click);
            // 
            // extensionSetSettingsButton
            // 
            this.extensionSetSettingsButton.Location = new System.Drawing.Point(189, 32);
            this.extensionSetSettingsButton.Name = "extensionSetSettingsButton";
            this.extensionSetSettingsButton.Size = new System.Drawing.Size(115, 23);
            this.extensionSetSettingsButton.TabIndex = 3;
            this.extensionSetSettingsButton.Text = "Настройки наборов";
            this.extensionSetSettingsButton.UseVisualStyleBackColor = true;
            this.extensionSetSettingsButton.Click += new System.EventHandler(this.extensionSetSettingsButton_Click);
            // 
            // clearLogCheckbox
            // 
            this.clearLogCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearLogCheckbox.AutoSize = true;
            this.clearLogCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearLogCheckbox.Location = new System.Drawing.Point(46, 88);
            this.clearLogCheckbox.Name = "clearLogCheckbox";
            this.clearLogCheckbox.Size = new System.Drawing.Size(91, 17);
            this.clearLogCheckbox.TabIndex = 9;
            this.clearLogCheckbox.Text = "Очищать лог";
            this.checkboxesToolTip.SetToolTip(this.clearLogCheckbox, "Очистить лог перед выполнением задания");
            this.clearLogCheckbox.UseVisualStyleBackColor = true;
            this.clearLogCheckbox.CheckedChanged += new System.EventHandler(this.clearLogCheckbox_CheckedChanged);
            // 
            // overwriteFiles
            // 
            this.overwriteFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.overwriteFiles.Checked = true;
            this.overwriteFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteFiles.Location = new System.Drawing.Point(46, 111);
            this.overwriteFiles.Name = "overwriteFiles";
            this.overwriteFiles.Size = new System.Drawing.Size(114, 40);
            this.overwriteFiles.TabIndex = 8;
            this.overwriteFiles.Text = "Перезаписывать файлы";
            this.checkboxesToolTip.SetToolTip(this.overwriteFiles, "Перезаписывать уже существующие файлы в случае конфликта (если не отмечено, файл " +
        "не будет скопирован)");
            this.overwriteFiles.UseVisualStyleBackColor = true;
            this.overwriteFiles.CheckedChanged += new System.EventHandler(this.overwriteFiles_CheckedChanged);
            // 
            // deleteFlag
            // 
            this.deleteFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFlag.Checked = true;
            this.deleteFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteFlag.Location = new System.Drawing.Point(46, 137);
            this.deleteFlag.Name = "deleteFlag";
            this.deleteFlag.Size = new System.Drawing.Size(114, 55);
            this.deleteFlag.TabIndex = 7;
            this.deleteFlag.Text = "Удалять после копирования";
            this.checkboxesToolTip.SetToolTip(this.deleteFlag, "Удалить файл после копирования");
            this.deleteFlag.UseVisualStyleBackColor = true;
            this.deleteFlag.CheckedChanged += new System.EventHandler(this.deleteFlag_CheckedChanged);
            // 
            // globalSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 290);
            this.Controls.Add(this.clearLogCheckbox);
            this.Controls.Add(this.overwriteFiles);
            this.Controls.Add(this.deleteFlag);
            this.Controls.Add(this.extensionSetSettingsButton);
            this.Controls.Add(this.rulesSettings);
            this.Name = "globalSettingsForm";
            this.Text = "TrashVanish - Настройки";
            this.Load += new System.EventHandler(this.globalSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rulesSettings;
        private System.Windows.Forms.Button extensionSetSettingsButton;
        private System.Windows.Forms.CheckBox clearLogCheckbox;
        private System.Windows.Forms.CheckBox overwriteFiles;
        private System.Windows.Forms.CheckBox deleteFlag;
        private System.Windows.Forms.ToolTip checkboxesToolTip;
    }
}