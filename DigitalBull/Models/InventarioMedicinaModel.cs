using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class InventarioMedicinaModel
    {  
        public int InventarioMedicinaID { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
    }
}
