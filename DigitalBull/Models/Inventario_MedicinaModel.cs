using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class Inventario_MedicinaModel
    {  
        public int id_invent_Medicina { get; set; }
        public string producto { get; set; }
        public string descripcion { get; set; }
        public decimal cantidad { get; set; }
    }
}
