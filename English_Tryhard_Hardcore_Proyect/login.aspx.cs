using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;



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

            password = GetMD5(password);

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                Label3.Text = "All fields are required.";
                return;
            }
            try
            {
                string DBpath = Server.MapPath("~/DateBase/BBDD_English.db");
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");
                conn.Open();

                string query = "SELECT Id,Name,FOD,Address,Mobile,Rol,Email FROM Users WHERE Email = @email AND Password = @password";

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            
                            UserClass user = new UserClass(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(6),
                                reader.GetString(5),
                                reader.GetString(2),
                                reader.GetString(4),
                                reader.GetString(3)
                            );

                            if (user.Role == "user")
                            {
                                Session["User"] = user;
                                Response.Redirect("./UserPage.aspx");
                            }else if(user.Role == "receptionist")
                            {
                                Response.Redirect("./ReceptionistPage.aspx");
                            }
                        }else{
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

        private string GetMD5(string password)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(data).Replace("-", "");
            }
        }
    }
}