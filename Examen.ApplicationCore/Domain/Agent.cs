using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Agent
    {
        [Key]
        public int AgentId { get; set; }

        public DateTime DateEmbauche { get; set; }
        public string Nom{ get; set; }
        public string Prenom { get; set;}

        public IList<Locataire> Locataires { get; set; }



    }
}
