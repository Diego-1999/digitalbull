using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class RegistroGastosActivosVM : Utilities.ViewModelBase
    {
        private readonly RegistroGastosActivosService _gastosActivosService;
        public RegistroGastosActivosVM()
        {
            _gastosActivosService = new RegistroGastosActivosService();
        }
       
    }
}
