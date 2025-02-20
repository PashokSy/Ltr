﻿namespace Ltr
{
    partial class EditReadedPages
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.pagesReadedLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.readedPagesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.errorLabel.Location = new System.Drawing.Point(12, 9);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(120, 25);
            this.errorLabel.TabIndex = 19;
            this.errorLabel.Text = "<error msg>";
            this.errorLabel.Visible = false;
            // 
            // pagesReadedLabel
            // 
            this.pagesReadedLabel.AutoSize = true;
            this.pagesReadedLabel.Location = new System.Drawing.Point(12, 53);
            this.pagesReadedLabel.Name = "pagesReadedLabel";
            this.pagesReadedLabel.Size = new System.Drawing.Size(395, 25);
            this.pagesReadedLabel.TabIndex = 17;
            this.pagesReadedLabel.Text = "Введите колличество прочитанных страниц";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(263, 120);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(144, 50);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(17, 120);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(144, 50);
            this.acceptButton.TabIndex = 15;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // readedPagesTextBox
            // 
            this.readedPagesTextBox.Location = new System.Drawing.Point(17, 82);
            this.readedPagesTextBox.Name = "readedPagesTextBox";
            this.readedPagesTextBox.Size = new System.Drawing.Size(387, 33);
            this.readedPagesTextBox.TabIndex = 20;
            this.readedPagesTextBox.Text = " ";
            this.readedPagesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReadedPagesTextBox_KeyPress);
            // 
            // EditReadedPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 187);
            this.Controls.Add(this.readedPagesTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.pagesReadedLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.acceptButton);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "EditReadedPages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактировать колличество страниц";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditReadedPages_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label pagesReadedLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox readedPagesTextBox;
    }
}