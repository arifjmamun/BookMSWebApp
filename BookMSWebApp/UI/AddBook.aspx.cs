using System;
using BookMSWebApp.BLL;
using BookMSWebApp.Model;

namespace BookMSWebApp.UI
{
    public partial class AddBook : System.Web.UI.Page
    {
        BookManager _bookManager = new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            msgLabel.Text = String.Empty;
            if (bookNameTextBox.Text != String.Empty && isbnTextBox.Text != String.Empty && authorTextBox.Text != String.Empty && isbnTextBox.Text.Length == 13)
            {
                AddBookInfo();
            }
            else
            {
                msgLabel.Text = "Every Fields required! ISBN max-char: 13.";
            }
        }

        private void AddBookInfo()
        {
            string name = bookNameTextBox.Text;
            string isbn = isbnTextBox.Text;
            string author = authorTextBox.Text;
            Book book = new Book(isbn,name,author);
            msgLabel.Text = _bookManager.SaveBook(book);
        }
    }
}