using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookMSWebApp.DAL;
using BookMSWebApp.Model;

namespace BookMSWebApp.BLL
{
    public class BookManager
    {
        BookGateway _bookGateway = new BookGateway();

        public string SaveBook(Book book)
        {
            if (!IsIsbnExists(book.ISBN))
            {
                int affectedRows = _bookGateway.SaveBook(book);
                if(affectedRows>0) return "Book Added Successfully!";
                return "Book Not Added!";
            }
            else
            {
                return "ISBN already exists!";
            }
        }

        private bool IsIsbnExists(string isbn)
        {
            int countIsbn = _bookGateway.IsIsbnExists(isbn);
            if (countIsbn > 0) return true;
            return false;
        }
        
        public List<Book> GetAllBooks()
        {
            return _bookGateway.GetAllBooks();
        }
    }
}