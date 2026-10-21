using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class RegistroUsuarioVM : Utilities.ViewModelBase
    {
        private readonly RegistroUsuarioService _registroUsuarioService;
        public RegistroUsuarioVM()
        {
            _registroUsuarioService = new RegistroUsuarioService();
        }
    }
}
