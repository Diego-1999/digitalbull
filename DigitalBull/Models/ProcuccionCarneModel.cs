using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
   public class ProcuccionCarneModel
    {
        public int ProduccionCarneID { get; set; }    
        public decimal GananciaDiariaPeso { get; set; }
        public int HatoID { get; set; } //FOREIGN KEY con la tabla de Hato
    }
}
