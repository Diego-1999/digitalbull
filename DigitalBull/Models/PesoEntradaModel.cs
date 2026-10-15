using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class PesoEntradaModel
    {
        public int PesoEntradaID { get; set; }
        public decimal PesoEntrada { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int HatoID { get; set; }// FOREIGN KEY con la tabla Hato 
    }
}
