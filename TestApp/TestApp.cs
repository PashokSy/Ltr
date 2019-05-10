using System;
using System.Collections.Generic;
using System.Text;
using BooksLibrary;

namespace TestApp
{
    class TestApp
    {
        static void Main(string[] args)
        {
            BooksDictionary booksDictionary = new BooksDictionary();
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            Book book1 = new Book("C# 4.0 Полное руководство", "<Имя>", "Шилд", 1043, "C#", ".pdf", 426);
            Book book2 = new Book("ОО анализ и проектирование с примерами приложений", "<Имя>", "Буч", 575, "OOP", ".pdf", 120);
            Book book3 = new Book("Паттерны на .NET", "<Имя>", "Тепляков", 312, "C#", ".pdf", 27);
            Book book4 = new Book("Совершенный код", "<Имя>", "Макконнелл", 860, "CleanCode", ".pdf", 251);
            Book book5 = new Book("CLR via C#", "<Имя>", "Рихтер", 892, "C#", ".pdf", 0);

            booksDictionary.StoreBook(book1);
            booksDictionary.StoreBook(book2);
            booksDictionary.StoreBook(book3);
            booksDictionary.StoreBook(book4);
            booksDictionary.StoreBook(book5);

            booksDictionary.Save("test.txt");

            BooksDictionary booksDictionary1 = BooksDictionary.Load("library.txt");

            foreach (KeyValuePair<string, ILiterature> book in booksDictionary1)
            {
                Console.WriteLine($"Название книги: {book.Key}; Автор: {book.Value.authorLastname}; Прогресс: {book.Value.progress}");
            }

            //ILiterature storedBook1 = booksDictionary1.FindBook("Джава для нубов");
            //if (storedBook1 != null)
            //    Console.WriteLine("Book found");
            //else
            //    Console.WriteLine("Not FOund");

            //storedBook1.authorName = Console.ReadLine();
            //booksDictionary1.Save("test.txt");

            //ILiterature storedBook2 = booksDictionary1.FindBook("Сишарп для детей");
            //if (storedBook2 != null)
            //    Console.WriteLine("Book found");
            //else
            //    Console.WriteLine("Not FOund");

            //storedBook2.pagesReaded = Int32.Parse(Console.ReadLine());
            //booksDictionary1.Save("test.txt");
        }
    }
}
