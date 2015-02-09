using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Users
    {
        Int16 id, role;
        string username, password, email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        } 

        public Int16 Role
        {
            get { return role; }
            set { role = value; }
        }

        public Int16 Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
