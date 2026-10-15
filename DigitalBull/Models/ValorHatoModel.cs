using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class ValorHatoModel
    {
        public int ValorHatoID { get; set; }
        public int HatoID { get; set; } // Foreign key to the Hato table
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; } // Tipo de vaca: "Leche", "Carne"
        public int Valor { get; set; }
        public string Observaciones { get; set; }



    }
}
