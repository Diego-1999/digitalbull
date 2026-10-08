using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
   public class Gastos_VeterinarioModel
    {
        public int id_gastos_veterinarios { get; set; }
        public decimal monto { get; set; }
        public string metodo_pago { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public int id_Chip { get; set; }//FOREIGN KEY con la tabla hato

    }
}
