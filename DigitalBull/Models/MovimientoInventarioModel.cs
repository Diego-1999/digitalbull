using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class MovimientoInventarioModel
    {
        public int MovimientoInventarioID { get; set; }
        public string TipoMovimiento { get; set; }
        public string Observacion { get; set; }
        public decimal Cantidad { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public int InventarioAlimentoCarneID { get; set; } //FOREIGN KEY con la tabla inventario_alimento
        public int InventarioAlimentoLecheID { get; set; } //FOREIGN KEY con la tabla inventario_medicina
        public int InventarioMedicinaID { get; set; } //FOREIGN KEY con la tabla inventario_medicina
        public int HatoID { get; set; } //FOREIGN KEY con la tabla hato
    }
}
