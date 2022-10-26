using System;
using System.Collections.Generic;

namespace SistemaTesis.Entity
{
    public partial class Clientes
    {
        public int IdCliente { get; set; }
        public int DniCliente { get; set; }
        public string? Apellidos { get; set; }
        public string? Nombres { get; set; }
        public DateTime? FechaNac { get; set; }
        public string? Telefono { get; set; }
        public string? Domicilio { get; set; }
        public int? IdEstado { get; set; }
        public string? Clave { get; set; }
        public string? Correo { get; set; }
        public int? IdProvincia { get; set; }
        public int? IdLocalidad { get; set; }
        public int? IdTipoRegistro { get; set; }

        public virtual Estados? IdEstadoNavigation { get; set; }
        public virtual Localidades? IdLocalidadNavigation { get; set; }
        public virtual Provincias? IdProvinciaNavigation { get; set; }
        public virtual TiposDeRegistro? IdTipoRegistroNavigation { get; set; }
    }
}
