namespace TrashVanish.Forms.SetsForms
{
    partial class AddExtensionSet
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
            this.setNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addExtensionToSetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setNameTextBox
            // 
            this.setNameTextBox.Location = new System.Drawing.Point(12, 29);
            this.setNameTextBox.Name = "setNameTextBox";
            this.setNameTextBox.Size = new System.Drawing.Size(285, 20);
            this.setNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название набора";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 69);
            this.listBox1.TabIndex = 2;
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.Location = new System.Drawing.Point(12, 73);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(136, 20);
            this.extensionTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Расширение";
            // 
            // addExtensionToSetButton
            // 
            this.addExtensionToSetButton.Location = new System.Drawing.Point(161, 72);
            this.addExtensionToSetButton.Name = "addExtensionToSetButton";
            this.addExtensionToSetButton.Size = new System.Drawing.Size(136, 23);
            this.addExtensionToSetButton.TabIndex = 5;
            this.addExtensionToSetButton.Text = "Добавить";
            this.addExtensionToSetButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расширения в наборе";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить набор";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(-5, 206);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(318, 23);
            this.messageLabel.TabIndex = 13;
            this.messageLabel.Text = "Message";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLabel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddExtensionSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 267);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addExtensionToSetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.extensionTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setNameTextBox);
            this.Name = "AddExtensionSet";
            this.Text = "TrashVanish - Добавить набор расширений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox setNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addExtensionToSetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button button2;
    }
}