using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class PuestoColaboradorModel
    {
        /* en la base de datos esta entidad tiene una llave primaria compuesta por PuestoColaboradorID, PuestoID, FechaInicio,
        pero en el modelo de C# se define como una sola propiedad para simplificar el acceso a los datos.*/
        public int PuestoColaboradorID { get; set; }
        public int PuestoID { get; set; } 
        public string NombrePuesto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }  
        public decimal Salario { get; set; }



    }
}
