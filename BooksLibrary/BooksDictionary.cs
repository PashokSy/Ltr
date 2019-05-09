using System;
using System.Collections.Generic;
using System.Text;

namespace BooksLibrary
{
    public class BooksDictionary
    {
        Dictionary<string, ILiterature> dictionaryBooks = new Dictionary<string, ILiterature>();

        /// <summary>
        /// Метод который находит книгу в библиотеке
        /// </summary>
        /// <param name="Title">Название книги</param>
        /// <returns>Экземпляр книги</returns>
        public ILiterature FindBook(string Title)
        {
            if (dictionaryBooks.ContainsKey(Title) == true)
                return dictionaryBooks[Title];
            else
                return null;
        }

        /// <summary>
        /// Метод сохраняющий книгу
        /// </summary>
        /// <param name="book">Экземпляр книги</param>
        /// <returns>Удачно ли сохранение</returns>
        public bool StoreBook(ILiterature book)
        {
            if (dictionaryBooks.ContainsKey(book.title) == true)
                return false;

            dictionaryBooks.Add(book.title, book);
            return true;
        }

        /// <summary>
        /// Метод сохраняющий поток с нигами в библиотеке
        /// </summary>
        /// <param name="textOut">Текстовый поток</param>
        void Save(System.IO.TextWriter textOut)
        {
            textOut.WriteLine(dictionaryBooks.Count);
            foreach (Book book in dictionaryBooks.Values)
            {
                book.Save(textOut);
            }
        }

        /// <summary>
        /// Метод схраняющий библиотеку в файл
        /// </summary>
        /// <param name="filename">Имя файла</param>
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
        /// Метод библиотеку книг из текстового потока
        /// </summary>
        /// <param name="textIn">Текстовый поток</param>
        /// <returns>Библиотеку книг</returns>
        public static BooksDictionary Load(System.IO.TextReader textIn)
        {
            BooksDictionary resultDictionary = new BooksDictionary();
            string countString = textIn.ReadLine();
            int count = Int32.Parse(countString);

            for (int i = 0; i < count; i++)
            {
                Book book = Book.Load(textIn);
                resultDictionary.dictionaryBooks.Add(book.title, book);
            }
            return resultDictionary;
        }

        /// <summary>
        /// Метод загружающий библиотеку книг из файла
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <returns>Библиотеку книг</returns>
        public static BooksDictionary Load(string filename)
        {
            System.IO.TextReader textIn = null;
            BooksDictionary resultDictionary = null;
            try
            {
                textIn = new System.IO.StreamReader(filename);
                resultDictionary = BooksDictionary.Load(textIn);
            }
            catch
            {
                return null;
            }
            finally
            {
                if (textIn != null) textIn.Close();
            }

            return resultDictionary;
        }
    }
}
