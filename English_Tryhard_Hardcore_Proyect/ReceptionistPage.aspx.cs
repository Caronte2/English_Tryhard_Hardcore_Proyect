using English_Tryhard_Hardcore_Proyect.Class;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace English_Tryhard_Hardcore_Proyect
{
    public partial class ReceptionistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextUpdateName.Enabled = false;
            TextUpdateFOD.Enabled = false;
            TextUpdateAddress.Enabled = false;
            TextUpdateMobile.Enabled = false;
            DropDownList2.Enabled = false;
            TextUpdatePassword.Enabled = false;

            TextRoomChangeBooking.Enabled = false;
            TextDepartureChangeBookin.Enabled=false;
            TextEntryDateChangeDate.Enabled = false;

            UserClass user = Session["User"] as UserClass;

            if (user == null)
            {
                Response.Redirect("./login.aspx");
            }
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


            string onlyLettersPattern = @"^[a-zA-Z]+$";
            string onlyNumbersPattern = @"^[0-9]+$";
            string haveCapitalLetterPattern = "^(?=.*[A-Z]).+$";
            string haveNumberPattern = "^(?=.*[0-9]).+$";
            string haveSymbolsPattern = "^(?=.*[$@€!%*?&]).+$";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(rol) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password))
            {
                LabelError.Text = "All fields are required.";
                return;
            }

            if (!Regex.IsMatch(name, onlyLettersPattern))
            {
                LabelError.Text = "The name must contain only letters.";
                return;
            }
            if (!Regex.IsMatch(mobile, onlyNumbersPattern))
            {
                LabelError.Text = "The mobile number must contain only digits.";
                return;
            }

            if (!Regex.IsMatch(password, haveNumberPattern) || !Regex.IsMatch(password, haveCapitalLetterPattern) || !Regex.IsMatch(password, haveSymbolsPattern))
            {
                LabelError.Text = "The password must contain a number, a capital letter, and a symbol.";
                return;
            }

            password = GetMD5(password);
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
                            LabelError.Text = "User created successfully.";
                        }
                        else
                        {
                            LabelError.Text = "Error creating user.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LabelError.Text = "An error occurred: " + ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string emailToDelete = TextDeleteEmail.Text;

            if (string.IsNullOrEmpty(emailToDelete))
            {
                LabelDeleteUserErrorr.Text = "Email field is required.";
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
                            LabelDeleteUserErrorr.Text = "User deleted successfully.";
                        }
                        else
                        {
                            LabelDeleteUserErrorr.Text = "No user found with the provided email.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LabelDeleteUserErrorr.Text = "An error occurred: " + ex.Message;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string email, room, departureDate, entryDate;
            email = TextMakeBookingUserEmail.Text;
            room = TextMakeBookingRoomNumber.Text;
            departureDate = TextMakeBookingCheckInDate.Text;
            entryDate = TextMakeBookingCheckOutDate.Text;

            try
            {
                string DBpath = Server.MapPath("~/DateBase/BBDD_English.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
                {
                    conn.Open();

                    string query = "INSERT INTO Reservation (Id_User, Room, Departure_date, Entry_date) " +
                                   "SELECT Id, @room, @departureDate, @entryDate " +
                                   "FROM Users WHERE Email = @email";

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@room", room);

                        
                        command.Parameters.AddWithValue("@departureDate", departureDate);

                        command.Parameters.AddWithValue("@entryDate", entryDate);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            LabelDeletoBooking.Text = "New booking created successfully.";
                        }
                        else
                        {

                            LabelDeletoBooking.Text = "No user found with the provided email. Please register first.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LabelDeletoBooking.Text = "An error occurred: " + ex.Message;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            string email = TextSearchForEmail.Text;
            try
            {
                string DBpath = Server.MapPath("~/DateBase/BBDD_English.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
                {
                    conn.Open();

                    string query = "SELECT Name,FOD,Address,Mobile,Rol FROM Users WHERE Email = @email";

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TextUpdateName.Text = reader.GetString(0);
                                TextUpdateFOD.Text = reader.GetString(1);
                                TextUpdateAddress.Text = reader.GetString(2);
                                TextUpdateMobile.Text = reader.GetString(3);
                                DropDownList2.SelectedValue = reader.GetString(4);
                                TextUpdatePassword.Text = "********";

                                TextUpdateName.Enabled = true;
                                TextUpdateFOD.Enabled = true;
                                TextUpdateAddress.Enabled = true;
                                TextUpdateMobile.Enabled = true;
                                DropDownList2.Enabled = true;
                                TextUpdatePassword.Enabled = true;
                            }
                            else
                            {
                                LabelChangerUserError.Text = "No user found with the provided email.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                LabelChangerUserError.Text = "An error occurred: " + ex.Message;
            }

        }

        protected void ButtonUpdateUser_Click(object sender, EventArgs e)
        {
            string name,date, address, mobile, rol, password,email;

            name = TextUpdateName.Text;
            date = TextUpdateFOD.Text;
            address = TextUpdateAddress.Text;
            mobile = TextUpdateMobile.Text;
            rol = DropDownList2.SelectedValue;
            password = TextUpdatePassword.Text;
            email = TextSearchForEmail.Text;

            try
            {
                string DBpath = Server.MapPath("~/DateBase/BBDD_English.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
                {
                    conn.Open();

                    string query = "UPDATE Users SET Name = @name, FOD = @fod, Address = @address, Mobile = @mobile, Rol = @rol, Password = @password WHERE Email = @email";

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {

                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@fod", date);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@mobile", mobile);
                        command.Parameters.AddWithValue("@rol", rol);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email); 

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LabelChangerUser2.Text = "User updated successfully!";
                        }
                        else
                        {
                            LabelChangerUser2.Text = "Update failed. Email not found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LabelChangerUser2.Text = "An error occurred: " + ex.Message;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            string reservationDelete = TextDeleteBookingID.Text;

            if (string.IsNullOrEmpty(reservationDelete))
            {
                LabeDeleteBooking1.Text = "Email field is required.";
                return;
            }

            try
            {
                string DBpath = Server.MapPath("~/DateBase/BBDD_English.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
                {
                    conn.Open();
                    string query = "DELETE FROM Reservation WHERE Id = @id";
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", reservationDelete);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            LabeDeleteBooking1.Text = "User deleted successfully.";
                        }
                        else
                        {
                            LabeDeleteBooking1.Text = "No user found with the provided email.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LabeDeleteBooking1.Text = "An error occurred: " + ex.Message;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

            string reservationId = TextSearchReservationId.Text;
            try
            {
                string DBpath = Server.MapPath("~/DateBase/BBDD_English.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
                {
                    conn.Open();

                    string query = "SELECT Departure_date,Entry_date,Room FROM Reservation WHERE Id = @id";

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", reservationId);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TextRoomChangeBooking.Text = reader.GetString(2);
                                TextDepartureChangeBookin.Text= reader.GetString(0);
                                TextEntryDateChangeDate.Text= reader.GetString(1);

                                TextRoomChangeBooking.Enabled = true;
                                TextDepartureChangeBookin.Enabled = true;
                                TextEntryDateChangeDate.Enabled = true;
                            }
                            else
                            {
                                LabelChangeBooking.Text = "No user found with the provided email.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LabelChangeBooking.Text = "An error occurred: " + ex.Message;
            }


        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string room, departure_date, entry_date ,id_reservation;

            room = TextRoomChangeBooking.Text;
            departure_date = TextDepartureChangeBookin.Text;
            entry_date = TextEntryDateChangeDate.Text;
            id_reservation = TextSearchReservationId.Text;

            try
            {
                string DBpath = Server.MapPath("~/DateBase/BBDD_English.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
                {
                    conn.Open();

                    string query = "UPDATE Reservation SET Room = @room, Departure_date = @departure_date, Entry_date = @entry_date WHERE Id = @id";

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {

                        command.Parameters.AddWithValue("@room", room);
                        command.Parameters.AddWithValue("@departure_date", departure_date);
                        command.Parameters.AddWithValue("@entry_date", entry_date);
                        command.Parameters.AddWithValue("@id", id_reservation);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LabelChangeBooking2.Text = "User updated successfully!";
                        }
                        else
                        {
                            LabelChangeBooking2.Text = "Update failed. Email not found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LabelChangeBooking2.Text = "An error occurred: " + ex.Message;
            }

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string email = TextEmailSearch.Text;

            try
            {
                string DBpath = Server.MapPath("~/DateBase/BBDD_English.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
                {
                    conn.Open();

                    string query = "SELECT Name,FOD,Address,Mobile,Rol FROM Users WHERE Email = @email ";

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SearchName.Text = "Name: " + reader.GetString(0);
                                SearchDate.Text = "Date: " + reader.GetString(1);
                                SearchAddress.Text = "Address: " + reader.GetString(2);
                                SearchMobile.Text = "Mobile "+reader.GetString(3);
                                SearchRol.Text = "Rol: " + reader.GetString(4);
                            }
                            else
                            {
                                LabelSearchUser.Text = "No user found with the provided email.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LabelSearchUser.Text = "An error occurred: " + ex.Message;
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