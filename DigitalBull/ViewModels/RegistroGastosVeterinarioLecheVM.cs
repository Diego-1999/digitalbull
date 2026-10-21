using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
    class RegistroGastosVeterinarioLecheVM : Utilities.ViewModelBase
    {
        private readonly RegistroGastosVeterinarioCarneService _gastosVeterinarioLecheService;
        public RegistroGastosVeterinarioLecheVM()
        {
            _gastosVeterinarioLecheService = new RegistroGastosVeterinarioCarneService();
        }
    }
}
