namespace Ltr
{
    partial class AddBook
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.authorLastnameTextBox = new System.Windows.Forms.TextBox();
            this.authorLastnameLabel = new System.Windows.Forms.Label();
            this.pagesTotalTextBox = new System.Windows.Forms.TextBox();
            this.pagesTotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(149, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Название книги";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(17, 37);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(580, 33);
            this.titleTextBox.TabIndex = 2;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(17, 101);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(580, 33);
            this.authorNameTextBox.TabIndex = 4;
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Location = new System.Drawing.Point(12, 73);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(114, 25);
            this.authorNameLabel.TabIndex = 3;
            this.authorNameLabel.Text = "Имя автора";
            // 
            // authorLastnameTextBox
            // 
            this.authorLastnameTextBox.Location = new System.Drawing.Point(17, 165);
            this.authorLastnameTextBox.Name = "authorLastnameTextBox";
            this.authorLastnameTextBox.Size = new System.Drawing.Size(580, 33);
            this.authorLastnameTextBox.TabIndex = 6;
            // 
            // authorLastnameLabel
            // 
            this.authorLastnameLabel.AutoSize = true;
            this.authorLastnameLabel.Location = new System.Drawing.Point(12, 137);
            this.authorLastnameLabel.Name = "authorLastnameLabel";
            this.authorLastnameLabel.Size = new System.Drawing.Size(156, 25);
            this.authorLastnameLabel.TabIndex = 5;
            this.authorLastnameLabel.Text = "Фамилия автора";
            // 
            // pagesTotalTextBox
            // 
            this.pagesTotalTextBox.Location = new System.Drawing.Point(17, 229);
            this.pagesTotalTextBox.Name = "pagesTotalTextBox";
            this.pagesTotalTextBox.Size = new System.Drawing.Size(580, 33);
            this.pagesTotalTextBox.TabIndex = 8;
            // 
            // pagesTotalLabel
            // 
            this.pagesTotalLabel.AutoSize = true;
            this.pagesTotalLabel.Location = new System.Drawing.Point(12, 201);
            this.pagesTotalLabel.Name = "pagesTotalLabel";
            this.pagesTotalLabel.Size = new System.Drawing.Size(200, 25);
            this.pagesTotalLabel.TabIndex = 7;
            this.pagesTotalLabel.Text = "Колличество страниц";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 561);
            this.Controls.Add(this.pagesTotalTextBox);
            this.Controls.Add(this.pagesTotalLabel);
            this.Controls.Add(this.authorLastnameTextBox);
            this.Controls.Add(this.authorLastnameLabel);
            this.Controls.Add(this.authorNameTextBox);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.TextBox authorLastnameTextBox;
        private System.Windows.Forms.Label authorLastnameLabel;
        private System.Windows.Forms.TextBox pagesTotalTextBox;
        private System.Windows.Forms.Label pagesTotalLabel;
    }
}