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
            this.addRule = new System.Windows.Forms.Button();
            this.rulesSettings = new System.Windows.Forms.Button();
            this.mainTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logRTB = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRule
            // 
            this.addRule.Location = new System.Drawing.Point(377, 12);
            this.addRule.Name = "addRule";
            this.addRule.Size = new System.Drawing.Size(114, 23);
            this.addRule.TabIndex = 0;
            this.addRule.Text = "Добавить правило";
            this.addRule.UseVisualStyleBackColor = true;
            this.addRule.Click += new System.EventHandler(this.addRule_Click);
            // 
            // rulesSettings
            // 
            this.rulesSettings.Location = new System.Drawing.Point(377, 42);
            this.rulesSettings.Name = "rulesSettings";
            this.rulesSettings.Size = new System.Drawing.Size(114, 23);
            this.rulesSettings.TabIndex = 1;
            this.rulesSettings.Text = "Настроить правила";
            this.rulesSettings.UseVisualStyleBackColor = true;
            this.rulesSettings.Click += new System.EventHandler(this.rulesSettings_Click);
            // 
            // mainTask
            // 
            this.mainTask.Location = new System.Drawing.Point(377, 177);
            this.mainTask.Name = "mainTask";
            this.mainTask.Size = new System.Drawing.Size(114, 23);
            this.mainTask.TabIndex = 2;
            this.mainTask.Text = "Vanish";
            this.mainTask.UseVisualStyleBackColor = true;
            this.mainTask.Click += new System.EventHandler(this.mainTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logRTB);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лог";
            // 
            // logRTB
            // 
            this.logRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logRTB.Location = new System.Drawing.Point(3, 16);
            this.logRTB.Name = "logRTB";
            this.logRTB.ReadOnly = true;
            this.logRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.logRTB.Size = new System.Drawing.Size(352, 168);
            this.logRTB.TabIndex = 0;
            this.logRTB.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 212);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainTask);
            this.Controls.Add(this.rulesSettings);
            this.Controls.Add(this.addRule);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addRule;
        private System.Windows.Forms.Button rulesSettings;
        private System.Windows.Forms.Button mainTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox logRTB;
    }
}

