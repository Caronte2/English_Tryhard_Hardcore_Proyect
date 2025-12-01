using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace English_Tryhard_Hardcore_Proyect
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email, password;

            email = TextBox1.Text;
            password = TextBox2.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                Label3.Text = "All fields are required.";
                return;
            }
            try
            {
                string DBpath = Server.MapPath("~/Bbdd/data.db");
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");
                conn.Open();

                string query = "SELECT Rol FROM Users WHERE Email = @email AND Password = @password";

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            string rol = reader["Rol"].ToString();
                            if (rol == "user")
                            {
                                Response.Redirect("");
                            }else if(rol == "receptionist")
                            {
                                Response.Redirect("");
                            }
                        }else if{
                            Label3.Text = "Invalid email or password.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Label3.Text = "Error: " + ex.Message;
            }
        }
    }
}