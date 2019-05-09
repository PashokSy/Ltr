namespace Ltr
{
    partial class Ltr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ltr));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.RichTextBox();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesReaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tablePanel.SuspendLayout();
            this.errorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.author,
            this.pagesReaded,
            this.pagesTotal,
            this.progression});
            this.dataGrid.Enabled = false;
            this.dataGrid.Location = new System.Drawing.Point(3, 61);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(848, 465);
            this.dataGrid.TabIndex = 0;
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablePanel.Controls.Add(this.changeButton);
            this.tablePanel.Controls.Add(this.errorPanel);
            this.tablePanel.Controls.Add(this.deleteButton);
            this.tablePanel.Controls.Add(this.dataGrid);
            this.tablePanel.Controls.Add(this.addButton);
            this.tablePanel.Location = new System.Drawing.Point(13, 14);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(858, 533);
            this.tablePanel.TabIndex = 2;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.BackColor = System.Drawing.Color.White;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(54, 3);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.ReadOnly = true;
            this.errorLabel.Size = new System.Drawing.Size(440, 45);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "<error code>";
            // 
            // errorPanel
            // 
            this.errorPanel.BackColor = System.Drawing.Color.Transparent;
            this.errorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorPanel.Controls.Add(this.errorButton);
            this.errorPanel.Controls.Add(this.errorLabel);
            this.errorPanel.Location = new System.Drawing.Point(352, 3);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(500, 55);
            this.errorPanel.TabIndex = 6;
            this.errorPanel.Visible = false;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Transparent;
            this.changeButton.BackgroundImage = global::Ltr.Properties.Resources.change_ico;
            this.changeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Location = new System.Drawing.Point(125, 3);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(55, 55);
            this.changeButton.TabIndex = 7;
            this.changeButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BackgroundImage = global::Ltr.Properties.Resources.delete_ico;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(64, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(55, 55);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackgroundImage = global::Ltr.Properties.Resources.add_ico;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(55, 55);
            this.addButton.TabIndex = 3;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название книги";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 400;
            // 
            // author
            // 
            this.author.HeaderText = "Автор";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // pagesReaded
            // 
            this.pagesReaded.HeaderText = "Прочитано страниц";
            this.pagesReaded.Name = "pagesReaded";
            this.pagesReaded.ReadOnly = true;
            this.pagesReaded.Width = 25;
            // 
            // pagesTotal
            // 
            this.pagesTotal.HeaderText = "Страниц";
            this.pagesTotal.Name = "pagesTotal";
            this.pagesTotal.ReadOnly = true;
            this.pagesTotal.Width = 25;
            // 
            // progression
            // 
            this.progression.HeaderText = "Прогресс";
            this.progression.Name = "progression";
            this.progression.ReadOnly = true;
            this.progression.Width = 25;
            // 
            // errorButton
            // 
            this.errorButton.BackColor = System.Drawing.Color.Transparent;
            this.errorButton.BackgroundImage = global::Ltr.Properties.Resources.error_ico;
            this.errorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.errorButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.errorButton.FlatAppearance.BorderSize = 0;
            this.errorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.errorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.errorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorButton.Location = new System.Drawing.Point(3, 3);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(45, 45);
            this.errorButton.TabIndex = 8;
            this.errorButton.UseVisualStyleBackColor = false;
            this.errorButton.Click += new System.EventHandler(this.ErrorButton_Click);
            // 
            // Ltr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tablePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ltr";
            this.Text = "Литература";
            this.Load += new System.EventHandler(this.Ltr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.errorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox errorLabel;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesReaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn progression;
        private System.Windows.Forms.Button errorButton;
    }
}

