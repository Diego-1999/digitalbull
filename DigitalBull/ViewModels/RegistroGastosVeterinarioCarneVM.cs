using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class RegistroGastosVeterinarioCarneVM : Utilities.ViewModelBase
    {
        private readonly RegistroGastosVeterinarioCarneService _gastosVeterinarioCarneService;
        public RegistroGastosVeterinarioCarneVM()
        {
            _gastosVeterinarioCarneService = new RegistroGastosVeterinarioCarneService();
        }
    }
}
