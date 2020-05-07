namespace TrashVanish
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.rulesSettings = new System.Windows.Forms.Button();
            this.mainTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logRTB = new System.Windows.Forms.RichTextBox();
            this.deleteFlag = new System.Windows.Forms.CheckBox();
            this.overwriteFiles = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rulesSettings
            // 
            this.rulesSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesSettings.Location = new System.Drawing.Point(548, 27);
            this.rulesSettings.Name = "rulesSettings";
            this.rulesSettings.Size = new System.Drawing.Size(114, 23);
            this.rulesSettings.TabIndex = 1;
            this.rulesSettings.Text = "Настроить правила";
            this.rulesSettings.UseVisualStyleBackColor = true;
            this.rulesSettings.Click += new System.EventHandler(this.rulesSettings_Click);
            // 
            // mainTask
            // 
            this.mainTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTask.Location = new System.Drawing.Point(548, 174);
            this.mainTask.Name = "mainTask";
            this.mainTask.Size = new System.Drawing.Size(114, 23);
            this.mainTask.TabIndex = 2;
            this.mainTask.Text = "Vanish";
            this.mainTask.UseVisualStyleBackColor = true;
            this.mainTask.Click += new System.EventHandler(this.mainTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.logRTB);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лог";
            // 
            // logRTB
            // 
            this.logRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logRTB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logRTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logRTB.Location = new System.Drawing.Point(3, 16);
            this.logRTB.Name = "logRTB";
            this.logRTB.ReadOnly = true;
            this.logRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.logRTB.Size = new System.Drawing.Size(523, 168);
            this.logRTB.TabIndex = 0;
            this.logRTB.Text = "";
            // 
            // deleteFlag
            // 
            this.deleteFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFlag.Checked = true;
            this.deleteFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteFlag.Location = new System.Drawing.Point(548, 113);
            this.deleteFlag.Name = "deleteFlag";
            this.deleteFlag.Size = new System.Drawing.Size(114, 55);
            this.deleteFlag.TabIndex = 4;
            this.deleteFlag.Text = "Удалять после копирования";
            this.deleteFlag.UseVisualStyleBackColor = true;
            this.deleteFlag.CheckedChanged += new System.EventHandler(this.deleteFlag_CheckedChanged);
            // 
            // overwriteFiles
            // 
            this.overwriteFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.overwriteFiles.Checked = true;
            this.overwriteFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteFiles.Location = new System.Drawing.Point(548, 87);
            this.overwriteFiles.Name = "overwriteFiles";
            this.overwriteFiles.Size = new System.Drawing.Size(114, 40);
            this.overwriteFiles.TabIndex = 5;
            this.overwriteFiles.Text = "Перезаписывать файлы";
            this.overwriteFiles.UseVisualStyleBackColor = true;
            this.overwriteFiles.CheckedChanged += new System.EventHandler(this.overwriteFiles_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(548, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Очищать лог";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 209);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.overwriteFiles);
            this.Controls.Add(this.rulesSettings);
            this.Controls.Add(this.deleteFlag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(515, 248);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrashVanisher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rulesSettings;
        private System.Windows.Forms.Button mainTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox logRTB;
        private System.Windows.Forms.CheckBox deleteFlag;
        private System.Windows.Forms.CheckBox overwriteFiles;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

