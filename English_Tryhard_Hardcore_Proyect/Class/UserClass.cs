using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace English_Tryhard_Hardcore_Proyect
{
    public class UserClass
    {
        private int id;
        private string name;
        private string email;
        private string mobile;
        private string role;
        private string dateOfBirth;
        private string password;
        private string address;
        public UserClass(int id, string name, string email, string role, string dateOfBirth, string mobile, string address)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.role = role;
            this.dateOfBirth = dateOfBirth;
            this.mobile = mobile;
            this.address = address;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}