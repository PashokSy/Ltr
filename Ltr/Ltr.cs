using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            try
            {
                //Создание библиотеки книг и заполнение их из файла в корневой папке
                BooksDictionary booksDictionary = new BooksDictionary();
                booksDictionary = BooksDictionary.Load("library.txt");
                ILiterature storedBook = booksDictionary.FindBook("Джава для нубов");
                if (storedBook != null)
                    label1.Text = storedBook.authorLastname;
                else
                    label1.Text = "Not FOund";
            }
            catch
            {
                label1.Text = "File not found";
            }
            
        }
    }
}
