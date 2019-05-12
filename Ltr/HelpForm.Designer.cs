namespace Ltr
{
    partial class HelpForm
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
            this.addButtonImg = new System.Windows.Forms.PictureBox();
            this.addButtonDescription = new System.Windows.Forms.Label();
            this.addButtonPanel = new System.Windows.Forms.Panel();
            this.addHotKeyLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.buttonsPage = new System.Windows.Forms.TabPage();
            this.editReadedPagesButtonPanel = new System.Windows.Forms.Panel();
            this.editReadedPagesHotKeyLabel = new System.Windows.Forms.Label();
            this.editReadedPagesButtonImg = new System.Windows.Forms.PictureBox();
            this.editReadedPagesButtonDescription = new System.Windows.Forms.Label();
            this.editButtonPanel = new System.Windows.Forms.Panel();
            this.editHotKeyLabel = new System.Windows.Forms.Label();
            this.editButtonImg = new System.Windows.Forms.PictureBox();
            this.editButtonDescription = new System.Windows.Forms.Label();
            this.deleteButtonPanel = new System.Windows.Forms.Panel();
            this.deleteHotKeyLabel = new System.Windows.Forms.Label();
            this.deleteButtonImg = new System.Windows.Forms.PictureBox();
            this.deleteButtonDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addButtonImg)).BeginInit();
            this.addButtonPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.buttonsPage.SuspendLayout();
            this.editReadedPagesButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editReadedPagesButtonImg)).BeginInit();
            this.editButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButtonImg)).BeginInit();
            this.deleteButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButtonImg)).BeginInit();
            this.SuspendLayout();
            // 
            // addButtonImg
            // 
            this.addButtonImg.Image = global::Ltr.Properties.Resources.add_ico;
            this.addButtonImg.Location = new System.Drawing.Point(3, 3);
            this.addButtonImg.Name = "addButtonImg";
            this.addButtonImg.Size = new System.Drawing.Size(50, 50);
            this.addButtonImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addButtonImg.TabIndex = 1;
            this.addButtonImg.TabStop = false;
            // 
            // addButtonDescription
            // 
            this.addButtonDescription.AutoSize = true;
            this.addButtonDescription.Location = new System.Drawing.Point(59, 13);
            this.addButtonDescription.Name = "addButtonDescription";
            this.addButtonDescription.Size = new System.Drawing.Size(401, 30);
            this.addButtonDescription.TabIndex = 2;
            this.addButtonDescription.Text = "\"Добавить новую книгу в библиотеку\"";
            // 
            // addButtonPanel
            // 
            this.addButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addButtonPanel.Controls.Add(this.addHotKeyLabel);
            this.addButtonPanel.Controls.Add(this.addButtonImg);
            this.addButtonPanel.Controls.Add(this.addButtonDescription);
            this.addButtonPanel.Location = new System.Drawing.Point(6, 6);
            this.addButtonPanel.Name = "addButtonPanel";
            this.addButtonPanel.Size = new System.Drawing.Size(579, 60);
            this.addButtonPanel.TabIndex = 4;
            // 
            // addHotKeyLabel
            // 
            this.addHotKeyLabel.AutoSize = true;
            this.addHotKeyLabel.Location = new System.Drawing.Point(496, 13);
            this.addHotKeyLabel.Name = "addHotKeyLabel";
            this.addHotKeyLabel.Size = new System.Drawing.Size(78, 30);
            this.addHotKeyLabel.TabIndex = 2;
            this.addHotKeyLabel.Text = "Ctrl+N";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.buttonsPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(597, 295);
            this.tabControl.TabIndex = 4;
            // 
            // buttonsPage
            // 
            this.buttonsPage.Controls.Add(this.editReadedPagesButtonPanel);
            this.buttonsPage.Controls.Add(this.editButtonPanel);
            this.buttonsPage.Controls.Add(this.deleteButtonPanel);
            this.buttonsPage.Controls.Add(this.addButtonPanel);
            this.buttonsPage.Location = new System.Drawing.Point(4, 39);
            this.buttonsPage.Name = "buttonsPage";
            this.buttonsPage.Padding = new System.Windows.Forms.Padding(3);
            this.buttonsPage.Size = new System.Drawing.Size(589, 252);
            this.buttonsPage.TabIndex = 0;
            this.buttonsPage.Text = "Кнопки управления";
            this.buttonsPage.UseVisualStyleBackColor = true;
            // 
            // editReadedPagesButtonPanel
            // 
            this.editReadedPagesButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editReadedPagesButtonPanel.Controls.Add(this.editReadedPagesHotKeyLabel);
            this.editReadedPagesButtonPanel.Controls.Add(this.editReadedPagesButtonImg);
            this.editReadedPagesButtonPanel.Controls.Add(this.editReadedPagesButtonDescription);
            this.editReadedPagesButtonPanel.Location = new System.Drawing.Point(6, 186);
            this.editReadedPagesButtonPanel.Name = "editReadedPagesButtonPanel";
            this.editReadedPagesButtonPanel.Size = new System.Drawing.Size(579, 60);
            this.editReadedPagesButtonPanel.TabIndex = 7;
            // 
            // editReadedPagesHotKeyLabel
            // 
            this.editReadedPagesHotKeyLabel.AutoSize = true;
            this.editReadedPagesHotKeyLabel.Location = new System.Drawing.Point(496, 13);
            this.editReadedPagesHotKeyLabel.Name = "editReadedPagesHotKeyLabel";
            this.editReadedPagesHotKeyLabel.Size = new System.Drawing.Size(75, 30);
            this.editReadedPagesHotKeyLabel.TabIndex = 9;
            this.editReadedPagesHotKeyLabel.Text = "Ctrl+R";
            // 
            // editReadedPagesButtonImg
            // 
            this.editReadedPagesButtonImg.Image = global::Ltr.Properties.Resources.bookmark_ico;
            this.editReadedPagesButtonImg.Location = new System.Drawing.Point(3, 3);
            this.editReadedPagesButtonImg.Name = "editReadedPagesButtonImg";
            this.editReadedPagesButtonImg.Size = new System.Drawing.Size(50, 50);
            this.editReadedPagesButtonImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editReadedPagesButtonImg.TabIndex = 1;
            this.editReadedPagesButtonImg.TabStop = false;
            // 
            // editReadedPagesButtonDescription
            // 
            this.editReadedPagesButtonDescription.AutoSize = true;
            this.editReadedPagesButtonDescription.Location = new System.Drawing.Point(59, 13);
            this.editReadedPagesButtonDescription.Name = "editReadedPagesButtonDescription";
            this.editReadedPagesButtonDescription.Size = new System.Drawing.Size(388, 30);
            this.editReadedPagesButtonDescription.TabIndex = 2;
            this.editReadedPagesButtonDescription.Text = "\"Колличество прочитанных страниц\"";
            // 
            // editButtonPanel
            // 
            this.editButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editButtonPanel.Controls.Add(this.editHotKeyLabel);
            this.editButtonPanel.Controls.Add(this.editButtonImg);
            this.editButtonPanel.Controls.Add(this.editButtonDescription);
            this.editButtonPanel.Location = new System.Drawing.Point(6, 126);
            this.editButtonPanel.Name = "editButtonPanel";
            this.editButtonPanel.Size = new System.Drawing.Size(579, 60);
            this.editButtonPanel.TabIndex = 6;
            // 
            // editHotKeyLabel
            // 
            this.editHotKeyLabel.AutoSize = true;
            this.editHotKeyLabel.Location = new System.Drawing.Point(496, 13);
            this.editHotKeyLabel.Name = "editHotKeyLabel";
            this.editHotKeyLabel.Size = new System.Drawing.Size(73, 30);
            this.editHotKeyLabel.TabIndex = 8;
            this.editHotKeyLabel.Text = "Ctrl+E";
            // 
            // editButtonImg
            // 
            this.editButtonImg.Image = global::Ltr.Properties.Resources.change_ico;
            this.editButtonImg.Location = new System.Drawing.Point(3, 3);
            this.editButtonImg.Name = "editButtonImg";
            this.editButtonImg.Size = new System.Drawing.Size(50, 50);
            this.editButtonImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.editButtonImg.TabIndex = 1;
            this.editButtonImg.TabStop = false;
            // 
            // editButtonDescription
            // 
            this.editButtonDescription.AutoSize = true;
            this.editButtonDescription.Location = new System.Drawing.Point(59, 13);
            this.editButtonDescription.Name = "editButtonDescription";
            this.editButtonDescription.Size = new System.Drawing.Size(379, 30);
            this.editButtonDescription.TabIndex = 2;
            this.editButtonDescription.Text = "\"Редактировать книгу в библиотеке\"";
            // 
            // deleteButtonPanel
            // 
            this.deleteButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteButtonPanel.Controls.Add(this.deleteHotKeyLabel);
            this.deleteButtonPanel.Controls.Add(this.deleteButtonImg);
            this.deleteButtonPanel.Controls.Add(this.deleteButtonDescription);
            this.deleteButtonPanel.Location = new System.Drawing.Point(6, 66);
            this.deleteButtonPanel.Name = "deleteButtonPanel";
            this.deleteButtonPanel.Size = new System.Drawing.Size(579, 60);
            this.deleteButtonPanel.TabIndex = 5;
            // 
            // deleteHotKeyLabel
            // 
            this.deleteHotKeyLabel.AutoSize = true;
            this.deleteHotKeyLabel.Location = new System.Drawing.Point(530, 13);
            this.deleteHotKeyLabel.Name = "deleteHotKeyLabel";
            this.deleteHotKeyLabel.Size = new System.Drawing.Size(44, 30);
            this.deleteHotKeyLabel.TabIndex = 8;
            this.deleteHotKeyLabel.Text = "Del";
            // 
            // deleteButtonImg
            // 
            this.deleteButtonImg.Image = global::Ltr.Properties.Resources.delete_ico;
            this.deleteButtonImg.Location = new System.Drawing.Point(3, 3);
            this.deleteButtonImg.Name = "deleteButtonImg";
            this.deleteButtonImg.Size = new System.Drawing.Size(50, 50);
            this.deleteButtonImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.deleteButtonImg.TabIndex = 1;
            this.deleteButtonImg.TabStop = false;
            // 
            // deleteButtonDescription
            // 
            this.deleteButtonDescription.AutoSize = true;
            this.deleteButtonDescription.Location = new System.Drawing.Point(59, 13);
            this.deleteButtonDescription.Name = "deleteButtonDescription";
            this.deleteButtonDescription.Size = new System.Drawing.Size(324, 30);
            this.deleteButtonDescription.TabIndex = 2;
            this.deleteButtonDescription.Text = "\"Удалить книгу из библиотеки\"";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 316);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)(this.addButtonImg)).EndInit();
            this.addButtonPanel.ResumeLayout(false);
            this.addButtonPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.buttonsPage.ResumeLayout(false);
            this.editReadedPagesButtonPanel.ResumeLayout(false);
            this.editReadedPagesButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editReadedPagesButtonImg)).EndInit();
            this.editButtonPanel.ResumeLayout(false);
            this.editButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButtonImg)).EndInit();
            this.deleteButtonPanel.ResumeLayout(false);
            this.deleteButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButtonImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox addButtonImg;
        private System.Windows.Forms.Label addButtonDescription;
        private System.Windows.Forms.Panel addButtonPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage buttonsPage;
        private System.Windows.Forms.Panel deleteButtonPanel;
        private System.Windows.Forms.PictureBox deleteButtonImg;
        private System.Windows.Forms.Label deleteButtonDescription;
        private System.Windows.Forms.Panel editButtonPanel;
        private System.Windows.Forms.PictureBox editButtonImg;
        private System.Windows.Forms.Label editButtonDescription;
        private System.Windows.Forms.Panel editReadedPagesButtonPanel;
        private System.Windows.Forms.PictureBox editReadedPagesButtonImg;
        private System.Windows.Forms.Label editReadedPagesButtonDescription;
        private System.Windows.Forms.Label addHotKeyLabel;
        private System.Windows.Forms.Label editHotKeyLabel;
        private System.Windows.Forms.Label deleteHotKeyLabel;
        private System.Windows.Forms.Label editReadedPagesHotKeyLabel;
    }
}