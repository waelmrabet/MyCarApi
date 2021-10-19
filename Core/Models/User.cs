using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class User: BaseEntity
    {
        public string UserName { get; set; }
        public int Nom { get; set; }
        public int Prenom { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        // navgation properties
        public ICollection<Vehicule> Vehicules { get; set; }
    }
}
