using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetNote
{
    internal class Authentification
    {
        public string email { get; set; }
        public string password { get; set; }

        public Authentification(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}
