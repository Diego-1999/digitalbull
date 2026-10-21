using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class RegistroGastosAlimentacionLecheVM : Utilities.ViewModelBase
    {
        private readonly RegistroGastosAlimentacionLecheService _gastosAlimentacionLecheService;
        public RegistroGastosAlimentacionLecheVM()
        {
            _gastosAlimentacionLecheService = new RegistroGastosAlimentacionLecheService();
        }
    }
}
