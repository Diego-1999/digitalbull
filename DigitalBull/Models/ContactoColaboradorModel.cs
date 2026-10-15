using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Models
{
   public class ContactoColaboradorModel
    {
        public  int ContactoID { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int ColaboradorID { get; set; } //FOREIGN KEY con tabla Colaborador

    }
}
