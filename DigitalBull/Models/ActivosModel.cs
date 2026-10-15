using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class ActivosModel
    {
        public int ActivoID { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public DateTime Fecha { get; set; }
        public string DescripcionActivo { get; set; }
        public int UsuarioID { get; set; } // Foreign key to the Usuario table
    }
}
