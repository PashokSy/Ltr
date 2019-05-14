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
        public BooksDictionary library = new BooksDictionary();
        public string libraryPath = "library.txt";

        public Ltr()
        {
            InitializeComponent();
            statusComboBox.Text = "Сейчас читаю";
        }



        /// <summary>
        /// Считывание нужной литератру
        /// </summary>
        public void LoadDataToGrid(string status, string searchBoxText)
        {
            try
            {
                library = BooksDictionary.Load(libraryPath);
                dataGrid.Rows.Clear();
                
                foreach (KeyValuePair<string, ILiterature> book in library)
                {
                    if (statusComboBox.Text == "Показать все книги")
                    {
                        LoadDataLogic(book);
                    }
                    if (book.Value.status == statusComboBox.Text)
                    {
                        LoadDataLogic(book);
                    }
                }

                dataGrid.Sort(dataGrid.Columns[0], ListSortDirection.Ascending);
            }
            catch (Exception exception)
            {
                ErrorMessage(true, exception.ToString());
            }
        }

        /// <summary>
        /// Логика заполненния таблицы
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        private void LoadDataLogic(KeyValuePair<string, ILiterature> book)
        {
            if (book.Key.ToLower().Contains(searchBox.Text.ToLower())
                                || book.Value.authorLastname.ToLower().Contains(searchBox.Text.ToLower())
                                || book.Value.commentary.ToLower().Contains(searchBox.Text.ToLower()))
            {
                dataGrid.Rows.Add(book.Key, 
                                  book.Value.authorLastname,
                                  book.Value.pagesReaded, 
                                  book.Value.pagesTotal, 
                                  book.Value.progress);
            }
        }

        /// <summary>
        /// Загрузка Формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ltr_Load(object sender, EventArgs e)
        {
            LoadDataToGrid(statusComboBox.Text, searchBox.Text);
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
            {
                dialogResult = MessageBox.Show("Редактирование нескольки книг сразу невозможно", "Редактирование");
                return;
            }
            if (dataGrid.SelectedRows.Count == 0)
            {
                dialogResult = MessageBox.Show("Не выбрано ни одного ряда", "Редактирование");
                return;
            }
            OpenEditForm();        
        }        

        /// <summary>
        /// Кнопка редактирование прочитанных страниц
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditReadedPagesButton_Click(object sender, EventArgs e)
        {
            OpenEditReadedPagesForm();
        }

        /// <summary>
        /// Выбор определенного списка книг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDataToGrid(statusComboBox.Text, searchBox.Text);
        }

        /// <summary>
        /// Окно поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadDataToGrid(statusComboBox.Text, searchBox.Text);
        }


        //Кнопки меню
        private void ДобавитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddForm();
        }

        private void УдалитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchBox.ContainsFocus)
            {
                searchBox.SelectedText = "";
            }
            else DeleteBook();
        }

        private void РедактироватьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBook();
        }

        private void РедактироватьКолвоПрочитанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetReaded();
        }

        private void СправкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Owner = this;
            helpForm.ShowDialog();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutForm = new AboutBox();
            aboutForm.Owner = this;
            aboutForm.ShowDialog();
        }

        private void ПриветствиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelloForm helloForm = new HelloForm();
            helloForm.Owner = this;
            helloForm.ShowDialog();
        }

        private void ВыбратьВсеКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.SelectAll();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
