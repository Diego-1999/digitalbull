using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class RegistroGastosAlimentacionCarneVM : Utilities.ViewModelBase
    {
        private readonly RegistroGastosAlimentacionCarneService _gastosAlimentacionCarneService;
        public RegistroGastosAlimentacionCarneVM()
        {
            _gastosAlimentacionCarneService = new RegistroGastosAlimentacionCarneService();
        }
    
    }
}
