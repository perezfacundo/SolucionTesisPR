using System;
using System.Collections.Generic;

namespace SistemaTesis.Entity
{
    public partial class Estados
    {
        public Estados()
        {
            Clientes = new HashSet<Clientes>();
            Empleados = new HashSet<Empleados>();
            Transportes = new HashSet<Transportes>();
        }

        public int IdEstado { get; set; }
        public string Descripcion { get; set; } = null!;
        public int IdTipoRegistro { get; set; }

        public virtual TiposDeRegistro IdTipoRegistroNavigation { get; set; } = null!;
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
        public virtual ICollection<Transportes> Transportes { get; set; }
    }
}
