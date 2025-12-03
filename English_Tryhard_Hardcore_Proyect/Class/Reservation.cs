using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace English_Tryhard_Hardcore_Proyect.Class
{
    public class Reservation
    {
        int id;
        int idUser;
        string room;
        string departureDate;
        string entryDate;

        public Reservation(int id, int idUser, string departureDate, string entryDate, string room)
        {
            this.id = id;
            this.idUser = idUser;
            this.room = room;
            this.departureDate = departureDate;
            this.entryDate = entryDate;
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        public string Room
        {
            get { return room; }
            set { room = value; }
        }

        public string DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }

        public string EntryDate
        {
            get { return entryDate; }
            set { entryDate = value; }
        }
    }
}