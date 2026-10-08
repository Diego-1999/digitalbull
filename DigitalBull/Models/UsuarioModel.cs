using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
    public class UsuarioModel
    {
        public int id_usuario { get; set; }
        public string usuario { get; set; }
        public string contrasena_hash { get; set; }
        public string salt { get; set; }    
        public int iteraciones { get; set; }
        public int id_rol { get; set; } //FOREIGN KEY con la tabla Rol
        public int numero_id { get; set; } //FOREIGN KEY con la tabla Colaborador
    }
}
