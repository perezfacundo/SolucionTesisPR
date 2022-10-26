using System;
using System.Collections.Generic;

namespace SistemaTesis.Entity
{
    public partial class SolicitudesEmpleados
    {
        public int IdSe { get; set; }
        public int IdSolicitud { get; set; }
        public int IdEmpleado { get; set; }

        public virtual Empleados IdEmpleadoNavigation { get; set; } = null!;
        public virtual Solicitudes IdSolicitudNavigation { get; set; } = null!;
    }
}
