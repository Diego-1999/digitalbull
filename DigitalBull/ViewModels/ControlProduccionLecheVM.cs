using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class ControlProduccionLecheVM : Utilities.ViewModelBase
    {
        private readonly ControlProduccionLecheService _controlProduccionLecheService;
        public ControlProduccionLecheVM()
        {
            _controlProduccionLecheService = new ControlProduccionLecheService();
        }
    }
}
