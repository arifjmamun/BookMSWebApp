using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BookMSWebApp.DAL
{
    abstract public class DBconnection
    {
        protected SqlConnection Connection;
        protected SqlCommand Command;
        protected SqlDataReader Reader;
        protected SqlDataReader Adapter;

        protected DBconnection()
        {
            Connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
            Command = new SqlCommand();
            Command.Connection = Connection;
        }
    }
}