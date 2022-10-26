using System;
using System.Collections.Generic;

namespace SistemaTesis.Entity
{
    public partial class Empleados
    {
        public Empleados()
        {
            SolicitudesEmpleados = new HashSet<SolicitudesEmpleados>();
        }

        public int IdEmpleado { get; set; }
        public int DniEmpleado { get; set; }
        public string? Apellidos { get; set; }
        public string? Nombres { get; set; }
        public DateTime? FechaNac { get; set; }
        public int? PorcComision { get; set; }
        public int IdEstado { get; set; }
        public string Clave { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public int IdTipoRegistro { get; set; }

        public virtual Estados IdEstadoNavigation { get; set; } = null!;
        public virtual TiposDeRegistro IdTipoRegistroNavigation { get; set; } = null!;
        public virtual ICollection<SolicitudesEmpleados> SolicitudesEmpleados { get; set; }
    }
}
