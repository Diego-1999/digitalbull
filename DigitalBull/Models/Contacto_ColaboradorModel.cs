using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
   public class Contacto_ColaboradorModel
    {
        public  int id_Contacto_Colaborador { get; set; }
        public string telefono { get; set; }

        public string correo { get; set; }
        public int numero_id { get; set; } //FOREIGN KEY con tabla Colaborador

    }
}
