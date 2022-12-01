using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetNote
{
    public class Rdv
    {
        public string idRdv { get; set; }
        public DateTime dateRendezVous { get; set; }
        public string libelle { get; set; }

        public int duree { get; set; }
        public bool urgence { get; set; }
        public bool estAnnule { get; set; }
        public bool estVu{ get; set; }
        public int patientId { get; set; }
        public Rdv() { }
    }
}
