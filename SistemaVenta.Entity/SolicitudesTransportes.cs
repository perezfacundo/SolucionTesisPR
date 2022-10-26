using System;
using System.Collections.Generic;

namespace SistemaTesis.Entity
{
    public partial class SolicitudesTransportes
    {
        public int IdSt { get; set; }
        public int IdSolicitud { get; set; }
        public int IdTransporte { get; set; }

        public virtual Solicitudes IdSolicitudNavigation { get; set; } = null!;
        public virtual Transportes IdTransporteNavigation { get; set; } = null!;
    }
}
