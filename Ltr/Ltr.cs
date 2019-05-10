using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using BooksLibrary;

namespace Ltr
{
    public partial class Ltr : Form
    {
        //Создание библиотеки книг и заполнение их из файла в корневой папке
        BooksDictionary booksDictionary = new BooksDictionary();

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
            booksDictionary = BooksDictionary.Load(libraryPath);
            if (booksDictionary != null)
            {
                dataGrid.Rows.Clear(); //очистка старой сетки перед добавлением новой
                foreach (KeyValuePair<string, ILiterature> book in booksDictionary)
                {
                    dataGrid.Rows.Add(book.Key, book.Value.authorLastname,
                                            book.Value.pagesReaded, book.Value.pagesTotal, book.Value.progress);
                }
            }
            else
            {
                ErrorMessage(true, "File not found/Corrupted. \nSet path to your library or create new");
            }
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
            if(Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                OpenAddForm();
            }

            //Удаление книги
            if (e.KeyCode == Keys.Delete)
            {
                DeleteBook();
            }
        }

        /// <summary>
        /// Открывает форму добавления книги
        /// </summary>
        private void OpenAddForm()
        {
            AddBook addBook = new AddBook(booksDictionary);
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

        private void DeleteBook()
        {
            DialogResult dialogResult = MessageBox.Show("Уверены что хотите удалить книгу?", "Удаление книги", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {                
                foreach (DataGridViewTextBoxCell book in this.dataGrid.SelectedCells)
                {
                    booksDictionary.RemoteBook((string)dataGrid.CurrentRow.Cells[0].Value);
                    dataGrid.Rows.RemoveAt(book.RowIndex);
                }
                booksDictionary.Save(libraryPath);
            }
        }
    }
}
