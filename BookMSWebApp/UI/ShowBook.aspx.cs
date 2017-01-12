using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookMSWebApp.BLL;
using BookMSWebApp.Model;

namespace BookMSWebApp.UI
{
    public partial class ShowBook : System.Web.UI.Page
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
            
        }

        private void ShowAllBooks()
        {
            List<Book> books = _bookManager.GetAllBooks();
            showBookGridView.DataSource = books;
            showBookGridView.DataBind();
        }

    }
}