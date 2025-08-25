using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class Ex13UserListPage : System.Web.UI.Page
    {
        DataSet dataSet = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getAllRecords();
                rptUsers.DataSource = dataSet.Tables["UserDetails"];
                rptUsers.DataBind();
            }
        }

        private void getAllRecords()
        {
            const string SelectQuery = "SELECT * FROM UserDetails";
            string connectionString = ConfigurationManager.ConnectionStrings["dbConfig"].ConnectionString;
            using (var adapter = new SqlDataAdapter(SelectQuery, connectionString))
            {
                dataSet.Tables.Clear();
                adapter.Fill(dataSet, "UserDetails");
            }
        }
    }
}