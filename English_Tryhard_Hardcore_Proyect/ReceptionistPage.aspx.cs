using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace English_Tryhard_Hardcore_Proyect
{
    public partial class ReceptionistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name, date, address, mobile, rol, email, password;

            name = TextMakeName.Text;
            date = TextMakeFod.Text;
            address = TextMakeAddress.Text;
            mobile = TextMakeMobile.Text;
            rol = DropDownList1.SelectedValue;
            email = TextMakeEmail.Text;
            password = TextMakePassword.Text;


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(rol) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password))
            {
                Label1.Text = "All fields are required.";
                return;
            }


            try
            {
                string DBpath = Server.MapPath("~/DateBase/BBDD_English.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Name, FOD, Address, Mobile, Rol, Email, Password) " +
                                   "VALUES (@name, @fod, @address, @mobile, @rol, @email, @password)";
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@fod", date);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@mobile", mobile);
                        command.Parameters.AddWithValue("@rol", rol);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Label1.Text = "User created successfully.";
                        }
                        else
                        {
                            Label1.Text = "Error creating user.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "An error occurred: " + ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string emailToDelete = TextDeleteEmail.Text;

            if (string.IsNullOrEmpty(emailToDelete))
            {
                Label2.Text = "Email field is required.";
                return;
            }

            try
            {
                string DBpath = Server.MapPath("~/DateBase/BBDD_English.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
                {
                    conn.Open();
                    string query = "DELETE FROM Users WHERE Email = @Email";
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Email", emailToDelete);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Label2.Text = "User deleted successfully.";
                        }
                        else
                        {
                            Label2.Text = "No user found with the provided email.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Label2.Text = "An error occurred: " + ex.Message;
            }
        }
    }
}