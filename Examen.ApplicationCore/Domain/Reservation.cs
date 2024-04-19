using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime DateReservation { get; set; }

        [Range(1, 30)]
        public int DureeJours { get; set; }

        public int LocataireKey { get; set; }
        public int VehiculeKey { get; set; }

        [ForeignKey("LocataireKey")]
        public virtual Locataire locataire { get; set; }

        [ForeignKey("VehiculeKey")]
        public virtual Vehicule Vehicule { get; set; }

    }
}
