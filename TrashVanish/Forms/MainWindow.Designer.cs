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
            this.mainTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.globalSettings = new System.Windows.Forms.Button();
            this.logMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearLogItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.logMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTask
            // 
            this.mainTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTask.Location = new System.Drawing.Point(531, 160);
            this.mainTask.Name = "mainTask";
            this.mainTask.Size = new System.Drawing.Size(114, 37);
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
            this.groupBox1.Controls.Add(this.logRichTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лог";
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logRichTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logRichTextBox.ContextMenuStrip = this.logMenuStrip;
            this.logRichTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.ReadOnly = true;
            this.logRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.logRichTextBox.Size = new System.Drawing.Size(506, 168);
            this.logRichTextBox.TabIndex = 0;
            this.logRichTextBox.Text = "";
            // 
            // globalSettings
            // 
            this.globalSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.globalSettings.Location = new System.Drawing.Point(531, 28);
            this.globalSettings.Name = "globalSettings";
            this.globalSettings.Size = new System.Drawing.Size(114, 23);
            this.globalSettings.TabIndex = 7;
            this.globalSettings.Text = "Настройки";
            this.globalSettings.UseVisualStyleBackColor = true;
            this.globalSettings.Click += new System.EventHandler(this.globalSettings_Click);
            // 
            // logMenuStrip
            // 
            this.logMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearLogItem});
            this.logMenuStrip.Name = "logMenuStrip";
            this.logMenuStrip.Size = new System.Drawing.Size(149, 26);
            // 
            // ClearLogItem
            // 
            this.ClearLogItem.Name = "ClearLogItem";
            this.ClearLogItem.Size = new System.Drawing.Size(180, 22);
            this.ClearLogItem.Text = "Очистить лог";
            this.ClearLogItem.Click += new System.EventHandler(this.ClearLogItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 209);
            this.Controls.Add(this.globalSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainTask);
            this.MinimumSize = new System.Drawing.Size(515, 248);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrashVanisher";
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

