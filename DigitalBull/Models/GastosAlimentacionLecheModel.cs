using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class GastosAlimentacionLecheModel
    {
        public int AlimentacionLecheID { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int HatoID { get; set; } //FOREIGN KEY con la tabla hato
    }
}
