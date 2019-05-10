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
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pagesReadedTexBox = new System.Windows.Forms.TextBox();
            this.pagesReadedLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 67);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(157, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Название книги*";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(17, 95);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(580, 33);
            this.titleTextBox.TabIndex = 2;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(17, 159);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(580, 33);
            this.authorNameTextBox.TabIndex = 4;
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Location = new System.Drawing.Point(12, 131);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(122, 25);
            this.authorNameLabel.TabIndex = 3;
            this.authorNameLabel.Text = "Имя автора*";
            // 
            // authorLastnameTextBox
            // 
            this.authorLastnameTextBox.Location = new System.Drawing.Point(17, 223);
            this.authorLastnameTextBox.Name = "authorLastnameTextBox";
            this.authorLastnameTextBox.Size = new System.Drawing.Size(580, 33);
            this.authorLastnameTextBox.TabIndex = 6;
            // 
            // authorLastnameLabel
            // 
            this.authorLastnameLabel.AutoSize = true;
            this.authorLastnameLabel.Location = new System.Drawing.Point(12, 195);
            this.authorLastnameLabel.Name = "authorLastnameLabel";
            this.authorLastnameLabel.Size = new System.Drawing.Size(164, 25);
            this.authorLastnameLabel.TabIndex = 5;
            this.authorLastnameLabel.Text = "Фамилия автора*";
            // 
            // pagesTotalTextBox
            // 
            this.pagesTotalTextBox.Location = new System.Drawing.Point(17, 287);
            this.pagesTotalTextBox.Name = "pagesTotalTextBox";
            this.pagesTotalTextBox.Size = new System.Drawing.Size(580, 33);
            this.pagesTotalTextBox.TabIndex = 8;
            // 
            // pagesTotalLabel
            // 
            this.pagesTotalLabel.AutoSize = true;
            this.pagesTotalLabel.Location = new System.Drawing.Point(12, 259);
            this.pagesTotalLabel.Name = "pagesTotalLabel";
            this.pagesTotalLabel.Size = new System.Drawing.Size(208, 25);
            this.pagesTotalLabel.TabIndex = 7;
            this.pagesTotalLabel.Text = "Колличество страниц*";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(17, 499);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 50);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(477, 499);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 50);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pagesReadedTexBox
            // 
            this.pagesReadedTexBox.Location = new System.Drawing.Point(17, 351);
            this.pagesReadedTexBox.Name = "pagesReadedTexBox";
            this.pagesReadedTexBox.Size = new System.Drawing.Size(580, 33);
            this.pagesReadedTexBox.TabIndex = 12;
            // 
            // pagesReadedLabel
            // 
            this.pagesReadedLabel.AutoSize = true;
            this.pagesReadedLabel.Location = new System.Drawing.Point(12, 323);
            this.pagesReadedLabel.Name = "pagesReadedLabel";
            this.pagesReadedLabel.Size = new System.Drawing.Size(197, 25);
            this.pagesReadedLabel.TabIndex = 11;
            this.pagesReadedLabel.Text = "Прочитанно страниц";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(12, 9);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(542, 25);
            this.noteLabel.TabIndex = 13;
            this.noteLabel.Text = "* Поля, помеченные звездочкой, обязательны к заполнению";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 34);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(120, 25);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.Text = "<error msg>";
            this.errorLabel.Visible = false;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 561);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.pagesReadedTexBox);
            this.Controls.Add(this.pagesReadedLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pagesTotalTextBox);
            this.Controls.Add(this.pagesTotalLabel);
            this.Controls.Add(this.authorLastnameTextBox);
            this.Controls.Add(this.authorLastnameLabel);
            this.Controls.Add(this.authorNameTextBox);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox pagesReadedTexBox;
        private System.Windows.Forms.Label pagesReadedLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}