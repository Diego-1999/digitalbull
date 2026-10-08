using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
   public class Procuccion_CarneModel
    {
        public int id_procuccion_carne { get; set; }    
        public decimal ganancia_diaria_en_peso { get; set; }
        public int id_Chip { get; set; } //FOREIGN KEY con la tabla de Hato
    }
}
