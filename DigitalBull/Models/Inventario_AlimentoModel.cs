using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Documents;

namespace DigitalBull.Models
{
   public class Inventario_AlimentoModel
    {
        public int id_invent_alimento { get; set; }
        public string producto { get; set; }
        public string descripcion { get; set; }
        public decimal cantidad { get; set; }
    }
}
