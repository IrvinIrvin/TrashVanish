namespace TrashVanish
{
    partial class ExtensionsSetSettings
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
            this.extensionsSetGrid = new System.Windows.Forms.DataGridView();
            this.addSetButton = new System.Windows.Forms.Button();
            this.editSetButton = new System.Windows.Forms.Button();
            this.deleteSetButton = new System.Windows.Forms.Button();
            this.updateGridButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.extensionsSetGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // extensionsSetGrid
            // 
            this.extensionsSetGrid.AllowUserToAddRows = false;
            this.extensionsSetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extensionsSetGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.SetName,
            this.Extensions});
            this.extensionsSetGrid.Location = new System.Drawing.Point(13, 13);
            this.extensionsSetGrid.Name = "extensionsSetGrid";
            this.extensionsSetGrid.RowHeadersVisible = false;
            this.extensionsSetGrid.Size = new System.Drawing.Size(240, 228);
            this.extensionsSetGrid.TabIndex = 0;
            // 
            // addSetButton
            // 
            this.addSetButton.Location = new System.Drawing.Point(269, 51);
            this.addSetButton.Name = "addSetButton";
            this.addSetButton.Size = new System.Drawing.Size(128, 23);
            this.addSetButton.TabIndex = 1;
            this.addSetButton.Text = "Добавить набор";
            this.addSetButton.UseVisualStyleBackColor = true;
            this.addSetButton.Click += new System.EventHandler(this.addSetButton_Click);
            // 
            // editSetButton
            // 
            this.editSetButton.Location = new System.Drawing.Point(269, 91);
            this.editSetButton.Name = "editSetButton";
            this.editSetButton.Size = new System.Drawing.Size(128, 23);
            this.editSetButton.TabIndex = 2;
            this.editSetButton.Text = "Править набор";
            this.editSetButton.UseVisualStyleBackColor = true;
            this.editSetButton.Click += new System.EventHandler(this.editSetButton_Click);
            // 
            // deleteSetButton
            // 
            this.deleteSetButton.Location = new System.Drawing.Point(269, 129);
            this.deleteSetButton.Name = "deleteSetButton";
            this.deleteSetButton.Size = new System.Drawing.Size(128, 23);
            this.deleteSetButton.TabIndex = 3;
            this.deleteSetButton.Text = "Удалить набор";
            this.deleteSetButton.UseVisualStyleBackColor = true;
            this.deleteSetButton.Click += new System.EventHandler(this.deleteSetButton_Click);
            // 
            // updateGridButton
            // 
            this.updateGridButton.Location = new System.Drawing.Point(269, 13);
            this.updateGridButton.Name = "updateGridButton";
            this.updateGridButton.Size = new System.Drawing.Size(128, 23);
            this.updateGridButton.TabIndex = 4;
            this.updateGridButton.Text = "Обновить";
            this.updateGridButton.UseVisualStyleBackColor = true;
            this.updateGridButton.Click += new System.EventHandler(this.updateGridButton_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // SetName
            // 
            this.SetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SetName.HeaderText = "Имя набора";
            this.SetName.Name = "SetName";
            this.SetName.ReadOnly = true;
            this.SetName.Width = 93;
            // 
            // Extensions
            // 
            this.Extensions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Extensions.HeaderText = "Расширения";
            this.Extensions.Name = "Extensions";
            this.Extensions.ReadOnly = true;
            // 
            // ExtensionsSetSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 253);
            this.Controls.Add(this.updateGridButton);
            this.Controls.Add(this.deleteSetButton);
            this.Controls.Add(this.editSetButton);
            this.Controls.Add(this.addSetButton);
            this.Controls.Add(this.extensionsSetGrid);
            this.Name = "ExtensionsSetSettings";
            this.Text = "TrashVanish - Настройки наборов расширений";
            ((System.ComponentModel.ISupportInitialize)(this.extensionsSetGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView extensionsSetGrid;
        private System.Windows.Forms.Button addSetButton;
        private System.Windows.Forms.Button editSetButton;
        private System.Windows.Forms.Button deleteSetButton;
        private System.Windows.Forms.Button updateGridButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensions;
    }
}