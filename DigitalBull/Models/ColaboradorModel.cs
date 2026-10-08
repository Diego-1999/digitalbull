using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class ColaboradorModel
    {
        private int numero_id { get; set; }
        public string nombre { get; set; } 
        public string apellidos { get; set; }
        public int tipo_id { get; set; } // FOREIGN KEY con tabla tipo_id

    }
}
