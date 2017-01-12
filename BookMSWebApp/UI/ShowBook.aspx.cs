using System;
using System.Collections.Generic;
using System.Web.UI;
using BookMSWebApp.BLL;
using BookMSWebApp.Model;

namespace BookMSWebApp.UI
{
    public partial class ShowBook : Page
    {
        BookManager _bookManager = new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowAllBooks();
            }
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == String.Empty)
            {
                ShowAllBooks();
            }
            else
            {
                string pattern = nameTextBox.Text;
                ShowTheBook(pattern);
            }
        }

        private void ShowTheBook(string pattern)
        {
            List<Book> books = _bookManager.GetTheBook(pattern);
            showBookGridView.DataSource = books;
            showBookGridView.DataBind();
        }

        private void ShowAllBooks()
        {
            List<Book> books = _bookManager.GetAllBooks();
            showBookGridView.DataSource = books;
            showBookGridView.DataBind();
        }

    }
}