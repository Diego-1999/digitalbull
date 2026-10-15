using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class ProduccionLecheModel
    { 
        public int ProduccionLecheID { get; set; }
        public decimal RegistroDiarioLitros { get; set; }
        public int HatoID { get; set; } //FOREIGN KEY con la tabla de Hato
    }
}
