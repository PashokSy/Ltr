using BooksLibrary;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ltr
{
    public partial class EditReadedPages : Form
    {
        BooksDictionary library = null;
        ILiterature book = null;

        public EditReadedPages(BooksDictionary LtrBooksLibrary, ILiterature Book)
        {
            InitializeComponent();
            try
            {
                library = LtrBooksLibrary;
                book = Book;
                readedPagesTextBox.Text = book.pagesReaded.ToString();
                readedPagesTextBox.Select();
            }
            catch (Exception exeption)
            {
                errorLabel.Text = exeption.ToString();
            }
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
                    PagesReaded: (readedPagesTextBox.Text.Length == 0) ? 0 : Int32.Parse(readedPagesTextBox.Text),
                    Tag: book.tag,
                    PathToBook: book.pathToBook);
                                
                parentForm.library.RemoteBook((string)parentForm.dataGrid.CurrentRow.Cells[0].Value);
                parentForm.dataGrid.Rows.Remove(parentForm.dataGrid.CurrentRow);
                //Добаляем книгу в таблицу
                parentForm.dataGrid.Rows.Add(newBook.title, newBook.authorLastname, newBook.pagesReaded, newBook.pagesTotal, newBook.progress);
                //Добавляет книгу в библиотеку
                library.StoreBook(newBook);
                //Сохраняет изменения в файл
                library.Save(parentForm.libraryPath);
                                
                int RememberRowIndex = parentForm.dataGrid.CurrentRow.Index;
                parentForm.dataGrid.Sort(parentForm.dataGrid.Columns[0], ListSortDirection.Ascending);
                parentForm.dataGrid.ClearSelection();
                parentForm.dataGrid.Rows[RememberRowIndex].Cells[0].Selected = true;
                parentForm.dataGrid.CurrentCell = parentForm.dataGrid.Rows[RememberRowIndex].Cells[0];
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.ToString();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReadedPagesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
