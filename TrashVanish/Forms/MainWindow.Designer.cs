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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.logMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearLogItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.logMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTask
            // 
            resources.ApplyResources(this.mainTask, "mainTask");
            this.mainTask.Name = "mainTask";
            this.mainTask.UseVisualStyleBackColor = true;
            this.mainTask.Click += new System.EventHandler(this.MainTask_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.logRichTextBox);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // logRichTextBox
            // 
            resources.ApplyResources(this.logRichTextBox, "logRichTextBox");
            this.logRichTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logRichTextBox.ContextMenuStrip = this.logMenuStrip;
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.ReadOnly = true;
            // 
            // logMenuStrip
            // 
            resources.ApplyResources(this.logMenuStrip, "logMenuStrip");
            this.logMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearLogItem});
            this.logMenuStrip.Name = "logMenuStrip";
            // 
            // ClearLogItem
            // 
            resources.ApplyResources(this.ClearLogItem, "ClearLogItem");
            this.ClearLogItem.Name = "ClearLogItem";
            this.ClearLogItem.Click += new System.EventHandler(this.ClearLogItem_Click);
            // 
            // globalSettings
            // 
            resources.ApplyResources(this.globalSettings, "globalSettings");
            this.globalSettings.Name = "globalSettings";
            this.globalSettings.UseVisualStyleBackColor = true;
            this.globalSettings.Click += new System.EventHandler(this.GlobalSettings_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.globalSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainTask);
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.logMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mainTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.Button globalSettings;
        private System.Windows.Forms.ContextMenuStrip logMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClearLogItem;
    }
}

