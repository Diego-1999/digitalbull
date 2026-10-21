using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class ControlProduccionCarneVM : Utilities.ViewModelBase
    {
        private readonly ControlProduccionCarneService _controlProduccionCarneService;

        public ControlProduccionCarneVM()
        {
            _controlProduccionCarneService = new ControlProduccionCarneService();
        }

    }
}
