using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Documents;

namespace DigitalBull.Models
{
   public class InventarioAlimentoCarneModel
    {
        public int InventarioAlimentoCarneID { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
    }
}
