using System;
using System.Collections.Generic;

namespace SistemaTesis.Entity
{
    public partial class Transportes
    {
        public Transportes()
        {
            SolicitudesTransportes = new HashSet<SolicitudesTransportes>();
        }

        public int IdTransporte { get; set; }
        public string Patente { get; set; } = null!;
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int IdEstado { get; set; }
        public int Capacidad { get; set; }
        public int IdTipoRegistro { get; set; }

        public virtual Estados IdEstadoNavigation { get; set; } = null!;
        public virtual TiposDeRegistro IdTipoRegistroNavigation { get; set; } = null!;
        public virtual ICollection<SolicitudesTransportes> SolicitudesTransportes { get; set; }
    }
}
