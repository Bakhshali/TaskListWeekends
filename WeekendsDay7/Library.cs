using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendsDay7
{
     class Library
    {
        public List<Book> books = new List<Book>();

        public List<Book> FindAllBooksbyName(string value)
        {

            return books.FindAll(book => book.Name.Contains(value));

        }
        public void RemoveBooksbyName(string value)
        {
            books.RemoveAll(book => book.Name.Contains(value));

        }
        public List<Book> SearchBooks(string value)
        {
            return books.FindAll(book => book.Name.Contains(value) || book.AuthorName.Contains(value) || book.PageCount.ToString().Contains(value));
        }
        public List<Book> FindAllBooksByPageCountRange(int minPage, int maxPage)
        {
            return books.FindAll(book => book.PageCount >= minPage && book.PageCount <= maxPage);
        }
        public void RemoveBooksbyCode(string value)
        {
            Book book = books.Find(book => book.Code.Contains(value));
            if (book != null)
            {
                books.Remove(book);
            }

        }


    }  
}
