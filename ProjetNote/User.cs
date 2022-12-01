using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetNote
{
    public class User
    {
        public string userId { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string eMail { get; set; }
        public string token { get; set; }
        public User()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
