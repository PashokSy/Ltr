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
            Book book3 = new Book("Сишарп для детей", "Вася", "Пупкин", 223, "СШарп", "пдф", 3);

            booksDictionary.StoreBook(book1);
            booksDictionary.StoreBook(book2);
            booksDictionary.StoreBook(book3);

            booksDictionary.Save("test.txt");

            BooksDictionary booksDictionary1 = BooksDictionary.Load("test.txt");
            
            ILiterature storedBook1 = booksDictionary1.FindBook("Джава для нубов");
            if (storedBook1 != null)
                Console.WriteLine("Book found");
            else
                Console.WriteLine("Not FOund");

            storedBook1.authorName = Console.ReadLine();
            booksDictionary1.Save("test.txt");

            ILiterature storedBook2 = booksDictionary1.FindBook("Сишарп для детей");
            if (storedBook2 != null)
                Console.WriteLine("Book found");
            else
                Console.WriteLine("Not FOund");

            storedBook2.pagesReaded = Int32.Parse(Console.ReadLine());
            booksDictionary1.Save("test.txt");
        }
    }
}
