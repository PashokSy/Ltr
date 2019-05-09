using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using BooksLibrary;

namespace Ltr
{
    public partial class Ltr : Form
    {
        public Ltr()
        {
            InitializeComponent();
        }

        private void Ltr_Load(object sender, EventArgs e)
        {
            //Создание библиотеки книг и заполнение их из файла в корневой папке
            BooksDictionary booksDictionary = new BooksDictionary();
            booksDictionary = BooksDictionary.Load("library.txt");
            if (booksDictionary == null)
            {
                errorPanel.Visible = true;
                errorButton.BackColor = Color.Maroon;
                errorLabel.Text = "Error: File not found. \nSet path to your library or create new";
            }
            else
            {
                foreach (KeyValuePair<string, ILiterature> book in booksDictionary)
                {
                    this.dataGrid.Rows.Add(book.Key, book.Value.authorLastname, book.Value.pagesReaded, book.Value.pagesTotal);
                }
            }
        }

        private void ErrorButton_Click(object sender, EventArgs e)
        {
            errorPanel.Visible = false;
        }
    }
}
