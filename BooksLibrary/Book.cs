using System;
using System.Collections.Generic;
using System.Text;

namespace BooksLibrary
{
    public class Book : ILiterature
    {
        /// <summary>
        /// Название книги
        /// </summary>
        public string title { get; set; }        
        /// <summary>
        /// Фамилия автора книги
        /// </summary>
        public string authorLastname { get; set; }
        /// <summary>
        /// Всего страниц в книге
        /// </summary>
        public int pagesTotal { get; set; }
        /// <summary> 
        /// Прочитано страниц книги
        /// </summary>
        public int pagesReaded { get; set; }
        /// <summary>
        /// Прогресс чтения книги в процентах
        /// </summary>
        public string progress {
            get
            {
                try
                {
                    float persent = (((float)pagesReaded / (float)pagesTotal) * 100.0f);
                    string result = $"{persent:0.00}%";
                    return result;
                }
                catch
                {
                    return "0";
                }
            }
            private set { }
        }
        /// <summary>
        /// Коментарии к книге
        /// </summary>
        public string commentary { get; set; }
        /// <summary>
        /// Статус прочтения книги
        /// </summary>
        public string status { get; set; }


        /// <summary>
        /// Создать экземпляр книги
        /// </summary>
        /// <param name="Title">Название книги</param>
        /// <param name="AuthorLastname">Фамилия автора книги</param>
        /// <param name="PagesTotal">Колличество страниц книги</param>
        /// <param name="PagesReaded">Колличество прочитанных страниц</param>
        /// <param name="Commentary">Комментарий к книге</param>
        /// <param name="Status">На каком этапе чтения книга</param>
        public Book(
            string Title = "Empty title",
            string AuthorLastname = "EmptyAuthorLastName",
            int PagesTotal = 0,
            int PagesReaded = 0,
            string Commentary = "EmptyCommentary",
            string Status = "Может прочту")
        {
            title = Title;            
            authorLastname = AuthorLastname;
            pagesTotal = PagesTotal;
            pagesReaded = PagesReaded;
            commentary = Commentary;
            status = Status;
        }

        /// <summary>
        /// Закрытый перегруженый метод для того что бы можно было высчитывать прогресс и записывать его в файл
        /// </summary>
        /// <param name="Progress">Прогрешон. Считается внутри класса или при скитывании с файла</param>
        /// <param name="Title">Название книги</param>
        /// <param name="AuthorLastname">Фамилия автора книги</param>
        /// <param name="PagesTotal">Колличество страниц книги</param>
        /// <param name="PagesReaded">Колличество прочитанных страниц</param>
        /// <param name="Commentary">Комментарий к книге</param>
        /// <param name="Status">Книга мастрид?</param>
        private Book(
            string Progress,
            string Title = "Empty title",            
            string AuthorLastname = "EmptyAuthorLastName",
            int PagesTotal = 0,
            int PagesReaded = 0,
            string Commentary = "EmptyCommentary",
            string Status = "Может прочту")
        {
            title = Title;            
            authorLastname = AuthorLastname;
            pagesTotal = PagesTotal;
            pagesReaded = PagesReaded;
            progress = Progress;
            commentary = Commentary;
            status = Status;
        }

        /// <summary>
        /// Метод сохраняющий конктерный экземпляр
        /// </summary>
        /// <param name="textOut">Текстовый поток</param>
        public void Save(System.IO.TextWriter textOut)
        {
            textOut.WriteLine(progress);
            textOut.WriteLine(title);            
            textOut.WriteLine(authorLastname);
            textOut.WriteLine(pagesTotal);
            textOut.WriteLine(pagesReaded);
            textOut.WriteLine(commentary);
            textOut.WriteLine(status);
        }

        /// <summary>
        /// Метод обеспечивающий поток данных в файл
        /// </summary>
        /// <param name="filename">Имя файла для сохранения</param>
        /// <returns>Удачно ли сохранение</returns>        
        public bool Save(string filename)
        {
            System.IO.TextWriter textOut = null;
            try
            {
                textOut = new System.IO.StreamWriter(filename);
                Save(textOut);
            }
            catch
            {
                return false;
            }
            finally
            {
                if (textOut != null)
                {
                    textOut.Close();
                }
            }
            return true;
        }

        /// <summary>
        /// Метод обеспечивающий загрузку контретного экземпляра
        /// </summary>
        /// <param name="textIn">Текстовый поток</param>
        /// <returns>Экземпляр загружаемого класса</returns>
        public static Book Load(System.IO.TextReader textIn)
        {
            Book resultBook = null;
            try
            {
                string progress = textIn.ReadLine();
                string title = textIn.ReadLine();
                string authorLastname = textIn.ReadLine();
                string pagesTotalText = textIn.ReadLine();
                int pagesTotal = Int32.Parse(pagesTotalText);
                string pagesReadedText = textIn.ReadLine();
                int pagesReaded = Int32.Parse(pagesReadedText);
                string commentary = textIn.ReadLine();
                string status = textIn.ReadLine();

                resultBook = new Book(progress, title, authorLastname,
                                    pagesTotal, pagesReaded, commentary, status);
            }
            catch
            {
                return null;
            }
            return resultBook;
        }

        /// <summary>
        /// Метод обеспечивающий поток данных из файла
        /// </summary>
        /// <param name="filename">Имя файла для загрузки</param>
        /// <returns>Экземпляр загружаемого класса</returns>
        public static Book Load(string filename)
        {
            System.IO.TextReader textIn = null;
            Book resultBook = null;
            try
            {
                textIn = new System.IO.StreamReader(filename);
                resultBook = Book.Load(textIn);
            }
            catch
            {
                return null;
            }
            finally
            {
                if (textIn != null) textIn.Close();
            }
            return resultBook;
        }
    }
}
