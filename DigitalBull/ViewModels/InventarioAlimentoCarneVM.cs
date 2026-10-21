using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class InventarioAlimentoCarneVM : Utilities.ViewModelBase
    {
        private readonly InventarioAlimentoCarneService _inventarioAlimentoCarneService;
        public InventarioAlimentoCarneVM()
        {
            _inventarioAlimentoCarneService = new InventarioAlimentoCarneService();
        }
    }
}
