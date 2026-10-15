using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class PesoMensualModel
    {
        public int PesoMensualID { get; set; }
        public decimal PesoMensual { get; set; }
        public DateTime FechaMensual { get; set; }
        public int HatoID { get; set; } // FOREIGN KEY con la tabla Hato
    }
}
