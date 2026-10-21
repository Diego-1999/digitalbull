using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class RegistroColaboradoresVM : Utilities.ViewModelBase
    {
        private readonly RegistroColaboradoresService _colaboradorService;
        public RegistroColaboradoresVM()
        {
            _colaboradorService = new RegistroColaboradoresService();
        }
        
    }
}
