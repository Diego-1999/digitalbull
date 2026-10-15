using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class Tasa_CrecimientoModel
    {
        public int TasaCrecimientoID { get; set; }
        public decimal TasaCrecimiento { get; set; }
        public DateTime Fecha { get; set; }
        public int HatoID { get; set; } //FOREIGN KEY con la tabla hato
    }
}
