using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class PuestoModel
    {
        public int PuestoID { get; set; }
        public string NombrePuesto { get; set; } 
        public int DepartamentoID { get; set; } //FOREIGN KEY con la tabla Departamento
    }
}
