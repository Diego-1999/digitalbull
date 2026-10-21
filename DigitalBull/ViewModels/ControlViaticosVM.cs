using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class ControlViaticosVM : Utilities.ViewModelBase
    {
        private readonly ControlViaticosService _controlViaticosService;
        public ControlViaticosVM()
        {
            _controlViaticosService = new ControlViaticosService();
        }
        
    }
}
