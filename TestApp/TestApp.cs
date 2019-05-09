using System;
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

            Book book1 = new Book("Сишарп для детей", "Вася", "Пупкин", 223, "СШарп", "пдф", 2);
            Book book2 = new Book("Джава для нубов", "Миша", "Могила", 111, "Жаба", "пдф", 13);

            booksDictionary.StoreBook(book1);
            booksDictionary.StoreBook(book2);

            booksDictionary.Save("test.txt");

            BooksDictionary booksDictionary1 = BooksDictionary.Load("test.txt");
            
            ILiterature storedBook = booksDictionary1.FindBook("Джава для нубов");
            if (storedBook != null)
                Console.WriteLine("Book found");
            else
                Console.WriteLine("Not FOund");

            storedBook.authorName = Console.ReadLine();
            booksDictionary1.Save("test.txt");
        }
    }
}
