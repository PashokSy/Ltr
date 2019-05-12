using BooksLibrary;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Ltr
{
    public partial class AddEditBook : Form
    {
        BooksDictionary library = null;
        ILiterature book = null;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="LtrBooksLibrary">Бибилиотека книг с главной формы</param>
        /// <param name="isAdd">Параметр отвечающий за режи работы</param>
        public AddEditBook(BooksDictionary LtrBooksLibrary)
        {
            InitializeComponent();
            try
            {
                library = LtrBooksLibrary;
                addEditButton.Text = "Добавить";
                this.Text = "Добавить книгу";
            }
            catch (Exception exeption)
            {
                errorLabel.Text = exeption.ToString();
            }
        }

        /// <summary>
        /// Конструктор если нужно внести изменения в книгу
        /// </summary>
        /// <param name="LtrBooksLibrary"></param>
        /// <param name="book"></param>
        public AddEditBook(BooksDictionary LtrBooksLibrary, ILiterature book)
        {
            InitializeComponent();
            try
            {
                library = LtrBooksLibrary;
                this.book = book;
                addEditButton.Text = "Редактировать";
                this.Text = "Редактировать книгу";

                titleTextBox.Text = this.book.title;
                authorLastnameTextBox.Text = this.book.authorLastname;
                pagesTotalTextBox.Text = this.book.pagesTotal.ToString();
                pagesReadedTexBox.Text = this.book.pagesReaded.ToString();
                tagTextBox.Text = this.book.tag;
                pathTextBox.Text = this.book.pathToBook;
            }
            catch (Exception exeption)
            {
                errorLabel.Text = exeption.ToString();
            }
        }

        /// <summary>
        /// Кнопка добавить книгу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEditButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (obligatoryField())
                {
                    Ltr parentForm = Owner as Ltr;
                    ILiterature newBook = new Book(
                        Title: titleTextBox.Text,
                        AuthorLastname: authorLastnameTextBox.Text,
                        PagesTotal: Int32.Parse(pagesTotalTextBox.Text),
                        PagesReaded: (pagesReadedTexBox.Text.Length == 0) ? 0 : Int32.Parse(pagesReadedTexBox.Text),
                        Tag: tagTextBox.Text,
                        PathToBook: pathTextBox.Text);

                    if (addEditButton.Text == "Редактировать")
                    {                        
                        parentForm.library.RemoteBook((string)parentForm.dataGrid.CurrentRow.Cells[0].Value);
                        parentForm.dataGrid.Rows.Remove(parentForm.dataGrid.CurrentRow);                        
                    }
                    //Добаляем книгу в таблицу
                    parentForm.dataGrid.Rows.Add(newBook.title, newBook.authorLastname, newBook.pagesReaded, newBook.pagesTotal, newBook.progress);
                    //Добавляет книгу в библиотеку
                    library.StoreBook(newBook);
                    //Сохраняет изменения в файл
                    library.Save(parentForm.libraryPath);

                    //Исправлен баг с перепрыгиванием на другой ряд при редактировании книги. boiboiyeaboi
                    int RememberRowIndex = parentForm.dataGrid.CurrentRow.Index;
                    parentForm.dataGrid.Sort(parentForm.dataGrid.Columns[0], ListSortDirection.Ascending);
                    parentForm.dataGrid.ClearSelection();
                    parentForm.dataGrid.Rows[RememberRowIndex].Cells[0].Selected = true;
                    parentForm.dataGrid.CurrentCell = parentForm.dataGrid.Rows[RememberRowIndex].Cells[0];

                    if (addEditButton.Text == "Добавить")
                    {
                        //Чисто-чисто чистим боксы
                        titleTextBox.Clear();
                        authorLastnameTextBox.Clear();
                        pagesTotalTextBox.Clear();
                        pagesReadedTexBox.Clear();
                        tagTextBox.Clear();
                        pathTextBox.Clear();
                    }
                }
                else
                {
                    errorLabel.ForeColor = Color.Maroon;
                    errorLabel.Visible = true;
                    errorLabel.Text = "ВНИМАНИЕ! Одно из полей не заполнено!";
                }
            }
            catch (Exception exeption)
            {
                errorLabel.Text = exeption.ToString();
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Разрешает вводить только числа
        /// </summary>
        /// <param name="e"></param>
        private void OnlyDigitInput(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Валидация введеного в поле "Общее кол-во страниц"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PagesTotalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigitInput(e);
        }

        /// <summary>
        /// Валидация введеного в поле "Прочитанное кол-во страниц"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PagesReadedTexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigitInput(e);
        }

        private bool obligatoryField()
        {
            if (titleTextBox.Text.Length == 0 ||
                    authorLastnameTextBox.Text.Length == 0 ||
                    pagesTotalTextBox.Text.Length == 0)
                return false;

            if (titleTextBox.Text.Length == 0 ||
                    authorLastnameTextBox.Text.Length == 0 ||
                    pagesTotalTextBox.Text.Length == 0 ||
                    pagesReadedTexBox.Text.Length == 0 ||
                    tagTextBox.Text.Length == 0 ||
                    pathTextBox.Text.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Внимание! Одно из полей не заполнено. " +
                    "\nПоле автоматически будет заполнено значение по умолчанию. " +
                    "\nВсё равно продолжить?", "Удаление", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                    return true;
                else
                    return false;

            }

            return true;
        }
    }
}
