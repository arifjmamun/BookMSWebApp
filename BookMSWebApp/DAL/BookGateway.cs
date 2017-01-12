using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookMSWebApp.Model;

namespace BookMSWebApp.DAL
{
    public class BookGateway : DBconnection
    {
        public int IsIsbnExists(string isbn)
        {
            try
            {
                const string query = @"SELECT COUNT(*) FROM Book WHERE ISBN=@ISBN";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@ISBN", isbn);
                int countIsbn = (int)Command.ExecuteScalar();
                return countIsbn;
            }
            finally
            {
                Connection.Close();
            }
        }

        public int SaveBook(Book book)
        {
            try
            {
                const string query = @"INSERT INTO Book(ISBN, Name, Author) VALUES(@ISBN, @Name, @Author)";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@ISBN", book.ISBN);
                Command.Parameters.AddWithValue("@Name", book.Name);
                Command.Parameters.AddWithValue("@Author", book.Author);
                int affectedRows = Command.ExecuteNonQuery();
                return affectedRows;
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<Book> GetAllBooks()
        {
            try
            {
                List<Book> books = new List<Book>();
                const string query = "SELECT * FROM Book";
                Connection.Open();
                Command.CommandText = query;
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    int rowSerial = 0;
                    while (Reader.Read())
                    {
                        int serial = ++rowSerial;
                        string isbn = Reader["ISBN"].ToString();
                        string name = Reader["Name"].ToString();
                        string author = Reader["Author"].ToString();
                        Book book = new Book(serial,isbn,name,author);
                        books.Add(book);
                    }
                    Reader.Close();
                }
                return books;
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<Book> GetTheBook(string pattern)
        {
            try
            {
                List<Book> books = new List<Book>();
                const string query = "SELECT * FROM Book WHERE Name LIKE @Pattern";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@Pattern", pattern);
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    int rowSerial = 0;
                    while (Reader.Read())
                    {
                        int serial = ++rowSerial;
                        string isbn = Reader["ISBN"].ToString();
                        string name = Reader["Name"].ToString();
                        string author = Reader["Author"].ToString();
                        Book book = new Book(serial, isbn, name, author);
                        books.Add(book);
                    }
                    Reader.Close();
                }
                return books;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}