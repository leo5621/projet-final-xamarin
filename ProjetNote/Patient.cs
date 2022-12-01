using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetNote
{
    internal class Patient
    {
        public string idPatient { get; set; }
        public string patient { get; set; }
        public string nom { get; set; }

        public string prenom { get; set; }
        public string civilite { get; set; }
        public string sexe { get; set; }
        public DateTime dateNaissance { get; set; }
        public string adresse { get; set; }
        public int codePostal { get; set; }
        public string ville { get; set; }
        public string telFixe { get; set; }
        public string telMobile { get; set; }
        public string eMail { get; set; }
        public string id { get; set; }
        public Patient()
        {
        }
    }
}
