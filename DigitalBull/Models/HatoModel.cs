using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DigitalBull.Models
{
    public class HatoModel
    {
        public int id_Chip { get; set; }
        public Blob foto { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string estado_sanitario { get; set; }
        public int id_raza { get; set; } //FOREIGN KEY con la tabla raza
        public int id_sexo { get; set; } //FOREIGN KEY con la tabla sexo
        public int id_usuario { get; set; } //FOREIGN KEY con la tabla usuario
    }
}
