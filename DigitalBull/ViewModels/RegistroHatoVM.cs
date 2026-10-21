using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class RegistroHatoVM : Utilities.ViewModelBase
    {
        private readonly RegistroHatoService _registroHatoService;
        public RegistroHatoVM()
        {
            _registroHatoService = new RegistroHatoService();
        }
    }
}
