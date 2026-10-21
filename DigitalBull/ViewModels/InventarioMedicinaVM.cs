using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class InventarioMedicinaVM : Utilities.ViewModelBase
    {
        private readonly InventarioMedicinaService _inventarioMedicinaService;
        public InventarioMedicinaVM()
        {
            _inventarioMedicinaService = new InventarioMedicinaService();
        }

    }
}
