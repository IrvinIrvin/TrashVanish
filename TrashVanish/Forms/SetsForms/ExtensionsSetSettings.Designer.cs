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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSetButton = new System.Windows.Forms.Button();
            this.editSetButton = new System.Windows.Forms.Button();
            this.deleteSetButton = new System.Windows.Forms.Button();
            this.updateGridButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.extensionsSetGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // extensionsSetGrid
            // 
            this.extensionsSetGrid.AllowUserToAddRows = false;
            this.extensionsSetGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extensionsSetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extensionsSetGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.SetName,
            this.Extensions,
            this.targetPath});
            this.extensionsSetGrid.Location = new System.Drawing.Point(13, 13);
            this.extensionsSetGrid.Name = "extensionsSetGrid";
            this.extensionsSetGrid.RowHeadersVisible = false;
            this.extensionsSetGrid.Size = new System.Drawing.Size(352, 164);
            this.extensionsSetGrid.TabIndex = 0;
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
            // targetPath
            // 
            this.targetPath.HeaderText = "Путь";
            this.targetPath.Name = "targetPath";
            this.targetPath.ReadOnly = true;
            // 
            // addSetButton
            // 
            this.addSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSetButton.Location = new System.Drawing.Point(371, 51);
            this.addSetButton.Name = "addSetButton";
            this.addSetButton.Size = new System.Drawing.Size(128, 23);
            this.addSetButton.TabIndex = 1;
            this.addSetButton.Text = "Добавить набор";
            this.addSetButton.UseVisualStyleBackColor = true;
            this.addSetButton.Click += new System.EventHandler(this.addSetButton_Click);
            // 
            // editSetButton
            // 
            this.editSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSetButton.Location = new System.Drawing.Point(371, 90);
            this.editSetButton.Name = "editSetButton";
            this.editSetButton.Size = new System.Drawing.Size(128, 23);
            this.editSetButton.TabIndex = 2;
            this.editSetButton.Text = "Редактировать";
            this.editSetButton.UseVisualStyleBackColor = true;
            this.editSetButton.Click += new System.EventHandler(this.editSetButton_Click);
            // 
            // deleteSetButton
            // 
            this.deleteSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSetButton.Location = new System.Drawing.Point(371, 129);
            this.deleteSetButton.Name = "deleteSetButton";
            this.deleteSetButton.Size = new System.Drawing.Size(128, 23);
            this.deleteSetButton.TabIndex = 3;
            this.deleteSetButton.Text = "Удалить набор";
            this.deleteSetButton.UseVisualStyleBackColor = true;
            this.deleteSetButton.Click += new System.EventHandler(this.deleteSetButton_Click);
            // 
            // updateGridButton
            // 
            this.updateGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateGridButton.Location = new System.Drawing.Point(371, 13);
            this.updateGridButton.Name = "updateGridButton";
            this.updateGridButton.Size = new System.Drawing.Size(128, 23);
            this.updateGridButton.TabIndex = 4;
            this.updateGridButton.Text = "Обновить";
            this.updateGridButton.UseVisualStyleBackColor = true;
            this.updateGridButton.Click += new System.EventHandler(this.updateGridButton_Click);
            // 
            // ExtensionsSetSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 189);
            this.Controls.Add(this.updateGridButton);
            this.Controls.Add(this.deleteSetButton);
            this.Controls.Add(this.editSetButton);
            this.Controls.Add(this.addSetButton);
            this.Controls.Add(this.extensionsSetGrid);
            this.MinimumSize = new System.Drawing.Size(527, 228);
            this.Name = "ExtensionsSetSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrashVanish - Настройки наборов расширений";
            this.Load += new System.EventHandler(this.ExtensionsSetSettings_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn targetPath;
    }
}