using System;
using System.Collections.Generic;

namespace SistemaTesis.Entity
{
    public partial class Provincias
    {
        public Provincias()
        {
            Clientes = new HashSet<Clientes>();
            Localidades = new HashSet<Localidades>();
        }

        public int IdProvincia { get; set; }
        public string? Provincia1 { get; set; }
        public int? IdTipoRegistro { get; set; }

        public virtual TiposDeRegistro? IdTipoRegistroNavigation { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Localidades> Localidades { get; set; }
    }
}
