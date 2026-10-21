using System;
using System.Collections.Generic;
using System.Text;
using DigitalBull.Service;

namespace DigitalBull.ViewModels
{
     class PlanillaVM : Utilities.ViewModelBase
    {
        private PlanillaService _planillaService;
        public PlanillaVM()
        {
            _planillaService = new PlanillaService();
        }
       
    }
}
