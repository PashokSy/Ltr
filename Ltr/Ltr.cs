using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using BooksLibrary;

namespace Ltr
{
    public partial class Ltr : Form
    {
        //Создание библиотеки книг и заполнение их из файла в корневой папке
        public BooksDictionary library = new BooksDictionary();

        //пока что он общий. (добавить функционал выбора)
        public string libraryPath = "library.txt";

        public Ltr()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка Формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ltr_Load(object sender, EventArgs e)
        {
            library = BooksDictionary.Load(libraryPath);
            if (library != null)
            {
                dataGrid.Rows.Clear(); //очистка старой сетки перед добавлением новой                
                foreach (KeyValuePair<string, ILiterature> book in library)
                {
                    dataGrid.Rows.Add(book.Key, book.Value.authorLastname,
                                            book.Value.pagesReaded, book.Value.pagesTotal, book.Value.progress);
                }
            }
            else
            {
                ErrorMessage(true, "File not found/Corrupted. \nSet path to your library or create new");
            }
            dataGrid.Sort(dataGrid.Columns[0], ListSortDirection.Ascending);
        }

        /// <summary>
        /// Кнопка добавить книгу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenAddForm();
        }

        /// <summary>
        /// Метод выводящий ошибки в соответсвующее им поле
        /// </summary>
        /// <param name="visible">Параметр видимости ошибки</param>
        /// <param name="errorText">Сообщение ошибки</param>
        private void ErrorMessage(bool visible, string errorText = "<some error>")
        {
            if (visible)
            {
                errorPanel.Visible = true;
                errorButton.BackColor = Color.Maroon;
                errorLabel.Text = "Error: " + errorText;
            }
            else
            {
                errorPanel.Visible = false;
            }
        }

        /// <summary>
        /// Закрытие сообщения об ошибке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ErrorButton_Click(object sender, EventArgs e)
        {
            ErrorMessage(false);
        }

        /// <summary>
        /// Хоткеи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ltr_KeyDown(object sender, KeyEventArgs e)
        {
            //Создание новой книги Ctrl+N
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                OpenAddForm();
            }

            //Удаление книги
            if (e.KeyCode == Keys.Delete)
            {
                DeleteBook();
            }

            //Редактирование книги
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.E)
            {
                EditBook();
            }

            //Редактирование прочитанных страниц
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.R)
            {
                SetReaded();
            }
        }

        /// <summary>
        /// Редактирование прочитанных страниц
        /// </summary>
        public void SetReaded()
        {
            OpenEditReadedPagesForm();
        }

        /// <summary>
        /// Открывает форму редактирования страниц
        /// </summary>
        private void OpenEditReadedPagesForm()
        {
            ILiterature book = library.FindBook((string)dataGrid.CurrentRow.Cells[0].Value);
            EditReadedPages setReadedPages = new EditReadedPages(library, book);
            setReadedPages.Owner = this;
            setReadedPages.ShowDialog();
        }

        /// <summary>
        /// Открывает форму добавления книги
        /// </summary>
        private void OpenAddForm()
        {
            AddEditBook addBook = new AddEditBook(library);
            addBook.Owner = this;
            addBook.ShowDialog();
        }

        /// <summary>
        /// Открывает форму редактирования формы
        /// </summary>
        private void OpenEditForm()
        {
            ILiterature book = library.FindBook((string)dataGrid.CurrentRow.Cells[0].Value);
            AddEditBook addBook = new AddEditBook(library, book);
            addBook.Owner = this;
            addBook.ShowDialog();
        }

        /// <summary>
        /// Кнопка удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        /// <summary>
        /// Кнопка редактировать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditBook();
        }

        /// <summary>
        /// Метод удаляющйи книгу
        /// </summary>
        /// Вери криптик
        private void DeleteBook()
        {
            DialogResult dialogResult = new DialogResult();
            if (dataGrid.SelectedRows.Count > 1)
                dialogResult = MessageBox.Show("Внимание! Выбрано несколько книг. \nУверены что хотите удалить все выбранные книги?", "Удаление", MessageBoxButtons.OKCancel);
            else if (dataGrid.SelectedRows.Count == 1)
                dialogResult = MessageBox.Show("Уверены что хотите удалить книгу?", "Удаление", MessageBoxButtons.OKCancel);
            else
                dialogResult = MessageBox.Show("Не выбрано ни одного ряда", "Удаление", MessageBoxButtons.RetryCancel);

            if (dialogResult == DialogResult.OK)
            {
                foreach (DataGridViewRow book in this.dataGrid.SelectedRows)
                {
                    library.RemoteBook((string)dataGrid.CurrentRow.Cells[0].Value);
                    dataGrid.Rows.Remove(dataGrid.CurrentRow);
                }
                library.Save(libraryPath);
            }
        }

        /// <summary>
        /// Метод редактирующий выбранную книгу
        /// </summary>
        private void EditBook()
        {
            DialogResult dialogResult = new DialogResult();
            if (dataGrid.SelectedRows.Count > 1)
                dialogResult = MessageBox.Show("Редактирование нескольки книг сразу невозможно", "Редактирование", MessageBoxButtons.OKCancel);
            else if (dataGrid.SelectedRows.Count == 1)
                dialogResult = MessageBox.Show("Редактировать книгу?", "Редактирование", MessageBoxButtons.OKCancel);
            else
                dialogResult = MessageBox.Show("Не выбрано ни одного ряда", "Редактирование", MessageBoxButtons.RetryCancel);

            if (dialogResult == DialogResult.OK)
            {
                OpenEditForm();
            }
        }





        /*
        /// <summary>
        /// Нумерация рядов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGrid.TopLeftHeaderCell.Value = "N п/п";
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = dataGrid.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                dataGrid.Rows[index].HeaderCell.Value = indexStr;
        }*/
    }
}
