using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class Ex12VerificationPage : System.Web.UI.Page
    {
        public readonly string connectionString = ConfigurationManager.ConnectionStrings["dbConfig"].ConnectionString;
        public readonly string SelectQuery = "SELECT UserPassword FROM UserDetails WHERE UserName = @username";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool VerifyPassword(string password, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(32);
            for(int i=0;i<32;i++)
            {
                if (hashBytes[i+16] != hash[i]) return false;
            }
            return true;
        }

        protected void txtLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
            string enteredpassword = txtPassword.Text.Trim();

            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(SelectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string storedHash = result.ToString();
                        if (VerifyPassword(enteredpassword, storedHash))
                        {
                            Response.Redirect("Ex13UserListPage.aspx");
                        }
                        else
                        {
                            txtDisplay.Text = "Username or password is incorrect.";
                        }
                    }
                    else
                    {
                        txtDisplay.Text = "Username or password is incorrect.";
                    }
                    conn.Close();
                }
            }
        }

        protected void txtSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ex10ValidationPage.aspx");
        }
    }
}