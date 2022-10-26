using System;
using System.Collections.Generic;

namespace SistemaTesis.Entity
{
    public partial class TiposDeRegistro
    {
        public TiposDeRegistro()
        {
            Clientes = new HashSet<Clientes>();
            Empleados = new HashSet<Empleados>();
            Estados = new HashSet<Estados>();
            Localidades = new HashSet<Localidades>();
            Provincia = new HashSet<Provincias>();
            Transportes = new HashSet<Transportes>();
        }

        public int IdTipoRegistro { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
        public virtual ICollection<Estados> Estados { get; set; }
        public virtual ICollection<Localidades> Localidades { get; set; }
        public virtual ICollection<Provincias> Provincia { get; set; }
        public virtual ICollection<Transportes> Transportes { get; set; }
    }
}
