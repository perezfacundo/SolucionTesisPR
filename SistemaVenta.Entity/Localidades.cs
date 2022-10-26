using System;
using System.Collections.Generic;

namespace SistemaTesis.Entity
{
    public partial class Localidades
    {
        public Localidades()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int IdLocalidad { get; set; }
        public string Localidad { get; set; } = null!;
        public int IdProvincia { get; set; }
        public int IdTipoRegistro { get; set; }

        public virtual Provincias IdProvinciaNavigation { get; set; } = null!;
        public virtual TiposDeRegistro IdTipoRegistroNavigation { get; set; } = null!;
        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
