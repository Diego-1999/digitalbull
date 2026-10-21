using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class InventarioAlimentoLecheVM : Utilities.ViewModelBase
    {
        private readonly InventarioAlimentoLecheService _inventarioAlimentoLecheService;
        public InventarioAlimentoLecheVM()
        {
            _inventarioAlimentoLecheService = new InventarioAlimentoLecheService();
        }      
    }
}
