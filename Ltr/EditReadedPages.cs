using BooksLibrary;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ltr
{
    public partial class EditReadedPages : Form
    {
        BooksDictionary booksDictinary = null;
        ILiterature book = null;

        public EditReadedPages(BooksDictionary LtrBooksLibrary, ILiterature book)
        {
            booksDictinary = LtrBooksLibrary;
            this.book = book;
            pagesReadedTexBox.Text = this.book.pagesReaded.ToString();
            InitializeComponent();
        }

        private void PagesReadedTexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                Ltr parentForm = Owner as Ltr;
                ILiterature newBook = new Book(
                    Title: book.title,
                    AuthorLastname: book.authorLastname,
                    PagesTotal: book.pagesTotal,
                    PagesReaded: (pagesReadedTexBox.Text.Length == 0) ? 0 : Int32.Parse(pagesReadedTexBox.Text),
                    Tag: book.tag,
                    PathToBook: book.pathToBook);

                //Добаляем книгу в таблицу
                parentForm.dataGrid.Rows.Add(newBook.title, newBook.authorLastname, newBook.pagesReaded, newBook.pagesTotal, newBook.progress);
                //Добавляет книгу в библиотеку
                booksDictinary.StoreBook(newBook);
                //Сохраняет изменения в файл
                booksDictinary.Save(parentForm.libraryPath);

                parentForm.dataGrid.Sort(parentForm.dataGrid.Columns[0], ListSortDirection.Ascending);
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.ToString();
            }
        }
    }
}
