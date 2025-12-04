using English_Tryhard_Hardcore_Proyect.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace English_Tryhard_Hardcore_Proyect
{
    public partial class UserPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            UserClass user = Session["User"] as UserClass;


            if (user == null)
            {
                Response.Redirect("./login.aspx");
            }
            else
            {
                LabelName.Text = user.Name;
                LabelEmail.Text = user.Email;
                LabelDate.Text = user.DateOfBirth;
                LabelMobile.Text = user.Mobile;
                LabelAddress.Text = user.Address;
                LabelRol.Text = user.Role;
                List<Reservation> reservationList = getListReservation(user.Id.ToString());

                for (int i = 0; i < reservationList.Count; i++)
                {
                    string texto = "Reserva " + reservationList[i].IdUser + ": " + reservationList[i].EntryDate + " - " + reservationList[i].DepartureDate + "Room:" + reservationList[i].Room;
                    ListBoxBooking.Items.Add(texto);
                }
            }
        }

        private List<Reservation> getListReservation(string idUser)
        {
            List<Reservation> reservations = new List<Reservation>();

            try
            {
                string DBpath = Server.MapPath("~/DateBase/BBDD_English.db"); 

                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
                {
                    conn.Open();

                    string query = "SELECT * FROM Reservation WHERE Id_User = @UserId";

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@UserId", idUser);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Reservation reservation = new Reservation(
                                    reader.GetInt32(0),       
                                    reader.GetInt32(1),        
                                    reader.GetString(2),       
                                    reader.GetString(3),       
                                    reader.GetString(4)        
                                );

                                reservations.Add(reservation);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ListBoxBooking.Items.Add(ex.Message);
            }

            return reservations;
        }
    }
}