using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Vehicule: BaseEntity
    {
        public int Puissance { get; set; }
        public Carburant Carburant { get; set; }
        public string Matricule { get; set; }

        // navigation porpoerties
        public virtual User User { get; set; }
        public virtual ICollection<Intervention> Interventions { get; set; }
    }
}
