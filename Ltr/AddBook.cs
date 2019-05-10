using BooksLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ltr
{
    public partial class AddBook : Form
    {
        BooksDictionary booksDictinary = null;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="LtrBooksLibrary">Бибилиотека книг с главной формы</param>
        public AddBook(BooksDictionary LtrBooksLibrary)
        {
            this.booksDictinary = LtrBooksLibrary;
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка добавить книгу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, System.EventArgs e)
        {
            Ltr parentForm = Owner as Ltr;
            ILiterature newBook = new Book(
                Title: titleTextBox.Text, 
                AuthorName: authorNameTextBox.Text, 
                AuthorLastname: authorLastnameTextBox.Text, 
                PagesTotal: Int32.Parse(pagesTotalTextBox.Text),
                PagesReaded: Int32.Parse(pagesReadedTexBox.Text));
            
            //Добаляем книгу в таблицу
            parentForm.dataGrid.Rows.Add(newBook.title, newBook.authorLastname, newBook.pagesReaded, newBook.pagesTotal, newBook.progress);
            //Добавляет книгу в библиотеку
            booksDictinary.StoreBook(newBook);
            //Сохраняет изменения в файл
            booksDictinary.Save(parentForm.libraryPath);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
