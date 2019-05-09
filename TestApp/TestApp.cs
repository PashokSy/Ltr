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



            //if (booksDictionary.StoreNewBook(book) == true)
            //    Console.WriteLine("Book added");

            //booksDictionary.Save("test.txt");

            //BooksDictionary booksDictionary1 = BooksDictionary.Load("test.txt");

            //ILiterature storedBook = booksDictionary1.FindBook("oyioioio");
            //if (storedBook != null)
            //    Console.WriteLine("Book found");
            //Console.WriteLine(storedBook.title);
            //Console.WriteLine(storedBook.authorLastname);
            //storedBook.authorLastname = "Vasya";
            //Console.WriteLine(storedBook.authorLastname);
            //booksDictionary.Save("test1.txt");
        }
    }
}
