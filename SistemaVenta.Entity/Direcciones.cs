using System;
using System.Collections.Generic;

namespace SistemaTesis.Entity
{
    public partial class Direcciones
    {
        public int IdDireccion { get; set; }
        public string CalleCiudadProvincia { get; set; } = null!;
        public string Numeracion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
    }
}
