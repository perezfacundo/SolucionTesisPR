using System;
using System.Collections.Generic;

namespace SistemaTesis.Entity
{
    public partial class Solicitudes
    {
        public Solicitudes()
        {
            SolicitudesEmpleados = new HashSet<SolicitudesEmpleados>();
            SolicitudesTransportes = new HashSet<SolicitudesTransportes>();
        }

        public int IdSolicitud { get; set; }
        public int IdCliente { get; set; }
        public string? DireccionInicio { get; set; }
        public string? DireccionFinal { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaTrabajo { get; set; }
        public int? PagoFaltante { get; set; }
        public int IdEstado { get; set; }
        public int IdTipoRegistro { get; set; }
        public int IdLocalidadInicio { get; set; }
        public int IdLocalidadFinal { get; set; }

        public virtual ICollection<SolicitudesEmpleados> SolicitudesEmpleados { get; set; }
        public virtual ICollection<SolicitudesTransportes> SolicitudesTransportes { get; set; }
    }
}
