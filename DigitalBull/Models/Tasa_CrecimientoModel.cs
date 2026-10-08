using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class Tasa_CrecimientoModel
    {
        public int id_tasa_crecimiento { get; set; }
        public decimal tasa_crecimiento { get; set; }
        public DateTime fecha { get; set; }
        public int id_Chip { get; set; } //FOREIGN KEY con la tabla hato
    }
}
