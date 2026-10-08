using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class Produccion_LecheModel
    { 
        public int id_produccion_leche { get; set; }
        public decimal registro_diario_en_litros { get; set; }
        public int id_Chip { get; set; } //FOREIGN KEY con la tabla de Hato
    }
}
