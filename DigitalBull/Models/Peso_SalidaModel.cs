using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class Peso_SalidaModel
    {
        public int id_peso_salida { get; set; }
        public decimal peso_salida { get; set; }
        public DateTime fecha_salida { get; set; }
        public decimal ingreso_venta { get; set; }
        public int id_Chip { get; set; } // FOREIGN KEY con la tabla Hato
    }
}
