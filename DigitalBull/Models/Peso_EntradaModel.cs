using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class Peso_EntradaModel
    {
        public int id_peso_entrada { get; set; }
        public decimal peso_entrada { get; set; }
        public DateTime fecha_entrada { get; set; }
        public int id_Chip { get; set; }// FOREIGN KEY con la tabla Hato 
    }
}
