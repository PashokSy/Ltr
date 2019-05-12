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

            Book book1 = new Book("C# 4.0 Полное руководство","Шилд", 1043, 426, "Пока что лучшый учебник", "Сейчас читаю");
            Book book2 = new Book("ОО анализ и проектирование с примерами приложений","Буч", 575, 120, "meh", "Сейчас читаю");
            Book book3 = new Book("Паттерны на .NET","Тепляков", 312, 27, "Расшарить паттерны", "Обязательно прочту");
            Book book4 = new Book("Совершенный код","Макконнелл", 860, 251, "Что бы писать стихЫ", "Обязательно прочту");
            Book book5 = new Book("CLR via C#","Рихтер", 892, 0, "хз", "Может прочту");
            Book book6 = new Book("Unity и C# геймдев от идеи до реализации", "Бонд", 930, 0, "Когда то я к ней доберусь", "Может прочту");

            booksDictionary.StoreBook(book1);
            booksDictionary.StoreBook(book2);
            booksDictionary.StoreBook(book3);
            booksDictionary.StoreBook(book4);
            booksDictionary.StoreBook(book5);
            booksDictionary.StoreBook(book6);

            booksDictionary.Save("library.txt");

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
