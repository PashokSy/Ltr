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
        /// Имя автора книги
        /// </summary>
        public string authorName { get; set; }
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
        /// Метка книги
        /// </summary>
        public string tag { get; set; }
        /// <summary>
        /// Расширение файла книги
        /// </summary>
        public string fileExtension { get; set; }

        /// <summary>
        /// Создать экземпляр книги
        /// </summary>
        /// <param name="Title">Название книги</param>
        /// <param name="AuthorName">Имя автора книги</param>
        /// <param name="AuthorLastname">Фамилия автора книги</param>
        /// <param name="PagesTotal">Колличество страниц книги</param>
        /// <param name="Tag">Метка книги (например: "C#", "OOP")</param>
        /// <param name="FileExtension">Разширение имени файла (например: ".pdf", ".djvu")</param>
        /// <param name="PagesReaded">Колличество прочитанных страниц</param>
        public Book(
            string Title = "Empty title",
            string AuthorName = "EmptyAuthorName", 
            string AuthorLastname = "EmptyAuthorLastName", 
            int PagesTotal = 0, 
            string Tag = "EmptyTag", 
            string FileExtension = "EmptyFileExtension", 
            int PagesReaded = 0)
        {
            title = Title;
            authorName = AuthorName;
            authorLastname = AuthorLastname;
            pagesTotal = PagesTotal;
            tag = Tag;
            fileExtension = FileExtension;
            pagesReaded = PagesReaded;
        }

        /// <summary>
        /// Метод сохраняющий конктерный экземпляр
        /// </summary>
        /// <param name="textOut">Текстовый поток</param>
        public void Save(System.IO.TextWriter textOut)
        {
            textOut.WriteLine(title);
            textOut.WriteLine(authorName);
            textOut.WriteLine(authorLastname);
            textOut.WriteLine(pagesTotal);
            textOut.WriteLine(tag);
            textOut.WriteLine(fileExtension);
            textOut.WriteLine(pagesReaded);
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
                string title = textIn.ReadLine();
                string authorName = textIn.ReadLine();
                string authorLastname = textIn.ReadLine();
                string pagesTotalText = textIn.ReadLine();
                int pagesTotal = Int32.Parse(pagesTotalText);
                string tag = textIn.ReadLine();
                string filenameExtension = textIn.ReadLine();
                string pagesReadedText = textIn.ReadLine();
                int pagesReaded = Int32.Parse(pagesReadedText);

                resultBook = new Book(title, authorName, authorLastname,
                                    pagesTotal, tag, filenameExtension, pagesReaded);
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
