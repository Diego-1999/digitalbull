using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class PesoSalidaModel
    {
        public int PesoSalidaID { get; set; }
        public decimal PesoSalida { get; set; }
        public DateTime FechaSalida { get; set; }
        public decimal IngresoVenta { get; set; }
        public int HatoID { get; set; } // FOREIGN KEY con la tabla Hato
    }
}
