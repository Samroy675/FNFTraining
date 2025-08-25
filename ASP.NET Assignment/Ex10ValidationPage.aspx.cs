using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Security.Cryptography;

namespace SampleWebFormsApp
{
    public partial class Ex10ValidationPage : System.Web.UI.Page
    {
        public readonly string connectionString = ConfigurationManager.ConnectionStrings["dbConfig"].ConnectionString;
        public readonly string insertQuery = "INSERT INTO UserDetails(Username,UserPassword,Email,DOB) VALUES(@username,@userpassword,@email,@dob)";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string HashedPassword(string password)
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            var pbkdf2 = new Rfc2898DeriveBytes(password,salt,100000);
            byte[] hash = pbkdf2.GetBytes(32);
            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 32);
            return Convert.ToBase64String(hashBytes);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                string username = txtUsername.Text.Trim();
                string userpassword = txtPassword.Text.Trim();
                string email = txtEmail.Text.Trim();
                DateTime dob = DateTime.Parse(txtDOB.Text);
                string hashedpassword = HashedPassword(userpassword);

                using (var conn = new SqlConnection(connectionString))
                {
                    using (var cmd = new SqlCommand(insertQuery, conn))
                    {                        
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@userpassword", hashedpassword);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                txtDisplay.Text = "User Saved Successfully.";
                txtDisplay.ForeColor = System.Drawing.Color.Green;  
            }
        }

        protected void txtbtnSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ex12VerificationPage.aspx");
        }
    }
}