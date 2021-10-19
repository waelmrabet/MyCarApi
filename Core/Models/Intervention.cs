using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Intervention : BaseEntity
    {
        public TypeIntervention TypeIntervention { get; set; }
        public string Commentaire { get; set; }
        public bool EstEntretionComplet { get; set; }
        public DateTime DateIntervention { get; set; }
        public int Kilometrage { get; set; }

        // navigation properties
        public virtual Vehicule Vehicule { get; set; }

    }
}
