using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class Peso_MensualModel
    {
        public int id_peso_mensual { get; set; }
        public decimal peso_mensual { get; set; }
        public DateTime fecha_mensual { get; set; }
        public int id_Chip { get; set; } // FOREIGN KEY con la tabla Hato
    }
}
