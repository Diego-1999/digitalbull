using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class PagoSalarioModel
    {
        public int PagoSalarioID { get; set; }
        public int ColaboradorID { get; set; } //FOREIGN KEY con la tabla colaborador
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public string Periodo { get;set; }
        public string Observaciones { get; set; }


    }
}
