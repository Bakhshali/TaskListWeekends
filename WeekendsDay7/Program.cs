
using System;
using System.Collections.Generic;

namespace WeekendsDay7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("galaxy", "Stephan Hawking", 254);
            Book book1 = new Book("algorithm", "Bakhsali Nazarov", 480);
            Book book2 = new Book("geological", "Darwin", 180);
            Book book3 = new Book("murder", "Agatha Christie", 324);

            Library library = new Library();
            library.books.Add(book1);
            library.books.Add(book2);
            library.books.Add(book3);
            library.books.Add(book);




            Console.WriteLine("BooksName");
            foreach (var item in library.FindAllBooksbyName("galaxy"))
            {
                Console.WriteLine(item.Code);
            }

            Console.WriteLine("\nPage Counts:");
            foreach (var item in library.FindAllBooksByPageCountRange(200, 400))
            {
                Console.WriteLine(item.Code);
            }


            Console.WriteLine("\nSearchBooks:");
            library.SearchBooks(book1.Name);
            foreach (var item in library.books)
            {
                Console.WriteLine(item.Code);
            }



            Console.WriteLine("\nRemoveBooksbyName:");
            library.RemoveBooksbyName("algorithm");
            foreach (var item in library.books)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\nRemoveBooksbyCode:");

            library.RemoveBooksbyCode("GA-11");
            foreach (var item in library.books)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
