using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class Movimiento_InventarioModel
    {
        public int id_movimiento { get; set; }
        public string tipo_movimiento { get; set; }
        public string observacion { get; set; }
        public decimal cantidad { get; set; }
        public DateTime fecha_movimiento { get; set; }
        public int id_invent_alimento { get; set; } //FOREIGN KEY con la tabla inventario_alimento
        public int id_invent_Medicina { get; set; } //FOREIGN KEY con la tabla inventario_medicina
        public int id_chip { get; set; } //FOREIGN KEY con la tabla hato
    }
}
